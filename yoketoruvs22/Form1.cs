using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace yoketoruvs22
{
    public partial class Form1 : Form
    {
        const bool isDebug = true;

        const int PlayerMax = 1;
        const int EnemyMax = 10;
        const int ItemMax = 10;
        const int ChrMax = PlayerMax + EnemyMax + ItemMax;
        Label[] chrs = new Label[ChrMax];
        const int PlayerIndex = 0;
        const int EnemyIndex = PlayerIndex + PlayerMax;
        const int ItemIndex = EnemyIndex + EnemyMax;

        const string PlayerText = "(・ω・)";
        const string EnemyText = "◆";
        const string ItemText = "★";

        static Random rand = new Random();

        enum State
        {
            None=-1,    //無効
            Title,      //タイトル
            Game,       //ゲーム
            Gameover,   //ゲームオーバー
            Clear   //クリア
        }
        State currentState = State.None;
        State nextState = State.Title;

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(nextState != State.None)
            {
                initProc();
            }

            if(isDebug)
            {
                if (GetAsyncKeyState((int)Keys.O) < 0)
                {
                    nextState = State.Gameover;
                }
                if(GetAsyncKeyState((int)Keys.C)<0)
                {
                    nextState = State.Clear;
                }
            }
        }
        void initProc()
        {
            currentState = nextState;
            nextState = State.None;

            switch(currentState)
            {
                case State.Title:
                    titlelabel.Visible = true;
                    startbutton.Visible = true;
                    scorelabel.Visible = true;
                    copyrightlabel.Visible = true;
                    gameoverlabel.Visible = false;
                    titlebutton.Visible = false;
                    clearlabel.Visible = false;
                    break;

                case State.Game:
                    titlelabel.Visible = false;
                    startbutton.Visible = false;
                    scorelabel.Visible = false;
                    copyrightlabel.Visible = false;
                    break;

                case State.Gameover:
                    gameoverlabel.Visible = true;
                    titlebutton.Visible = true;
                    break;

                case State.Clear:
                    clearlabel.Visible = true;
                    titlebutton.Visible = true;
                    scorelabel.Visible = true;
                    break;
            }
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }

        private void titlebutton_Click(object sender, EventArgs e)
        {
            nextState = State.Title;
        }
    }
}
