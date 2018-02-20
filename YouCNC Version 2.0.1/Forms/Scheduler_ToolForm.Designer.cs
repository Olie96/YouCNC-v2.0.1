namespace YouCNC_Version_2._0._1.Forms
{
    partial class Scheduler_ToolForm
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
			this.radTimePicker1 = new Telerik.WinControls.UI.RadTimePicker();
			this.radClock1 = new Telerik.WinControls.UI.RadClock();
			this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
			this.radButton1 = new Telerik.WinControls.UI.RadButton();
			((System.ComponentModel.ISupportInitialize)(this.radTimePicker1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radClock1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			this.SuspendLayout();
			// 
			// radTimePicker1
			// 
			this.radTimePicker1.Location = new System.Drawing.Point(174, 170);
			this.radTimePicker1.MaxValue = new System.DateTime(9999, 12, 31, 23, 59, 59, 0);
			this.radTimePicker1.MinValue = new System.DateTime(((long)(0)));
			this.radTimePicker1.Name = "radTimePicker1";
			this.radTimePicker1.Size = new System.Drawing.Size(100, 20);
			this.radTimePicker1.TabIndex = 0;
			this.radTimePicker1.TabStop = false;
			this.radTimePicker1.Value = new System.DateTime(2018, 2, 13, 13, 6, 14, 233);
			// 
			// radClock1
			// 
			this.radClock1.Location = new System.Drawing.Point(12, 12);
			this.radClock1.Name = "radClock1";
			this.radClock1.Size = new System.Drawing.Size(134, 135);
			this.radClock1.TabIndex = 1;
			// 
			// radLabel1
			// 
			this.radLabel1.Location = new System.Drawing.Point(12, 171);
			this.radLabel1.Name = "radLabel1";
			this.radLabel1.Size = new System.Drawing.Size(156, 18);
			this.radLabel1.TabIndex = 2;
			this.radLabel1.Text = "Schedule your work to start at";
			// 
			// radButton1
			// 
			this.radButton1.Location = new System.Drawing.Point(13, 196);
			this.radButton1.Name = "radButton1";
			this.radButton1.Size = new System.Drawing.Size(276, 24);
			this.radButton1.TabIndex = 3;
			this.radButton1.Text = "Confirm";
			this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
			// 
			// Scheduler_ToolForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 222);
			this.Controls.Add(this.radButton1);
			this.Controls.Add(this.radLabel1);
			this.Controls.Add(this.radClock1);
			this.Controls.Add(this.radTimePicker1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Scheduler_ToolForm";
			// 
			// 
			// 
			this.RootElement.ApplyShapeToControl = true;
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Scheduler";
			((System.ComponentModel.ISupportInitialize)(this.radTimePicker1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radClock1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private Telerik.WinControls.UI.RadTimePicker radTimePicker1;
		private Telerik.WinControls.UI.RadClock radClock1;
		private Telerik.WinControls.UI.RadLabel radLabel1;
		private Telerik.WinControls.UI.RadButton radButton1;
	}
}
