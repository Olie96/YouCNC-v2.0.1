namespace YouCNC_Version_2._0._1.Forms
{
    partial class ComConnectionsForm
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
			this.components = new System.ComponentModel.Container();
			this.rbDisconnect = new Telerik.WinControls.UI.RadButton();
			this.rbConnect = new Telerik.WinControls.UI.RadButton();
			this.rlBaudRate = new Telerik.WinControls.UI.RadLabel();
			this.rlComPort = new Telerik.WinControls.UI.RadLabel();
			this.rddlBaudRate = new Telerik.WinControls.UI.RadDropDownList();
			this.bsBaudRate = new System.Windows.Forms.BindingSource(this.components);
			this.rddlComPort = new Telerik.WinControls.UI.RadDropDownList();
			this.bsComPorts = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.rbDisconnect)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rbConnect)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rlBaudRate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rlComPort)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rddlBaudRate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsBaudRate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rddlComPort)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsComPorts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			this.SuspendLayout();
			// 
			// rbDisconnect
			// 
			this.rbDisconnect.Location = new System.Drawing.Point(144, 59);
			this.rbDisconnect.Name = "rbDisconnect";
			this.rbDisconnect.Size = new System.Drawing.Size(125, 24);
			this.rbDisconnect.TabIndex = 13;
			this.rbDisconnect.Text = "Disconnect";
			this.rbDisconnect.Click += new System.EventHandler(this.rbDisconnect_Click);
			// 
			// rbConnect
			// 
			this.rbConnect.Location = new System.Drawing.Point(12, 59);
			this.rbConnect.Name = "rbConnect";
			this.rbConnect.Size = new System.Drawing.Size(125, 24);
			this.rbConnect.TabIndex = 12;
			this.rbConnect.Text = "Connect";
			this.rbConnect.Click += new System.EventHandler(this.rbConnect_Click);
			// 
			// rlBaudRate
			// 
			this.rlBaudRate.Location = new System.Drawing.Point(144, 12);
			this.rlBaudRate.Name = "rlBaudRate";
			this.rlBaudRate.Size = new System.Drawing.Size(54, 18);
			this.rlBaudRate.TabIndex = 11;
			this.rlBaudRate.Text = "BaudRate";
			// 
			// rlComPort
			// 
			this.rlComPort.Location = new System.Drawing.Point(12, 12);
			this.rlComPort.Name = "rlComPort";
			this.rlComPort.Size = new System.Drawing.Size(32, 18);
			this.rlComPort.TabIndex = 10;
			this.rlComPort.Text = "Ports";
			// 
			// rddlBaudRate
			// 
			this.rddlBaudRate.DataSource = this.bsBaudRate;
			this.rddlBaudRate.DisplayMember = "DisplayMember";
			this.rddlBaudRate.Location = new System.Drawing.Point(144, 33);
			this.rddlBaudRate.Name = "rddlBaudRate";
			this.rddlBaudRate.Size = new System.Drawing.Size(125, 20);
			this.rddlBaudRate.TabIndex = 9;
			this.rddlBaudRate.ValueMember = "ValueMamber";
			// 
			// bsBaudRate
			// 
			this.bsBaudRate.DataSource = typeof(YouCNC_Version_2._0._1.Common.BaudRate);
			// 
			// rddlComPort
			// 
			this.rddlComPort.DataSource = this.bsComPorts;
			this.rddlComPort.DisplayMember = "DisplayMember";
			this.rddlComPort.Location = new System.Drawing.Point(12, 33);
			this.rddlComPort.Name = "rddlComPort";
			this.rddlComPort.Size = new System.Drawing.Size(125, 20);
			this.rddlComPort.TabIndex = 8;
			this.rddlComPort.ValueMember = "ValueMamber";
			// 
			// bsComPorts
			// 
			this.bsComPorts.DataSource = typeof(YouCNC_Version_2._0._1.Common.ComPort);
			// 
			// ComConnectionsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 109);
			this.Controls.Add(this.rbDisconnect);
			this.Controls.Add(this.rbConnect);
			this.Controls.Add(this.rlBaudRate);
			this.Controls.Add(this.rlComPort);
			this.Controls.Add(this.rddlBaudRate);
			this.Controls.Add(this.rddlComPort);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ComConnectionsForm";
			// 
			// 
			// 
			this.RootElement.ApplyShapeToControl = true;
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "ComPorts";
			((System.ComponentModel.ISupportInitialize)(this.rbDisconnect)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rbConnect)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rlBaudRate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rlComPort)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rddlBaudRate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsBaudRate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rddlComPort)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsComPorts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private Telerik.WinControls.UI.RadButton rbDisconnect;
		private Telerik.WinControls.UI.RadButton rbConnect;
		private Telerik.WinControls.UI.RadLabel rlBaudRate;
		private Telerik.WinControls.UI.RadLabel rlComPort;
		private Telerik.WinControls.UI.RadDropDownList rddlBaudRate;
		private Telerik.WinControls.UI.RadDropDownList rddlComPort;
		private System.Windows.Forms.BindingSource bsBaudRate;
		private System.Windows.Forms.BindingSource bsComPorts;
	}
}
