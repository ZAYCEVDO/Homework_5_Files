namespace WindowsFormsApp1
{
	partial class PlayerControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this._pnlPicture = new System.Windows.Forms.Panel();
			this._picVideo = new System.Windows.Forms.PictureBox();
			this._pnlButtons = new System.Windows.Forms.Panel();
			this._btnForward = new System.Windows.Forms.Button();
			this._btnBack = new System.Windows.Forms.Button();
			this._btnStop = new System.Windows.Forms.Button();
			this._btnPause = new System.Windows.Forms.Button();
			this._btnStart = new System.Windows.Forms.Button();
			this._btnOpenFolder = new System.Windows.Forms.Button();
			this._btnOpenFile = new System.Windows.Forms.Button();
			this._opnFileDialog = new System.Windows.Forms.OpenFileDialog();
			this._opnFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
			this._pnlPicture.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._picVideo)).BeginInit();
			this._pnlButtons.SuspendLayout();
			this.SuspendLayout();
			// 
			// _pnlPicture
			// 
			this._pnlPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._pnlPicture.Controls.Add(this._picVideo);
			this._pnlPicture.Location = new System.Drawing.Point(0, 0);
			this._pnlPicture.Name = "_pnlPicture";
			this._pnlPicture.Size = new System.Drawing.Size(626, 354);
			this._pnlPicture.TabIndex = 0;
			// 
			// _picVideo
			// 
			this._picVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._picVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this._picVideo.Location = new System.Drawing.Point(0, -3);
			this._picVideo.Name = "_picVideo";
			this._picVideo.Size = new System.Drawing.Size(626, 354);
			this._picVideo.TabIndex = 1;
			this._picVideo.TabStop = false;
			// 
			// _pnlButtons
			// 
			this._pnlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._pnlButtons.Controls.Add(this._btnForward);
			this._pnlButtons.Controls.Add(this._btnBack);
			this._pnlButtons.Controls.Add(this._btnStop);
			this._pnlButtons.Controls.Add(this._btnPause);
			this._pnlButtons.Controls.Add(this._btnStart);
			this._pnlButtons.Controls.Add(this._btnOpenFolder);
			this._pnlButtons.Controls.Add(this._btnOpenFile);
			this._pnlButtons.Location = new System.Drawing.Point(0, 351);
			this._pnlButtons.Name = "_pnlButtons";
			this._pnlButtons.Size = new System.Drawing.Size(626, 43);
			this._pnlButtons.TabIndex = 1;
			// 
			// _btnForward
			// 
			this._btnForward.BackColor = System.Drawing.Color.White;
			this._btnForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._btnForward.Location = new System.Drawing.Point(230, 9);
			this._btnForward.Name = "_btnForward";
			this._btnForward.Size = new System.Drawing.Size(35, 23);
			this._btnForward.TabIndex = 13;
			this._btnForward.Text = ">>";
			this._btnForward.UseVisualStyleBackColor = false;
			this._btnForward.Click += new System.EventHandler(this.OnNextClick);
			// 
			// _btnBack
			// 
			this._btnBack.BackColor = System.Drawing.Color.White;
			this._btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._btnBack.Location = new System.Drawing.Point(189, 9);
			this._btnBack.Name = "_btnBack";
			this._btnBack.Size = new System.Drawing.Size(35, 23);
			this._btnBack.TabIndex = 12;
			this._btnBack.Text = "<<";
			this._btnBack.UseVisualStyleBackColor = false;
			this._btnBack.Click += new System.EventHandler(this.OnPreviousClick);
			// 
			// _btnStop
			// 
			this._btnStop.BackColor = System.Drawing.Color.White;
			this._btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._btnStop.ForeColor = System.Drawing.Color.Maroon;
			this._btnStop.Location = new System.Drawing.Point(133, 9);
			this._btnStop.Name = "_btnStop";
			this._btnStop.Size = new System.Drawing.Size(47, 23);
			this._btnStop.TabIndex = 11;
			this._btnStop.Text = "Stop";
			this._btnStop.UseVisualStyleBackColor = false;
			// 
			// _btnPause
			// 
			this._btnPause.BackColor = System.Drawing.Color.White;
			this._btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._btnPause.Location = new System.Drawing.Point(74, 9);
			this._btnPause.Name = "_btnPause";
			this._btnPause.Size = new System.Drawing.Size(53, 23);
			this._btnPause.TabIndex = 10;
			this._btnPause.Text = "Pause";
			this._btnPause.UseVisualStyleBackColor = false;
			// 
			// _btnStart
			// 
			this._btnStart.BackColor = System.Drawing.Color.White;
			this._btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._btnStart.Location = new System.Drawing.Point(13, 9);
			this._btnStart.Name = "_btnStart";
			this._btnStart.Size = new System.Drawing.Size(55, 23);
			this._btnStart.TabIndex = 9;
			this._btnStart.Text = "Start";
			this._btnStart.UseVisualStyleBackColor = false;
			// 
			// _btnOpenFolder
			// 
			this._btnOpenFolder.BackColor = System.Drawing.Color.White;
			this._btnOpenFolder.Location = new System.Drawing.Point(271, 9);
			this._btnOpenFolder.Name = "_btnOpenFolder";
			this._btnOpenFolder.Size = new System.Drawing.Size(129, 23);
			this._btnOpenFolder.TabIndex = 8;
			this._btnOpenFolder.Text = "Открыть папку";
			this._btnOpenFolder.UseVisualStyleBackColor = false;
			this._btnOpenFolder.Click += new System.EventHandler(this.OnOpenFolderClick);
			// 
			// _btnOpenFile
			// 
			this._btnOpenFile.BackColor = System.Drawing.Color.White;
			this._btnOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._btnOpenFile.Location = new System.Drawing.Point(406, 9);
			this._btnOpenFile.Name = "_btnOpenFile";
			this._btnOpenFile.Size = new System.Drawing.Size(114, 23);
			this._btnOpenFile.TabIndex = 7;
			this._btnOpenFile.Text = "Открыть файл";
			this._btnOpenFile.UseVisualStyleBackColor = false;
			this._btnOpenFile.Click += new System.EventHandler(this.OnOpenFileClick);
			// 
			// _opnFileDialog
			// 
			this._opnFileDialog.FileName = "openFileDialog1";
			// 
			// PlayerControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.Controls.Add(this._pnlButtons);
			this.Controls.Add(this._pnlPicture);
			this.Name = "PlayerControl";
			this.Size = new System.Drawing.Size(626, 394);
			this._pnlPicture.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._picVideo)).EndInit();
			this._pnlButtons.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel _pnlPicture;
		private System.Windows.Forms.PictureBox _picVideo;
		private System.Windows.Forms.Panel _pnlButtons;
		private System.Windows.Forms.Button _btnForward;
		private System.Windows.Forms.Button _btnBack;
		private System.Windows.Forms.Button _btnStop;
		private System.Windows.Forms.Button _btnPause;
		private System.Windows.Forms.Button _btnStart;
		private System.Windows.Forms.Button _btnOpenFolder;
		private System.Windows.Forms.Button _btnOpenFile;
		private System.Windows.Forms.OpenFileDialog _opnFileDialog;
		private System.Windows.Forms.FolderBrowserDialog _opnFolderDialog;
	}
}
