using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtReferenceTimedViewer
{
    public partial class DialogForm : Form
    {
        public DialogForm(string dialogMessage)
        {
            InitializeComponent();
            _dialogMessageLabel.Text = dialogMessage;
        }

        private void ErrorForm_Load(object sender, EventArgs e)
        {
        }
    }
}
