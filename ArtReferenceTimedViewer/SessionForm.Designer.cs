namespace ArtReferenceTimedViewer
{
    partial class SessionForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            _currentTimeLabel = new Label();
            _endSessionButtonPictureBox = new PictureBox();
            _skipForwardButtonPictureBox = new PictureBox();
            _pauseSessionButtonPictureBox = new PictureBox();
            _skipBackButtonPictureBox = new PictureBox();
            _sessionProgressTextLabel = new Label();
            _currentImageProgressBar = new ProgressBar();
            _currentImagePictureBox = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_endSessionButtonPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_skipForwardButtonPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_pauseSessionButtonPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_skipBackButtonPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_currentImagePictureBox).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(_currentImageProgressBar, 0, 2);
            tableLayoutPanel1.Controls.Add(_currentImagePictureBox, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.265176F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90.7348251F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1264, 921);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(_currentTimeLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(_endSessionButtonPictureBox, 5, 0);
            tableLayoutPanel2.Controls.Add(_skipForwardButtonPictureBox, 4, 0);
            tableLayoutPanel2.Controls.Add(_pauseSessionButtonPictureBox, 3, 0);
            tableLayoutPanel2.Controls.Add(_skipBackButtonPictureBox, 2, 0);
            tableLayoutPanel2.Controls.Add(_sessionProgressTextLabel, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1258, 77);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // _currentTimeLabel
            // 
            _currentTimeLabel.AutoSize = true;
            _currentTimeLabel.Dock = DockStyle.Left;
            _currentTimeLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _currentTimeLabel.Location = new Point(3, 0);
            _currentTimeLabel.Name = "_currentTimeLabel";
            _currentTimeLabel.Size = new Size(104, 77);
            _currentTimeLabel.TabIndex = 4;
            _currentTimeLabel.Text = "00:00";
            // 
            // _endSessionButtonPictureBox
            // 
            _endSessionButtonPictureBox.BorderStyle = BorderStyle.Fixed3D;
            _endSessionButtonPictureBox.Dock = DockStyle.Right;
            _endSessionButtonPictureBox.Image = Properties.Resources.button_stop;
            _endSessionButtonPictureBox.Location = new Point(1186, 3);
            _endSessionButtonPictureBox.Name = "_endSessionButtonPictureBox";
            _endSessionButtonPictureBox.Size = new Size(69, 71);
            _endSessionButtonPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            _endSessionButtonPictureBox.TabIndex = 3;
            _endSessionButtonPictureBox.TabStop = false;
            _endSessionButtonPictureBox.Click += _endSessionButtonPictureBox_Click;
            // 
            // _skipForwardButtonPictureBox
            // 
            _skipForwardButtonPictureBox.BorderStyle = BorderStyle.Fixed3D;
            _skipForwardButtonPictureBox.Dock = DockStyle.Fill;
            _skipForwardButtonPictureBox.Image = Properties.Resources.button_skip_forward;
            _skipForwardButtonPictureBox.Location = new Point(669, 3);
            _skipForwardButtonPictureBox.Name = "_skipForwardButtonPictureBox";
            _skipForwardButtonPictureBox.Size = new Size(69, 71);
            _skipForwardButtonPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            _skipForwardButtonPictureBox.TabIndex = 2;
            _skipForwardButtonPictureBox.TabStop = false;
            _skipForwardButtonPictureBox.Click += _skipForwardButtonPictureBox_Click;
            // 
            // _pauseSessionButtonPictureBox
            // 
            _pauseSessionButtonPictureBox.BorderStyle = BorderStyle.Fixed3D;
            _pauseSessionButtonPictureBox.Dock = DockStyle.Fill;
            _pauseSessionButtonPictureBox.Image = Properties.Resources.button_pause;
            _pauseSessionButtonPictureBox.Location = new Point(594, 3);
            _pauseSessionButtonPictureBox.Name = "_pauseSessionButtonPictureBox";
            _pauseSessionButtonPictureBox.Size = new Size(69, 71);
            _pauseSessionButtonPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            _pauseSessionButtonPictureBox.TabIndex = 0;
            _pauseSessionButtonPictureBox.TabStop = false;
            _pauseSessionButtonPictureBox.Click += _pauseSessionButtonPictureBox_Click;
            // 
            // _skipBackButtonPictureBox
            // 
            _skipBackButtonPictureBox.BorderStyle = BorderStyle.Fixed3D;
            _skipBackButtonPictureBox.Dock = DockStyle.Fill;
            _skipBackButtonPictureBox.Image = Properties.Resources.button_skip_back;
            _skipBackButtonPictureBox.Location = new Point(519, 3);
            _skipBackButtonPictureBox.Name = "_skipBackButtonPictureBox";
            _skipBackButtonPictureBox.Size = new Size(69, 71);
            _skipBackButtonPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            _skipBackButtonPictureBox.TabIndex = 1;
            _skipBackButtonPictureBox.TabStop = false;
            _skipBackButtonPictureBox.Click += _skipBackButtonPictureBox_Click;
            // 
            // _sessionProgressTextLabel
            // 
            _sessionProgressTextLabel.AutoSize = true;
            _sessionProgressTextLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _sessionProgressTextLabel.Location = new Point(416, 0);
            _sessionProgressTextLabel.Name = "_sessionProgressTextLabel";
            _sessionProgressTextLabel.Size = new Size(60, 40);
            _sessionProgressTextLabel.TabIndex = 5;
            _sessionProgressTextLabel.Text = "0/0";
            // 
            // _currentImageProgressBar
            // 
            _currentImageProgressBar.Dock = DockStyle.Fill;
            _currentImageProgressBar.Location = new Point(3, 903);
            _currentImageProgressBar.Name = "_currentImageProgressBar";
            _currentImageProgressBar.Size = new Size(1258, 15);
            _currentImageProgressBar.TabIndex = 1;
            // 
            // _currentImagePictureBox
            // 
            _currentImagePictureBox.BorderStyle = BorderStyle.Fixed3D;
            _currentImagePictureBox.Dock = DockStyle.Fill;
            _currentImagePictureBox.InitialImage = null;
            _currentImagePictureBox.Location = new Point(3, 86);
            _currentImagePictureBox.Name = "_currentImagePictureBox";
            _currentImagePictureBox.Size = new Size(1258, 811);
            _currentImagePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            _currentImagePictureBox.TabIndex = 2;
            _currentImagePictureBox.TabStop = false;
            // 
            // SessionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 921);
            Controls.Add(tableLayoutPanel1);
            Name = "SessionForm";
            Text = "Art in progress...";
            FormClosed += SessionForm_FormClosed;
            Load += SessionForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_endSessionButtonPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)_skipForwardButtonPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)_pauseSessionButtonPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)_skipBackButtonPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)_currentImagePictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private ProgressBar _currentImageProgressBar;
        private PictureBox _currentImagePictureBox;
        private PictureBox _pauseSessionButtonPictureBox;
        private PictureBox _skipBackButtonPictureBox;
        private PictureBox _skipForwardButtonPictureBox;
        private PictureBox _endSessionButtonPictureBox;
        private Label _currentTimeLabel;
        private Label _sessionProgressTextLabel;
    }
}