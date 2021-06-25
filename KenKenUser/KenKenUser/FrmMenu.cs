using System;
using System.IO;
using System.Windows.Forms;

namespace KenKenUser
{
    public partial class FrmMenu : Form
    {
        string[] lv;
        int[] lvls_koor = new int[0];
        static public string[] problem;
        static public bool rand;
        bool lvl_cor;

        public FrmMenu()
        {
            InitializeComponent();
        }

        void LoadLvl()
        {
            lv = File.ReadAllLines(Program.filename);
            for (int i = 0; i < lv.Length; i++)
                if (lv[i] == "|||")
                {
                    Array.Resize(ref lvls_koor, lvls_koor.Length + 1);
                    lvls_koor[lvls_koor.Length - 1] = i + 1;
                    listBox1.Items.Add(lv[i + 1]);
                }
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            tLoad.Start();// smooth load
            try
            {
                LoadLvl();
                lvl_cor = true;
            }
            catch
            {
                listBox1.Items.Add("Натисніть \"відкрити\"");
                listBox1.Items.Add("щоб  відкрити");
                listBox1.Items.Add("користувальні рівні");
            }
        }

        private void btOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            lvl_cor = true;
            listBox1.Items.Clear();
            Program.filename = openFileDialog1.FileName;
            LoadLvl();
        }

        private void tLoad_Tick(object sender, EventArgs e)
        {
            Opacity += 0.06;
            if (Opacity > 0.9)
            {
                Opacity = 1;
                tLoad.Stop();
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1 && lvl_cor)
            {
                rand = false;
                int p = 0;
                problem = new string[0];
                int slInd = listBox1.SelectedIndex;
                for (int i = lvls_koor[slInd]; i < lv.Length; i++)
                    if (lv[i] != "|||")
                    {
                        Array.Resize(ref problem, problem.Length + 1);
                        problem[p] = lv[i];
                        p++;
                    }
                    else
                        break;
                FrmGame game = new FrmGame();
                game.Show();
                Hide();
            }
        }

        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        { Application.Exit(); }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Гра KenKen" + "\n" + "Автор: Єгор Пронь" + "\n" + "Клас 10 - В", "Про програму", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menEditor_Click(object sender, EventArgs e)
        {
            FrmNewPrblm tool = new FrmNewPrblm();
            tool.Show();
            Hide();
        }

        private void btChrmiss_Click(object sender, EventArgs e)
        {
            rand = true;
            Random_lvl.GetProblem();
            problem = Random_lvl.problems;
            FrmGame game = new FrmGame();
            game.Show();
            Hide();
        }

        private void btLeaders_Click(object sender, EventArgs e)
        {
            Form tabl = new FrmLeaders();
            tabl.Show();
            Hide();
        }
    }
}
