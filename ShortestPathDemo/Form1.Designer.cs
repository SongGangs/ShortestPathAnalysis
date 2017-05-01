namespace ShortestPathDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Openfile = new System.Windows.Forms.Panel();
            this.Btu_OpenFile = new System.Windows.Forms.Button();
            this.Txt_FileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Tools = new System.Windows.Forms.Panel();
            this.Btu_ShortestPath = new System.Windows.Forms.Button();
            this.Btu_Load = new System.Windows.Forms.Button();
            this.panel_Draw = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_Openfile.SuspendLayout();
            this.panel_Tools.SuspendLayout();
            this.panel_Draw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Openfile
            // 
            this.panel_Openfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Openfile.Controls.Add(this.Btu_OpenFile);
            this.panel_Openfile.Controls.Add(this.Txt_FileName);
            this.panel_Openfile.Controls.Add(this.label1);
            this.panel_Openfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Openfile.Location = new System.Drawing.Point(0, 0);
            this.panel_Openfile.Name = "panel_Openfile";
            this.panel_Openfile.Size = new System.Drawing.Size(801, 64);
            this.panel_Openfile.TabIndex = 0;
            // 
            // Btu_OpenFile
            // 
            this.Btu_OpenFile.Location = new System.Drawing.Point(699, 20);
            this.Btu_OpenFile.Name = "Btu_OpenFile";
            this.Btu_OpenFile.Size = new System.Drawing.Size(75, 30);
            this.Btu_OpenFile.TabIndex = 2;
            this.Btu_OpenFile.Text = "打 开";
            this.Btu_OpenFile.UseVisualStyleBackColor = true;
            this.Btu_OpenFile.Click += new System.EventHandler(this.Btu_OpenFile_Click);
            // 
            // Txt_FileName
            // 
            this.Txt_FileName.Location = new System.Drawing.Point(164, 20);
            this.Txt_FileName.Name = "Txt_FileName";
            this.Txt_FileName.ReadOnly = true;
            this.Txt_FileName.Size = new System.Drawing.Size(501, 25);
            this.Txt_FileName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "文件读取:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Tools
            // 
            this.panel_Tools.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Tools.Controls.Add(this.Btu_ShortestPath);
            this.panel_Tools.Controls.Add(this.Btu_Load);
            this.panel_Tools.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Tools.Location = new System.Drawing.Point(0, 64);
            this.panel_Tools.Name = "panel_Tools";
            this.panel_Tools.Size = new System.Drawing.Size(118, 569);
            this.panel_Tools.TabIndex = 1;
            // 
            // Btu_ShortestPath
            // 
            this.Btu_ShortestPath.Location = new System.Drawing.Point(13, 358);
            this.Btu_ShortestPath.Name = "Btu_ShortestPath";
            this.Btu_ShortestPath.Size = new System.Drawing.Size(82, 30);
            this.Btu_ShortestPath.TabIndex = 3;
            this.Btu_ShortestPath.Text = "计 算";
            this.Btu_ShortestPath.UseVisualStyleBackColor = true;
            this.Btu_ShortestPath.Click += new System.EventHandler(this.Btu_ShortestPath_Click);
            // 
            // Btu_Load
            // 
            this.Btu_Load.Location = new System.Drawing.Point(12, 64);
            this.Btu_Load.Name = "Btu_Load";
            this.Btu_Load.Size = new System.Drawing.Size(82, 30);
            this.Btu_Load.TabIndex = 0;
            this.Btu_Load.Text = "加 载";
            this.Btu_Load.UseVisualStyleBackColor = true;
            this.Btu_Load.Click += new System.EventHandler(this.Btu_Load_Click);
            // 
            // panel_Draw
            // 
            this.panel_Draw.Controls.Add(this.pictureBox1);
            this.panel_Draw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Draw.Location = new System.Drawing.Point(0, 0);
            this.panel_Draw.Name = "panel_Draw";
            this.panel_Draw.Size = new System.Drawing.Size(1248, 633);
            this.panel_Draw.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1248, 633);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(801, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(447, 633);
            this.panel4.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.richTextBox);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 45);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(447, 588);
            this.panel6.TabIndex = 2;
            // 
            // richTextBox
            // 
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Location = new System.Drawing.Point(0, 0);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(447, 588);
            this.richTextBox.TabIndex = 1;
            this.richTextBox.Text = "";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(447, 45);
            this.panel5.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(447, 45);
            this.label2.TabIndex = 0;
            this.label2.Text = "结 果 记 录";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 633);
            this.Controls.Add(this.panel_Tools);
            this.Controls.Add(this.panel_Openfile);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel_Draw);
            this.Name = "Form1";
            this.Text = "最短路径";
            this.panel_Openfile.ResumeLayout(false);
            this.panel_Openfile.PerformLayout();
            this.panel_Tools.ResumeLayout(false);
            this.panel_Draw.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Openfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Tools;
        private System.Windows.Forms.Panel panel_Draw;
        private System.Windows.Forms.Button Btu_OpenFile;
        private System.Windows.Forms.TextBox Txt_FileName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button Btu_Load;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btu_ShortestPath;
    }
}

