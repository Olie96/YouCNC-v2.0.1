namespace YouCNC_Version_2._0._1.Forms
{
    partial class SystemSettingsForm
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
			this.rtsAlertSound = new Telerik.WinControls.UI.RadToggleSwitch();
			this.rbAlertSound = new Telerik.WinControls.UI.RadLabel();
			this.rlTheme = new Telerik.WinControls.UI.RadLabel();
			this.rddlTheme = new Telerik.WinControls.UI.RadDropDownList();
			((System.ComponentModel.ISupportInitialize)(this.rtsAlertSound)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rbAlertSound)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rlTheme)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rddlTheme)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			this.SuspendLayout();
			// 
			// rtsAlertSound
			// 
			this.rtsAlertSound.Location = new System.Drawing.Point(82, 43);
			this.rtsAlertSound.Name = "rtsAlertSound";
			this.rtsAlertSound.Size = new System.Drawing.Size(50, 20);
			this.rtsAlertSound.TabIndex = 1;
			this.rtsAlertSound.ValueChanged += new System.EventHandler(this.radToggleSwitch1_ValueChanged);
			// 
			// rbAlertSound
			// 
			this.rbAlertSound.Location = new System.Drawing.Point(12, 45);
			this.rbAlertSound.Name = "rbAlertSound";
			this.rbAlertSound.Size = new System.Drawing.Size(64, 18);
			this.rbAlertSound.TabIndex = 2;
			this.rbAlertSound.Text = "Alert sound";
			// 
			// rlTheme
			// 
			this.rlTheme.Location = new System.Drawing.Point(13, 13);
			this.rlTheme.Name = "rlTheme";
			this.rlTheme.Size = new System.Drawing.Size(40, 18);
			this.rlTheme.TabIndex = 3;
			this.rlTheme.Text = "Theme";
			// 
			// rddlTheme
			// 
			this.rddlTheme.Location = new System.Drawing.Point(82, 13);
			this.rddlTheme.Name = "rddlTheme";
			this.rddlTheme.Size = new System.Drawing.Size(125, 20);
			this.rddlTheme.TabIndex = 4;
			// 
			// SystemSettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(495, 335);
			this.Controls.Add(this.rddlTheme);
			this.Controls.Add(this.rlTheme);
			this.Controls.Add(this.rbAlertSound);
			this.Controls.Add(this.rtsAlertSound);
			this.Name = "SystemSettingsForm";
			// 
			// 
			// 
			this.RootElement.ApplyShapeToControl = true;
			this.Text = "SystemSettingsForm";
			((System.ComponentModel.ISupportInitialize)(this.rtsAlertSound)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rbAlertSound)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rlTheme)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rddlTheme)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion
		private Telerik.WinControls.UI.RadToggleSwitch rtsAlertSound;
		private Telerik.WinControls.UI.RadLabel rbAlertSound;
		private Telerik.WinControls.UI.RadLabel rlTheme;
		private Telerik.WinControls.UI.RadDropDownList rddlTheme;
	}
}
