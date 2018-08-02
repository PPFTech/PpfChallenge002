using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PpfChallenge002;

namespace PpfChallenge002.Level3
{
    public partial class FormMp3Player : Form
    {
        /// <summary>
        /// 再生リスト(フルパス)
        /// </summary>
        private List<string> TrackFilePathList;

        /// <summary>
        /// 再生リスト(タイトル)
        /// </summary>
        private List<string> TrackTitleList;        

        /// <summary>
        /// 現在のトラックIndex
        /// </summary>
        private int CurrentTrackIndex = -1;

        /// <summary>
        ///  プレーヤー
        /// </summary>
        private Mp3Player Player = new Mp3Player();

        /// <summary>
        /// トラック情報
        /// </summary>
        private TrackInfo Track = new TrackInfo();

        /// <summary>
        /// 再生中止フラグ
        /// </summary>
        private bool AbortFlag = false;

        /// <summary>
        /// トラック長
        /// </summary>
        private TimeSpan TrackTotal;

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
        /// フォームクローズ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMp3Player_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 再生中の場合もあるので、念のため停止しておく
            AbortFlag = true;
            Player.Stop();
        }

        /// <summary>
        /// [...]ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSelectList_Click(object sender, EventArgs e)
        {
            // 再生リスト選択(フルパス)
            TrackFilePathList = SelectMp3Files();
            CurrentTrackIndex = -1;

            // 選択されたファイル情報を画面に反映
            if (TrackFilePathList.Count > 0)
            {
                // 再生リストのタイトルのみ抽出
                TrackTitleList = GetTrackTitles(TrackFilePathList);

                // 再生リスト
                listPlaylist.Items.Clear();
                listPlaylist.Items.AddRange(TrackTitleList.ToArray());
                CurrentTrackIndex = 0;

                // トラック情報の表示
                DispTrackInfo();
            }
        }

        /// <summary>
        /// 再生リストの選択変更時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            // リスト選択情報の取得
            ListBox list = (ListBox)sender;
            int idx = list.SelectedIndex;

            // 項目が選択されていなければ、そのまま抜ける
            if (idx < 0)
                return;

