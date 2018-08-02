using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PpfChallenge002.Level1
{
    public partial class FormMp3Player : Form
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FormMp3Player()
        {
            InitializeComponent();
        }

        #region "イベント"
        /// <summary>
        /// 
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
            string filepath = SelectMp3File(textFilepath.Text);

            // 選択されたファイルパスを画面に反映
            if (filepath != "")
                textFilepath.Text = filepath;
        }

        /// <summary>
        /// [再生]ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            // ここに再生の処理を書いていくよ。
        }

        /// <summary>
        /// [停止]ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStop_Click(object sender, EventArgs e)
        {
            // ここに停止の処理を書いていくよ。
        }
        #endregion

        #region "メソッド"
        /// <summary>
        /// フォーム初期化
        /// </summary>
        private void InitForm()
        {
            textFilepath.Text = "";
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
        #endregion


    }
}
