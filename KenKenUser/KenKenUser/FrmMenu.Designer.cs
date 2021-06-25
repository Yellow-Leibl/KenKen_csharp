namespace KenKenUser
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btOpenFile = new System.Windows.Forms.Button();
            this.tLoad = new System.Windows.Forms.Timer(this.components);
            this.btChrmiss = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.btLeaders = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(12, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(308, 345);
            this.listBox1.TabIndex = 45;
            this.toolTip1.SetToolTip(this.listBox1, "Подвійний клік миші,\r\nщоб завантажити рівень");
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "KenKen Files(*.pken)|*.pken|All files(*.*)|*.*";
            // 
            // btOpenFile
            // 
            this.btOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btOpenFile.Location = new System.Drawing.Point(195, 299);
            this.btOpenFile.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btOpenFile.Name = "btOpenFile";
            this.btOpenFile.Size = new System.Drawing.Size(125, 51);
            this.btOpenFile.TabIndex = 50;
            this.btOpenFile.Text = "Відкрити";
            this.toolTip1.SetToolTip(this.btOpenFile, "Открыть пользовательский\r\nуровень");
            this.btOpenFile.UseVisualStyleBackColor = true;
            this.btOpenFile.Click += new System.EventHandler(this.btOpenFile_Click);
            // 
            // tLoad
            // 
            this.tLoad.Interval = 25;
            this.tLoad.Tick += new System.EventHandler(this.tLoad_Tick);
            // 
            // btChrmiss
            // 
            this.btChrmiss.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.btChrmiss.Location = new System.Drawing.Point(329, 5);
            this.btChrmiss.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btChrmiss.Name = "btChrmiss";
            this.btChrmiss.Size = new System.Drawing.Size(158, 103);
            this.btChrmiss.TabIndex = 51;
            this.btChrmiss.Text = "Випадковий рівень";
            this.btChrmiss.UseVisualStyleBackColor = true;
            this.btChrmiss.Click += new System.EventHandler(this.btChrmiss_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.White;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menEditor,
            this.About});
            this.menuStrip1.Location = new System.Drawing.Point(0, 360);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(493, 29);
            this.menuStrip1.TabIndex = 52;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menEditor
            // 
            this.menEditor.Name = "menEditor";
            this.menEditor.Size = new System.Drawing.Size(89, 25);
            this.menEditor.Text = "Редактор";
            this.menEditor.Click += new System.EventHandler(this.menEditor_Click);
            // 
            // About
            // 
            this.About.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(124, 25);
            this.About.Text = "Про програму";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // btLeaders
            // 
            this.btLeaders.BackgroundImage = global::KenKenUser.Properties.Resources.kubok;
            this.btLeaders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btLeaders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btLeaders.Location = new System.Drawing.Point(329, 202);
            this.btLeaders.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btLeaders.Name = "btLeaders";
            this.btLeaders.Size = new System.Drawing.Size(158, 148);
            this.btLeaders.TabIndex = 53;
            this.btLeaders.Text = "Таблиця Часів";
            this.btLeaders.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btLeaders.UseVisualStyleBackColor = true;
            this.btLeaders.Click += new System.EventHandler(this.btLeaders_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 389);
            this.Controls.Add(this.btLeaders);
            this.Controls.Add(this.btChrmiss);
            this.Controls.Add(this.btOpenFile);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenu";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KenKen Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMenu_FormClosed);
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btOpenFile;
        private System.Windows.Forms.Timer tLoad;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btChrmiss;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.ToolStripMenuItem menEditor;
        private System.Windows.Forms.Button btLeaders;
    }
}