namespace RoslynCodeDOM_OOKP_WinForm
{
    partial class FMain
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.xml_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.compile_name_box = new System.Windows.Forms.TextBox();
            this.framework_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.values_num = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Xpath_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Gen_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.values_num)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Parse and close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.xml_box);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.compile_name_box);
            this.groupBox1.Controls.Add(this.framework_box);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 123);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "System Settings";
            // 
            // xml_box
            // 
            this.xml_box.Location = new System.Drawing.Point(67, 93);
            this.xml_box.Name = "xml_box";
            this.xml_box.Size = new System.Drawing.Size(107, 20);
            this.xml_box.TabIndex = 5;
            this.xml_box.Text = "xmldata.xml";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "XML name:";
            // 
            // compile_name_box
            // 
            this.compile_name_box.Location = new System.Drawing.Point(91, 61);
            this.compile_name_box.Name = "compile_name_box";
            this.compile_name_box.Size = new System.Drawing.Size(83, 20);
            this.compile_name_box.TabIndex = 3;
            this.compile_name_box.Text = "App.exe";
            // 
            // framework_box
            // 
            this.framework_box.Location = new System.Drawing.Point(68, 24);
            this.framework_box.Name = "framework_box";
            this.framework_box.Size = new System.Drawing.Size(106, 20);
            this.framework_box.TabIndex = 2;
            this.framework_box.Text = "v4.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Compile name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Framework:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.values_num);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.Xpath_txt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(199, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 262);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "HTML Parse Settings";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(241, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 20);
            this.textBox1.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(179, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "ADD";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // values_num
            // 
            this.values_num.Location = new System.Drawing.Point(53, 153);
            this.values_num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.values_num.Name = "values_num";
            this.values_num.Size = new System.Drawing.Size(120, 20);
            this.values_num.TabIndex = 8;
            this.values_num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Values:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(47, 17);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(445, 121);
            this.listBox1.TabIndex = 6;
            // 
            // Xpath_txt
            // 
            this.Xpath_txt.Location = new System.Drawing.Point(47, 191);
            this.Xpath_txt.Multiline = true;
            this.Xpath_txt.Name = "Xpath_txt";
            this.Xpath_txt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Xpath_txt.Size = new System.Drawing.Size(445, 65);
            this.Xpath_txt.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Path:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "HTML:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 317);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(858, 395);
            this.textBox2.TabIndex = 4;
            // 
            // Gen_btn
            // 
            this.Gen_btn.Location = new System.Drawing.Point(3, 288);
            this.Gen_btn.Name = "Gen_btn";
            this.Gen_btn.Size = new System.Drawing.Size(94, 23);
            this.Gen_btn.TabIndex = 5;
            this.Gen_btn.Text = "Genarate";
            this.Gen_btn.UseVisualStyleBackColor = true;
            this.Gen_btn.Click += new System.EventHandler(this.Gen_btn_Click);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 715);
            this.Controls.Add(this.Gen_btn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "FMain";
            this.Text = "Code Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.values_num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox xml_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox compile_name_box;
        private System.Windows.Forms.TextBox framework_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Xpath_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown values_num;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Gen_btn;
    }
}

