namespace ArtReferenceTimedViewer
{
    partial class StatisticsForm
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
            panel1 = new Panel();
            _usageStatisticsAverageTimePerDayLabel = new Label();
            _usageStatisticsAverageImagesPerDayLabel = new Label();
            _usageStatisticsAverageTimePerImageLabel = new Label();
            _usageStatisticsTotalTimeLabel = new Label();
            _usageStatisticsTotalImagesLabel = new Label();
            _mainLabelLogoStatisticsPictureBox = new PictureBox();
            _usageStatisticsTotalNumberOfActiveDays = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_mainLabelLogoStatisticsPictureBox).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Controls.Add(_mainLabelLogoStatisticsPictureBox, 1, 0);
            tableLayoutPanel1.Location = new Point(29, 16);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(895, 580);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(_usageStatisticsTotalNumberOfActiveDays);
            panel1.Controls.Add(_usageStatisticsAverageTimePerDayLabel);
            panel1.Controls.Add(_usageStatisticsAverageImagesPerDayLabel);
            panel1.Controls.Add(_usageStatisticsAverageTimePerImageLabel);
            panel1.Controls.Add(_usageStatisticsTotalTimeLabel);
            panel1.Controls.Add(_usageStatisticsTotalImagesLabel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(226, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(441, 380);
            panel1.TabIndex = 0;
            // 
            // _usageStatisticsAverageTimePerDayLabel
            // 
            _usageStatisticsAverageTimePerDayLabel.AutoSize = true;
            _usageStatisticsAverageTimePerDayLabel.Location = new Point(-8, 293);
            _usageStatisticsAverageTimePerDayLabel.Name = "_usageStatisticsAverageTimePerDayLabel";
            _usageStatisticsAverageTimePerDayLabel.Size = new Size(317, 32);
            _usageStatisticsAverageTimePerDayLabel.TabIndex = 4;
            _usageStatisticsAverageTimePerDayLabel.Text = "Average time per active day:";
            // 
            // _usageStatisticsAverageImagesPerDayLabel
            // 
            _usageStatisticsAverageImagesPerDayLabel.AutoSize = true;
            _usageStatisticsAverageImagesPerDayLabel.Location = new Point(-8, 251);
            _usageStatisticsAverageImagesPerDayLabel.Name = "_usageStatisticsAverageImagesPerDayLabel";
            _usageStatisticsAverageImagesPerDayLabel.Size = new Size(345, 32);
            _usageStatisticsAverageImagesPerDayLabel.TabIndex = 3;
            _usageStatisticsAverageImagesPerDayLabel.Text = "Average images per active day:";
            // 
            // _usageStatisticsAverageTimePerImageLabel
            // 
            _usageStatisticsAverageTimePerImageLabel.AutoSize = true;
            _usageStatisticsAverageTimePerImageLabel.Location = new Point(0, 124);
            _usageStatisticsAverageTimePerImageLabel.Name = "_usageStatisticsAverageTimePerImageLabel";
            _usageStatisticsAverageTimePerImageLabel.Size = new Size(276, 32);
            _usageStatisticsAverageTimePerImageLabel.TabIndex = 2;
            _usageStatisticsAverageTimePerImageLabel.Text = "Average time per image:";
            // 
            // _usageStatisticsTotalTimeLabel
            // 
            _usageStatisticsTotalTimeLabel.AutoSize = true;
            _usageStatisticsTotalTimeLabel.Location = new Point(3, 82);
            _usageStatisticsTotalTimeLabel.Name = "_usageStatisticsTotalTimeLabel";
            _usageStatisticsTotalTimeLabel.Size = new Size(191, 32);
            _usageStatisticsTotalTimeLabel.TabIndex = 1;
            _usageStatisticsTotalTimeLabel.Text = "Total time spent:";
            // 
            // _usageStatisticsTotalImagesLabel
            // 
            _usageStatisticsTotalImagesLabel.AutoSize = true;
            _usageStatisticsTotalImagesLabel.Location = new Point(3, 37);
            _usageStatisticsTotalImagesLabel.Name = "_usageStatisticsTotalImagesLabel";
            _usageStatisticsTotalImagesLabel.Size = new Size(274, 32);
            _usageStatisticsTotalImagesLabel.TabIndex = 0;
            _usageStatisticsTotalImagesLabel.Text = "Total images completed:";
            // 
            // _mainLabelLogoStatisticsPictureBox
            // 
            _mainLabelLogoStatisticsPictureBox.BorderStyle = BorderStyle.Fixed3D;
            _mainLabelLogoStatisticsPictureBox.Dock = DockStyle.Fill;
            _mainLabelLogoStatisticsPictureBox.Image = Properties.Resources.usage_statistics_logo;
            _mainLabelLogoStatisticsPictureBox.Location = new Point(226, 3);
            _mainLabelLogoStatisticsPictureBox.Name = "_mainLabelLogoStatisticsPictureBox";
            _mainLabelLogoStatisticsPictureBox.Size = new Size(441, 90);
            _mainLabelLogoStatisticsPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            _mainLabelLogoStatisticsPictureBox.TabIndex = 1;
            _mainLabelLogoStatisticsPictureBox.TabStop = false;
            // 
            // _usageStatisticsTotalNumberOfActiveDays
            // 
            _usageStatisticsTotalNumberOfActiveDays.AutoSize = true;
            _usageStatisticsTotalNumberOfActiveDays.Location = new Point(0, 166);
            _usageStatisticsTotalNumberOfActiveDays.Name = "_usageStatisticsTotalNumberOfActiveDays";
            _usageStatisticsTotalNumberOfActiveDays.Size = new Size(314, 32);
            _usageStatisticsTotalNumberOfActiveDays.TabIndex = 5;
            _usageStatisticsTotalNumberOfActiveDays.Text = "Total number of active days:";
            // 
            // StatisticsForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 612);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "StatisticsForm";
            Text = "Usage Statistics";
            Load += StatisticsForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_mainLabelLogoStatisticsPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private PictureBox _mainLabelLogoStatisticsPictureBox;
        private Label _usageStatisticsAverageImagesPerDayLabel;
        private Label _usageStatisticsAverageTimePerImageLabel;
        private Label _usageStatisticsTotalTimeLabel;
        private Label _usageStatisticsTotalImagesLabel;
        private Label _usageStatisticsAverageTimePerDayLabel;
        private Label _usageStatisticsTotalNumberOfActiveDays;
    }
}