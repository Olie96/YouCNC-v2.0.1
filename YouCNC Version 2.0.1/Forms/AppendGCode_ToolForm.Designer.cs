namespace YouCNC_Version_2._0._1.Forms
{
    partial class AppendGCode_ToolForm
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
			this.rcddCalculator = new Telerik.WinControls.UI.RadCalculatorDropDown();
			this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
			this.radButton1 = new Telerik.WinControls.UI.RadButton();
			((System.ComponentModel.ISupportInitialize)(this.rcddCalculator)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			this.SuspendLayout();
			// 
			// rcddCalculator
			// 
			this.rcddCalculator.Location = new System.Drawing.Point(13, 31);
			this.rcddCalculator.Name = "rcddCalculator";
			this.rcddCalculator.Size = new System.Drawing.Size(183, 20);
			this.rcddCalculator.TabIndex = 0;
			this.rcddCalculator.TabStop = false;
			this.rcddCalculator.Value = "0";
			// 
			// radLabel1
			// 
			this.radLabel1.Location = new System.Drawing.Point(13, 7);
			this.radLabel1.Name = "radLabel1";
			this.radLabel1.Size = new System.Drawing.Size(122, 18);
			this.radLabel1.TabIndex = 1;
			this.radLabel1.Text = "Calculate needed value";
			// 
			// radButton1
			// 
			this.radButton1.Location = new System.Drawing.Point(203, 31);
			this.radButton1.Name = "radButton1";
			this.radButton1.Size = new System.Drawing.Size(77, 20);
			this.radButton1.TabIndex = 2;
			this.radButton1.Text = "Append";
			this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
			// 
			// AppendGCode_ToolForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 72);
			this.Controls.Add(this.radButton1);
			this.Controls.Add(this.radLabel1);
			this.Controls.Add(this.rcddCalculator);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "AppendGCode_ToolForm";
			// 
			// 
			// 
			this.RootElement.ApplyShapeToControl = true;
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Calculate value";
			((System.ComponentModel.ISupportInitialize)(this.rcddCalculator)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private Telerik.WinControls.UI.RadCalculatorDropDown rcddCalculator;
		private Telerik.WinControls.UI.RadLabel radLabel1;
		private Telerik.WinControls.UI.RadButton radButton1;
	}
}
