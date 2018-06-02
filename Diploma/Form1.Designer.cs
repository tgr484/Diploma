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
            this.tb_length = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_load = new System.Windows.Forms.Button();
            this.button_create_cutting_single = new System.Windows.Forms.Button();
            this.tabControl_Type = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_create_cutting_best = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_length_B = new System.Windows.Forms.TextBox();
            this.tb_length_A = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dg_input = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_best = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dg_output = new System.Windows.Forms.DataGridView();
            this.labelCoef = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Column_l = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl_Type.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_input)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_output)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_length
            // 
            this.tb_length.Location = new System.Drawing.Point(36, 24);
            this.tb_length.Name = "tb_length";
            this.tb_length.Size = new System.Drawing.Size(70, 20);
            this.tb_length.TabIndex = 0;
            this.tb_length.Text = "0";
            this.tb_length.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_length.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Длина профиля";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_load
            // 
            this.button_load.Location = new System.Drawing.Point(41, 19);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(180, 23);
            this.button_load.TabIndex = 2;
            this.button_load.Text = "Загрузить заготовки из файла";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_create_cutting_single
            // 
            this.button_create_cutting_single.Location = new System.Drawing.Point(125, 15);
            this.button_create_cutting_single.Name = "button_create_cutting_single";
            this.button_create_cutting_single.Size = new System.Drawing.Size(96, 36);
            this.button_create_cutting_single.TabIndex = 3;
            this.button_create_cutting_single.Text = "Сформировать раскрой";
            this.button_create_cutting_single.UseVisualStyleBackColor = true;
            this.button_create_cutting_single.Click += new System.EventHandler(this.button_create_cutting_Click);
            // 
            // tabControl_Type
            // 
            this.tabControl_Type.Controls.Add(this.tabPage1);
            this.tabControl_Type.Controls.Add(this.tabPage2);
            this.tabControl_Type.Location = new System.Drawing.Point(12, 12);
            this.tabControl_Type.Name = "tabControl_Type";
            this.tabControl_Type.SelectedIndex = 0;
            this.tabControl_Type.Size = new System.Drawing.Size(514, 84);
            this.tabControl_Type.TabIndex = 7;
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
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
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
            this.button_create_cutting_best.Click += new System.EventHandler(this.button_create_cutting_best_Click);
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
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tb_length_B
            // 
            this.tb_length_B.Location = new System.Drawing.Point(140, 23);
            this.tb_length_B.Name = "tb_length_B";
            this.tb_length_B.Size = new System.Drawing.Size(70, 20);
            this.tb_length_B.TabIndex = 8;
            this.tb_length_B.Text = "1";
            this.tb_length_B.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_length_B.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_length_B_KeyPress);
            // 
            // tb_length_A
            // 
            this.tb_length_A.Location = new System.Drawing.Point(36, 23);
            this.tb_length_A.Name = "tb_length_A";
            this.tb_length_A.Size = new System.Drawing.Size(70, 20);
            this.tb_length_A.TabIndex = 8;
            this.tb_length_A.Text = "0";
            this.tb_length_A.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_length_A.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_length_A_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dg_input);
            this.groupBox1.Controls.Add(this.button_load);
            this.groupBox1.Location = new System.Drawing.Point(16, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 266);
            this.groupBox1.TabIndex = 8;
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
            this.dg_input.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_input_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_best);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dg_output);
            this.groupBox2.Controls.Add(this.labelCoef);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(276, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 266);
            this.groupBox2.TabIndex = 9;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 381);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl_Type);
            this.Name = "MainForm";
            this.Text = "Раскрой профиля";
            this.tabControl_Type.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_input)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_output)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_length;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.Button button_create_cutting_single;
        private System.Windows.Forms.TabControl tabControl_Type;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_length_B;
        private System.Windows.Forms.TextBox tb_length_A;
        private System.Windows.Forms.Button button_create_cutting_best;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dg_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCoef;
        private System.Windows.Forms.DataGridView dg_output;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_best;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_l;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_b;
    }
}

