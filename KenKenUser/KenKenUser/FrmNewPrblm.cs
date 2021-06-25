using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace KenKenUser
{
    public partial class FrmNewPrblm : Form
    {
        Button[] btArif = new Button[4];
        Button[] bt = new Button[16];
        string[] prob_lvl;
        string[] header;

        public FrmNewPrblm()
        {
            InitializeComponent();
            for (int i = 0; i < 4; i++)
                btArif[i] = (Button)groupBoxbt.Controls[i];
            for (int i = 0; i < 16; i++)
            {
                string namebt = tblBt.Controls[i].Name;
                int kor = int.Parse(namebt.Substring(6));
                bt[kor] = (Button)tblBt.Controls[i];
            }
        }
        int kol = 0;

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.BackColor == Color.Wheat)
            {
                button.BackColor = Color.White;
                kol--;
            }
            else if (kol < 4)
            {
                button.BackColor = Color.Wheat;
                kol++;
            }
        }

        private void button_arif_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            for (int i = 0; i < 4; i++)
                btArif[i].BackColor = Color.White;
            button.BackColor = Color.Wheat;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            bool correctarf = false;
            bool correctbt = false;
            for (int i = 0; i < 4; i++)
                if (btArif[i].BackColor == Color.Wheat)
                    correctarf= true;
            for (int i = 0; i < 16; i++)
                if (bt[i].BackColor == Color.Wheat)
                    correctbt = true;

            if (!correctbt || !correctarf)
            {
                MessageBox.Show("Error");
                return;
            }
            kol = 0;
            string problem = "";
            for (int i = 0; i < 4; i++)// arif
                if (btArif[i].BackColor == Color.Wheat)
                    problem = btArif[i].Text + " " + numRez.Value;

            for (int i = 0; i < 16; i++)
                if (bt[i].BackColor == Color.Wheat)
                {
                    problem += " " + i;
                    bt[i].BackColor = Color.Sienna;
                    bt[i].Enabled = false;
                }
            listBox1.Items.Add(problem);

            bool enAdd = false;
            for (int i = 0; i < 16; i++)
                if (bt[i].BackColor != Color.Sienna)
                    enAdd = true;
            if (!enAdd)
            {
                btAdd.Enabled = false;
                prob_lvl = new string[listBox1.Items.Count];
                for (int i = 0; i < prob_lvl.Length; i++)
                    prob_lvl[i] = listBox1.Items[i].ToString();
            }
                
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
                btDell.Enabled = true;
        }

        private void btDell_Click(object sender, EventArgs e)
        {
            int ind = listBox1.SelectedIndex;
            string[] line = listBox1.Items[ind].ToString().Split(' ');
            for (int i = 2; i < line.Length; i++)
            {
                bt[int.Parse(line[i])].BackColor = Color.White;
                bt[int.Parse(line[i])].Enabled = true;
            }

            btAdd.Enabled = true;

            listBox1.Items.RemoveAt(ind);
        }

        private void btsProb_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count < 4 || btAdd.Enabled == true)
            {
                MessageBox.Show("Ошибка!");
                return;
            }

            string filename;
            Button bts = (Button)sender;

            if (bts.Name == "btSave")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                filename = saveFileDialog1.FileName;
            }
            else
            {
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                filename = openFileDialog1.FileName;
            }

            // Clear
            for (int i = 0; i < 16; i++)
            {
                bt[i].BackColor = Color.White;
                bt[i].Enabled = true;
            }
            btAdd.Enabled = true;
            listBox1.Items.Clear();
            //

            Random rnd = new Random();
            header = new string[2] { "|||", "" };
            if (txtName.Text != "")
                header[1] = txtName.Text;
            else
                header[1] = "Problem " + rnd.Next(100);

            File.AppendAllLines(filename, header);
            File.AppendAllLines(filename, prob_lvl);
        }

        private void FrmNewPrblm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();
        }
    }
}
