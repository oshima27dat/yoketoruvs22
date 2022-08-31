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

        const int SpeedMax = 10;
        const int PlayerMax = 1;
        const int EnemyMax = 10;
        const int ItemMax = 10;
        const int ChrMax = PlayerMax + EnemyMax + ItemMax;
        Label[] chrs = new Label[ChrMax];
        int[] vx = new int[ChrMax];
        int[] vy = new int[ChrMax];
        const int PlayerIndex = 0;
        const int EnemyIndex = PlayerIndex + PlayerMax;
        const int ItemIndex = EnemyIndex + EnemyMax;
        const int StartTime = 100;
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

        int itemCount = 0;
        int time = 0;
        int hiscore = 0;

        public Form1()
        {
            InitializeComponent();

            for (int i=0;i<ChrMax;i++)
            {
                chrs[i] = new Label();
                chrs[i].AutoSize = true;
                if(i==PlayerIndex)
                {
                    chrs[i].Text = PlayerText;
                }
                else if(i<ItemIndex)
                {
                    chrs[i].Text = EnemyText;
                }
                else
                {
                    chrs[i].Text = ItemText;
                }
                chrs[i].Font = TempLabel.Font;
                Controls.Add(chrs[i]);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(nextState != State.None)
            {
                initProc();
            }

            /*if(isDebug)
            {
                if (GetAsyncKeyState((int)Keys.O) < 0)
                {
                    nextState = State.Gameover;
                }
                if(GetAsyncKeyState((int)Keys.C)<0)
                {
                    nextState = State.Clear;
                }
            }*/
            if(currentState == State.Game)
            {
                UpdateGame();

            }
        }

        void UpdateGame()
        {
            time--;
            timelabel.Text = $"Time{time:000}";
            Point mp = PointToClient(MousePosition);

            if (Keylabel.Checked == false)
            {
                //プレイヤーがマウスの中心になる
                chrs[PlayerIndex].Left = mp.X - chrs[PlayerIndex].Width / 2;
                chrs[PlayerIndex].Top = mp.Y - chrs[PlayerIndex].Height / 2;
                hantei.Left = mp.X - hantei.Width / 2;
                hantei.Top = mp.Y - hantei.Height / 2;
            }
            else
            {
                if (GetAsyncKeyState((int)Keys.D) < 0)
                    {
                        if (GetAsyncKeyState((int)Keys.LShiftKey) < 0)
                        {
                            chrs[PlayerIndex].Left += 15;
                            hantei.Left += 15;
                        }
                        else
                        {
                            chrs[PlayerIndex].Left += 30;
                            hantei.Left += 30;
                        }
                    }
                    if (GetAsyncKeyState((int)Keys.A) < 0)
                    {
                        if (GetAsyncKeyState((int)Keys.LShiftKey) < 0)
                        {
                            chrs[PlayerIndex].Left -= 15;
                            hantei.Left -= 15;
                        }
                        else
                        {
                            chrs[PlayerIndex].Left -= 30;
                            hantei.Left -= 30;
                        }
                    }
                    if (GetAsyncKeyState((int)Keys.W) < 0)
                    {
                        if (GetAsyncKeyState((int)Keys.LShiftKey) < 0)
                        {
                            chrs[PlayerIndex].Top -= 15;
                            hantei.Top -= 15;
                        }
                        else
                        {
                            chrs[PlayerIndex].Top -= 30;
                            hantei.Top -= 30;
                        }
                    }
                    if (GetAsyncKeyState((int)Keys.S) < 0)
                    {
                        if (GetAsyncKeyState((int)Keys.LShiftKey) < 0)
                        {
                            chrs[PlayerIndex].Top += 15;
                            hantei.Top += 15;
                        }
                        else
                        {
                            chrs[PlayerIndex].Top += 30;
                            hantei.Top += 30;
                        }
                    }
            }

            if(GetAsyncKeyState((int)Keys.Escape)<0)
            {
                nextState = State.Title;
            }

            for (int i = EnemyIndex; i < ChrMax; i++)
            {
                if (!chrs[i].Visible) continue;

                chrs[i].Left += vx[i];
                chrs[i].Top += vy[i];
                //反転
                if (chrs[i].Left < 0)
                {
                    vx[i] = Math.Abs(vx[i]);
                }
                if (chrs[i].Top < 0)
                {
                    vy[i] = Math.Abs(vy[i]);
                }
                if (chrs[i].Right > ClientSize.Width)
                {
                    vx[i] = -Math.Abs(vx[i]);
                }
                if (chrs[i].Bottom > ClientSize.Height)
                {
                    vy[i] = -Math.Abs(vy[i]);
                }
                //当たり判定
                if (Keylabel.Checked == false)
                {
                    if ((chrs[i].Left <= mp.X)
                && (chrs[i].Right >= mp.X)
                && (chrs[i].Top <= mp.Y)
                && (chrs[i].Bottom >= mp.Y))
                    {
                        if (i < ItemIndex)
                        {
                            if(time <= 090)
                            nextState = State.Gameover;
                        }
                        else
                        {
                            chrs[i].Visible = false;
                            itemCount--;
                            leftlabel.Text = $"★の数:{itemCount: 00}";
                            if (itemCount <= 0)
                            {
                                nextState = State.Clear;
                            }

                        }
                    }
                }
                else
                {
                    if ((chrs[i].Left <= hantei.Right)
                && (chrs[i].Right >= hantei.Left)
                && (chrs[i].Top <= hantei.Bottom)
                && (chrs[i].Bottom >= hantei.Top))
                    {
                        if (i < ItemIndex)
                        {
                            if (time <= 090)
                            nextState = State.Gameover;
                        }
                        else
                        {
                            chrs[i].Visible = false;
                            itemCount--;
                            leftlabel.Text = $"★の数:{itemCount: 00}";
                            if (itemCount <= 0)
                            {
                                nextState = State.Clear;
                            }

                        }
                    }
                }
                if(time <=0 && (nextState == State.None))
                {
                    nextState = State.Gameover;
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
                    Keylabel.Visible = true;
                    label1.Visible = true;
                    break;

                case State.Game:
                    titlelabel.Visible = false;
                    startbutton.Visible = false;
                    scorelabel.Visible = false;
                    copyrightlabel.Visible = false;
                    Keylabel.Visible = false;
                    label1.Visible = false;

                    itemCount = ItemMax;
                    time = StartTime + 1;
                    leftlabel.Text = $"★の数:{ itemCount: 00}";

                    for (int i=EnemyIndex;i<ChrMax;i++)
                    {
                        chrs[i].Left = rand.Next(ClientSize.Width - chrs[i].Width);
                        chrs[i].Top = rand.Next(ClientSize.Height - chrs[i].Height);
                        vx[i] = rand.Next(-SpeedMax, SpeedMax + 1);
                        vy[i] = rand.Next(-SpeedMax, SpeedMax + 1);
                        chrs[i].Visible = true;
                    }
                    break;


                case State.Gameover:
                    gameoverlabel.Visible = true;
                    titlebutton.Visible = true;
                    break;

                case State.Clear:
                    clearlabel.Visible = true;
                    titlebutton.Visible = true;
                    scorelabel.Visible = true;
                    if(time>hiscore)
                    {
                        hiscore = time;
                        scorelabel.Text = "HighScore" + hiscore;
                    }
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

        private void Keylabel_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