            // 選択情報の反映
            CurrentTrackIndex = idx;
            DispTrackInfo();
        }

        /// <summary>
        /// [再生]ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            // トラックが未選択ならばすぐに抜ける
            if (CurrentTrackIndex < 0)
            {
                MessageBox.Show("曲を選択してください。", "再生リスト未選択", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // サウンド再生
            int startIdx = CurrentTrackIndex;
            int stopIdx = TrackFilePathList.Count - 1;
            for (int i = startIdx; i <= stopIdx; i++)
            { 
                string trackfile = TrackFilePathList[i];
                if (trackfile != "")
                {
                    // リストから現在のインデックスを選択
                    listPlaylist.SelectedIndex = i;
                    // サウンド再生
                    PlaySound(trackfile);
                    // 完了待ち
                    WaitTrackLast();
                }

                // 再生中止したら、ここで抜ける
                if (AbortFlag)
                    break;
            }

            // 通常通り再生終了したら、インデックスを元に戻しておく。
            if (!AbortFlag)
                listPlaylist.SelectedIndex = 0;

            // 背景変更
            panelPlayer.BackgroundImage = Properties.Resources.panel_pause;

            // フラグも元に戻しておく。
            AbortFlag = false;
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

            // 停止フラグ
            AbortFlag = true;
        }

        /// <summary>
        /// 再生ステータス監視タイマー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerPlayState_Tick(object sender, EventArgs e)
        {
            // タグ情報が入っている間は、処理をスキップする
            if (timerPlayState.Tag != null)
                return;

            // 経過時刻表示
            TimeSpan ts = new TimeSpan(0, 0, (int)Player.Position); // sec
            DisplayTime(ts, TrackTotal);

            // 再生ステータスが停止状態になったら
            if (Player.State == Mp3Player.StateInfo.Stop)
            {
                // コントロールを停止状態に戻す
                EnableControls(false);
                // タイマー停止
                timerPlayState.Enabled = false;
            }
        }

        /// <summary>
        /// トラック経過時間表示マウスダウンイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackTime_MouseDown(object sender, MouseEventArgs e)
        {
            // 再生情報表示タイマーにPause情報を入れる
            timerPlayState.Tag = "Pause";
        }

        /// <summary>
        /// トラック経過時間表示マウスアップイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackTime_MouseUp(object sender, MouseEventArgs e)
        {
            // 現在の経過時間を取得
            double pos = trackTime.Value;
            // プレイヤーに時間を設定
            Player.Position = pos;
            // タグ情報を空に戻す
            timerPlayState.Tag = null;
        }
        #endregion

        #region "メソッド"
        /// <summary>
        /// フォーム初期化
        /// </summary>
        private void InitForm()
        {
            // 再生リスト
            listPlaylist.Items.Clear();
            // コントロールの状態
            EnableControls(false);
            // 再生ステータス監視タイマー初期化
            timerPlayState.Interval = 200;  // 200msec
            timerPlayState.Enabled = false;
            // メッセージクリア
            DisplayMessage("");
            DisplayTime(TimeSpan.Zero, TimeSpan.Zero);
        }

        /// <summary>
        /// コントロール状態の設定
        /// </summary>
        /// <param name="playing">再生状態</param>
        private void EnableControls(bool playing)
        {
            // 再生リスト
            listPlaylist.Enabled = !playing;    // 停止中のみ有効

            // 再生/停止
            buttonPlay.Enabled = !playing;      // 停止中のみ有効
            buttonStop.Enabled = playing;       // 再生中のみ有効
        }

        /// <summary>
        /// メッセージ表示
        /// </summary>
        /// <param name="msg">メッセージ表示</param>
        private void DisplayMessage(string msg)
        {
            toolStripStatusMessage.Text = msg;
        }

        /// <summary>
        /// 時間表示
        /// </summary>
        /// <param name="offset">経過時間</param>
        private void DisplayTime(TimeSpan offset, TimeSpan total)
        {
            trackTime.Value = (int)offset.TotalSeconds;
            labelTrackTime.Text = offset.ToString(@"hh\:mm\:ss") + "/" +
                                  total.ToString(@"hh\:mm\:ss");
        }
        
        /// <summary>
        /// ファイル複数選択
        /// </summary>
        /// <param name="initfile">初期選択ファイルパス</param>
        /// <returns>選択されたファイルのパス</returns>
        private List<string> SelectMp3Files()
        {
            List<string> selectedfiles = new List<string>();

            // ファイル選択ダイアログ設定
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "mp3ファイル(*.mp3)|*.mp3";
            dlg.AddExtension = true;
            dlg.CheckFileExists = true;
            dlg.Multiselect = true;
            //dlg.FileName = initfile;

            // ダイアログ表示
            DialogResult dr = dlg.ShowDialog(this);

            // OK時、選択されたファイルへのパスを取得
            if (dr == DialogResult.OK)
                selectedfiles = dlg.FileNames.ToList();

            // 破棄
            dlg.Dispose();

            return selectedfiles;
        }

        /// <summary>
        /// タイトル配列の抽出
        /// </summary>
        /// <param name="filepaths">ファイルパスリスト</param>
        /// <returns></returns>
        private List<string> GetTrackTitles(List<string> filepaths)
        {
            List<string> titles = new List<string>();

            // ファイルパス配列の要素がなければ、すぐに抜ける
            if (filepaths == null)
                return titles;

            // 念のため、要素数でもチェック
            if (filepaths.Count <= 0)
                return titles;

            // 要素があれば、タイトルを抽出した配列を作成
            titles.Clear();
            foreach(string trackfile in TrackFilePathList)
            {
                // トラック情報の取得
                Track.GetTrackInfo(trackfile);

                // タイトル
                titles.Add( Track.Title);     
            }

            return titles;
        }

        /// <summary>
        /// トラック情報の表示
        /// </summary>
        private void DispTrackInfo()
        {
            // インデックスが負の値なら、すぐに抜ける
            if (CurrentTrackIndex < 0)
                return;

            // トラック情報の取得
            string trackfile = TrackFilePathList[CurrentTrackIndex];
            Track.GetTrackInfo(trackfile);

            // トラック情報の表示
            textTitle.Text = Track.Title;
            textArtist.Text = Track.Artist;
            textAlbum.Text = Track.Album;

            // トラック時間の初期表示
            TrackTotal = TimeSpan.Parse(Track.Time);
            trackTime.Maximum = (int)TrackTotal.TotalSeconds;
            DisplayTime(TimeSpan.Zero, TrackTotal);
            Application.DoEvents();
        }

        /// <summary>
        /// サウンド再生
        /// </summary>
        /// <param name="filepath">ファイルパス</param>
        private void PlaySound(string filepath)
        {
            // 再生
            Player.Play(filepath);
            // コントロール制御
            EnableControls(true);
            // メッセージ表示
            DisplayMessage("再生中...");
            // 背景変更
            panelPlayer.BackgroundImage = Properties.Resources.panel_playing;
            // 監視タイマー起動
            timerPlayState.Enabled = true;
        }

        /// <summary>
        /// サウンド停止
        /// </summary>
        /// <param name="filepath"></param>
        private void StopSound()
        {
            // 一時停止　※再開ができるよう、Stopにしない
            Player.Pause();
            // コントロール制御
            EnableControls(false);
            // 背景変更
            panelPlayer.BackgroundImage = Properties.Resources.panel_pause;
            // 監視タイマー停止
            timerPlayState.Enabled = false;
        }

        /// <summary>
        /// トラックが終了するまで待機する
        /// </summary>
        private void WaitTrackLast()
        {
            bool last = false;  // 終了確認フラグ

            // トラック終了待機ループ
            while (!last)
            {
                // メディアの最後まで来たら、フラグを立てる
                if ((Player.State == Mp3Player.StateInfo.Last) ||
                    (Player.State == Mp3Player.StateInfo.Stop))
                    last = true;

                // アボートしたら、その時点で抜ける
                if (AbortFlag)
                    break;

                System.Threading.Thread.Sleep(200);

                Application.DoEvents();
            }

            // メッセージ表示
            DisplayMessage("停止");

        }
        #endregion

    }

}
