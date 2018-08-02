namespace PpfChallenge002.Level2
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
            this.labelFilepath = new System.Windows.Forms.Label();
            this.textFilepath = new System.Windows.Forms.TextBox();
            this.buttonSelectPath = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelArtist = new System.Windows.Forms.Label();
            this.labelAlbum = new System.Windows.Forms.Label();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.textArtist = new System.Windows.Forms.TextBox();
            this.textAlbum = new System.Windows.Forms.TextBox();
            this.timerPlayState = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelFilepath
            // 
            this.labelFilepath.AutoSize = true;
            this.labelFilepath.Location = new System.Drawing.Point(26, 33);
            this.labelFilepath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFilepath.Name = "labelFilepath";
            this.labelFilepath.Size = new System.Drawing.Size(77, 18);
            this.labelFilepath.TabIndex = 0;
            this.labelFilepath.Text = "mp3ファイル";
            // 
            // textFilepath
            // 
            this.textFilepath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textFilepath.Location = new System.Drawing.Point(28, 55);
            this.textFilepath.Margin = new System.Windows.Forms.Padding(4);
            this.textFilepath.Name = "textFilepath";
            this.textFilepath.Size = new System.Drawing.Size(375, 24);
            this.textFilepath.TabIndex = 1;
            // 
            // buttonSelectPath
            // 
            this.buttonSelectPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectPath.Location = new System.Drawing.Point(411, 50);
            this.buttonSelectPath.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSelectPath.Name = "buttonSelectPath";
            this.buttonSelectPath.Size = new System.Drawing.Size(34, 32);
            this.buttonSelectPath.TabIndex = 2;
            this.buttonSelectPath.Text = "...";
            this.buttonSelectPath.UseVisualStyleBackColor = true;
            this.buttonSelectPath.Click += new System.EventHandler(this.buttonSelectPath_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPlay.Font = new System.Drawing.Font("Meiryo UI", 18F);
            this.buttonPlay.Image = ((System.Drawing.Image)(resources.GetObject("buttonPlay.Image")));
            this.buttonPlay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPlay.Location = new System.Drawing.Point(49, 215);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(134, 70);
            this.buttonPlay.TabIndex = 9;
            this.buttonPlay.Text = "再生";
            this.buttonPlay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStop.Font = new System.Drawing.Font("Meiryo UI", 18F);
            this.buttonStop.Image = ((System.Drawing.Image)(resources.GetObject("buttonStop.Image")));
            this.buttonStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStop.Location = new System.Drawing.Point(269, 215);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(134, 70);
            this.buttonStop.TabIndex = 10;
            this.buttonStop.Text = "停止";
            this.buttonStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(26, 96);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(49, 18);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "タイトル";
            // 
            // labelArtist
            // 
            this.labelArtist.AutoSize = true;
            this.labelArtist.Location = new System.Drawing.Point(26, 134);
            this.labelArtist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelArtist.Name = "labelArtist";
            this.labelArtist.Size = new System.Drawing.Size(70, 18);
            this.labelArtist.TabIndex = 5;
            this.labelArtist.Text = "アーティスト";
            // 
            // labelAlbum
            // 
            this.labelAlbum.AutoSize = true;
            this.labelAlbum.Location = new System.Drawing.Point(26, 173);
            this.labelAlbum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAlbum.Name = "labelAlbum";
            this.labelAlbum.Size = new System.Drawing.Size(53, 18);
            this.labelAlbum.TabIndex = 7;
            this.labelAlbum.Text = "アルバム";
            // 
            // textTitle
            // 
            this.textTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textTitle.Location = new System.Drawing.Point(109, 94);
            this.textTitle.Margin = new System.Windows.Forms.Padding(4);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(294, 24);
            this.textTitle.TabIndex = 4;
            this.textTitle.TabStop = false;
            // 
            // textArtist
            // 
            this.textArtist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textArtist.Location = new System.Drawing.Point(109, 131);
            this.textArtist.Margin = new System.Windows.Forms.Padding(4);
            this.textArtist.Name = "textArtist";
            this.textArtist.Size = new System.Drawing.Size(294, 24);
            this.textArtist.TabIndex = 6;
            this.textArtist.TabStop = false;
            // 
            // textAlbum
            // 
            this.textAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textAlbum.Location = new System.Drawing.Point(109, 170);
            this.textAlbum.Margin = new System.Windows.Forms.Padding(4);
            this.textAlbum.Name = "textAlbum";
            this.textAlbum.Size = new System.Drawing.Size(294, 24);
            this.textAlbum.TabIndex = 8;
            this.textAlbum.TabStop = false;
            // 
            // timerPlayState
            // 
            this.timerPlayState.Tick += new System.EventHandler(this.timerPlayState_Tick);
            // 
            // FormMp3Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 317);
            this.Controls.Add(this.textAlbum);
            this.Controls.Add(this.textArtist);
            this.Controls.Add(this.textTitle);
            this.Controls.Add(this.labelAlbum);
            this.Controls.Add(this.labelArtist);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonSelectPath);
            this.Controls.Add(this.textFilepath);
            this.Controls.Add(this.labelFilepath);
            this.Font = new System.Drawing.Font("Meiryo UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(490, 270);
            this.Name = "FormMp3Player";
            this.Text = "mp3プレーヤー";
            this.Load += new System.EventHandler(this.FormMp3Player_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFilepath;
        private System.Windows.Forms.TextBox textFilepath;
        private System.Windows.Forms.Button buttonSelectPath;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelArtist;
        private System.Windows.Forms.Label labelAlbum;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.TextBox textArtist;
        private System.Windows.Forms.TextBox textAlbum;
        private System.Windows.Forms.Timer timerPlayState;
    }
}

