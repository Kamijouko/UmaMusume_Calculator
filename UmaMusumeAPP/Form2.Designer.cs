namespace UmaMusumeAPP
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.CheckBoxTABC = new umaCalculatorConctolLibs.labelLibs();
            this.CheckBoxTAALLAmax = new umaCalculatorConctolLibs.labelLibs();
            this.CheckBoxTAALLAmin = new umaCalculatorConctolLibs.labelLibs();
            this.CheckBoxTBorCmax = new umaCalculatorConctolLibs.labelLibs();
            this.CheckBoxTBorCmin = new umaCalculatorConctolLibs.labelLibs();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Reset1 = new umaCalculatorConctolLibs.buttonLibs();
            this.Reset2 = new umaCalculatorConctolLibs.buttonLibs();
            this.Reset3 = new umaCalculatorConctolLibs.buttonLibs();
            this.Reset4 = new umaCalculatorConctolLibs.buttonLibs();
            this.Reset5 = new umaCalculatorConctolLibs.buttonLibs();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // CheckBoxTABC
            // 
            this.CheckBoxTABC.AutoSize = true;
            this.CheckBoxTABC.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CheckBoxTABC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBoxTABC.Font = new System.Drawing.Font("微软雅黑", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxTABC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CheckBoxTABC.Location = new System.Drawing.Point(13, 53);
            this.CheckBoxTABC.Name = "CheckBoxTABC";
            this.CheckBoxTABC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CheckBoxTABC.Size = new System.Drawing.Size(170, 26);
            this.CheckBoxTABC.TabIndex = 22;
            this.CheckBoxTABC.Text = "第一世代之和 阈值";
            this.ToolTip1.SetToolTip(this.CheckBoxTABC, "设置第一世代的相性和在多少以上保留，\r\n第一世代相性和为1和2，1和3的相性相加。\r\n50适用与大部分马，\r\n但对于与大部分马娘的第一世代和最高只在\r\n46左右的" +
        "真机伶来说，建议设置为45.");
            // 
            // CheckBoxTAALLAmax
            // 
            this.CheckBoxTAALLAmax.AutoSize = true;
            this.CheckBoxTAALLAmax.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CheckBoxTAALLAmax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBoxTAALLAmax.Font = new System.Drawing.Font("微软雅黑", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxTAALLAmax.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CheckBoxTAALLAmax.Location = new System.Drawing.Point(13, 99);
            this.CheckBoxTAALLAmax.Name = "CheckBoxTAALLAmax";
            this.CheckBoxTAALLAmax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CheckBoxTAALLAmax.Size = new System.Drawing.Size(170, 26);
            this.CheckBoxTAALLAmax.TabIndex = 23;
            this.CheckBoxTAALLAmax.Text = "主要平均最大 阈值";
            this.ToolTip1.SetToolTip(this.CheckBoxTAALLAmax, "设置主要平均值范围的最大值，\r\n主要平均值指1对于2、3、4、5、6、7的相性相加后的平均值\r\n与下面的主要平均最小值联合形成一个区间，\r\n此值设定主要平均一般来" +
        "说应该在多少为正常\r\n此值不可小于下面的主要平均最小。\r\n25可稳定作用于所有马娘");
            // 
            // CheckBoxTAALLAmin
            // 
            this.CheckBoxTAALLAmin.AutoSize = true;
            this.CheckBoxTAALLAmin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CheckBoxTAALLAmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBoxTAALLAmin.Font = new System.Drawing.Font("微软雅黑", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxTAALLAmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CheckBoxTAALLAmin.Location = new System.Drawing.Point(13, 144);
            this.CheckBoxTAALLAmin.Name = "CheckBoxTAALLAmin";
            this.CheckBoxTAALLAmin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CheckBoxTAALLAmin.Size = new System.Drawing.Size(170, 26);
            this.CheckBoxTAALLAmin.TabIndex = 24;
            this.CheckBoxTAALLAmin.Text = "主要平均最小 阈值";
            this.ToolTip1.SetToolTip(this.CheckBoxTAALLAmin, "设置主要平均值的最小值，\r\n主要平均值即1与2、3、4、5、6、7的相性相加后的平均\r\n这里设置的最小值与上面的最大值形成一个区间，\r\n此值设定主要平均最小也应该" +
        "在多少以上才保留\r\n此值不可大于主要平均最大值。");
            // 
            // CheckBoxTBorCmax
            // 
            this.CheckBoxTBorCmax.AutoSize = true;
            this.CheckBoxTBorCmax.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CheckBoxTBorCmax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBoxTBorCmax.Font = new System.Drawing.Font("微软雅黑", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxTBorCmax.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CheckBoxTBorCmax.Location = new System.Drawing.Point(13, 191);
            this.CheckBoxTBorCmax.Name = "CheckBoxTBorCmax";
            this.CheckBoxTBorCmax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CheckBoxTBorCmax.Size = new System.Drawing.Size(170, 26);
            this.CheckBoxTBorCmax.TabIndex = 25;
            this.CheckBoxTBorCmax.Text = "二世代和最大 阈值";
            this.ToolTip1.SetToolTip(this.CheckBoxTBorCmax, "设置二世代和的最大值，\r\n二世代和指父母辈的马娘对与爷爷奶奶辈的相性值之和\r\n即2对于4、5的相性之和或3对于6、7的相性之和\r\n此值设定二世代和的其中一方应该在" +
        "多少以上\r\n与下方的二世代和最小形成一个区间。\r\n此值不可小于下方的二世代和最小。");
            // 
            // CheckBoxTBorCmin
            // 
            this.CheckBoxTBorCmin.AutoSize = true;
            this.CheckBoxTBorCmin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CheckBoxTBorCmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBoxTBorCmin.Font = new System.Drawing.Font("微软雅黑", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxTBorCmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CheckBoxTBorCmin.Location = new System.Drawing.Point(13, 237);
            this.CheckBoxTBorCmin.Name = "CheckBoxTBorCmin";
            this.CheckBoxTBorCmin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CheckBoxTBorCmin.Size = new System.Drawing.Size(170, 26);
            this.CheckBoxTBorCmin.TabIndex = 26;
            this.CheckBoxTBorCmin.Text = "二世代和最小 阈值";
            this.ToolTip1.SetToolTip(this.CheckBoxTBorCmin, "设置二世代和的最小值，\r\n二世代和指父母辈的马娘对与爷爷奶奶辈的相性值之和\r\n即2对于4、5的相性之和或3对于6、7的相性之和\r\n此值设定二世代和最小应该在多少以" +
        "上\r\n与上方的二世代和最大形成一个区间。\r\n此值不可大于上方的二世代和最大。\r\n");
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(195, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(52, 27);
            this.textBox1.TabIndex = 27;
            this.textBox1.Text = "50";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox2.Location = new System.Drawing.Point(195, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(52, 27);
            this.textBox2.TabIndex = 28;
            this.textBox2.Text = "25";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox3.Location = new System.Drawing.Point(195, 144);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(52, 27);
            this.textBox3.TabIndex = 29;
            this.textBox3.Text = "20";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox4.Location = new System.Drawing.Point(195, 191);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(52, 27);
            this.textBox4.TabIndex = 30;
            this.textBox4.Text = "45";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox5.Location = new System.Drawing.Point(195, 237);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(52, 27);
            this.textBox5.TabIndex = 31;
            this.textBox5.Text = "40";
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // Reset1
            // 
            this.Reset1.BackColor = System.Drawing.Color.Navy;
            this.Reset1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset1.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Reset1.Location = new System.Drawing.Point(258, 51);
            this.Reset1.Name = "Reset1";
            this.Reset1.Size = new System.Drawing.Size(32, 30);
            this.Reset1.TabIndex = 32;
            this.Reset1.Text = "X";
            this.ToolTip1.SetToolTip(this.Reset1, "重置为默认值");
            this.Reset1.UseVisualStyleBackColor = false;
            this.Reset1.Click += new System.EventHandler(this.Reset1_Click);
            // 
            // Reset2
            // 
            this.Reset2.BackColor = System.Drawing.Color.Navy;
            this.Reset2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset2.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Reset2.Location = new System.Drawing.Point(258, 97);
            this.Reset2.Name = "Reset2";
            this.Reset2.Size = new System.Drawing.Size(32, 30);
            this.Reset2.TabIndex = 33;
            this.Reset2.Text = "X";
            this.ToolTip1.SetToolTip(this.Reset2, "重置为默认值");
            this.Reset2.UseVisualStyleBackColor = false;
            this.Reset2.Click += new System.EventHandler(this.Reset2_Click);
            // 
            // Reset3
            // 
            this.Reset3.BackColor = System.Drawing.Color.Navy;
            this.Reset3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset3.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Reset3.Location = new System.Drawing.Point(258, 144);
            this.Reset3.Name = "Reset3";
            this.Reset3.Size = new System.Drawing.Size(32, 30);
            this.Reset3.TabIndex = 34;
            this.Reset3.Text = "X";
            this.ToolTip1.SetToolTip(this.Reset3, "重置为默认值");
            this.Reset3.UseVisualStyleBackColor = false;
            this.Reset3.Click += new System.EventHandler(this.Reset3_Click);
            // 
            // Reset4
            // 
            this.Reset4.BackColor = System.Drawing.Color.Navy;
            this.Reset4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset4.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset4.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Reset4.Location = new System.Drawing.Point(258, 190);
            this.Reset4.Name = "Reset4";
            this.Reset4.Size = new System.Drawing.Size(32, 30);
            this.Reset4.TabIndex = 35;
            this.Reset4.Text = "X";
            this.ToolTip1.SetToolTip(this.Reset4, "重置为默认值");
            this.Reset4.UseVisualStyleBackColor = false;
            this.Reset4.Click += new System.EventHandler(this.Reset4_Click);
            // 
            // Reset5
            // 
            this.Reset5.BackColor = System.Drawing.Color.Navy;
            this.Reset5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset5.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset5.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Reset5.Location = new System.Drawing.Point(258, 236);
            this.Reset5.Name = "Reset5";
            this.Reset5.Size = new System.Drawing.Size(32, 30);
            this.Reset5.TabIndex = 36;
            this.Reset5.Text = "X";
            this.ToolTip1.SetToolTip(this.Reset5, "重置为默认值");
            this.Reset5.UseVisualStyleBackColor = false;
            this.Reset5.Click += new System.EventHandler(this.Reset5_Click);
            // 
            // ToolTip1
            // 
            this.ToolTip1.AutomaticDelay = 20000;
            this.ToolTip1.AutoPopDelay = 20000;
            this.ToolTip1.InitialDelay = 50;
            this.ToolTip1.IsBalloon = true;
            this.ToolTip1.ReshowDelay = 20;
            this.ToolTip1.ShowAlways = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(304, 279);
            this.Controls.Add(this.Reset5);
            this.Controls.Add(this.Reset4);
            this.Controls.Add(this.Reset3);
            this.Controls.Add(this.Reset2);
            this.Controls.Add(this.Reset1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CheckBoxTBorCmin);
            this.Controls.Add(this.CheckBoxTBorCmax);
            this.Controls.Add(this.CheckBoxTAALLAmin);
            this.Controls.Add(this.CheckBoxTAALLAmax);
            this.Controls.Add(this.CheckBoxTABC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "二世代 模式一 阈值设置";
            this.ToolTip1.SetToolTip(this, "设置模式一计算时的阈值，将鼠标放在阈值名称上有\r\n详细说明。此窗口即使关闭已设置数值也会保留，但\r\n重启应用后数值会返回默认值。\r\n默认值可作用与99%的情况（除" +
        "非数据更新）\r\n阈值不支持小数。");
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public umaCalculatorConctolLibs.labelLibs CheckBoxTABC;
        public umaCalculatorConctolLibs.labelLibs CheckBoxTAALLAmax;
        public umaCalculatorConctolLibs.labelLibs CheckBoxTAALLAmin;
        public umaCalculatorConctolLibs.labelLibs CheckBoxTBorCmax;
        public umaCalculatorConctolLibs.labelLibs CheckBoxTBorCmin;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.TextBox textBox5;
        private umaCalculatorConctolLibs.buttonLibs Reset1;
        private umaCalculatorConctolLibs.buttonLibs Reset2;
        private umaCalculatorConctolLibs.buttonLibs Reset3;
        private umaCalculatorConctolLibs.buttonLibs Reset4;
        private umaCalculatorConctolLibs.buttonLibs Reset5;
        private System.Windows.Forms.ToolTip ToolTip1;
    }
}