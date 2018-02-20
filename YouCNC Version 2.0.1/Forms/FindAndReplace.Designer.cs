namespace YouCNC_Version_2._0._1.Forms
{
    partial class FindAndReplace
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
			this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
			this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
			this.radButton1 = new Telerik.WinControls.UI.RadButton();
			this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
			this.radTextBox2 = new Telerik.WinControls.UI.RadTextBox();
			((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radTextBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			this.SuspendLayout();
			// 
			// radTextBox1
			// 
			this.radTextBox1.Location = new System.Drawing.Point(76, 13);
			this.radTextBox1.Name = "radTextBox1";
			this.radTextBox1.Size = new System.Drawing.Size(309, 20);
			this.radTextBox1.TabIndex = 0;
			// 
			// radLabel1
			// 
			this.radLabel1.Location = new System.Drawing.Point(1, 14);
			this.radLabel1.Name = "radLabel1";
			this.radLabel1.Size = new System.Drawing.Size(28, 18);
			this.radLabel1.TabIndex = 1;
			this.radLabel1.Text = "Find";
			// 
			// radButton1
			// 
			this.radButton1.Location = new System.Drawing.Point(391, 38);
			this.radButton1.Name = "radButton1";
			this.radButton1.Size = new System.Drawing.Size(63, 19);
			this.radButton1.TabIndex = 2;
			this.radButton1.Text = "Replace";
			// 
			// radLabel2
			// 
			this.radLabel2.Location = new System.Drawing.Point(1, 38);
			this.radLabel2.Name = "radLabel2";
			this.radLabel2.Size = new System.Drawing.Size(69, 18);
			this.radLabel2.TabIndex = 3;
			this.radLabel2.Text = "Replace with";
			// 
			// radTextBox2
			// 
			this.radTextBox2.Location = new System.Drawing.Point(76, 37);
			this.radTextBox2.Name = "radTextBox2";
			this.radTextBox2.Size = new System.Drawing.Size(309, 20);
			this.radTextBox2.TabIndex = 2;
			// 
			// FindAndReplace
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(467, 68);
			this.Controls.Add(this.radLabel2);
			this.Controls.Add(this.radTextBox2);
			this.Controls.Add(this.radButton1);
			this.Controls.Add(this.radLabel1);
			this.Controls.Add(this.radTextBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FindAndReplace";
			// 
			// 
			// 
			this.RootElement.ApplyShapeToControl = true;
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
			this.Text = "Find and Replace";
			((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radTextBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private Telerik.WinControls.UI.RadTextBox radTextBox1;
		private Telerik.WinControls.UI.RadLabel radLabel1;
		private Telerik.WinControls.UI.RadButton radButton1;
		private Telerik.WinControls.UI.RadLabel radLabel2;
		private Telerik.WinControls.UI.RadTextBox radTextBox2;
	}
}
