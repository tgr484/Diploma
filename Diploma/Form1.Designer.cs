namespace Diploma
{
    partial class MainForm
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
            this.SelectTypeOfCutting = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_best = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dg_output = new System.Windows.Forms.DataGridView();
            this.labelCoef = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dg_input = new System.Windows.Forms.DataGridView();
            this.Column_l = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_load = new System.Windows.Forms.Button();
            this.tabControl_Type = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tb_length = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_create_cutting_single = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_create_cutting_best = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_length_B = new System.Windows.Forms.TextBox();
            this.tb_length_A = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dg_output2 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dg_input2 = new System.Windows.Forms.DataGridView();
            this.l = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.с = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button_create_cutting2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_w2 = new System.Windows.Forms.TextBox();
            this.tb_l2 = new System.Windows.Forms.TextBox();
            this.SelectTypeOfCutting.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_output)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_input)).BeginInit();
            this.tabControl_Type.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_output2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_input2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectTypeOfCutting
            // 
            this.SelectTypeOfCutting.Controls.Add(this.tabPage3);
            this.SelectTypeOfCutting.Controls.Add(this.tabPage4);
            this.SelectTypeOfCutting.Location = new System.Drawing.Point(12, 12);
            this.SelectTypeOfCutting.Name = "SelectTypeOfCutting";
            this.SelectTypeOfCutting.SelectedIndex = 0;
            this.SelectTypeOfCutting.Size = new System.Drawing.Size(792, 414);
            this.SelectTypeOfCutting.TabIndex = 10;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.tabControl_Type);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(784, 388);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Раскрой профиля";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_best);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dg_output);
            this.groupBox2.Controls.Add(this.labelCoef);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(270, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 266);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результат";
            // 
            // label_best
            // 
            this.label_best.AutoSize = true;
            this.label_best.Location = new System.Drawing.Point(143, 33);
            this.label_best.Name = "label_best";
            this.label_best.Size = new System.Drawing.Size(13, 13);
            this.label_best.TabIndex = 11;
            this.label_best.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Лучшая длина профиля:";
            // 
            // dg_output
            // 
            this.dg_output.AllowUserToAddRows = false;
            this.dg_output.AllowUserToDeleteRows = false;
            this.dg_output.AllowUserToOrderColumns = true;
            this.dg_output.AllowUserToResizeColumns = false;
            this.dg_output.AllowUserToResizeRows = false;
            this.dg_output.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_output.Location = new System.Drawing.Point(7, 54);
            this.dg_output.MultiSelect = false;
            this.dg_output.Name = "dg_output";
            this.dg_output.ReadOnly = true;
            this.dg_output.Size = new System.Drawing.Size(473, 206);
            this.dg_output.TabIndex = 9;
            // 
            // labelCoef
            // 
            this.labelCoef.AutoSize = true;
            this.labelCoef.Location = new System.Drawing.Point(120, 16);
            this.labelCoef.Name = "labelCoef";
            this.labelCoef.Size = new System.Drawing.Size(13, 13);
            this.labelCoef.TabIndex = 8;
            this.labelCoef.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Коэфициент раскроя:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dg_input);
            this.groupBox1.Controls.Add(this.button_load);
            this.groupBox1.Location = new System.Drawing.Point(10, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 266);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Входные данные";
            // 
            // dg_input
            // 
            this.dg_input.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_input.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_l,
            this.Column_b});
            this.dg_input.Location = new System.Drawing.Point(7, 54);
            this.dg_input.Name = "dg_input";
            this.dg_input.Size = new System.Drawing.Size(237, 206);
            this.dg_input.TabIndex = 3;
            // 
            // Column_l
            // 
            this.Column_l.HeaderText = "Длина заготовки";
            this.Column_l.Name = "Column_l";
            // 
            // Column_b
            // 
            this.Column_b.HeaderText = "Количество";
            this.Column_b.Name = "Column_b";
            // 
            // button_load
            // 
            this.button_load.Location = new System.Drawing.Point(41, 19);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(180, 23);
            this.button_load.TabIndex = 2;
            this.button_load.Text = "Загрузить заготовки из файла";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // tabControl_Type
            // 
            this.tabControl_Type.Controls.Add(this.tabPage1);
            this.tabControl_Type.Controls.Add(this.tabPage2);
            this.tabControl_Type.Location = new System.Drawing.Point(6, 6);
            this.tabControl_Type.Name = "tabControl_Type";
            this.tabControl_Type.SelectedIndex = 0;
            this.tabControl_Type.Size = new System.Drawing.Size(514, 84);
            this.tabControl_Type.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tb_length);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button_create_cutting_single);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(506, 58);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Один размер";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tb_length
            // 
            this.tb_length.Location = new System.Drawing.Point(36, 24);
            this.tb_length.Name = "tb_length";
            this.tb_length.Size = new System.Drawing.Size(70, 20);
            this.tb_length.TabIndex = 0;
            this.tb_length.Text = "0";
            this.tb_length.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Длина профиля";
            // 
            // button_create_cutting_single
            // 
            this.button_create_cutting_single.Location = new System.Drawing.Point(125, 15);
            this.button_create_cutting_single.Name = "button_create_cutting_single";
            this.button_create_cutting_single.Size = new System.Drawing.Size(96, 36);
            this.button_create_cutting_single.TabIndex = 3;
            this.button_create_cutting_single.Text = "Сформировать раскрой";
            this.button_create_cutting_single.UseVisualStyleBackColor = true;
            this.button_create_cutting_single.Click += new System.EventHandler(this.button_create_cutting_single_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_create_cutting_best);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.tb_length_B);
            this.tabPage2.Controls.Add(this.tb_length_A);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(506, 58);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Подбор лучшего размера";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_create_cutting_best
            // 
            this.button_create_cutting_best.Location = new System.Drawing.Point(216, 14);
            this.button_create_cutting_best.Name = "button_create_cutting_best";
            this.button_create_cutting_best.Size = new System.Drawing.Size(96, 36);
            this.button_create_cutting_best.TabIndex = 12;
            this.button_create_cutting_best.Text = "Сформировать раскрой";
            this.button_create_cutting_best.UseVisualStyleBackColor = true;
            this.button_create_cutting_best.Click += new System.EventHandler(this.button_create_cutting_best_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "До";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "От";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Интервал длины профиля";
            // 
            // tb_length_B
            // 
            this.tb_length_B.Location = new System.Drawing.Point(140, 23);
            this.tb_length_B.Name = "tb_length_B";
            this.tb_length_B.Size = new System.Drawing.Size(70, 20);
            this.tb_length_B.TabIndex = 8;
            this.tb_length_B.Text = "1";
            this.tb_length_B.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_length_A
            // 
            this.tb_length_A.Location = new System.Drawing.Point(36, 23);
            this.tb_length_A.Name = "tb_length_A";
            this.tb_length_A.Size = new System.Drawing.Size(70, 20);
            this.tb_length_A.TabIndex = 8;
            this.tb_length_A.Text = "0";
            this.tb_length_A.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Controls.Add(this.tabControl1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(784, 388);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Раскрой стеклопакета";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.dg_output2);
            this.groupBox4.Location = new System.Drawing.Point(406, 98);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(399, 241);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Результат";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(126, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Коэфициент раскроя";
            // 
            // dg_output2
            // 
            this.dg_output2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_output2.Location = new System.Drawing.Point(6, 60);
            this.dg_output2.Name = "dg_output2";
            this.dg_output2.Size = new System.Drawing.Size(366, 150);
            this.dg_output2.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dg_input2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(11, 98);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(379, 241);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Входные данные";
            // 
            // dg_input2
            // 
            this.dg_input2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_input2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.l,
            this.h,
            this.с});
            this.dg_input2.Location = new System.Drawing.Point(6, 60);
            this.dg_input2.Name = "dg_input2";
            this.dg_input2.Size = new System.Drawing.Size(349, 150);
            this.dg_input2.TabIndex = 1;
            // 
            // l
            // 
            this.l.HeaderText = "Длина";
            this.l.Name = "l";
            // 
            // h
            // 
            this.h.HeaderText = "Высота";
            this.h.Name = "h";
            // 
            // с
            // 
            this.с.HeaderText = "Количество";
            this.с.Name = "с";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Загрузить заготовки из файла";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(7, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(506, 84);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button_create_cutting2);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.tb_w2);
            this.tabPage5.Controls.Add(this.tb_l2);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(498, 58);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Один размер";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button_create_cutting2
            // 
            this.button_create_cutting2.Location = new System.Drawing.Point(236, 17);
            this.button_create_cutting2.Name = "button_create_cutting2";
            this.button_create_cutting2.Size = new System.Drawing.Size(96, 36);
            this.button_create_cutting2.TabIndex = 4;
            this.button_create_cutting2.Text = "Сформировать раскрой";
            this.button_create_cutting2.UseVisualStyleBackColor = true;
            this.button_create_cutting2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(127, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Высота";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Длина";
            // 
            // tb_w2
            // 
            this.textBox2.Location = new System.Drawing.Point(130, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_w2.Location = new System.Drawing.Point(130, 26);
            this.tb_w2.Name = "tb_w2";
            this.tb_w2.Size = new System.Drawing.Size(100, 20);
            this.tb_w2.TabIndex = 1;
            // 
            // tb_l2
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_l2.Location = new System.Drawing.Point(24, 26);
            this.tb_l2.Name = "tb_l2";
            this.tb_l2.Size = new System.Drawing.Size(100, 20);
            this.tb_l2.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 479);
            this.Controls.Add(this.SelectTypeOfCutting);
            this.Name = "MainForm";
            this.Text = "Раскройщик окон";
            this.SelectTypeOfCutting.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_output)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_input)).EndInit();
            this.tabControl_Type.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_output2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_input2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl SelectTypeOfCutting;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_best;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dg_output;
        private System.Windows.Forms.Label labelCoef;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dg_input;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_l;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_b;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.TabControl tabControl_Type;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tb_length;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_create_cutting_single;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button_create_cutting_best;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_length_B;
        private System.Windows.Forms.TextBox tb_length_A;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dg_input2;
        private System.Windows.Forms.Button button_create_cutting2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_w2;
        private System.Windows.Forms.TextBox tb_l2;
        private System.Windows.Forms.DataGridViewTextBoxColumn l;
        private System.Windows.Forms.DataGridViewTextBoxColumn h;
        private System.Windows.Forms.DataGridViewTextBoxColumn с;
        private System.Windows.Forms.DataGridView dg_output2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

