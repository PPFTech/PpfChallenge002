using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shell32;      // Windows Shell32 ライブラリ
using WMPLib;       // Windows Media Player ライブラリ

namespace PpfChallenge002.Level2
{
    public partial class FormMp3Player : Form
    {
        // トラックファイル情報
        private string TrackFilePath = "";

        // トラック情報
        private string TrackTitle = "";
        private string TrackArtist = "";
        private string TrackAlbum = "";

        // プレーヤー
        WindowsMediaPlayer Player = new WindowsMediaPlayer();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FormMp3Player()
        {
            InitializeComponent();
        }

        #region "イベント"
        /// <summary>
        /// フォームロード
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMp3Player_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        /// <summary>
        /// [...]ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSelectPath_Click(object sender, EventArgs e)
        {
            // ファイル選択
            TrackFilePath = SelectMp3File(textFilepath.Text);

            // 選択されたファイル情報を画面に反映
            if (TrackFilePath != "")
            {
                // ファイルパス
                textFilepath.Text = TrackFilePath;

                // トラック情報の取得
                GetTrackInfo();

                // トラック情報の表示
                textTitle.Text = TrackTitle;
                textArtist.Text = TrackArtist;
                textAlbum.Text = TrackAlbum;
            }
        }

        /// <summary>
        /// [再生]ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            // サウンド再生
            if (TrackFilePath != "")
                PlaySound(TrackFilePath);
        }

        /// <summary>
        /// [停止]ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStop_Click(object sender, EventArgs e)
        {
            // サウンド停止
            StopSound();
        }

        /// <summary>
        /// 再生ステータス監視タイマー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerPlayState_Tick(object sender, EventArgs e)
        {
            // 再生ステータスが停止状態になったら
            if (Player.playState == WMPPlayState.wmppsStopped)
            {
                // コントロールを停止状態に戻す
                EnableControls(false);
                // タイマー停止
                timerPlayState.Enabled = false;
            }
        }
        #endregion

        #region "メソッド"
        /// <summary>
        /// フォーム初期化
        /// </summary>
        private void InitForm()
        {
            // ファイルパス
            textFilepath.Text = "";
            // コントロールの状態
            EnableControls(false);
            // 再生ステータス監視タイマー初期化
            timerPlayState.Interval = 200;  // 200msec
            timerPlayState.Enabled = false;
        }

        /// <summary>
        /// コントロール状態の設定
        /// </summary>
        /// <param name="playing">再生状態</param>
        private void EnableControls(bool playing)
        {
            // トラック情報

            // 再生/停止
            buttonPlay.Enabled = !playing;  // 停止中のみ有効
            buttonStop.Enabled = playing;   // 再生中のみ有効
        }

        /// <summary>
        /// ファイル選択
        /// </summary>
        /// <param name="initfile">初期選択ファイルパス</param>
        /// <returns>選択されたファイルのパス</returns>
        private string SelectMp3File(string initfile)
        {
            string selectedfile = "";

            // ファイル選択ダイアログ設定
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "mp3ファイル(*.mp3)|*.mp3";
            dlg.AddExtension = true;
            dlg.CheckFileExists = true;
            dlg.FileName = initfile;

            // ダイアログ表示
            DialogResult dr = dlg.ShowDialog(this);

            // OK時、選択されたファイルへのパスを取得
            if (dr == DialogResult.OK)
                selectedfile = dlg.FileName;

            // 破棄
            dlg.Dispose();

            return selectedfile;
        }

        /// <summary>
        /// トラック情報の取得
        /// </summary>
        private void GetTrackInfo()
        {
            // トラック情報の初期化
            TrackTitle = "";
            TrackArtist = "";
            TrackAlbum = "";

            // ファイルプロパティ(ID3タグ情報)の取得
            string dir = System.IO.Directory.GetParent(TrackFilePath).ToString();
            string file = System.IO.Path.GetFileName(TrackFilePath);

            ShellClass shell = new ShellClass();
            Folder f = shell.NameSpace(dir);
            FolderItem item = f.ParseName(file);

            //// ID3情報の格納位置確認 (※出力ウィンドウに表示されます)
            //      for (int i = 0; i < 100; i++)
            //{
            //    string msg = string.Format("[{0}] {1}", i, f.GetDetailsOf(item, i));
            //    System.Diagnostics.Debug.WriteLine(msg);
            //}

            TrackTitle = f.GetDetailsOf(item, 21);      // タイトル
            TrackArtist = f.GetDetailsOf(item, 13);     // アーティスト
            TrackAlbum = f.GetDetailsOf(item, 14);      // アルバム

        }

        /// <summary>
        /// サウンド再生
        /// </summary>
        /// <param name="filepath">ファイルパス</param>
        private void PlaySound(string filepath)
        {
            // オーディオファイルの指定
            Player.URL = filepath;
            // 再生
            Player.controls.play();
            // コントロール制御
            EnableControls(true);
            // 監視タイマー起動
            timerPlayState.Enabled = true;
        }

        /// <summary>
        /// サウンド停止
        /// </summary>
        /// <param name="filepath"></param>
        private void StopSound()
        {
            // 停止
            Player.controls.stop();
            // オーディオファイル情報のクリア
            Player.URL = "";
            // コントロール制御
            EnableControls(false);
        }
        #endregion

    }

}
