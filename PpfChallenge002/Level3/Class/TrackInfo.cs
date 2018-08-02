using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shell32;      // Windows Shell32 ライブラリ

namespace PpfChallenge002.Level3
{
    class TrackInfo
    {
        #region "Enum"
        /// <summary>
        /// トラック情報インデックス(ID3タグ情報に対応)
        /// </summary>
        private enum TrackIndex
        {
            Artist = 13,
            Album = 14,
            Title = 21,
            Time = 27
        }
        #endregion

        #region "プロパティ"
        /// <summary>
        /// タイトル
        /// </summary>
        public string Title = "";

        /// <summary>
        /// アーティスト
        /// </summary>
        public string Artist = "";

        /// <summary>
        /// アルバム
        /// </summary>
        public string Album = "";

        /// <summary>
        /// 時間
        /// </summary>
        public string Time = "";
        #endregion

        #region "メソッド"
        /// <summary>
        /// トラック情報の取得
        /// </summary>
        /// <param name="trackfile"></param>
        public void GetTrackInfo(string trackfile)
        {
            // ファイル情報の取得
            string dir = System.IO.Directory.GetParent(trackfile).ToString();   // ディレクトリ名
            string file = System.IO.Path.GetFileName(trackfile);                // ファイル名

            // ファイルプロパティ(ID3タグ情報)の取得
            ShellClass shell = new ShellClass();
            Folder f = shell.NameSpace(dir);
            FolderItem item = f.ParseName(file);

            //// ID3情報の格納位置確認 (※出力ウィンドウに表示されます)
            //for (int i = 0; i < 100; i++)
            //{
            //    string msg = string.Format("[{0}] {1}", i, f.GetDetailsOf(item, i));
            //    System.Diagnostics.Debug.WriteLine(msg);
            //}

            // トラック情報の取得
            Title = f.GetDetailsOf(item, (int)TrackIndex.Title);            // タイトル
            Artist = f.GetDetailsOf(item, (int)TrackIndex.Artist);          // アーティスト
            Album = f.GetDetailsOf(item, (int)TrackIndex.Album);            // アルバム
            Time = f.GetDetailsOf(item, (int)TrackIndex.Time);              // 時間

        }
        #endregion
    }
}
