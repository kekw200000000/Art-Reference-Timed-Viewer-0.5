namespace ArtReferenceTimedViewer
{
    partial class DialogForm
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
            _dialogMessageLabel = new Label();
            SuspendLayout();
            // 
            // _dialogMessageLabel
            // 
            _dialogMessageLabel.AutoSize = true;
            _dialogMessageLabel.Location = new Point(57, 202);
            _dialogMessageLabel.Margin = new Padding(6, 0, 6, 0);
            _dialogMessageLabel.MaximumSize = new Size(800, 0);
            _dialogMessageLabel.Name = "_dialogMessageLabel";
            _dialogMessageLabel.Size = new Size(36, 32);
            _dialogMessageLabel.TabIndex = 0;
            _dialogMessageLabel.Text = ":D";
            // 
            // DialogForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 445);
            Controls.Add(_dialogMessageLabel);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "DialogForm";
            Text = "DialogForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label _dialogMessageLabel;
    }
}