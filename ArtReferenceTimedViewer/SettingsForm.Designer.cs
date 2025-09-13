namespace ArtReferenceTimedViewer
{
    partial class SettingsForm
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
            _enableCurrentTimerSettingCheckBox = new CheckBox();
            _enableCurrentProgressBarSettingCheckBox = new CheckBox();
            _enableSessionProgressBarSettingCheckBox = new CheckBox();
            _disableInSessionControlsSettingCheckBox = new CheckBox();
            _enableRepeatsSettingCheckBox = new CheckBox();
            _visibilitySettingsHeadingLabel = new Label();
            _otherSettingsHeadingLabel = new Label();
            SuspendLayout();
            // 
            // _enableCurrentTimerSettingCheckBox
            // 
            _enableCurrentTimerSettingCheckBox.AutoSize = true;
            _enableCurrentTimerSettingCheckBox.Location = new Point(56, 67);
            _enableCurrentTimerSettingCheckBox.Name = "_enableCurrentTimerSettingCheckBox";
            _enableCurrentTimerSettingCheckBox.Size = new Size(94, 36);
            _enableCurrentTimerSettingCheckBox.TabIndex = 0;
            _enableCurrentTimerSettingCheckBox.Text = "Timer";
            _enableCurrentTimerSettingCheckBox.UseVisualStyleBackColor = true;
            _enableCurrentTimerSettingCheckBox.CheckedChanged += _enableCurrentTimerSettingCheckBox_CheckedChanged;
            // 
            // _enableCurrentProgressBarSettingCheckBox
            // 
            _enableCurrentProgressBarSettingCheckBox.AutoSize = true;
            _enableCurrentProgressBarSettingCheckBox.Location = new Point(56, 109);
            _enableCurrentProgressBarSettingCheckBox.Name = "_enableCurrentProgressBarSettingCheckBox";
            _enableCurrentProgressBarSettingCheckBox.Size = new Size(325, 36);
            _enableCurrentProgressBarSettingCheckBox.TabIndex = 1;
            _enableCurrentProgressBarSettingCheckBox.Text = "Current image progress bar";
            _enableCurrentProgressBarSettingCheckBox.UseVisualStyleBackColor = true;
            _enableCurrentProgressBarSettingCheckBox.CheckedChanged += _enableCurrentProgressBarSettingCheckBox_CheckedChanged;
            // 
            // _enableSessionProgressBarSettingCheckBox
            // 
            _enableSessionProgressBarSettingCheckBox.AutoSize = true;
            _enableSessionProgressBarSettingCheckBox.Location = new Point(56, 151);
            _enableSessionProgressBarSettingCheckBox.Name = "_enableSessionProgressBarSettingCheckBox";
            _enableSessionProgressBarSettingCheckBox.Size = new Size(459, 36);
            _enableSessionProgressBarSettingCheckBox.TabIndex = 2;
            _enableSessionProgressBarSettingCheckBox.Text = "Session progress bar (not implemented)";
            _enableSessionProgressBarSettingCheckBox.UseVisualStyleBackColor = true;
            _enableSessionProgressBarSettingCheckBox.CheckedChanged += _enableSessionProgressBarSettingCheckBox_CheckedChanged;
            // 
            // _disableInSessionControlsSettingCheckBox
            // 
            _disableInSessionControlsSettingCheckBox.AutoSize = true;
            _disableInSessionControlsSettingCheckBox.Location = new Point(56, 301);
            _disableInSessionControlsSettingCheckBox.Name = "_disableInSessionControlsSettingCheckBox";
            _disableInSessionControlsSettingCheckBox.Size = new Size(317, 36);
            _disableInSessionControlsSettingCheckBox.TabIndex = 3;
            _disableInSessionControlsSettingCheckBox.Text = "Disable in-session controls";
            _disableInSessionControlsSettingCheckBox.UseVisualStyleBackColor = true;
            _disableInSessionControlsSettingCheckBox.CheckedChanged += _disableInSessionControlsSettingCheckBox_CheckedChanged;
            // 
            // _enableRepeatsSettingCheckBox
            // 
            _enableRepeatsSettingCheckBox.AutoSize = true;
            _enableRepeatsSettingCheckBox.Location = new Point(56, 259);
            _enableRepeatsSettingCheckBox.Name = "_enableRepeatsSettingCheckBox";
            _enableRepeatsSettingCheckBox.Size = new Size(249, 36);
            _enableRepeatsSettingCheckBox.TabIndex = 4;
            _enableRepeatsSettingCheckBox.Text = "Allow image repeats";
            _enableRepeatsSettingCheckBox.UseVisualStyleBackColor = true;
            _enableRepeatsSettingCheckBox.CheckedChanged += _enableRepeatsSettingCheckBox_CheckedChanged;
            // 
            // _visibilitySettingsHeadingLabel
            // 
            _visibilitySettingsHeadingLabel.AutoSize = true;
            _visibilitySettingsHeadingLabel.Location = new Point(33, 22);
            _visibilitySettingsHeadingLabel.Name = "_visibilitySettingsHeadingLabel";
            _visibilitySettingsHeadingLabel.Size = new Size(274, 32);
            _visibilitySettingsHeadingLabel.TabIndex = 5;
            _visibilitySettingsHeadingLabel.Text = "Toggle element visibility";
            // 
            // _otherSettingsHeadingLabel
            // 
            _otherSettingsHeadingLabel.AutoSize = true;
            _otherSettingsHeadingLabel.Location = new Point(33, 215);
            _otherSettingsHeadingLabel.Name = "_otherSettingsHeadingLabel";
            _otherSettingsHeadingLabel.Size = new Size(165, 32);
            _otherSettingsHeadingLabel.TabIndex = 6;
            _otherSettingsHeadingLabel.Text = "Other settings";
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 420);
            Controls.Add(_otherSettingsHeadingLabel);
            Controls.Add(_visibilitySettingsHeadingLabel);
            Controls.Add(_enableRepeatsSettingCheckBox);
            Controls.Add(_disableInSessionControlsSettingCheckBox);
            Controls.Add(_enableSessionProgressBarSettingCheckBox);
            Controls.Add(_enableCurrentProgressBarSettingCheckBox);
            Controls.Add(_enableCurrentTimerSettingCheckBox);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "SettingsForm";
            Text = "Settings";
            Load += SettingsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox _enableCurrentTimerSettingCheckBox;
        private CheckBox _enableCurrentProgressBarSettingCheckBox;
        private CheckBox _enableSessionProgressBarSettingCheckBox;
        private CheckBox _disableInSessionControlsSettingCheckBox;
        private CheckBox _enableRepeatsSettingCheckBox;
        private Label _visibilitySettingsHeadingLabel;
        private Label _otherSettingsHeadingLabel;
    }
}