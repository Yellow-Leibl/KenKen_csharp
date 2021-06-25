using System;
using System.Windows.Forms;

namespace KenKenUser
{
    public partial class FrmLeaders : Form
    {
        public FrmLeaders()
        {
            InitializeComponent();
        }

        private void FrmLeaders_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 10;
            int thr, tmin, tsec;
            for (int i = 0; i < 10; i++)
            {
                if (Program.tabl_leader[i] != 0)
                {
                    dataGridView1.Rows[i].Cells[0].Value = i + 1;
                    thr = Program.tabl_leader[i] / 3600;
                    tmin = (Program.tabl_leader[i] - thr * 3600) / 60;
                    tsec = Program.tabl_leader[i] - thr * 3600 - tmin * 60;

                    if (thr != 0)// hour
                        dataGridView1.Rows[i].Cells[1].Value += thr + ":";

                    if (tmin.ToString().Length == 1)// minutes
                        dataGridView1.Rows[i].Cells[1].Value += "0";
                    dataGridView1.Rows[i].Cells[1].Value += tmin + ":";

                    if (tsec.ToString().Length == 1)// seconds
                        dataGridView1.Rows[i].Cells[1].Value += "0";
                    dataGridView1.Rows[i].Cells[1].Value += tsec + "";

                }
                else
                    break;
            }
                
        }

        private void FrmLeaders_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form menu = new FrmMenu();
            menu.Show();
        }
    }
}
