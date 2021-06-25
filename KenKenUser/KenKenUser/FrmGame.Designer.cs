namespace KenKenUser
{
    partial class FrmGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGame));
            this.tLoad = new System.Windows.Forms.Timer(this.components);
            this.tError = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label0 = new System.Windows.Forms.Label();
            this.btChk = new System.Windows.Forms.Button();
            this.btRestart = new System.Windows.Forms.Button();
            this.btRet_v_Next = new System.Windows.Forms.Button();
            this.lblProg = new System.Windows.Forms.Label();
            this.tblPanArea = new System.Windows.Forms.TableLayoutPanel();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox0 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.tblLtPanFrmGame = new System.Windows.Forms.TableLayoutPanel();
            this.tblPanProg = new System.Windows.Forms.TableLayoutPanel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tblPanProblms = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tGame = new System.Windows.Forms.Timer(this.components);
            this.tblPanArea.SuspendLayout();
            this.tblLtPanFrmGame.SuspendLayout();
            this.tblPanProg.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tblPanProblms.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLoad
            // 
            this.tLoad.Enabled = true;
            this.tLoad.Interval = 20;
            this.tLoad.Tick += new System.EventHandler(this.tLoad_Tick);
            // 
            // tError
            // 
            this.tError.Interval = 500;
            this.tError.Tick += new System.EventHandler(this.tError_Tick);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.label1.Location = new System.Drawing.Point(92, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 55);
            this.label1.TabIndex = 37;
            this.label1.Text = "+0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.label2.Location = new System.Drawing.Point(181, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 55);
            this.label2.TabIndex = 38;
            this.label2.Text = "+0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.label3.Location = new System.Drawing.Point(3, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 55);
            this.label3.TabIndex = 39;
            this.label3.Text = "+0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.label4.Location = new System.Drawing.Point(92, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 55);
            this.label4.TabIndex = 40;
            this.label4.Text = "+0";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.label5.Location = new System.Drawing.Point(181, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 55);
            this.label5.TabIndex = 41;
            this.label5.Text = "+0";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.label6.Location = new System.Drawing.Point(3, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 57);
            this.label6.TabIndex = 42;
            this.label6.Text = "+0";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.label7.Location = new System.Drawing.Point(92, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 57);
            this.label7.TabIndex = 43;
            this.label7.Text = "+0";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.label8.Location = new System.Drawing.Point(181, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 57);
            this.label8.TabIndex = 44;
            this.label8.Text = "+0";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Visible = false;
            // 
            // label0
            // 
            this.label0.BackColor = System.Drawing.SystemColors.Control;
            this.label0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label0.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.label0.Location = new System.Drawing.Point(3, 0);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(83, 55);
            this.label0.TabIndex = 45;
            this.label0.Text = "+0";
            this.label0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label0.Visible = false;
            // 
            // btChk
            // 
            this.btChk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btChk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btChk.Location = new System.Drawing.Point(3, 3);
            this.btChk.Name = "btChk";
            this.btChk.Size = new System.Drawing.Size(129, 78);
            this.btChk.TabIndex = 33;
            this.btChk.Text = "Перевірити";
            this.btChk.UseVisualStyleBackColor = true;
            this.btChk.Click += new System.EventHandler(this.btChk_Click);
            // 
            // btRestart
            // 
            this.btRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRestart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btRestart.Location = new System.Drawing.Point(138, 3);
            this.btRestart.Name = "btRestart";
            this.btRestart.Size = new System.Drawing.Size(121, 78);
            this.btRestart.TabIndex = 61;
            this.btRestart.Text = "Заново";
            this.btRestart.UseVisualStyleBackColor = true;
            this.btRestart.Click += new System.EventHandler(this.btRestart_Click);
            // 
            // btRet_v_Next
            // 
            this.btRet_v_Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRet_v_Next.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btRet_v_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btRet_v_Next.Location = new System.Drawing.Point(3, 93);
            this.btRet_v_Next.Name = "btRet_v_Next";
            this.btRet_v_Next.Size = new System.Drawing.Size(262, 42);
            this.btRet_v_Next.TabIndex = 62;
            this.btRet_v_Next.Text = "Повернутися у меню";
            this.btRet_v_Next.UseVisualStyleBackColor = true;
            this.btRet_v_Next.Visible = false;
            this.btRet_v_Next.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // lblProg
            // 
            this.lblProg.BackColor = System.Drawing.Color.Transparent;
            this.lblProg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProg.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold);
            this.lblProg.Location = new System.Drawing.Point(3, 0);
            this.lblProg.Name = "lblProg";
            this.lblProg.Size = new System.Drawing.Size(268, 62);
            this.lblProg.TabIndex = 63;
            this.lblProg.Text = "labelProg";
            this.lblProg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProg.Visible = false;
            // 
            // tblPanArea
            // 
            this.tblPanArea.ColumnCount = 4;
            this.tblPanArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblPanArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblPanArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblPanArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblPanArea.Controls.Add(this.textBox12, 0, 3);
            this.tblPanArea.Controls.Add(this.textBox0, 0, 0);
            this.tblPanArea.Controls.Add(this.textBox3, 3, 0);
            this.tblPanArea.Controls.Add(this.textBox1, 1, 0);
            this.tblPanArea.Controls.Add(this.textBox2, 2, 0);
            this.tblPanArea.Controls.Add(this.textBox4, 0, 1);
            this.tblPanArea.Controls.Add(this.textBox5, 1, 1);
            this.tblPanArea.Controls.Add(this.textBox6, 2, 1);
            this.tblPanArea.Controls.Add(this.textBox7, 3, 1);
            this.tblPanArea.Controls.Add(this.textBox8, 0, 2);
            this.tblPanArea.Controls.Add(this.textBox9, 1, 2);
            this.tblPanArea.Controls.Add(this.textBox10, 2, 2);
            this.tblPanArea.Controls.Add(this.textBox11, 3, 2);
            this.tblPanArea.Controls.Add(this.textBox13, 1, 3);
            this.tblPanArea.Controls.Add(this.textBox14, 2, 3);
            this.tblPanArea.Controls.Add(this.textBox15, 3, 3);
            this.tblPanArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPanArea.Location = new System.Drawing.Point(3, 119);
            this.tblPanArea.Name = "tblPanArea";
            this.tblPanArea.RowCount = 4;
            this.tblPanArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblPanArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblPanArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblPanArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblPanArea.Size = new System.Drawing.Size(268, 268);
            this.tblPanArea.TabIndex = 64;
            // 
            // textBox12
            // 
            this.textBox12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F);
            this.textBox12.Location = new System.Drawing.Point(3, 204);
            this.textBox12.MaxLength = 2;
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(61, 61);
            this.textBox12.TabIndex = 77;
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox12.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox12.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBox0
            // 
            this.textBox0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox0.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F);
            this.textBox0.Location = new System.Drawing.Point(3, 3);
            this.textBox0.MaxLength = 2;
            this.textBox0.Multiline = true;
            this.textBox0.Name = "textBox0";
            this.textBox0.ShortcutsEnabled = false;
            this.textBox0.Size = new System.Drawing.Size(61, 61);
            this.textBox0.TabIndex = 65;
            this.textBox0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox0.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F);
            this.textBox3.Location = new System.Drawing.Point(204, 3);
            this.textBox3.MaxLength = 2;
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(61, 61);
            this.textBox3.TabIndex = 68;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F);
            this.textBox1.Location = new System.Drawing.Point(70, 3);
            this.textBox1.MaxLength = 2;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(61, 61);
            this.textBox1.TabIndex = 66;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F);
            this.textBox2.Location = new System.Drawing.Point(137, 3);
            this.textBox2.MaxLength = 2;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(61, 61);
            this.textBox2.TabIndex = 67;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F);
            this.textBox4.Location = new System.Drawing.Point(3, 70);
            this.textBox4.MaxLength = 2;
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(61, 61);
            this.textBox4.TabIndex = 69;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBox5
            // 
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F);
            this.textBox5.Location = new System.Drawing.Point(70, 70);
            this.textBox5.MaxLength = 2;
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(61, 61);
            this.textBox5.TabIndex = 70;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBox6
            // 
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F);
            this.textBox6.Location = new System.Drawing.Point(137, 70);
            this.textBox6.MaxLength = 2;
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(61, 61);
            this.textBox6.TabIndex = 71;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBox7
            // 
            this.textBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F);
            this.textBox7.Location = new System.Drawing.Point(204, 70);
            this.textBox7.MaxLength = 2;
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(61, 61);
            this.textBox7.TabIndex = 72;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBox8
            // 
            this.textBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F);
            this.textBox8.Location = new System.Drawing.Point(3, 137);
            this.textBox8.MaxLength = 2;
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(61, 61);
            this.textBox8.TabIndex = 73;
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBox9
            // 
            this.textBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F);
            this.textBox9.Location = new System.Drawing.Point(70, 137);
            this.textBox9.MaxLength = 2;
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(61, 61);
            this.textBox9.TabIndex = 74;
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBox10
            // 
            this.textBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F);
            this.textBox10.Location = new System.Drawing.Point(137, 137);
            this.textBox10.MaxLength = 2;
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(61, 61);
            this.textBox10.TabIndex = 75;
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox10.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBox11
            // 
            this.textBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F);
            this.textBox11.Location = new System.Drawing.Point(204, 137);
            this.textBox11.MaxLength = 2;
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(61, 61);
            this.textBox11.TabIndex = 76;
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox11.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox11.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBox13
            // 
            this.textBox13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F);
            this.textBox13.Location = new System.Drawing.Point(70, 204);
            this.textBox13.MaxLength = 2;
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(61, 61);
            this.textBox13.TabIndex = 78;
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox13.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox13.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBox14
            // 
            this.textBox14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F);
            this.textBox14.Location = new System.Drawing.Point(137, 204);
            this.textBox14.MaxLength = 2;
            this.textBox14.Multiline = true;
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(61, 61);
            this.textBox14.TabIndex = 79;
            this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox14.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox14.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBox15
            // 
            this.textBox15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F);
            this.textBox15.Location = new System.Drawing.Point(204, 204);
            this.textBox15.MaxLength = 2;
            this.textBox15.Multiline = true;
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(61, 61);
            this.textBox15.TabIndex = 80;
            this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox15.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox15.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // tblLtPanFrmGame
            // 
            this.tblLtPanFrmGame.ColumnCount = 2;
            this.tblLtPanFrmGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLtPanFrmGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLtPanFrmGame.Controls.Add(this.tblPanProg, 0, 0);
            this.tblLtPanFrmGame.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tblLtPanFrmGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLtPanFrmGame.Location = new System.Drawing.Point(0, 0);
            this.tblLtPanFrmGame.Name = "tblLtPanFrmGame";
            this.tblLtPanFrmGame.RowCount = 1;
            this.tblLtPanFrmGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLtPanFrmGame.Size = new System.Drawing.Size(560, 396);
            this.tblLtPanFrmGame.TabIndex = 65;
            // 
            // tblPanProg
            // 
            this.tblPanProg.ColumnCount = 1;
            this.tblPanProg.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanProg.Controls.Add(this.lblProg, 0, 0);
            this.tblPanProg.Controls.Add(this.tblPanArea, 0, 2);
            this.tblPanProg.Controls.Add(this.lblTimer, 0, 1);
            this.tblPanProg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPanProg.Location = new System.Drawing.Point(3, 3);
            this.tblPanProg.Name = "tblPanProg";
            this.tblPanProg.RowCount = 3;
            this.tblPanProg.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tblPanProg.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tblPanProg.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblPanProg.Size = new System.Drawing.Size(274, 390);
            this.tblPanProg.TabIndex = 66;
            // 
            // lblTimer
            // 
            this.lblTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.lblTimer.Location = new System.Drawing.Point(3, 62);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(268, 54);
            this.lblTimer.TabIndex = 65;
            this.lblTimer.Text = "00:00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tblPanProblms, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(283, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.3038F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.67089F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(274, 390);
            this.tableLayoutPanel3.TabIndex = 67;
            // 
            // tblPanProblms
            // 
            this.tblPanProblms.ColumnCount = 3;
            this.tblPanProblms.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblPanProblms.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblPanProblms.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblPanProblms.Controls.Add(this.label2, 2, 0);
            this.tblPanProblms.Controls.Add(this.label5, 2, 1);
            this.tblPanProblms.Controls.Add(this.label7, 1, 2);
            this.tblPanProblms.Controls.Add(this.label0, 0, 0);
            this.tblPanProblms.Controls.Add(this.label1, 1, 0);
            this.tblPanProblms.Controls.Add(this.label3, 0, 1);
            this.tblPanProblms.Controls.Add(this.label4, 1, 1);
            this.tblPanProblms.Controls.Add(this.label6, 0, 2);
            this.tblPanProblms.Controls.Add(this.label8, 2, 2);
            this.tblPanProblms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPanProblms.Location = new System.Drawing.Point(3, 3);
            this.tblPanProblms.Name = "tblPanProblms";
            this.tblPanProblms.RowCount = 3;
            this.tblPanProblms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblPanProblms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblPanProblms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblPanProblms.Size = new System.Drawing.Size(268, 167);
            this.tblPanProblms.TabIndex = 66;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btRet_v_Next, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 249);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.27778F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.72222F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(268, 138);
            this.tableLayoutPanel4.TabIndex = 66;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.65289F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.34711F));
            this.tableLayoutPanel5.Controls.Add(this.btChk, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btRestart, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(262, 84);
            this.tableLayoutPanel5.TabIndex = 67;
            // 
            // tGame
            // 
            this.tGame.Interval = 1000;
            this.tGame.Tick += new System.EventHandler(this.tGame_Tick);
            // 
            // FrmGame
            // 
            this.AcceptButton = this.btChk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(560, 396);
            this.Controls.Add(this.tblLtPanFrmGame);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(536, 381);
            this.Name = "FrmGame";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KenKen Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmGame_FormClosed);
            this.Load += new System.EventHandler(this.FrmGame_Load);
            this.SizeChanged += new System.EventHandler(this.FrmGame_SizeChanged);
            this.tblPanArea.ResumeLayout(false);
            this.tblPanArea.PerformLayout();
            this.tblLtPanFrmGame.ResumeLayout(false);
            this.tblPanProg.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tblPanProblms.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tLoad;
        private System.Windows.Forms.Timer tError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Button btChk;
        private System.Windows.Forms.Button btRestart;
        private System.Windows.Forms.Button btRet_v_Next;
        private System.Windows.Forms.Label lblProg;
        private System.Windows.Forms.TableLayoutPanel tblPanArea;
        private System.Windows.Forms.TextBox textBox0;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TableLayoutPanel tblLtPanFrmGame;
        private System.Windows.Forms.TableLayoutPanel tblPanProg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TableLayoutPanel tblPanProblms;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer tGame;
    }
}

