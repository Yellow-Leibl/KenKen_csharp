using System;
using System.Drawing;
using System.Windows.Forms;

namespace KenKenUser
{
    public partial class FrmGame : Form
    {
        TextBox[] tb = new TextBox[16];
        Label[] lab = new Label[9];
        string[] line;
        bool rw = true;
        int timerError = 0, timerGame = 0;
        int thr = 0, tmin = 0, tsec = 0;
        Color[] coll_col = { Color.Chocolate, Color.DeepPink, Color.Orange, Color.Lime, Color.LightBlue,
                Color.Violet, Color.Yellow, Color.RoyalBlue, Color.MistyRose  };
        Color[] col_game = new Color[0];
        bool keypress;
        string prev;

        void ResetLvl()
        {
            lblProg.Visible = false;
            lblTimer.Text = "00:00";
            for (int i = 0; i < tb.Length; i++)
                tb[i].Text = "";
            timerGame = 0;
            tGame.Start();
        }

        void LoadProblems()
        {
            Random rnd = new Random();
            int rand;
            for (int i = 1; i < FrmMenu.problem.Length; i++)
            {
                line = FrmMenu.problem[i].Split(' ');
                // write problem
                rand = rnd.Next(0, coll_col.Length);// random color

                Array.Resize(ref col_game, col_game.Length + 1);
                lab[i - 1].BackColor = col_game[i - 1] = coll_col[rand];// add color in col_game & label

                coll_col[rand] = coll_col[coll_col.Length - 1];// del color of collection colors
                Array.Resize(ref coll_col, coll_col.Length - 1);//

                if (line.Length == 3)
                    lab[i - 1].Text = line[1];
                else
                {
                    lab[i - 1].Text = line[1];
                    if (line[0] == "/")
                        lab[i - 1].Text += "÷";
                    else
                        lab[i - 1].Text += line[0];
                }

                // add problem in label
                lab[i - 1].Visible = true;//

                // backcolor textbox
                for (int p = 2; p < line.Length; p++)
                    tb[int.Parse(line[p])].BackColor = col_game[i - 1];
            }
        }

        public FrmGame()
        {
            InitializeComponent();
            // textBox
            for (int i = 0; i < 16; i++)
            {
                string namebt = tblPanArea.Controls[i].Name;
                int kor = int.Parse(namebt.Substring(7));
                tb[kor] = (TextBox)tblPanArea.Controls[i];
            }
            // label
            for (int i = 0; i < 9; i++)
            {
                string namelab = tblPanProblms.Controls[i].Name;
                int kor = int.Parse(namelab.Substring(5));
                lab[kor] = (Label)tblPanProblms.Controls[i];
            }
        }

        private void btChk_Click(object sender, EventArgs e)
        {
            tError.Stop();

            for (int i = 1; i < FrmMenu.problem.Length; i++)
            {
                line = FrmMenu.problem[i].Split(' ');
                // backcolor textbox
                for (int p = 2; p < line.Length; p++)
                    tb[int.Parse(line[p])].BackColor = col_game[i - 1];
            }

            bool error = false;
            for (int i = 1; i < tb.Length; i++)// find
                if (tb[i].Text == "")
                {
                    error = true;
                    break;
                }
            
            if (error)
                MessageBox.Show("Є порожні клітки!", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Solver.GetMiss(tb, FrmMenu.problem);
                // CHECK //
                if (Solver.errors != "" || Solver.vertic != "" || Solver.horiz != "")
                {
                    lblProg.ForeColor = Color.Red;
                    lblProg.Text = "Є помилки";
                    lblProg.Visible = true;
                    tError.Enabled = true;
                    timerError = 0;
                }
                else
                {
                    tGame.Stop();
                    lblProg.ForeColor = Color.Green;
                    lblProg.Text = "Успіх";
                    lblProg.Visible = true;
                    btRet_v_Next.Visible = true;

                    // Таблица времен
                    int ind = -1;
                    for (int i = 9; i >= 0; i--)
                    {
                        if (Program.tabl_leader[i] > timerGame || Program.tabl_leader[i] == 0)
                            ind = i;
                        else
                            break;
                    }

                    if (ind != -1)
                    {
                        for (int i = 8; i >= ind; i--)
                            Program.tabl_leader[i + 1] = Program.tabl_leader[i];
                        Program.tabl_leader[ind] = timerGame;
                    }
                    //

                }
                
            }
        }
        
        private void FrmGame_Load(object sender, EventArgs e)
        {
            LoadProblems();
            
            if (FrmMenu.rand)
            {
                btRet_v_Next.Visible = true;
                btRet_v_Next.Text = "Наступний рівень";
            }
        }

