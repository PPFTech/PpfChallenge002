namespace PpfChallenge002.Level3
{
    partial class FormMp3Player
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMp3Player));
            this.labelPlaylist = new System.Windows.Forms.Label();
            this.buttonSelectList = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelArtist = new System.Windows.Forms.Label();
            this.labelAlbum = new System.Windows.Forms.Label();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.textArtist = new System.Windows.Forms.TextBox();
            this.textAlbum = new System.Windows.Forms.TextBox();
            this.timerPlayState = new System.Windows.Forms.Timer(this.components);
            this.listPlaylist = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.trackTime = new System.Windows.Forms.TrackBar();
            this.labelTrackTime = new System.Windows.Forms.Label();
            this.panelPlayer = new System.Windows.Forms.Panel();
            this.toolPlayer = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackTime)).BeginInit();
            this.panelPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPlaylist
            // 
            this.labelPlaylist.AutoSize = true;
            this.labelPlaylist.BackColor = System.Drawing.Color.Transparent;
            this.labelPlaylist.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelPlaylist.Location = new System.Drawing.Point(26, 18);
            this.labelPlaylist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlaylist.Name = "labelPlaylist";
            this.labelPlaylist.Size = new System.Drawing.Size(65, 18);
            this.labelPlaylist.TabIndex = 0;
            this.labelPlaylist.Text = "再生リスト";
            // 
            // buttonSelectList
            // 
            this.buttonSelectList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectList.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonSelectList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSelectList.BackgroundImage")));
            this.buttonSelectList.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.buttonSelectList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectList.ForeColor = System.Drawing.Color.DarkCyan;
            this.buttonSelectList.Location = new System.Drawing.Point(177, 12);
            this.buttonSelectList.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSelectList.Name = "buttonSelectList";
            this.buttonSelectList.Size = new System.Drawing.Size(33, 28);
            this.buttonSelectList.TabIndex = 2;
            this.buttonSelectList.Text = "...";
            this.buttonSelectList.UseVisualStyleBackColor = false;
            this.buttonSelectList.Click += new System.EventHandler(this.buttonSelectList_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.Transparent;
            this.buttonPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonPlay.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.buttonPlay.FlatAppearance.BorderSize = 0;
            this.buttonPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Font = new System.Drawing.Font("Meiryo UI", 18F);
            this.buttonPlay.ForeColor = System.Drawing.Color.DarkCyan;
            this.buttonPlay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPlay.Location = new System.Drawing.Point(79, 8);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(50, 58);
            this.buttonPlay.TabIndex = 10;
            this.buttonPlay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolPlayer.SetToolTip(this.buttonPlay, "再生");
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.Transparent;
            this.buttonStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStop.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.buttonStop.FlatAppearance.BorderSize = 0;
            this.buttonStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.Font = new System.Drawing.Font("Meiryo UI", 18F);
            this.buttonStop.ForeColor = System.Drawing.Color.DarkCyan;
            this.buttonStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStop.Location = new System.Drawing.Point(163, 8);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(56, 58);
            this.buttonStop.TabIndex = 11;
            this.buttonStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolPlayer.SetToolTip(this.buttonStop, "停止");
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelTitle.Location = new System.Drawing.Point(237, 48);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(49, 18);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "タイトル";
            // 
            // labelArtist
            // 
            this.labelArtist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelArtist.AutoSize = true;
            this.labelArtist.BackColor = System.Drawing.Color.Transparent;
            this.labelArtist.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelArtist.Location = new System.Drawing.Point(237, 91);
            this.labelArtist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelArtist.Name = "labelArtist";
            this.labelArtist.Size = new System.Drawing.Size(70, 18);
            this.labelArtist.TabIndex = 5;
            this.labelArtist.Text = "アーティスト";
            // 
            // labelAlbum
            // 
            this.labelAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAlbum.AutoSize = true;
            this.labelAlbum.BackColor = System.Drawing.Color.Transparent;
            this.labelAlbum.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelAlbum.Location = new System.Drawing.Point(237, 134);
            this.labelAlbum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAlbum.Name = "labelAlbum";
            this.labelAlbum.Size = new System.Drawing.Size(53, 18);
            this.labelAlbum.TabIndex = 7;
            this.labelAlbum.Text = "アルバム";
            // 
            // textTitle
            // 
            this.textTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textTitle.ForeColor = System.Drawing.Color.DarkCyan;
            this.textTitle.Location = new System.Drawing.Point(323, 45);
            this.textTitle.Margin = new System.Windows.Forms.Padding(4);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(206, 24);
            this.textTitle.TabIndex = 4;
            this.textTitle.TabStop = false;
            // 
            // textArtist
            // 
            this.textArtist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textArtist.ForeColor = System.Drawing.Color.DarkCyan;
            this.textArtist.Location = new System.Drawing.Point(323, 88);
            this.textArtist.Margin = new System.Windows.Forms.Padding(4);
            this.textArtist.Name = "textArtist";
            this.textArtist.Size = new System.Drawing.Size(206, 24);
            this.textArtist.TabIndex = 6;
            this.textArtist.TabStop = false;
            // 
            // textAlbum
            // 
            this.textAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textAlbum.ForeColor = System.Drawing.Color.DarkCyan;
            this.textAlbum.Location = new System.Drawing.Point(323, 131);
            this.textAlbum.Margin = new System.Windows.Forms.Padding(4);
            this.textAlbum.Name = "textAlbum";
            this.textAlbum.Size = new System.Drawing.Size(206, 24);
            this.textAlbum.TabIndex = 8;
            this.textAlbum.TabStop = false;
            // 
            // timerPlayState
            // 
            this.timerPlayState.Tick += new System.EventHandler(this.timerPlayState_Tick);
            // 
            // listPlaylist
            // 
            this.listPlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listPlaylist.ForeColor = System.Drawing.Color.DarkCyan;
            this.listPlaylist.FormattingEnabled = true;
            this.listPlaylist.ItemHeight = 17;
            this.listPlaylist.Location = new System.Drawing.Point(29, 45);
            this.listPlaylist.Name = "listPlaylist";
            this.listPlaylist.Size = new System.Drawing.Size(181, 259);
            this.listPlaylist.TabIndex = 1;
            this.listPlaylist.SelectedIndexChanged += new System.EventHandler(this.listPlaylist_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("statusStrip1.BackgroundImage")));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 314);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(566, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusMessage
            // 
            this.toolStripStatusMessage.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.toolStripStatusMessage.Name = "toolStripStatusMessage";
            this.toolStripStatusMessage.Size = new System.Drawing.Size(551, 17);
            this.toolStripStatusMessage.Spring = true;
            this.toolStripStatusMessage.Text = "Message";
            this.toolStripStatusMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trackTime
            // 
            this.trackTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackTime.AutoSize = false;
            this.trackTime.BackColor = System.Drawing.Color.PowderBlue;
            this.trackTime.Location = new System.Drawing.Point(240, 178);
            this.trackTime.Maximum = 100;
            this.trackTime.Name = "trackTime";
            this.trackTime.Size = new System.Drawing.Size(289, 26);
            this.trackTime.TabIndex = 9;
            this.trackTime.TickFrequency = 0;
            this.trackTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackTime_MouseDown);
            this.trackTime.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackTime_MouseUp);
            // 
            // labelTrackTime
            // 
            this.labelTrackTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTrackTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTrackTime.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelTrackTime.Location = new System.Drawing.Point(252, 199);
            this.labelTrackTime.Name = "labelTrackTime";
            this.labelTrackTime.Size = new System.Drawing.Size(277, 18);
            this.labelTrackTime.TabIndex = 13;
            this.labelTrackTime.Text = "0:00:00 / 0:00:00";
            this.labelTrackTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelPlayer
            // 
            this.panelPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPlayer.BackColor = System.Drawing.Color.Transparent;
            this.panelPlayer.BackgroundImage = global::PpfChallenge002.Level3.Properties.Resources.panel_pause;
            this.panelPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelPlayer.Controls.Add(this.buttonPlay);
            this.panelPlayer.Controls.Add(this.buttonStop);
            this.panelPlayer.Location = new System.Drawing.Point(240, 227);
            this.panelPlayer.Name = "panelPlayer";
            this.panelPlayer.Size = new System.Drawing.Size(289, 77);
            this.panelPlayer.TabIndex = 14;
            // 
            // FormMp3Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(566, 336);
            this.Controls.Add(this.panelPlayer);
            this.Controls.Add(this.labelTrackTime);
            this.Controls.Add(this.trackTime);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listPlaylist);
            this.Controls.Add(this.textAlbum);
            this.Controls.Add(this.textArtist);
            this.Controls.Add(this.textTitle);
            this.Controls.Add(this.labelAlbum);
            this.Controls.Add(this.labelArtist);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonSelectList);
            this.Controls.Add(this.labelPlaylist);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Meiryo UI", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(580, 315);
            this.Name = "FormMp3Player";
            this.Opacity = 0.95D;
            this.Text = "mp3プレーヤー";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMp3Player_FormClosing);
            this.Load += new System.EventHandler(this.FormMp3Player_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackTime)).EndInit();
            this.panelPlayer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPlaylist;
        private System.Windows.Forms.Button buttonSelectList;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelArtist;
        private System.Windows.Forms.Label labelAlbum;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.TextBox textArtist;
        private System.Windows.Forms.TextBox textAlbum;
        private System.Windows.Forms.Timer timerPlayState;
        private System.Windows.Forms.ListBox listPlaylist;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusMessage;
        private System.Windows.Forms.TrackBar trackTime;
        private System.Windows.Forms.Label labelTrackTime;
        private System.Windows.Forms.Panel panelPlayer;
        private System.Windows.Forms.ToolTip toolPlayer;
    }
}

