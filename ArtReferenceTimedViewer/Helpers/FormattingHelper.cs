using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtReferenceTimedViewer.Helpers
{
    public static class FormattingHelper
    {
        public static void SetTimeFromSeconds(string prefix, Control ctrl, int time, bool colonFormat)
        {
            if (colonFormat)
            {
                if (time >= 60)
                {
                    if (time >= 3600)
                    {
                        ctrl.Text = prefix + $"{time / 3600}:{(time % 3600) / 60:D2}:{time % 60:D2}s";
                    }
                    else
                    {
                        ctrl.Text = prefix + $"{time / 3600}:{(time % 3600) / 60:D2}:{time % 60:D2}s";
                    }
                }
                else
                {
                    ctrl.Text = prefix + $"{time} seconds";
                }
            }
            else
            {
                if (time >= 60)
                {
                    if (time >= 3600)
                    {
                        ctrl.Text = prefix + $"{time / 3600}h {(time % 3600) / 60:D2}m {time % 60:D2}s";
                    }
                    else
                    {
                        ctrl.Text = prefix + $"{time / 3600}h {(time % 3600) / 60:D2}m {time % 60:D2}s";
                    }
                }
                else
                {
                    ctrl.Text = prefix + $"{time} seconds";
                }
            }
        }
    }
}
