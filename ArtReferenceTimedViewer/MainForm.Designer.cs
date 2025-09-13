namespace ArtReferenceTimedViewer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            _startSessionButton = new Button();
            _sessionFormatTextBox = new RichTextBox();
            _subfolderSelectionTextBox = new RichTextBox();
            _blacklistModeEnabledCheckbox = new CheckBox();
            _showStatisticsButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            _sessionFormatLabel = new Label();
            _subfolderSelectionLabel = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            _todayStatisticsLayoutPanel = new FlowLayoutPanel();
            _todayStatisticsTopLabel = new Label();
            _todayStatisticsMinutesLabel = new Label();
            _todayStatisticsImagesLabel = new Label();
            _todayStatisticsAvgPerImageLabel = new Label();
            panel1 = new Panel();
            _loadingDataLabel = new Label();
            panel2 = new Panel();
            _subfoldersNotFoundWarningLabel = new Label();
            _mainFolderCurrentPathLabel = new Label();
            _showSettingsFormButton = new Button();
            _showHelpFormButton = new Button();
            _incorrectSubfoldersEnteredWarning = new Label();
            _incorrectSessionFormatEnteredWarning = new Label();
            _mainFolderCurrentLabel = new Label();
            _mainFolderSelectionButton = new Button();
            pictureBox1 = new PictureBox();
            _mainFolderSelectionFolderBrowserDialog = new FolderBrowserDialog();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            _todayStatisticsLayoutPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // _startSessionButton
            // 
            _startSessionButton.Location = new Point(3, 3);
            _startSessionButton.Name = "_startSessionButton";
            _startSessionButton.Size = new Size(322, 472);
            _startSessionButton.TabIndex = 2;
            _startSessionButton.Text = "Start Session";
            _startSessionButton.UseVisualStyleBackColor = true;
            _startSessionButton.Click += _startSessionButton_Click;
            // 
            // _sessionFormatTextBox
            // 
            _sessionFormatTextBox.Location = new Point(3, 35);
            _sessionFormatTextBox.Name = "_sessionFormatTextBox";
            _sessionFormatTextBox.Size = new Size(282, 133);
            _sessionFormatTextBox.TabIndex = 3;
            _sessionFormatTextBox.Text = "";
            _sessionFormatTextBox.TextChanged += _sessionFormatTextBox_TextChanged;
            // 
            // _subfolderSelectionTextBox
            // 
            _subfolderSelectionTextBox.Location = new Point(3, 206);
            _subfolderSelectionTextBox.Name = "_subfolderSelectionTextBox";
            _subfolderSelectionTextBox.Size = new Size(282, 127);
            _subfolderSelectionTextBox.TabIndex = 4;
            _subfolderSelectionTextBox.Text = "";
            _subfolderSelectionTextBox.TextChanged += _subfolderSelectionTextBox_TextChanged;
            // 
            // _blacklistModeEnabledCheckbox
            // 
            _blacklistModeEnabledCheckbox.AutoSize = true;
            _blacklistModeEnabledCheckbox.Location = new Point(3, 339);
            _blacklistModeEnabledCheckbox.Name = "_blacklistModeEnabledCheckbox";
            _blacklistModeEnabledCheckbox.Size = new Size(187, 36);
            _blacklistModeEnabledCheckbox.TabIndex = 5;
            _blacklistModeEnabledCheckbox.Text = "Blacklist mode";
            _blacklistModeEnabledCheckbox.UseVisualStyleBackColor = true;
            _blacklistModeEnabledCheckbox.CheckedChanged += _blacklistModeEnabledCheckbox_CheckedChanged;
            // 
            // _showStatisticsButton
            // 
            _showStatisticsButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _showStatisticsButton.Location = new Point(94, 32);
            _showStatisticsButton.Name = "_showStatisticsButton";
            _showStatisticsButton.Size = new Size(146, 55);
            _showStatisticsButton.TabIndex = 6;
            _showStatisticsButton.Text = "Statistics";
            _showStatisticsButton.UseVisualStyleBackColor = true;
            _showStatisticsButton.Click += _showStatisticsButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 400F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 2, 1);
            tableLayoutPanel1.Controls.Add(_todayStatisticsLayoutPanel, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 2, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 1);
            tableLayoutPanel1.Controls.Add(pictureBox1, 1, 0);
            tableLayoutPanel1.Location = new Point(91, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.3298149F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 74.67018F));
            tableLayoutPanel1.Size = new Size(1062, 643);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.None;
            flowLayoutPanel2.Controls.Add(_sessionFormatLabel);
            flowLayoutPanel2.Controls.Add(_sessionFormatTextBox);
            flowLayoutPanel2.Controls.Add(_subfolderSelectionLabel);
            flowLayoutPanel2.Controls.Add(_subfolderSelectionTextBox);
            flowLayoutPanel2.Controls.Add(_blacklistModeEnabledCheckbox);
            flowLayoutPanel2.Location = new Point(23, 210);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(285, 384);
            flowLayoutPanel2.TabIndex = 8;
            // 
            // _sessionFormatLabel
            // 
            _sessionFormatLabel.AutoSize = true;
            _sessionFormatLabel.Location = new Point(3, 0);
            _sessionFormatLabel.Name = "_sessionFormatLabel";
            _sessionFormatLabel.Size = new Size(172, 32);
            _sessionFormatLabel.TabIndex = 6;
            _sessionFormatLabel.Text = "Session format";
            // 
            // _subfolderSelectionLabel
            // 
            _subfolderSelectionLabel.AutoSize = true;
            _subfolderSelectionLabel.Location = new Point(3, 171);
            _subfolderSelectionLabel.Name = "_subfolderSelectionLabel";
            _subfolderSelectionLabel.Size = new Size(270, 32);
            _subfolderSelectionLabel.TabIndex = 7;
            _subfolderSelectionLabel.Text = "Select album subfolders";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            flowLayoutPanel1.Controls.Add(_startSessionButton);
            flowLayoutPanel1.Location = new Point(734, 165);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(325, 475);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // _todayStatisticsLayoutPanel
            // 
            _todayStatisticsLayoutPanel.Anchor = AnchorStyles.None;
            _todayStatisticsLayoutPanel.Controls.Add(_todayStatisticsTopLabel);
            _todayStatisticsLayoutPanel.Controls.Add(_todayStatisticsMinutesLabel);
            _todayStatisticsLayoutPanel.Controls.Add(_todayStatisticsImagesLabel);
            _todayStatisticsLayoutPanel.Controls.Add(_todayStatisticsAvgPerImageLabel);
            _todayStatisticsLayoutPanel.FlowDirection = FlowDirection.TopDown;
            _todayStatisticsLayoutPanel.Location = new Point(3, 9);
            _todayStatisticsLayoutPanel.Name = "_todayStatisticsLayoutPanel";
            _todayStatisticsLayoutPanel.Size = new Size(325, 143);
            _todayStatisticsLayoutPanel.TabIndex = 9;
            // 
            // _todayStatisticsTopLabel
            // 
            _todayStatisticsTopLabel.AutoSize = true;
            _todayStatisticsTopLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _todayStatisticsTopLabel.Location = new Point(3, 0);
            _todayStatisticsTopLabel.Name = "_todayStatisticsTopLabel";
            _todayStatisticsTopLabel.Size = new Size(283, 30);
            _todayStatisticsTopLabel.TabIndex = 0;
            _todayStatisticsTopLabel.Text = "Congrats, today you've done:";
            // 
            // _todayStatisticsMinutesLabel
            // 
            _todayStatisticsMinutesLabel.AutoSize = true;
            _todayStatisticsMinutesLabel.Location = new Point(3, 30);
            _todayStatisticsMinutesLabel.Name = "_todayStatisticsMinutesLabel";
            _todayStatisticsMinutesLabel.Size = new Size(71, 32);
            _todayStatisticsMinutesLabel.TabIndex = 2;
            _todayStatisticsMinutesLabel.Text = "00:00";
            // 
            // _todayStatisticsImagesLabel
            // 
            _todayStatisticsImagesLabel.AutoSize = true;
            _todayStatisticsImagesLabel.Location = new Point(3, 62);
            _todayStatisticsImagesLabel.Name = "_todayStatisticsImagesLabel";
            _todayStatisticsImagesLabel.Size = new Size(110, 32);
            _todayStatisticsImagesLabel.TabIndex = 1;
            _todayStatisticsImagesLabel.Text = "0 images";
            // 
            // _todayStatisticsAvgPerImageLabel
            // 
            _todayStatisticsAvgPerImageLabel.AutoSize = true;
            _todayStatisticsAvgPerImageLabel.Location = new Point(3, 94);
            _todayStatisticsAvgPerImageLabel.Name = "_todayStatisticsAvgPerImageLabel";
            _todayStatisticsAvgPerImageLabel.Size = new Size(237, 32);
            _todayStatisticsAvgPerImageLabel.TabIndex = 3;
            _todayStatisticsAvgPerImageLabel.Text = "average 00:00/image";
            // 
            // panel1
            // 
            panel1.Controls.Add(_loadingDataLabel);
            panel1.Controls.Add(_showStatisticsButton);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(734, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(325, 156);
            panel1.TabIndex = 10;
            // 
            // _loadingDataLabel
            // 
            _loadingDataLabel.AutoSize = true;
            _loadingDataLabel.Location = new Point(85, 94);
            _loadingDataLabel.Name = "_loadingDataLabel";
            _loadingDataLabel.Size = new Size(167, 32);
            _loadingDataLabel.TabIndex = 7;
            _loadingDataLabel.Text = "Loading data...";
            // 
            // panel2
            // 
            panel2.Controls.Add(_subfoldersNotFoundWarningLabel);
            panel2.Controls.Add(_mainFolderCurrentPathLabel);
            panel2.Controls.Add(_showSettingsFormButton);
            panel2.Controls.Add(_showHelpFormButton);
            panel2.Controls.Add(_incorrectSubfoldersEnteredWarning);
            panel2.Controls.Add(_incorrectSessionFormatEnteredWarning);
            panel2.Controls.Add(_mainFolderCurrentLabel);
            panel2.Controls.Add(_mainFolderSelectionButton);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(334, 165);
            panel2.Name = "panel2";
            panel2.Size = new Size(394, 475);
            panel2.TabIndex = 11;
            // 
            // _subfoldersNotFoundWarningLabel
            // 
            _subfoldersNotFoundWarningLabel.AutoSize = true;
            _subfoldersNotFoundWarningLabel.ForeColor = Color.Red;
            _subfoldersNotFoundWarningLabel.Location = new Point(-3, 183);
            _subfoldersNotFoundWarningLabel.MaximumSize = new Size(390, 0);
            _subfoldersNotFoundWarningLabel.Name = "_subfoldersNotFoundWarningLabel";
            _subfoldersNotFoundWarningLabel.Size = new Size(344, 64);
            _subfoldersNotFoundWarningLabel.TabIndex = 8;
            _subfoldersNotFoundWarningLabel.Text = "Not all subfolders were found, can't start session.";
            _subfoldersNotFoundWarningLabel.Visible = false;
            // 
            // _mainFolderCurrentPathLabel
            // 
            _mainFolderCurrentPathLabel.AutoSize = true;
            _mainFolderCurrentPathLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _mainFolderCurrentPathLabel.Location = new Point(-3, 368);
            _mainFolderCurrentPathLabel.MaximumSize = new Size(390, 0);
            _mainFolderCurrentPathLabel.Name = "_mainFolderCurrentPathLabel";
            _mainFolderCurrentPathLabel.Size = new Size(58, 25);
            _mainFolderCurrentPathLabel.TabIndex = 7;
            _mainFolderCurrentPathLabel.Text = "None";
            // 
            // _showSettingsFormButton
            // 
            _showSettingsFormButton.Location = new Point(154, 13);
            _showSettingsFormButton.Name = "_showSettingsFormButton";
            _showSettingsFormButton.Size = new Size(142, 44);
            _showSettingsFormButton.TabIndex = 6;
            _showSettingsFormButton.Text = "Settings";
            _showSettingsFormButton.UseVisualStyleBackColor = true;
            _showSettingsFormButton.Click += _showSettingsFormButton_Click;
            // 
            // _showHelpFormButton
            // 
            _showHelpFormButton.Location = new Point(3, 13);
            _showHelpFormButton.Name = "_showHelpFormButton";
            _showHelpFormButton.Size = new Size(101, 44);
            _showHelpFormButton.TabIndex = 5;
            _showHelpFormButton.Text = "Help";
            _showHelpFormButton.UseVisualStyleBackColor = true;
            _showHelpFormButton.Click += _showHelpFormButton_Click;
            // 
            // _incorrectSubfoldersEnteredWarning
            // 
            _incorrectSubfoldersEnteredWarning.AutoSize = true;
            _incorrectSubfoldersEnteredWarning.ForeColor = Color.Red;
            _incorrectSubfoldersEnteredWarning.Location = new Point(-3, 247);
            _incorrectSubfoldersEnteredWarning.Name = "_incorrectSubfoldersEnteredWarning";
            _incorrectSubfoldersEnteredWarning.Size = new Size(308, 32);
            _incorrectSubfoldersEnteredWarning.TabIndex = 4;
            _incorrectSubfoldersEnteredWarning.Text = "Incorrect subfolders format.\r\n";
            // 
            // _incorrectSessionFormatEnteredWarning
            // 
            _incorrectSessionFormatEnteredWarning.AutoSize = true;
            _incorrectSessionFormatEnteredWarning.ForeColor = Color.Red;
            _incorrectSessionFormatEnteredWarning.Location = new Point(-3, 75);
            _incorrectSessionFormatEnteredWarning.Name = "_incorrectSessionFormatEnteredWarning";
            _incorrectSessionFormatEnteredWarning.Size = new Size(364, 32);
            _incorrectSessionFormatEnteredWarning.TabIndex = 3;
            _incorrectSessionFormatEnteredWarning.Text = "Incorrect session format entered.";
            // 
            // _mainFolderCurrentLabel
            // 
            _mainFolderCurrentLabel.AutoSize = true;
            _mainFolderCurrentLabel.Location = new Point(-3, 337);
            _mainFolderCurrentLabel.Name = "_mainFolderCurrentLabel";
            _mainFolderCurrentLabel.Size = new Size(229, 32);
            _mainFolderCurrentLabel.TabIndex = 1;
            _mainFolderCurrentLabel.Text = "Current main folder:";
            // 
            // _mainFolderSelectionButton
            // 
            _mainFolderSelectionButton.Location = new Point(60, 292);
            _mainFolderSelectionButton.Name = "_mainFolderSelectionButton";
            _mainFolderSelectionButton.Size = new Size(236, 42);
            _mainFolderSelectionButton.TabIndex = 0;
            _mainFolderSelectionButton.Text = "Select main folder";
            _mainFolderSelectionButton.UseVisualStyleBackColor = true;
            _mainFolderSelectionButton.Click += _mainFolderSelectionButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(334, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(394, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1243, 684);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "MainForm";
            Text = "Art Reference Timed-Viewer";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            Shown += MainForm_Shown;
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            _todayStatisticsLayoutPanel.ResumeLayout(false);
            _todayStatisticsLayoutPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button _startSessionButton;
        private RichTextBox _sessionFormatTextBox;
        private RichTextBox _subfolderSelectionTextBox;
        private CheckBox _blacklistModeEnabledCheckbox;
        private Button _showStatisticsButton;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label _sessionFormatLabel;
        private Label _subfolderSelectionLabel;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel _todayStatisticsLayoutPanel;
        private Label _todayStatisticsTopLabel;
        private Label _todayStatisticsMinutesLabel;
        private Label _todayStatisticsImagesLabel;
        private Label _todayStatisticsAvgPerImageLabel;
        private Panel panel1;
        private Label _loadingDataLabel;
        private Panel panel2;
        private Label _mainFolderCurrentLabel;
        private Button _mainFolderSelectionButton;
        private Label _incorrectSubfoldersEnteredWarning;
        private Label _incorrectSessionFormatEnteredWarning;
        private Button _showSettingsFormButton;
        private Button _showHelpFormButton;
        private FolderBrowserDialog _mainFolderSelectionFolderBrowserDialog;
        private Label _mainFolderCurrentPathLabel;
        private Label _subfoldersNotFoundWarningLabel;
        private PictureBox pictureBox1;
    }
}
