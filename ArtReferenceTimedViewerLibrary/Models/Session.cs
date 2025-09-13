using ArtReferenceTimedViewerLibrary.Enums;
using ArtReferenceTimedViewerLibrary.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
#nullable enable

namespace ArtReferenceTimedViewerLibrary.Models
{
    public class Session
    {
        private List<(int TimeInSeconds, string? ImagePath)> _timeImagePairs;
        private HashSet<string> _images;
        private int _sessionIndex = 0;
        public int SessionIndex { get { return _sessionIndex; } }
        private int _sessionMax;
        public int SessionMax { get { return _sessionMax; } }
        private bool _allowRepeats;
        
        public Session(List<(int Count, int TimeInSeconds)> sessionFormat, HashSet<string> images, bool allowRepeats)
        {
            _allowRepeats = allowRepeats;
            SetSessionFormat(sessionFormat, images);
        }
        public (string? ImagePath, int TimeInSeconds) CurrentImage()
        {
            string? currentImagePath = _timeImagePairs[_sessionIndex].ImagePath;
            int currentImageTime = _timeImagePairs[_sessionIndex].TimeInSeconds;
            if (currentImageTime < 0)
            {
                currentImageTime *= -1;
            }
            return (currentImagePath, currentImageTime);
        }
        public SessionTraversalStatus NextImage()
        {
            string? currentImagePath, nextImagePath;
            int currentImageTime;

            currentImageTime = _timeImagePairs[_sessionIndex].TimeInSeconds;
            currentImagePath = _timeImagePairs[_sessionIndex].ImagePath;

            if (currentImagePath is null)
            {
                return SessionTraversalStatus.NO_MORE_IMAGES;
            }

            if (_sessionIndex + 1 >= _timeImagePairs.Count)
            {
                if (currentImageTime < 0)
                {
                    _timeImagePairs.Add((currentImageTime, GeneralHelper.PickRandomString(_images, !_allowRepeats)));
                }
                else
                {
                    return SessionTraversalStatus.END_OF_SESSION;
                }
            }

            nextImagePath = _timeImagePairs[_sessionIndex + 1].ImagePath;
            if (nextImagePath is null)
            {
                return SessionTraversalStatus.NO_MORE_IMAGES;
            }

            _sessionIndex++;
            return SessionTraversalStatus.OK;
        }
        public SessionTraversalStatus LastImage()
        {
            if (_sessionIndex == 0)
            {
                return SessionTraversalStatus.START_OF_SESSION;
            }
            _sessionIndex--;
            return SessionTraversalStatus.OK;
        }
        private void SetSessionFormat(List<(int Count, int TimeInSeconds)> sessionFormat, HashSet<string> images)
        {
            //int timeWindowsCount = 0;
            //foreach ((int Count, int TimeInSeconds) block in sessionFormat)
            //{
            //    timeWindowsCount += block.Count;
            //}
            //_timeImagePairs = new(timeWindowsCount);
            //timeWindowsCount = 0;
            _timeImagePairs = new();
            //int tempNextTime;
            string? tempNextImage;
            foreach ((int Count, int TimeInSeconds) block in sessionFormat)
            {
                if (block.Count == -1)
                {
                    tempNextImage = GeneralHelper.PickRandomString(images, !_allowRepeats);
                    if (_timeImagePairs.Count != 0)
                    {
                        (int TimeInSeconds, string? ImagePath) lastImageAdded = _timeImagePairs.Last();
                        if (lastImageAdded.ImagePath is not null)
                        {
                            while (lastImageAdded.Equals(tempNextImage))
                            {
                                tempNextImage = GeneralHelper.PickRandomString(images, !_allowRepeats);
                            }
                        }
                    }
                    _timeImagePairs.Add((-block.TimeInSeconds, tempNextImage));
                    _images = images;
                    break;
                }
                for (int inWindowIndex = 0; inWindowIndex < block.Count; inWindowIndex++)
                {
                    tempNextImage = GeneralHelper.PickRandomString(images, !_allowRepeats);
                    if (_timeImagePairs.Count != 0)
                    {
                        (int TimeInSeconds, string? ImagePath) lastImageAdded = _timeImagePairs.Last();
                        if (lastImageAdded.ImagePath is not null)
                        {
                            while (lastImageAdded.Equals(tempNextImage))
                            {
                                tempNextImage = GeneralHelper.PickRandomString(images, !_allowRepeats);
                            }
                        }
                    }
                    _timeImagePairs.Add((block.TimeInSeconds, tempNextImage));
                }
            }
            _sessionMax = _timeImagePairs.Count;
        }
    }
}