        private void tError_Tick(object sender, EventArgs e)
        {
            string[] error = Solver.errors.Split(' ');
            string[] vert = Solver.vertic.Split(' ');
            string[] horz = Solver.horiz.Split(' ');

            if (rw)
            {
                rw = false;
                for (int i = 0; i < error.Length; i++)// problems
                    tb[int.Parse(error[i])].BackColor = Color.Red;

                for (int i = 0; i < vert.Length; i += 4)// vertical
                    for (int p = int.Parse(vert[i]); p < int.Parse(vert[i]) + 4; p++)
                        tb[p].BackColor = Color.Red;

                for (int i = 0; i < horz.Length; i++)// horizontal
                    for (int p = int.Parse(horz[i]); p <= int.Parse(horz[i]) + 12; p += 4)
                        tb[p].BackColor = Color.Red;
            }
            else
            {
                rw = true;
                for (int i = 1; i < FrmMenu.problem.Length; i++)
                {
                    line = FrmMenu.problem[i].Split(' ');
                    // backcolor textbox
                    for (int p = 2; p < line.Length; p++)
                        tb[int.Parse(line[p])].BackColor = col_game[i - 1];
                }
            }

            if (timerError != 5)
                timerError++;
            else
                tError.Enabled = false;
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        { keypress = true; }

        private void FrmGame_SizeChanged(object sender, EventArgs e)
        {
            // try
            /*
            // textBox
            double fnt = (float)tb[0].Height / 1.6470;
            for (int i = 0; i < tb.Length; i++)
                tb[i].Font = new Font("Microsoft Sans Serif", (float)fnt);
            // label problems
            fnt = (float)lab[0].Height / 1.8076;
            for (int i = 0; i < lab.Length; i++)
                lab[i].Font = new Font("Microsoft Sans Serif", (float)fnt);
            //label
            fnt = lblProg.Height / 2.4666;
            lblProg.Font = new Font("Microsoft Sans Serif", (float)fnt);
            fnt = lblTimer.Height / 2.5;
            lblTimer.Font = new Font("Microsoft Sans Serif", (float)fnt);
            // button
            fnt = btChk.Height / 4.6428;
            btChk.Font = new Font("Microsoft Sans Serif", (float)fnt);
            fnt = btRestart.Height/ 4.6428;
            btRestart.Font = new Font("Microsoft Sans Serif", (float)fnt);
            fnt = btRet_v_Next.Height / 2.1875;
            btRet_v_Next.Font = new Font("Microsoft Sans Serif", (float)fnt);
            */
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (keypress && textBox.Text != "")
            {
                int lng = 0;
                string rng = "";

                if (textBox.Text.Length == 2)
                    lng++;

                for (int i = 0; i <= lng; i++)
                    for (int p = 1; p <= 4; p++)
                        if (textBox.Text[i].ToString() == p.ToString())
                            rng += i.ToString();

                if (rng.Length == 1)
                {
                    textBox.Text = textBox.Text[int.Parse(rng)].ToString();
                    prev = textBox.Text;
                }
                else if (rng.Length == 2)
                {
                    if (textBox.Text[0].ToString() == prev)
                        textBox.Text = textBox.Text[1].ToString();
                    else
                        textBox.Text = textBox.Text[0].ToString();
                }
                else
                    textBox.Text = "";
                try
                { int i = int.Parse(textBox.Text); }
                catch { textBox.Text = ""; }

                keypress = false;
            }
        }

        private void tGame_Tick(object sender, EventArgs e)
        {
            timerGame++;

            thr = timerGame / 3600;
            tmin = (timerGame - thr * 3600) / 60;
            tsec = timerGame - thr * 3600 - tmin * 60;

            lblTimer.Text = "";
            if (thr != 0)// hour
                lblTimer.Text += thr + ":";

            if (tmin.ToString().Length == 1)// minutes
                lblTimer.Text += "0";
            lblTimer.Text += tmin + ":";

            if (tsec.ToString().Length == 1)// seconds
                lblTimer.Text += "0";
            lblTimer.Text += tsec;
        }

        private void FrmGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form menu = new FrmMenu();
            menu.Show();
        }

        private void btRestart_Click(object sender, EventArgs e)
        {
            ResetLvl();
        }

        private void tLoad_Tick(object sender, EventArgs e)
        {
            Opacity += 0.06;
            if (Opacity > 0.9)
            {
                Opacity = 1;
                tGame.Start();
                tLoad.Stop();
            }
        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            if (FrmMenu.rand)
            {
                ResetLvl();
                for (int i = 0; i < 9; i++)
                    lab[i].Visible = false;
                coll_col = new Color[] { Color.Chocolate, Color.DeepPink, Color.Orange, Color.Lime, Color.LightBlue,
                Color.Violet, Color.Yellow, Color.RoyalBlue, Color.MistyRose  };
                Random_lvl.GetProblem();
                FrmMenu.problem = Random_lvl.problems;
                LoadProblems();
            }
            else
            {
                FrmMenu menu = new FrmMenu();
                menu.Show();
                Hide();
            }
        }
    }
}