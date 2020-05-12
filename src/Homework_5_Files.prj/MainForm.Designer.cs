namespace WindowsFormsApp1
{
	partial class MainForm
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
			if(disposing && (components != null))
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
			this._pnlPlayer = new System.Windows.Forms.Panel();
			this._pnlLog = new System.Windows.Forms.Panel();
			this._pnlSettings = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// _pnlPlayer
			// 
			this._pnlPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._pnlPlayer.Location = new System.Drawing.Point(9, 7);
			this._pnlPlayer.Name = "_pnlPlayer";
			this._pnlPlayer.Size = new System.Drawing.Size(696, 376);
			this._pnlPlayer.TabIndex = 0;
			// 
			// _pnlLog
			// 
			this._pnlLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._pnlLog.Location = new System.Drawing.Point(9, 389);
			this._pnlLog.Name = "_pnlLog";
			this._pnlLog.Size = new System.Drawing.Size(833, 130);
			this._pnlLog.TabIndex = 1;
			// 
			// _pnlSettings
			// 
			this._pnlSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._pnlSettings.Location = new System.Drawing.Point(711, 7);
			this._pnlSettings.Name = "_pnlSettings";
			this._pnlSettings.Size = new System.Drawing.Size(128, 376);
			this._pnlSettings.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(96)))));
			this.ClientSize = new System.Drawing.Size(851, 531);
			this.Controls.Add(this._pnlSettings);
			this.Controls.Add(this._pnlLog);
			this.Controls.Add(this._pnlPlayer);
			this.Name = "MainForm";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel _pnlPlayer;
		private System.Windows.Forms.Panel _pnlLog;
		private System.Windows.Forms.Panel _pnlSettings;
	}
}

