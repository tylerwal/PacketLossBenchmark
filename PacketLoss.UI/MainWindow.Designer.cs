﻿namespace PacketLoss.UI
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.gbxPingSettings = new System.Windows.Forms.GroupBox();
			this.btnSettingsTest = new System.Windows.Forms.Button();
			this.btnSettingsReset = new System.Windows.Forms.Button();
			this.btnSettingsStart = new System.Windows.Forms.Button();
			this.btnSettingsStop = new System.Windows.Forms.Button();
			this.pbPingProgress = new System.Windows.Forms.ProgressBar();
			this.gbxPingSettingsOptional = new System.Windows.Forms.GroupBox();
			this.txtSettingsTTL = new System.Windows.Forms.TextBox();
			this.bsCriteria = new System.Windows.Forms.BindingSource(this.components);
			this.txtSettingsTimeOut = new System.Windows.Forms.TextBox();
			this.lblSettingsTTL = new System.Windows.Forms.Label();
			this.chkSettingsDontFragment = new System.Windows.Forms.CheckBox();
			this.lblSettingsDontFragment = new System.Windows.Forms.Label();
			this.lblSettingsTimeOut = new System.Windows.Forms.Label();
			this.txtSettingsBufferString = new System.Windows.Forms.TextBox();
			this.lblSettingsBufferString = new System.Windows.Forms.Label();
			this.gbxPingSettingsRequired = new System.Windows.Forms.GroupBox();
			this.txtSettingsNumberOfPings = new System.Windows.Forms.TextBox();
			this.lblSettingsNumberOfPings = new System.Windows.Forms.Label();
			this.txtSettingsAddress = new System.Windows.Forms.TextBox();
			this.lblSettingsAddress = new System.Windows.Forms.Label();
			this.gbxRealTime = new System.Windows.Forms.GroupBox();
			this.lblRealTimePingStatus = new System.Windows.Forms.Label();
			this.txtRealTimePingStatus = new System.Windows.Forms.TextBox();
			this.lblRealTimePingTime = new System.Windows.Forms.Label();
			this.txtRealTimePingTime = new System.Windows.Forms.TextBox();
			this.gbxPingResults = new System.Windows.Forms.GroupBox();
			this.txtSuccessfulPings = new System.Windows.Forms.TextBox();
			this.bsPingReplyStats = new System.Windows.Forms.BindingSource(this.components);
			this.txtAverageRoundTripTime = new System.Windows.Forms.TextBox();
			this.lblUnsuccesfulPingPercentage = new System.Windows.Forms.Label();
			this.lblReplyAverageRoundTripTime = new System.Windows.Forms.Label();
			this.dgvPingReplies = new System.Windows.Forms.DataGridView();
			this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.roundTripTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bsPingReplies = new System.Windows.Forms.BindingSource(this.components);
			this.btnSaveResults = new System.Windows.Forms.Button();
			this.msMenu = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.resetSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.startTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.stopTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gbxPingSettings.SuspendLayout();
			this.gbxPingSettingsOptional.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bsCriteria)).BeginInit();
			this.gbxPingSettingsRequired.SuspendLayout();
			this.gbxRealTime.SuspendLayout();
			this.gbxPingResults.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bsPingReplyStats)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvPingReplies)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsPingReplies)).BeginInit();
			this.msMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbxPingSettings
			// 
			this.gbxPingSettings.Controls.Add(this.btnSettingsTest);
			this.gbxPingSettings.Controls.Add(this.btnSettingsReset);
			this.gbxPingSettings.Controls.Add(this.btnSettingsStart);
			this.gbxPingSettings.Controls.Add(this.btnSettingsStop);
			this.gbxPingSettings.Controls.Add(this.pbPingProgress);
			this.gbxPingSettings.Controls.Add(this.gbxPingSettingsOptional);
			this.gbxPingSettings.Controls.Add(this.gbxPingSettingsRequired);
			this.gbxPingSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbxPingSettings.Location = new System.Drawing.Point(13, 27);
			this.gbxPingSettings.Name = "gbxPingSettings";
			this.gbxPingSettings.Size = new System.Drawing.Size(560, 240);
			this.gbxPingSettings.TabIndex = 0;
			this.gbxPingSettings.TabStop = false;
			this.gbxPingSettings.Text = "Ping Settings";
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
			// btnSettingsReset
			// 
			this.btnSettingsReset.Location = new System.Drawing.Point(93, 205);
			this.btnSettingsReset.Name = "btnSettingsReset";
			this.btnSettingsReset.Size = new System.Drawing.Size(75, 23);
			this.btnSettingsReset.TabIndex = 5;
			this.btnSettingsReset.Text = "Reset";
			this.btnSettingsReset.UseVisualStyleBackColor = true;
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
			// btnSettingsStop
			// 
			this.btnSettingsStop.Location = new System.Drawing.Point(474, 204);
			this.btnSettingsStop.Name = "btnSettingsStop";
			this.btnSettingsStop.Size = new System.Drawing.Size(75, 23);
			this.btnSettingsStop.TabIndex = 3;
			this.btnSettingsStop.Text = "Stop";
			this.btnSettingsStop.UseVisualStyleBackColor = true;
			// 
			// pbPingProgress
			// 
			this.pbPingProgress.Location = new System.Drawing.Point(304, 204);
			this.pbPingProgress.Name = "pbPingProgress";
			this.pbPingProgress.Size = new System.Drawing.Size(164, 23);
			this.pbPingProgress.TabIndex = 2;
			// 
			// gbxPingSettingsOptional
			// 
			this.gbxPingSettingsOptional.Controls.Add(this.txtSettingsTTL);
			this.gbxPingSettingsOptional.Controls.Add(this.txtSettingsTimeOut);
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
			// txtSettingsTTL
			// 
			this.txtSettingsTTL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCriteria, "TimeToLive", true));
			this.txtSettingsTTL.Location = new System.Drawing.Point(358, 49);
			this.txtSettingsTTL.Name = "txtSettingsTTL";
			this.txtSettingsTTL.Size = new System.Drawing.Size(100, 20);
			this.txtSettingsTTL.TabIndex = 7;
			// 
			// txtSettingsTimeOut
			// 
			this.txtSettingsTimeOut.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCriteria, "TimeOut", true));
			this.txtSettingsTimeOut.Location = new System.Drawing.Point(358, 19);
			this.txtSettingsTimeOut.Name = "txtSettingsTimeOut";
			this.txtSettingsTimeOut.Size = new System.Drawing.Size(100, 20);
			this.txtSettingsTimeOut.TabIndex = 6;
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
			// chkSettingsDontFragment
			// 
			this.chkSettingsDontFragment.AutoSize = true;
			this.chkSettingsDontFragment.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsCriteria, "DontFragment", true));
			this.chkSettingsDontFragment.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkSettingsDontFragment.Location = new System.Drawing.Point(95, 53);
			this.chkSettingsDontFragment.Name = "chkSettingsDontFragment";
			this.chkSettingsDontFragment.Size = new System.Drawing.Size(98, 17);
			this.chkSettingsDontFragment.TabIndex = 4;
			this.chkSettingsDontFragment.Text = "(Typically False)";
			this.chkSettingsDontFragment.UseVisualStyleBackColor = true;
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
			// lblSettingsTimeOut
			// 
			this.lblSettingsTimeOut.AutoSize = true;
			this.lblSettingsTimeOut.Location = new System.Drawing.Point(276, 20);
			this.lblSettingsTimeOut.Name = "lblSettingsTimeOut";
			this.lblSettingsTimeOut.Size = new System.Drawing.Size(75, 13);
			this.lblSettingsTimeOut.TabIndex = 2;
			this.lblSettingsTimeOut.Text = "Time Out (ms):";
			// 
			// txtSettingsBufferString
			// 
			this.txtSettingsBufferString.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCriteria, "Buffer", true));
			this.txtSettingsBufferString.Location = new System.Drawing.Point(79, 20);
			this.txtSettingsBufferString.Name = "txtSettingsBufferString";
			this.txtSettingsBufferString.Size = new System.Drawing.Size(187, 20);
			this.txtSettingsBufferString.TabIndex = 1;
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
			// txtSettingsNumberOfPings
			// 
			this.txtSettingsNumberOfPings.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCriteria, "NumberOfPings", true));
			this.txtSettingsNumberOfPings.Location = new System.Drawing.Point(405, 19);
			this.txtSettingsNumberOfPings.Name = "txtSettingsNumberOfPings";
			this.txtSettingsNumberOfPings.Size = new System.Drawing.Size(100, 20);
			this.txtSettingsNumberOfPings.TabIndex = 3;
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
			// txtSettingsAddress
			// 
			this.txtSettingsAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCriteria, "Address", true));
			this.txtSettingsAddress.Location = new System.Drawing.Point(59, 20);
			this.txtSettingsAddress.Name = "txtSettingsAddress";
			this.txtSettingsAddress.Size = new System.Drawing.Size(207, 20);
			this.txtSettingsAddress.TabIndex = 1;
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
			// gbxRealTime
			// 
			this.gbxRealTime.Controls.Add(this.lblRealTimePingStatus);
			this.gbxRealTime.Controls.Add(this.txtRealTimePingStatus);
			this.gbxRealTime.Controls.Add(this.lblRealTimePingTime);
			this.gbxRealTime.Controls.Add(this.txtRealTimePingTime);
			this.gbxRealTime.Location = new System.Drawing.Point(13, 274);
			this.gbxRealTime.Name = "gbxRealTime";
			this.gbxRealTime.Size = new System.Drawing.Size(263, 77);
			this.gbxRealTime.TabIndex = 1;
			this.gbxRealTime.TabStop = false;
			this.gbxRealTime.Text = "Real Time Stats";
			// 
			// lblRealTimePingStatus
			// 
			this.lblRealTimePingStatus.AutoSize = true;
			this.lblRealTimePingStatus.Location = new System.Drawing.Point(109, 20);
			this.lblRealTimePingStatus.Name = "lblRealTimePingStatus";
			this.lblRealTimePingStatus.Size = new System.Drawing.Size(74, 13);
			this.lblRealTimePingStatus.TabIndex = 3;
			this.lblRealTimePingStatus.Text = "Current Status";
			// 
			// txtRealTimePingStatus
			// 
			this.txtRealTimePingStatus.BackColor = System.Drawing.SystemColors.MenuText;
			this.txtRealTimePingStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRealTimePingStatus.ForeColor = System.Drawing.Color.Lime;
			this.txtRealTimePingStatus.Location = new System.Drawing.Point(112, 39);
			this.txtRealTimePingStatus.Name = "txtRealTimePingStatus";
			this.txtRealTimePingStatus.Size = new System.Drawing.Size(141, 32);
			this.txtRealTimePingStatus.TabIndex = 2;
			this.txtRealTimePingStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lblRealTimePingTime
			// 
			this.lblRealTimePingTime.AutoSize = true;
			this.lblRealTimePingTime.Location = new System.Drawing.Point(7, 20);
			this.lblRealTimePingTime.Name = "lblRealTimePingTime";
			this.lblRealTimePingTime.Size = new System.Drawing.Size(65, 13);
			this.lblRealTimePingTime.TabIndex = 1;
			this.lblRealTimePingTime.Text = "Current Ping";
			// 
			// txtRealTimePingTime
			// 
			this.txtRealTimePingTime.BackColor = System.Drawing.SystemColors.MenuText;
			this.txtRealTimePingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRealTimePingTime.ForeColor = System.Drawing.Color.Lime;
			this.txtRealTimePingTime.Location = new System.Drawing.Point(6, 39);
			this.txtRealTimePingTime.Name = "txtRealTimePingTime";
			this.txtRealTimePingTime.Size = new System.Drawing.Size(100, 32);
			this.txtRealTimePingTime.TabIndex = 0;
			this.txtRealTimePingTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// gbxPingResults
			// 
			this.gbxPingResults.Controls.Add(this.btnSaveResults);
			this.gbxPingResults.Controls.Add(this.txtSuccessfulPings);
			this.gbxPingResults.Controls.Add(this.txtAverageRoundTripTime);
			this.gbxPingResults.Controls.Add(this.lblUnsuccesfulPingPercentage);
			this.gbxPingResults.Controls.Add(this.lblReplyAverageRoundTripTime);
			this.gbxPingResults.Controls.Add(this.dgvPingReplies);
			this.gbxPingResults.Location = new System.Drawing.Point(13, 357);
			this.gbxPingResults.Name = "gbxPingResults";
			this.gbxPingResults.Size = new System.Drawing.Size(395, 173);
			this.gbxPingResults.TabIndex = 2;
			this.gbxPingResults.TabStop = false;
			this.gbxPingResults.Text = "Results";
			// 
			// txtSuccessfulPings
			// 
			this.txtSuccessfulPings.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPingReplyStats, "SuccessfulPings", true));
			this.txtSuccessfulPings.Location = new System.Drawing.Point(262, 83);
			this.txtSuccessfulPings.Name = "txtSuccessfulPings";
			this.txtSuccessfulPings.Size = new System.Drawing.Size(69, 20);
			this.txtSuccessfulPings.TabIndex = 7;
			// 
			// txtAverageRoundTripTime
			// 
			this.txtAverageRoundTripTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPingReplyStats, "AverageRoundTripTime", true));
			this.txtAverageRoundTripTime.Location = new System.Drawing.Point(262, 36);
			this.txtAverageRoundTripTime.Name = "txtAverageRoundTripTime";
			this.txtAverageRoundTripTime.Size = new System.Drawing.Size(69, 20);
			this.txtAverageRoundTripTime.TabIndex = 6;
			// 
			// lblUnsuccesfulPingPercentage
			// 
			this.lblUnsuccesfulPingPercentage.AutoSize = true;
			this.lblUnsuccesfulPingPercentage.Location = new System.Drawing.Point(259, 67);
			this.lblUnsuccesfulPingPercentage.Name = "lblUnsuccesfulPingPercentage";
			this.lblUnsuccesfulPingPercentage.Size = new System.Drawing.Size(83, 13);
			this.lblUnsuccesfulPingPercentage.TabIndex = 5;
			this.lblUnsuccesfulPingPercentage.Text = "Succesful Pings";
			// 
			// lblReplyAverageRoundTripTime
			// 
			this.lblReplyAverageRoundTripTime.AutoSize = true;
			this.lblReplyAverageRoundTripTime.Location = new System.Drawing.Point(259, 19);
			this.lblReplyAverageRoundTripTime.Name = "lblReplyAverageRoundTripTime";
			this.lblReplyAverageRoundTripTime.Size = new System.Drawing.Size(129, 13);
			this.lblReplyAverageRoundTripTime.TabIndex = 4;
			this.lblReplyAverageRoundTripTime.Text = "Average Round Trip Time";
			// 
			// dgvPingReplies
			// 
			this.dgvPingReplies.AllowUserToAddRows = false;
			this.dgvPingReplies.AllowUserToDeleteRows = false;
			this.dgvPingReplies.AutoGenerateColumns = false;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvPingReplies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvPingReplies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPingReplies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.statusDataGridViewTextBoxColumn,
            this.roundTripTimeDataGridViewTextBoxColumn});
			this.dgvPingReplies.DataSource = this.bsPingReplies;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvPingReplies.DefaultCellStyle = dataGridViewCellStyle5;
			this.dgvPingReplies.Location = new System.Drawing.Point(6, 19);
			this.dgvPingReplies.Name = "dgvPingReplies";
			this.dgvPingReplies.ReadOnly = true;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvPingReplies.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dgvPingReplies.Size = new System.Drawing.Size(247, 150);
			this.dgvPingReplies.TabIndex = 3;
			// 
			// statusDataGridViewTextBoxColumn
			// 
			this.statusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
			this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
			this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
			this.statusDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// roundTripTimeDataGridViewTextBoxColumn
			// 
			this.roundTripTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.roundTripTimeDataGridViewTextBoxColumn.DataPropertyName = "RoundTripTime";
			this.roundTripTimeDataGridViewTextBoxColumn.HeaderText = "Round Trip Time";
			this.roundTripTimeDataGridViewTextBoxColumn.Name = "roundTripTimeDataGridViewTextBoxColumn";
			this.roundTripTimeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// bsPingReplies
			// 
			this.bsPingReplies.DataSource = typeof(PacketLoss.Domain.PingInstanceReply);
			// 
			// btnSaveResults
			// 
			this.btnSaveResults.Location = new System.Drawing.Point(262, 110);
			this.btnSaveResults.Name = "btnSaveResults";
			this.btnSaveResults.Size = new System.Drawing.Size(75, 23);
			this.btnSaveResults.TabIndex = 8;
			this.btnSaveResults.Text = "Save Results";
			this.btnSaveResults.UseVisualStyleBackColor = true;
			// 
			// msMenu
			// 
			this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.msMenu.Location = new System.Drawing.Point(0, 0);
			this.msMenu.Name = "msMenu";
			this.msMenu.Size = new System.Drawing.Size(596, 24);
			this.msMenu.TabIndex = 3;
			this.msMenu.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.resetSettingsToolStripMenuItem,
            this.startTestToolStripMenuItem,
            this.stopTestToolStripMenuItem,
            this.saveResultsToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// testToolStripMenuItem
			// 
			this.testToolStripMenuItem.Name = "testToolStripMenuItem";
			this.testToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.testToolStripMenuItem.Text = "Test Ping";
			// 
			// resetSettingsToolStripMenuItem
			// 
			this.resetSettingsToolStripMenuItem.Name = "resetSettingsToolStripMenuItem";
			this.resetSettingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.resetSettingsToolStripMenuItem.Text = "Reset Settings";
			// 
			// startTestToolStripMenuItem
			// 
			this.startTestToolStripMenuItem.Name = "startTestToolStripMenuItem";
			this.startTestToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.startTestToolStripMenuItem.Text = "Start Test";
			// 
			// stopTestToolStripMenuItem
			// 
			this.stopTestToolStripMenuItem.Name = "stopTestToolStripMenuItem";
			this.stopTestToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.stopTestToolStripMenuItem.Text = "Stop Test";
			// 
			// saveResultsToolStripMenuItem
			// 
			this.saveResultsToolStripMenuItem.Name = "saveResultsToolStripMenuItem";
			this.saveResultsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.saveResultsToolStripMenuItem.Text = "Save Results";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(596, 536);
			this.Controls.Add(this.gbxPingResults);
			this.Controls.Add(this.gbxRealTime);
			this.Controls.Add(this.gbxPingSettings);
			this.Controls.Add(this.msMenu);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MainMenuStrip = this.msMenu;
			this.Name = "MainWindow";
			this.Text = "Ping Benchmark Tool by Waldron&Granado";
			this.gbxPingSettings.ResumeLayout(false);
			this.gbxPingSettingsOptional.ResumeLayout(false);
			this.gbxPingSettingsOptional.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bsCriteria)).EndInit();
			this.gbxPingSettingsRequired.ResumeLayout(false);
			this.gbxPingSettingsRequired.PerformLayout();
			this.gbxRealTime.ResumeLayout(false);
			this.gbxRealTime.PerformLayout();
			this.gbxPingResults.ResumeLayout(false);
			this.gbxPingResults.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bsPingReplyStats)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvPingReplies)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsPingReplies)).EndInit();
			this.msMenu.ResumeLayout(false);
			this.msMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

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
		private System.Windows.Forms.Button btnSettingsStop;
		private System.Windows.Forms.ProgressBar pbPingProgress;
		private System.Windows.Forms.TextBox txtSettingsTTL;
		private System.Windows.Forms.Label lblSettingsTTL;
		private System.Windows.Forms.CheckBox chkSettingsDontFragment;
		private System.Windows.Forms.Label lblSettingsDontFragment;
		private System.Windows.Forms.Label lblSettingsTimeOut;
		private System.Windows.Forms.TextBox txtSettingsBufferString;
		private System.Windows.Forms.Label lblSettingsBufferString;
		private System.Windows.Forms.Button btnSettingsTest;
		private System.Windows.Forms.TextBox txtSettingsTimeOut;
		private System.Windows.Forms.GroupBox gbxRealTime;
		private System.Windows.Forms.GroupBox gbxPingResults;
		private System.Windows.Forms.DataGridView dgvPingReplies;
		private System.Windows.Forms.BindingSource bsPingReplies;
		private System.Windows.Forms.TextBox txtSuccessfulPings;
		private System.Windows.Forms.TextBox txtAverageRoundTripTime;
		private System.Windows.Forms.Label lblUnsuccesfulPingPercentage;
		private System.Windows.Forms.Label lblReplyAverageRoundTripTime;
		private System.Windows.Forms.BindingSource bsPingReplyStats;
		private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn roundTripTimeDataGridViewTextBoxColumn;
		private System.Windows.Forms.Label lblRealTimePingTime;
		private System.Windows.Forms.TextBox txtRealTimePingTime;
		private System.Windows.Forms.Label lblRealTimePingStatus;
		private System.Windows.Forms.TextBox txtRealTimePingStatus;
		private System.Windows.Forms.Button btnSaveResults;
		private System.Windows.Forms.MenuStrip msMenu;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem resetSettingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem startTestToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem stopTestToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveResultsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
	}
}

