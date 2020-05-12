namespace WindowsFormsApp1
{
	partial class SettingsControl
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
			this._btnSave = new System.Windows.Forms.Button();
			this._btnLoad = new System.Windows.Forms.Button();
			this._chkDetector = new System.Windows.Forms.CheckBox();
			this._chkUnderCatalog = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// _btnSave
			// 
			this._btnSave.BackColor = System.Drawing.Color.White;
			this._btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._btnSave.Location = new System.Drawing.Point(3, 3);
			this._btnSave.Name = "_btnSave";
			this._btnSave.Size = new System.Drawing.Size(55, 23);
			this._btnSave.TabIndex = 10;
			this._btnSave.Text = "Save";
			this._btnSave.UseVisualStyleBackColor = false;
			this._btnSave.Click += new System.EventHandler(this.OnSaveClick);
			// 
			// _btnLoad
			// 
			this._btnLoad.BackColor = System.Drawing.Color.White;
			this._btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._btnLoad.Location = new System.Drawing.Point(64, 3);
			this._btnLoad.Name = "_btnLoad";
			this._btnLoad.Size = new System.Drawing.Size(55, 23);
			this._btnLoad.TabIndex = 11;
			this._btnLoad.Text = "Load";
			this._btnLoad.UseVisualStyleBackColor = false;
			// 
			// _chkDetector
			// 
			this._chkDetector.AutoSize = true;
			this._chkDetector.Location = new System.Drawing.Point(5, 32);
			this._chkDetector.Name = "_chkDetector";
			this._chkDetector.Size = new System.Drawing.Size(114, 17);
			this._chkDetector.TabIndex = 12;
			this._chkDetector.Text = "Детектор сцепок";
			this._chkDetector.UseVisualStyleBackColor = true;
			this._chkDetector.CheckedChanged += new System.EventHandler(this.OnChangeDetector);
			// 
			// _chkUnderCatalog
			// 
			this._chkUnderCatalog.AutoSize = true;
			this._chkUnderCatalog.Location = new System.Drawing.Point(5, 55);
			this._chkUnderCatalog.Name = "_chkUnderCatalog";
			this._chkUnderCatalog.Size = new System.Drawing.Size(114, 17);
			this._chkUnderCatalog.TabIndex = 13;
			this._chkUnderCatalog.Text = "С подкаталогами";
			this._chkUnderCatalog.UseVisualStyleBackColor = true;
			this._chkUnderCatalog.CheckedChanged += new System.EventHandler(this.OnChangeUnderCatalog);
			// 
			// SettingsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.Controls.Add(this._chkUnderCatalog);
			this.Controls.Add(this._chkDetector);
			this.Controls.Add(this._btnLoad);
			this.Controls.Add(this._btnSave);
			this.Name = "SettingsControl";
			this.Size = new System.Drawing.Size(171, 240);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button _btnSave;
		private System.Windows.Forms.Button _btnLoad;
		private System.Windows.Forms.CheckBox _chkDetector;
		private System.Windows.Forms.CheckBox _chkUnderCatalog;
	}
}
