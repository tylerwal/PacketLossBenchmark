namespace PacketLoss.UI
{
	partial class MainWindow
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
			this.gbxPingSettings = new System.Windows.Forms.GroupBox();
			this.gbxPingSettingsRequired = new System.Windows.Forms.GroupBox();
			this.gbxPingSettingsOptional = new System.Windows.Forms.GroupBox();
			this.lblSettingsAddress = new System.Windows.Forms.Label();
			this.txtSettingsAddress = new System.Windows.Forms.TextBox();
			this.lblSettingsNumberOfPings = new System.Windows.Forms.Label();
			this.txtSettingsNumberOfPings = new System.Windows.Forms.TextBox();
			this.pbPingProgress = new System.Windows.Forms.ProgressBar();
			this.btnSettingsCancel = new System.Windows.Forms.Button();
			this.btnSettingsStart = new System.Windows.Forms.Button();
			this.btnSettingsReset = new System.Windows.Forms.Button();
			this.lblSettingsBufferString = new System.Windows.Forms.Label();
			this.txtSettingsBufferString = new System.Windows.Forms.TextBox();
			this.lblSettingsTimeOut = new System.Windows.Forms.Label();
			this.lblSettingsDontFragment = new System.Windows.Forms.Label();
			this.chkSettingsDontFragment = new System.Windows.Forms.CheckBox();
			this.lblSettingsTTL = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.txtSettingsTTL = new System.Windows.Forms.TextBox();
			this.bsCriteria = new System.Windows.Forms.BindingSource(this.components);
			this.btnSettingsTest = new System.Windows.Forms.Button();
			this.gbxPingSettings.SuspendLayout();
			this.gbxPingSettingsRequired.SuspendLayout();
			this.gbxPingSettingsOptional.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bsCriteria)).BeginInit();
			this.SuspendLayout();
			// 
			// gbxPingSettings
			// 
			this.gbxPingSettings.Controls.Add(this.btnSettingsTest);
			this.gbxPingSettings.Controls.Add(this.btnSettingsReset);
			this.gbxPingSettings.Controls.Add(this.btnSettingsStart);
			this.gbxPingSettings.Controls.Add(this.btnSettingsCancel);
			this.gbxPingSettings.Controls.Add(this.pbPingProgress);
			this.gbxPingSettings.Controls.Add(this.gbxPingSettingsOptional);
			this.gbxPingSettings.Controls.Add(this.gbxPingSettingsRequired);
			this.gbxPingSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbxPingSettings.Location = new System.Drawing.Point(13, 13);
			this.gbxPingSettings.Name = "gbxPingSettings";
			this.gbxPingSettings.Size = new System.Drawing.Size(560, 240);
			this.gbxPingSettings.TabIndex = 0;
			this.gbxPingSettings.TabStop = false;
			this.gbxPingSettings.Text = "Ping Settings";
			// 
			// gbxPingSettingsRequired
			// 
			this.gbxPingSettingsRequired.Controls.Add(this.txtSettingsNumberOfPings);
			this.gbxPingSettingsRequired.Controls.Add(this.lblSettingsNumberOfPings);
			this.gbxPingSettingsRequired.Controls.Add(this.txtSettingsAddress);
			this.gbxPingSettingsRequired.Controls.Add(this.lblSettingsAddress);
			this.gbxPingSettingsRequired.Location = new System.Drawing.Point(6, 19);
			this.gbxPingSettingsRequired.Name = "gbxPingSettingsRequired";
			this.gbxPingSettingsRequired.Size = new System.Drawing.Size(543, 55);
			this.gbxPingSettingsRequired.TabIndex = 0;
			this.gbxPingSettingsRequired.TabStop = false;
			this.gbxPingSettingsRequired.Text = "Required";
			// 
			// gbxPingSettingsOptional
			// 
			this.gbxPingSettingsOptional.Controls.Add(this.txtSettingsTTL);
			this.gbxPingSettingsOptional.Controls.Add(this.textBox1);
			this.gbxPingSettingsOptional.Controls.Add(this.lblSettingsTTL);
			this.gbxPingSettingsOptional.Controls.Add(this.chkSettingsDontFragment);
			this.gbxPingSettingsOptional.Controls.Add(this.lblSettingsDontFragment);
			this.gbxPingSettingsOptional.Controls.Add(this.lblSettingsTimeOut);
			this.gbxPingSettingsOptional.Controls.Add(this.txtSettingsBufferString);
			this.gbxPingSettingsOptional.Controls.Add(this.lblSettingsBufferString);
			this.gbxPingSettingsOptional.Location = new System.Drawing.Point(6, 109);
			this.gbxPingSettingsOptional.Name = "gbxPingSettingsOptional";
			this.gbxPingSettingsOptional.Size = new System.Drawing.Size(471, 89);
			this.gbxPingSettingsOptional.TabIndex = 1;
			this.gbxPingSettingsOptional.TabStop = false;
			this.gbxPingSettingsOptional.Text = "Optional";
			// 
			// lblSettingsAddress
			// 
			this.lblSettingsAddress.AutoSize = true;
			this.lblSettingsAddress.Location = new System.Drawing.Point(7, 20);
			this.lblSettingsAddress.Name = "lblSettingsAddress";
			this.lblSettingsAddress.Size = new System.Drawing.Size(48, 13);
			this.lblSettingsAddress.TabIndex = 0;
			this.lblSettingsAddress.Text = "Address:";
			// 
			// txtSettingsAddress
			// 
			this.txtSettingsAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCriteria, "Address", true));
			this.txtSettingsAddress.Location = new System.Drawing.Point(59, 20);
			this.txtSettingsAddress.Name = "txtSettingsAddress";
			this.txtSettingsAddress.Size = new System.Drawing.Size(207, 20);
			this.txtSettingsAddress.TabIndex = 1;
			// 
			// lblSettingsNumberOfPings
			// 
			this.lblSettingsNumberOfPings.AutoSize = true;
			this.lblSettingsNumberOfPings.Location = new System.Drawing.Point(273, 19);
			this.lblSettingsNumberOfPings.Name = "lblSettingsNumberOfPings";
			this.lblSettingsNumberOfPings.Size = new System.Drawing.Size(128, 13);
			this.lblSettingsNumberOfPings.TabIndex = 2;
			this.lblSettingsNumberOfPings.Text = "Number of Pings to Send:";
			// 
			// txtSettingsNumberOfPings
			// 
			this.txtSettingsNumberOfPings.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCriteria, "NumberOfPings", true));
			this.txtSettingsNumberOfPings.Location = new System.Drawing.Point(405, 19);
			this.txtSettingsNumberOfPings.Name = "txtSettingsNumberOfPings";
			this.txtSettingsNumberOfPings.Size = new System.Drawing.Size(100, 20);
			this.txtSettingsNumberOfPings.TabIndex = 3;
			// 
			// pbPingProgress
			// 
			this.pbPingProgress.Location = new System.Drawing.Point(304, 204);
			this.pbPingProgress.Name = "pbPingProgress";
			this.pbPingProgress.Size = new System.Drawing.Size(164, 23);
			this.pbPingProgress.TabIndex = 2;
			// 
			// btnSettingsCancel
			// 
			this.btnSettingsCancel.Location = new System.Drawing.Point(474, 204);
			this.btnSettingsCancel.Name = "btnSettingsCancel";
			this.btnSettingsCancel.Size = new System.Drawing.Size(75, 23);
			this.btnSettingsCancel.TabIndex = 3;
			this.btnSettingsCancel.Text = "Cancel";
			this.btnSettingsCancel.UseVisualStyleBackColor = true;
			// 
			// btnSettingsStart
			// 
			this.btnSettingsStart.Location = new System.Drawing.Point(12, 205);
			this.btnSettingsStart.Name = "btnSettingsStart";
			this.btnSettingsStart.Size = new System.Drawing.Size(75, 23);
			this.btnSettingsStart.TabIndex = 4;
			this.btnSettingsStart.Text = "Start";
			this.btnSettingsStart.UseVisualStyleBackColor = true;
			// 
			// btnSettingsReset
			// 
			this.btnSettingsReset.Location = new System.Drawing.Point(93, 205);
			this.btnSettingsReset.Name = "btnSettingsReset";
			this.btnSettingsReset.Size = new System.Drawing.Size(75, 23);
			this.btnSettingsReset.TabIndex = 5;
			this.btnSettingsReset.Text = "Reset";
			this.btnSettingsReset.UseVisualStyleBackColor = true;
			// 
			// lblSettingsBufferString
			// 
			this.lblSettingsBufferString.AutoSize = true;
			this.lblSettingsBufferString.Location = new System.Drawing.Point(7, 20);
			this.lblSettingsBufferString.Name = "lblSettingsBufferString";
			this.lblSettingsBufferString.Size = new System.Drawing.Size(68, 13);
			this.lblSettingsBufferString.TabIndex = 0;
			this.lblSettingsBufferString.Text = "Buffer String:";
			// 
			// txtSettingsBufferString
			// 
			this.txtSettingsBufferString.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCriteria, "Buffer", true));
			this.txtSettingsBufferString.Location = new System.Drawing.Point(79, 20);
			this.txtSettingsBufferString.Name = "txtSettingsBufferString";
			this.txtSettingsBufferString.Size = new System.Drawing.Size(187, 20);
			this.txtSettingsBufferString.TabIndex = 1;
			// 
			// lblSettingsTimeOut
			// 
			this.lblSettingsTimeOut.AutoSize = true;
			this.lblSettingsTimeOut.Location = new System.Drawing.Point(276, 20);
			this.lblSettingsTimeOut.Name = "lblSettingsTimeOut";
			this.lblSettingsTimeOut.Size = new System.Drawing.Size(75, 13);
			this.lblSettingsTimeOut.TabIndex = 2;
			this.lblSettingsTimeOut.Text = "Time Out (ms):";
			// 
			// lblSettingsDontFragment
			// 
			this.lblSettingsDontFragment.AutoSize = true;
			this.lblSettingsDontFragment.Location = new System.Drawing.Point(7, 53);
			this.lblSettingsDontFragment.Name = "lblSettingsDontFragment";
			this.lblSettingsDontFragment.Size = new System.Drawing.Size(82, 13);
			this.lblSettingsDontFragment.TabIndex = 3;
			this.lblSettingsDontFragment.Text = "Don\'t Fragment:";
			// 
			// chkSettingsDontFragment
			// 
			this.chkSettingsDontFragment.AutoSize = true;
			this.chkSettingsDontFragment.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsCriteria, "DontFragment", true));
			this.chkSettingsDontFragment.Location = new System.Drawing.Point(95, 53);
			this.chkSettingsDontFragment.Name = "chkSettingsDontFragment";
			this.chkSettingsDontFragment.Size = new System.Drawing.Size(101, 17);
			this.chkSettingsDontFragment.TabIndex = 4;
			this.chkSettingsDontFragment.Text = "(Typically False)";
			this.chkSettingsDontFragment.UseVisualStyleBackColor = true;
			// 
			// lblSettingsTTL
			// 
			this.lblSettingsTTL.AutoSize = true;
			this.lblSettingsTTL.Location = new System.Drawing.Point(300, 54);
			this.lblSettingsTTL.Name = "lblSettingsTTL";
			this.lblSettingsTTL.Size = new System.Drawing.Size(52, 13);
			this.lblSettingsTTL.TabIndex = 5;
			this.lblSettingsTTL.Text = "TTL (ms):";
			// 
			// textBox1
			// 
			this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCriteria, "TimeOut", true));
			this.textBox1.Location = new System.Drawing.Point(358, 19);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 6;
			// 
			// txtSettingsTTL
			// 
			this.txtSettingsTTL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCriteria, "TimeToLive", true));
			this.txtSettingsTTL.Location = new System.Drawing.Point(358, 49);
			this.txtSettingsTTL.Name = "txtSettingsTTL";
			this.txtSettingsTTL.Size = new System.Drawing.Size(100, 20);
			this.txtSettingsTTL.TabIndex = 7;
			/*// 
			// bsCriteria
			// 
			this.bsCriteria.DataSource = typeof(PacketLoss.UI.Entity.PingCriteria);*/
			// 
			// btnSettingsTest
			// 
			this.btnSettingsTest.Location = new System.Drawing.Point(6, 80);
			this.btnSettingsTest.Name = "btnSettingsTest";
			this.btnSettingsTest.Size = new System.Drawing.Size(75, 23);
			this.btnSettingsTest.TabIndex = 6;
			this.btnSettingsTest.Text = "Test";
			this.btnSettingsTest.UseVisualStyleBackColor = true;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(583, 449);
			this.Controls.Add(this.gbxPingSettings);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "MainWindow";
			this.Text = "Ping Benchmark Tool by TCW";
			this.gbxPingSettings.ResumeLayout(false);
			this.gbxPingSettingsRequired.ResumeLayout(false);
			this.gbxPingSettingsRequired.PerformLayout();
			this.gbxPingSettingsOptional.ResumeLayout(false);
			this.gbxPingSettingsOptional.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bsCriteria)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.BindingSource bsCriteria;
		private System.Windows.Forms.GroupBox gbxPingSettings;
		private System.Windows.Forms.GroupBox gbxPingSettingsRequired;
		private System.Windows.Forms.GroupBox gbxPingSettingsOptional;
		private System.Windows.Forms.TextBox txtSettingsNumberOfPings;
		private System.Windows.Forms.Label lblSettingsNumberOfPings;
		private System.Windows.Forms.TextBox txtSettingsAddress;
		private System.Windows.Forms.Label lblSettingsAddress;
		private System.Windows.Forms.Button btnSettingsReset;
		private System.Windows.Forms.Button btnSettingsStart;
		private System.Windows.Forms.Button btnSettingsCancel;
		private System.Windows.Forms.ProgressBar pbPingProgress;
		private System.Windows.Forms.TextBox txtSettingsTTL;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label lblSettingsTTL;
		private System.Windows.Forms.CheckBox chkSettingsDontFragment;
		private System.Windows.Forms.Label lblSettingsDontFragment;
		private System.Windows.Forms.Label lblSettingsTimeOut;
		private System.Windows.Forms.TextBox txtSettingsBufferString;
		private System.Windows.Forms.Label lblSettingsBufferString;
		private System.Windows.Forms.Button btnSettingsTest;
	}
}

