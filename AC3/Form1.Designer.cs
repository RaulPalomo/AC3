﻿namespace AC3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(70, 98);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(233, 98);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(397, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 67);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 4;
            label1.Text = "Any";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(233, 65);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 5;
            label2.Text = "Comarca";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(397, 67);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 6;
            label3.Text = "Població";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 141);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 7;
            label4.Text = "Domèstic xarxa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(235, 142);
            label5.Name = "label5";
            label5.Size = new Size(134, 30);
            label5.TabIndex = 8;
            label5.Text = "Activitats econòmiques \r\ni fonts pròpies";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(442, 142);
            label6.Name = "label6";
            label6.Size = new Size(159, 15);
            label6.TabIndex = 9;
            label6.Text = "Consum domèstic per càpita";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(442, 192);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 10;
            label7.Text = "Total";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(658, 39);
            label8.Name = "label8";
            label8.Size = new Size(75, 15);
            label8.TabIndex = 11;
            label8.Text = "Estadístiques";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(658, 93);
            label9.Name = "label9";
            label9.Size = new Size(117, 15);
            label9.TabIndex = 12;
            label9.Text = "Població>20000hab.:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(658, 131);
            label10.Name = "label10";
            label10.Size = new Size(137, 15);
            label10.TabIndex = 13;
            label10.Text = "Consum domèstic mitja:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(658, 168);
            label11.Name = "label11";
            label11.Size = new Size(203, 15);
            label11.TabIndex = 14;
            label11.Text = "Consum domèstic per càpita més alt:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(658, 207);
            label12.Name = "label12";
            label12.Size = new Size(212, 15);
            label12.TabIndex = 15;
            label12.Text = "Consum domèstic per càpita més baix:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(70, 29);
            label13.Name = "label13";
            label13.Size = new Size(231, 15);
            label13.TabIndex = 16;
            label13.Text = "Gestió de dades demogràfiques de regions";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(70, 266);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(864, 150);
            dataGridView1.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 467);
            Controls.Add(dataGridView1);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private DataGridView dataGridView1;
    }
}