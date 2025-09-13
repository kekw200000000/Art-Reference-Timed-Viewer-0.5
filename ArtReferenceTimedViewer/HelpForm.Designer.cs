namespace ArtReferenceTimedViewer
{
    partial class HelpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            _sessionFormatDescriptionHelpLabel = new Label();
            _sessionFormatHeadingHelpLabel = new Label();
            _foldersHeadingHelpLabel = new Label();
            _foldersDescriptionHelpLabel = new Label();
            _foldersFormatHeadingHelpLabel = new Label();
            _foldersFormatDescriptionHelpLabel = new Label();
            _otherInfoDescriptionHelpLabel = new Label();
            _otherInfoHeadingHelpLabel = new Label();
            SuspendLayout();
            // 
            // _sessionFormatDescriptionHelpLabel
            // 
            _sessionFormatDescriptionHelpLabel.AutoSize = true;
            _sessionFormatDescriptionHelpLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _sessionFormatDescriptionHelpLabel.Location = new Point(23, 61);
            _sessionFormatDescriptionHelpLabel.Name = "_sessionFormatDescriptionHelpLabel";
            _sessionFormatDescriptionHelpLabel.Size = new Size(577, 210);
            _sessionFormatDescriptionHelpLabel.TabIndex = 0;
            _sessionFormatDescriptionHelpLabel.Text = "[amount]x[time in seconds], [amount]x[time in seconds], ...\r\n\r\nExample:\r\n3x120, 1x60, infx150\r\n\r\nResulting session:\r\n3 images 120s each, 1 image 60s, \"infinite\" images 150s each";
            // 
            // _sessionFormatHeadingHelpLabel
            // 
            _sessionFormatHeadingHelpLabel.AutoSize = true;
            _sessionFormatHeadingHelpLabel.Location = new Point(23, 29);
            _sessionFormatHeadingHelpLabel.Name = "_sessionFormatHeadingHelpLabel";
            _sessionFormatHeadingHelpLabel.Size = new Size(177, 32);
            _sessionFormatHeadingHelpLabel.TabIndex = 1;
            _sessionFormatHeadingHelpLabel.Text = "Session format:";
            // 
            // _foldersHeadingHelpLabel
            // 
            _foldersHeadingHelpLabel.AutoSize = true;
            _foldersHeadingHelpLabel.Location = new Point(23, 311);
            _foldersHeadingHelpLabel.Name = "_foldersHeadingHelpLabel";
            _foldersHeadingHelpLabel.Size = new Size(91, 32);
            _foldersHeadingHelpLabel.TabIndex = 2;
            _foldersHeadingHelpLabel.Text = "Folders";
            // 
            // _foldersDescriptionHelpLabel
            // 
            _foldersDescriptionHelpLabel.AutoSize = true;
            _foldersDescriptionHelpLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _foldersDescriptionHelpLabel.Location = new Point(23, 343);
            _foldersDescriptionHelpLabel.Name = "_foldersDescriptionHelpLabel";
            _foldersDescriptionHelpLabel.Size = new Size(770, 180);
            _foldersDescriptionHelpLabel.TabIndex = 3;
            _foldersDescriptionHelpLabel.Text = resources.GetString("_foldersDescriptionHelpLabel.Text");
            // 
            // _foldersFormatHeadingHelpLabel
            // 
            _foldersFormatHeadingHelpLabel.AutoSize = true;
            _foldersFormatHeadingHelpLabel.FlatStyle = FlatStyle.Flat;
            _foldersFormatHeadingHelpLabel.Location = new Point(23, 542);
            _foldersFormatHeadingHelpLabel.Name = "_foldersFormatHeadingHelpLabel";
            _foldersFormatHeadingHelpLabel.Size = new Size(174, 32);
            _foldersFormatHeadingHelpLabel.TabIndex = 4;
            _foldersFormatHeadingHelpLabel.Text = "Folders format:";
            // 
            // _foldersFormatDescriptionHelpLabel
            // 
            _foldersFormatDescriptionHelpLabel.AutoSize = true;
            _foldersFormatDescriptionHelpLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _foldersFormatDescriptionHelpLabel.Location = new Point(23, 574);
            _foldersFormatDescriptionHelpLabel.Name = "_foldersFormatDescriptionHelpLabel";
            _foldersFormatDescriptionHelpLabel.Size = new Size(256, 30);
            _foldersFormatDescriptionHelpLabel.TabIndex = 5;
            _foldersFormatDescriptionHelpLabel.Text = "folder1, folder2, folder3, ...";
            // 
            // _otherInfoDescriptionHelpLabel
            // 
            _otherInfoDescriptionHelpLabel.AutoSize = true;
            _otherInfoDescriptionHelpLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _otherInfoDescriptionHelpLabel.Location = new Point(642, 61);
            _otherInfoDescriptionHelpLabel.MaximumSize = new Size(350, 0);
            _otherInfoDescriptionHelpLabel.Name = "_otherInfoDescriptionHelpLabel";
            _otherInfoDescriptionHelpLabel.Size = new Size(335, 240);
            _otherInfoDescriptionHelpLabel.TabIndex = 6;
            _otherInfoDescriptionHelpLabel.Text = resources.GetString("_otherInfoDescriptionHelpLabel.Text");
            // 
            // _otherInfoHeadingHelpLabel
            // 
            _otherInfoHeadingHelpLabel.AutoSize = true;
            _otherInfoHeadingHelpLabel.Location = new Point(642, 29);
            _otherInfoHeadingHelpLabel.Name = "_otherInfoHeadingHelpLabel";
            _otherInfoHeadingHelpLabel.Size = new Size(129, 32);
            _otherInfoHeadingHelpLabel.TabIndex = 7;
            _otherInfoHeadingHelpLabel.Text = "Other info:";
            // 
            // HelpForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 625);
            Controls.Add(_otherInfoHeadingHelpLabel);
            Controls.Add(_otherInfoDescriptionHelpLabel);
            Controls.Add(_foldersFormatDescriptionHelpLabel);
            Controls.Add(_foldersFormatHeadingHelpLabel);
            Controls.Add(_foldersDescriptionHelpLabel);
            Controls.Add(_foldersHeadingHelpLabel);
            Controls.Add(_sessionFormatHeadingHelpLabel);
            Controls.Add(_sessionFormatDescriptionHelpLabel);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "HelpForm";
            Text = "HelpForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label _sessionFormatDescriptionHelpLabel;
        private Label _sessionFormatHeadingHelpLabel;
        private Label _foldersHeadingHelpLabel;
        private Label _foldersDescriptionHelpLabel;
        private Label _foldersFormatHeadingHelpLabel;
        private Label _foldersFormatDescriptionHelpLabel;
        private Label _otherInfoDescriptionHelpLabel;
        private Label _otherInfoHeadingHelpLabel;
    }
}