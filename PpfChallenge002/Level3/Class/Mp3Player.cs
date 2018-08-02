using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;   // Windows Media Player ライブラリ

namespace PpfChallenge002.Level3
{
    class Mp3Player
    {
        /// <summary>
        /// 再生状態
        /// </summary>
        public enum StateInfo
        {
            Wait,       // 待機中
            Playing,    // 再生中
            Stop,       // 停止
            Last        // 曲の最後
        }

        /// <summary>
        /// プレーヤー(Windows Media Player)
        /// </summary>
        private WindowsMediaPlayer Player = new WindowsMediaPlayer();

        #region "プロパティ"
        /// <summary>
        /// 再生位置の指定/取得
        /// </summary>
        public double Position
        {
            get
            {
                return Player.controls.currentPosition;
            }
            set
            {
                Player.controls.currentPosition = value;
            }
        }
        #endregion

        #region "コンストラクタ"
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Mp3Player()
        {

        }
        #endregion

        #region "プロパティ"
        /// <summary>
        /// 再生状態
        /// </summary>
        public StateInfo State
        {
            get
            {
                StateInfo s = StateInfo.Stop;

                // 
                switch (Player.playState)
                {
                    case WMPPlayState.wmppsPlaying:
                        s = StateInfo.Playing; 
                        break;
                    case WMPPlayState.wmppsPaused:
                    case WMPPlayState.wmppsStopped:
                        s = StateInfo.Stop;    
                        break;
                    case WMPPlayState.wmppsMediaEnded:
                        s = StateInfo.Last;
                        break;
                    default:
                        // 将来の拡張性のため置いておく
                        s = StateInfo.Wait;
                        break;
                }

                return s;
            }
        }
        
        #endregion

        #region "メソッド"
        /// <summary>
        /// 再生
        /// </summary>
        public void Play(string filepath)
        {
            // オーディオファイルの指定(ファイルが変わる時のみ)
            if (Player.URL != filepath)
                Player.URL = filepath;
            // 再生
            Player.controls.play();
        }

        /// <summary>
        /// 一時停止
        /// </summary>
        public void Pause()
        {
            // 一時停止
            Player.controls.pause();
        }

        /// <summary>
        /// 停止
        /// </summary>
        public void Stop()
        {
            // 停止
            Player.controls.stop();
            // オーディオファイル情報のクリア
            Player.URL = "";
        }
        #endregion

    }
}
