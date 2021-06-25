namespace KenKenUser
{
    partial class FrmNewPrblm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewPrblm));
            this.btAdd = new System.Windows.Forms.Button();
            this.btDeln = new System.Windows.Forms.Button();
            this.btUmn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btSum = new System.Windows.Forms.Button();
            this.btRazn = new System.Windows.Forms.Button();
            this.groupBoxbt = new System.Windows.Forms.GroupBox();
            this.tblBt = new System.Windows.Forms.TableLayoutPanel();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btAddLvl = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.numRez = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btDell = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxbt.SuspendLayout();
            this.tblBt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRez)).BeginInit();
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.btAdd.Location = new System.Drawing.Point(458, 9);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(98, 62);
            this.btAdd.TabIndex = 16;
            this.btAdd.Text = "Add";
            this.toolTip1.SetToolTip(this.btAdd, "Додати блок");
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDeln
            // 
            this.btDeln.BackColor = System.Drawing.Color.White;
            this.btDeln.BackgroundImage = global::KenKenUser.Properties.Resources.delenie;
            this.btDeln.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btDeln.Location = new System.Drawing.Point(249, 25);
            this.btDeln.Name = "btDeln";
            this.btDeln.Size = new System.Drawing.Size(75, 75);
            this.btDeln.TabIndex = 20;
            this.btDeln.Text = "/";
            this.btDeln.UseVisualStyleBackColor = false;
            this.btDeln.Click += new System.EventHandler(this.button_arif_Click);
            // 
            // btUmn
            // 
            this.btUmn.BackColor = System.Drawing.Color.White;
            this.btUmn.BackgroundImage = global::KenKenUser.Properties.Resources.Umnogh;
            this.btUmn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btUmn.Location = new System.Drawing.Point(168, 25);
            this.btUmn.Name = "btUmn";
            this.btUmn.Size = new System.Drawing.Size(75, 75);
            this.btUmn.TabIndex = 19;
            this.btUmn.Text = "*";
            this.btUmn.UseVisualStyleBackColor = false;
            this.btUmn.Click += new System.EventHandler(this.button_arif_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(355, 77);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(201, 204);
            this.listBox1.TabIndex = 23;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btSum
            // 
            this.btSum.BackColor = System.Drawing.Color.White;
            this.btSum.BackgroundImage = global::KenKenUser.Properties.Resources.summa;
            this.btSum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btSum.Location = new System.Drawing.Point(6, 25);
            this.btSum.Name = "btSum";
            this.btSum.Size = new System.Drawing.Size(75, 75);
            this.btSum.TabIndex = 25;
            this.btSum.Text = "+";
            this.btSum.UseVisualStyleBackColor = false;
            this.btSum.Click += new System.EventHandler(this.button_arif_Click);
            // 
            // btRazn
            // 
            this.btRazn.BackColor = System.Drawing.Color.White;
            this.btRazn.BackgroundImage = global::KenKenUser.Properties.Resources.razniza;
            this.btRazn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btRazn.Location = new System.Drawing.Point(87, 28);
            this.btRazn.Name = "btRazn";
            this.btRazn.Size = new System.Drawing.Size(75, 75);
            this.btRazn.TabIndex = 26;
            this.btRazn.Text = "-";
            this.btRazn.UseVisualStyleBackColor = false;
            this.btRazn.Click += new System.EventHandler(this.button_arif_Click);
            // 
            // groupBoxbt
            // 
            this.groupBoxbt.Controls.Add(this.btSum);
            this.groupBoxbt.Controls.Add(this.btRazn);
            this.groupBoxbt.Controls.Add(this.btUmn);
            this.groupBoxbt.Controls.Add(this.btDeln);
            this.groupBoxbt.Location = new System.Drawing.Point(12, 2);
            this.groupBoxbt.Name = "groupBoxbt";
            this.groupBoxbt.Size = new System.Drawing.Size(330, 109);
            this.groupBoxbt.TabIndex = 27;
            this.groupBoxbt.TabStop = false;
            // 
            // tblBt
            // 
            this.tblBt.ColumnCount = 4;
            this.tblBt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblBt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblBt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblBt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblBt.Controls.Add(this.button15, 3, 3);
            this.tblBt.Controls.Add(this.button14, 2, 3);
            this.tblBt.Controls.Add(this.button13, 1, 3);
            this.tblBt.Controls.Add(this.button12, 0, 3);
            this.tblBt.Controls.Add(this.button11, 3, 2);
            this.tblBt.Controls.Add(this.button10, 2, 2);
            this.tblBt.Controls.Add(this.button9, 1, 2);
            this.tblBt.Controls.Add(this.button8, 0, 2);
            this.tblBt.Controls.Add(this.button7, 3, 1);
            this.tblBt.Controls.Add(this.button6, 2, 1);
            this.tblBt.Controls.Add(this.button5, 1, 1);
            this.tblBt.Controls.Add(this.button4, 0, 1);
            this.tblBt.Controls.Add(this.button3, 3, 0);
            this.tblBt.Controls.Add(this.button2, 2, 0);
            this.tblBt.Controls.Add(this.button1, 1, 0);
            this.tblBt.Controls.Add(this.button0, 0, 0);
            this.tblBt.Location = new System.Drawing.Point(12, 160);
            this.tblBt.Name = "tblBt";
            this.tblBt.RowCount = 4;
            this.tblBt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblBt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblBt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblBt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblBt.Size = new System.Drawing.Size(273, 271);
            this.tblBt.TabIndex = 1;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.White;
            this.button15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button15.Location = new System.Drawing.Point(207, 204);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(63, 64);
            this.button15.TabIndex = 15;
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.White;
            this.button14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button14.Location = new System.Drawing.Point(139, 204);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(62, 64);
            this.button14.TabIndex = 14;
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.White;
            this.button13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button13.Location = new System.Drawing.Point(71, 204);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(62, 64);
            this.button13.TabIndex = 13;
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.White;
            this.button12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button12.Location = new System.Drawing.Point(3, 204);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(62, 64);
            this.button12.TabIndex = 12;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.Location = new System.Drawing.Point(207, 137);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(63, 61);
            this.button11.TabIndex = 11;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Location = new System.Drawing.Point(139, 137);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(62, 61);
            this.button10.TabIndex = 10;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Location = new System.Drawing.Point(71, 137);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(62, 61);
            this.button9.TabIndex = 9;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Location = new System.Drawing.Point(3, 137);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(62, 61);
            this.button8.TabIndex = 8;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Location = new System.Drawing.Point(207, 70);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(63, 61);
            this.button7.TabIndex = 7;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(139, 70);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(62, 61);
            this.button6.TabIndex = 6;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(71, 70);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(62, 61);
            this.button5.TabIndex = 5;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(3, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(62, 61);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(207, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 61);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(139, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 61);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(71, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 61);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.White;
            this.button0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button0.Location = new System.Drawing.Point(3, 3);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(62, 61);
            this.button0.TabIndex = 0;
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button_Click);
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.btSave.Location = new System.Drawing.Point(355, 369);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(98, 62);
            this.btSave.TabIndex = 28;
            this.btSave.Text = "Save";
            this.toolTip1.SetToolTip(this.btSave, "Зберегти у новий файл");
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btsProb_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "KenKen Files(*.pken)|*.pken";
            // 
            // btAddLvl
            // 
            this.btAddLvl.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.btAddLvl.Location = new System.Drawing.Point(458, 369);
            this.btAddLvl.Name = "btAddLvl";
            this.btAddLvl.Size = new System.Drawing.Size(98, 62);
            this.btAddLvl.TabIndex = 29;
            this.btAddLvl.Text = "Add lvl";
            this.toolTip1.SetToolTip(this.btAddLvl, "Додати рівень у файл");
            this.btAddLvl.UseVisualStyleBackColor = true;
            this.btAddLvl.Click += new System.EventHandler(this.btsProb_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // numRez
            // 
            this.numRez.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F);
            this.numRez.Location = new System.Drawing.Point(355, 12);
            this.numRez.Maximum = new decimal(new int[] {
            144,
            0,
            0,
            0});
            this.numRez.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRez.Name = "numRez";
            this.numRez.Size = new System.Drawing.Size(97, 59);
            this.numRez.TabIndex = 30;
            this.numRez.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtName.Location = new System.Drawing.Point(355, 320);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(201, 38);
            this.txtName.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Назва (необов\'язково)";
            // 
            // btDell
            // 
            this.btDell.Enabled = false;
            this.btDell.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btDell.Location = new System.Drawing.Point(458, 237);
            this.btDell.Name = "btDell";
            this.btDell.Size = new System.Drawing.Size(98, 44);
            this.btDell.TabIndex = 33;
            this.btDell.Text = "Видалити";
            this.btDell.UseVisualStyleBackColor = true;
            this.btDell.Click += new System.EventHandler(this.btDell_Click);
            // 
            // FrmNewPrblm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 443);
            this.Controls.Add(this.btDell);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.numRez);
            this.Controls.Add(this.btAddLvl);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tblBt);
            this.Controls.Add(this.groupBoxbt);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btAdd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmNewPrblm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmNewPrblm_FormClosed);
            this.groupBoxbt.ResumeLayout(false);
            this.tblBt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numRez)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btUmn;
        private System.Windows.Forms.Button btDeln;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btSum;
        private System.Windows.Forms.Button btRazn;
        private System.Windows.Forms.GroupBox groupBoxbt;
        private System.Windows.Forms.TableLayoutPanel tblBt;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btAddLvl;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.NumericUpDown numRez;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btDell;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}