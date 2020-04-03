namespace CayleyTree
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.depth = new System.Windows.Forms.TextBox();
            this.length = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rightper = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.leftper = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rigthth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.leftph = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.drawingColor = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(529, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "递归深度：";
            // 
            // depth
            // 
            this.depth.Location = new System.Drawing.Point(605, 119);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(100, 25);
            this.depth.TabIndex = 1;
            // 
            // length
            // 
            this.length.Location = new System.Drawing.Point(605, 150);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(100, 25);
            this.length.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(529, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "主干长度：";
            // 
            // rightper
            // 
            this.rightper.Location = new System.Drawing.Point(605, 181);
            this.rightper.Name = "rightper";
            this.rightper.Size = new System.Drawing.Size(100, 25);
            this.rightper.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(499, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "右分支长度比：";
            // 
            // leftper
            // 
            this.leftper.Location = new System.Drawing.Point(605, 212);
            this.leftper.Name = "leftper";
            this.leftper.Size = new System.Drawing.Size(100, 25);
            this.leftper.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(499, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "左分支长度比：";
            // 
            // rigthth
            // 
            this.rigthth.Location = new System.Drawing.Point(605, 243);
            this.rigthth.Name = "rigthth";
            this.rigthth.Size = new System.Drawing.Size(100, 25);
            this.rigthth.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(514, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "右分支角度：";
            // 
            // leftph
            // 
            this.leftph.Location = new System.Drawing.Point(605, 274);
            this.leftph.Name = "leftph";
            this.leftph.Size = new System.Drawing.Size(100, 25);
            this.leftph.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(514, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "左分支角度：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(517, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "画笔颜色：";
            // 
            // drawingColor
            // 
            this.drawingColor.FormattingEnabled = true;
            this.drawingColor.Items.AddRange(new object[] {
            "黑色",
            "蓝色",
            "绿色",
            "红色"});
            this.drawingColor.Location = new System.Drawing.Point(605, 305);
            this.drawingColor.Name = "drawingColor";
            this.drawingColor.Size = new System.Drawing.Size(121, 23);
            this.drawingColor.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(614, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.drawbutton_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 425);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.drawingColor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.leftph);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rigthth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.leftper);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rightper);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.length);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.depth);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox depth;
        private System.Windows.Forms.TextBox length;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rightper;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox leftper;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rigthth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox leftph;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox drawingColor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}

