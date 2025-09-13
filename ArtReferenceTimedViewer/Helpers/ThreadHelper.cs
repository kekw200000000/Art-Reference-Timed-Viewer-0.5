using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtReferenceTimedViewerLibrary.Helpers
{
    public static class ThreadHelper
    {
        // so I'm not really sure if this is the correct way to go about this
        // but since I set some properties from Task-run methods that are on different threads,
        // I was getting errors about that, so if I want to change some properties of an element (text and image source in this case),
        // I call these and if the target is on a different thread, the setting gets invoked from there
        // So really the question is whether there is any use to the original SetText/SetImage-calling method being on a different thread
        // and I guess not? I was hoping to put the image loading off-thread and to be fair! I could also do it in an asynchrone way now that
        // I think about it (why didn't I realize that earlier?) so yeah that's what should have happened. I hope the asynchrone calls being used elsewhere
        // make up for this absence here with setting the session images... XD
        delegate void SetTextCallback(Form f, Control ctrl, string text);
        public static void SetText(Form form, Control ctrl, string text)
        {
            if (ctrl.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                form.Invoke(d, new object[] { form, ctrl, text });
            }
            else
            {
                ctrl.Text = text;
            }
        }
        delegate void SetImageCallback(Form f, PictureBox ctrl, Image image);
        public static void SetImage(Form form, PictureBox ctrl, Image image)
        {
            if (ctrl.InvokeRequired)
            {
                SetImageCallback d = new SetImageCallback(SetImage);
                form.Invoke(d, new object[] { form, ctrl, image });
            }
            else
            {
                ctrl.Image = image;
            }
        }
        delegate void SetProgressBarCallback(Form f, ProgressBar ctrl, int progress);
        public static void SetProgressBar(Form form, ProgressBar ctrl, int value)
        {
            if (ctrl.InvokeRequired)
            {
                SetProgressBarCallback d = new SetProgressBarCallback(SetProgressBar);
                form.Invoke(d, new object[] { form, ctrl, value });
            }
            else
            {
                ctrl.Value = value;
            }
        }
    }
}
