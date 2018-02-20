namespace YouCNC_Version_2._0._1.Forms
{
    partial class Find
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
			this.radButton1 = new Telerik.WinControls.UI.RadButton();
			this.radListView1 = new Telerik.WinControls.UI.RadListView();
			this.radButton2 = new Telerik.WinControls.UI.RadButton();
			((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radListView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			this.SuspendLayout();
			// 
			// radTextBox1
			// 
			this.radTextBox1.Location = new System.Drawing.Point(1, 12);
			this.radTextBox1.Name = "radTextBox1";
			this.radTextBox1.Size = new System.Drawing.Size(401, 20);
			this.radTextBox1.TabIndex = 0;
			// 
			// radButton1
			// 
			this.radButton1.Location = new System.Drawing.Point(408, 13);
			this.radButton1.Name = "radButton1";
			this.radButton1.Size = new System.Drawing.Size(74, 20);
			this.radButton1.TabIndex = 1;
			this.radButton1.Text = "Find";
			// 
			// radListView1
			// 
			this.radListView1.Location = new System.Drawing.Point(1, 39);
			this.radListView1.Name = "radListView1";
			this.radListView1.Size = new System.Drawing.Size(481, 537);
			this.radListView1.TabIndex = 2;
			// 
			// radButton2
			// 
			this.radButton2.Location = new System.Drawing.Point(1, 582);
			this.radButton2.Name = "radButton2";
			this.radButton2.Size = new System.Drawing.Size(481, 26);
			this.radButton2.TabIndex = 3;
			this.radButton2.Text = "Done";
			// 
			// Find
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(483, 609);
			this.Controls.Add(this.radButton2);
			this.Controls.Add(this.radListView1);
			this.Controls.Add(this.radButton1);
			this.Controls.Add(this.radTextBox1);
			this.Name = "Find";
			// 
			// 
			// 
			this.RootElement.ApplyShapeToControl = true;
			this.Text = "Find";
			((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radListView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private Telerik.WinControls.UI.RadTextBox radTextBox1;
		private Telerik.WinControls.UI.RadButton radButton1;
		private Telerik.WinControls.UI.RadListView radListView1;
		private Telerik.WinControls.UI.RadButton radButton2;
	}
}
