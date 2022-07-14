using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yoketoruvs22
{
    public partial class Form1 : Form
    {
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
            }
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }
    }
}
