
using System;

namespace UP1_Leshukov
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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            pract2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pract3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            listBox1 = new System.Windows.Forms.ListBox();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            button2 = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            button3 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            textBox2 = new System.Windows.Forms.TextBox();
            numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            button4 = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            button5 = new System.Windows.Forms.Button();
            listBox2 = new System.Windows.Forms.ListBox();
            label6 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            textBox6 = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            comboBox2 = new System.Windows.Forms.ComboBox();
            numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            textBox5 = new System.Windows.Forms.TextBox();
            textBox4 = new System.Windows.Forms.TextBox();
            textBox3 = new System.Windows.Forms.TextBox();
            button12 = new System.Windows.Forms.Button();
            button11 = new System.Windows.Forms.Button();
            button10 = new System.Windows.Forms.Button();
            button9 = new System.Windows.Forms.Button();
            button8 = new System.Windows.Forms.Button();
            button7 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { pract2ToolStripMenuItem, pract3ToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // pract2ToolStripMenuItem
            // 
            pract2ToolStripMenuItem.Name = "pract2ToolStripMenuItem";
            pract2ToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            pract2ToolStripMenuItem.Text = "Практика 2";
            pract2ToolStripMenuItem.Click += Прейти_ко_2й_практике;
            // 
            // pract3ToolStripMenuItem
            // 
            pract3ToolStripMenuItem.Name = "pract3ToolStripMenuItem";
            pract3ToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            pract3ToolStripMenuItem.Text = "Практика 3";
            pract3ToolStripMenuItem.Click += Пререйти_к_3й_практике;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new System.Drawing.Point(289, 180);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(487, 244);
            listBox1.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new System.Drawing.Point(12, 72);
            numericUpDown1.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(144, 23);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(12, 105);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(144, 23);
            button2.TabIndex = 4;
            button2.Text = "Добавить в корзину";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Добавить_в_Корзину;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(12, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(144, 23);
            textBox1.TabIndex = 5;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(289, 152);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(190, 22);
            button3.TabIndex = 6;
            button3.Text = "Показать все элементы";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Показать_все_элементы;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(162, 37);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(71, 15);
            label1.TabIndex = 7;
            label1.Text = "Имя товара";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(162, 80);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(189, 15);
            label2.TabIndex = 8;
            label2.Text = "Кол-во которое продаст магазин";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new System.Drawing.Point(606, 14);
            numericUpDown2.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new System.Drawing.Size(120, 23);
            numericUpDown2.TabIndex = 9;
            numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(605, 44);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(121, 23);
            textBox2.TabIndex = 10;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new System.Drawing.Point(605, 72);
            numericUpDown3.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown3.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new System.Drawing.Size(120, 23);
            numericUpDown3.TabIndex = 11;
            numericUpDown3.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(488, 14);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(112, 15);
            label3.TabIndex = 12;
            label3.Text = "Количество товара";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(529, 44);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(71, 15);
            label4.TabIndex = 13;
            label4.Text = "Имя товара";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(525, 74);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(75, 15);
            label5.TabIndex = 14;
            label5.Text = "Цена товара";
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(605, 101);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(121, 46);
            button4.TabIndex = 15;
            button4.Text = "Добавить товар";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Добавить_Товар;
            // 
            // panel1
            // 
            panel1.Controls.Add(button5);
            panel1.Controls.Add(listBox2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(numericUpDown3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(numericUpDown2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(numericUpDown1);
            panel1.Location = new System.Drawing.Point(0, 27);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(788, 427);
            panel1.TabIndex = 16;
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(12, 331);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(167, 41);
            button5.TabIndex = 18;
            button5.Text = "Продать";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Продать_Товары;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new System.Drawing.Point(12, 221);
            listBox2.Name = "listBox2";
            listBox2.Size = new System.Drawing.Size(167, 94);
            listBox2.TabIndex = 17;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(12, 203);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(56, 15);
            label6.TabIndex = 16;
            label6.Text = "Корзина:";
            label6.Click += label6_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(numericUpDown4);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(button12);
            panel2.Controls.Add(button11);
            panel2.Controls.Add(button10);
            panel2.Controls.Add(button9);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new System.Drawing.Point(3, 27);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(800, 424);
            panel2.TabIndex = 17;
            panel2.Visible = false;
            panel2.Paint += panel2_Paint;
            // 
            // textBox6
            // 
            textBox6.Location = new System.Drawing.Point(650, 340);
            textBox6.Name = "textBox6";
            textBox6.Size = new System.Drawing.Size(121, 23);
            textBox6.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(402, 268);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(0, 15);
            label7.TabIndex = 15;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Удалить по названию файла", "Удалить по индексу", "Удалить по названию" });
            comboBox2.Location = new System.Drawing.Point(650, 311);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(121, 23);
            comboBox2.TabIndex = 14;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new System.Drawing.Point(402, 151);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new System.Drawing.Size(137, 23);
            numericUpDown4.TabIndex = 12;
            numericUpDown4.ValueChanged += numericUpDown4_ValueChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new System.Drawing.Point(402, 64);
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(137, 23);
            textBox5.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(402, 35);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(137, 23);
            textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(402, 6);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(137, 23);
            textBox3.TabIndex = 9;
            // 
            // button12
            // 
            button12.Location = new System.Drawing.Point(10, 359);
            button12.Name = "button12";
            button12.Size = new System.Drawing.Size(137, 23);
            button12.TabIndex = 8;
            button12.Text = "В начало";
            button12.UseVisualStyleBackColor = true;
            button12.Click += Start;
            // 
            // button11
            // 
            button11.Location = new System.Drawing.Point(402, 180);
            button11.Name = "button11";
            button11.Size = new System.Drawing.Size(137, 23);
            button11.TabIndex = 7;
            button11.Text = "Поиск";
            button11.UseVisualStyleBackColor = true;
            button11.Click += Search;
            // 
            // button10
            // 
            button10.Location = new System.Drawing.Point(671, 370);
            button10.Name = "button10";
            button10.Size = new System.Drawing.Size(75, 23);
            button10.TabIndex = 6;
            button10.Text = "Удалить";
            button10.UseVisualStyleBackColor = true;
            button10.Click += Delete;
            // 
            // button9
            // 
            button9.Location = new System.Drawing.Point(9, 388);
            button9.Name = "button9";
            button9.Size = new System.Drawing.Size(138, 23);
            button9.TabIndex = 5;
            button9.Text = "Очистить";
            button9.UseVisualStyleBackColor = true;
            button9.Click += Clear;
            // 
            // button8
            // 
            button8.Location = new System.Drawing.Point(10, 302);
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(75, 23);
            button8.TabIndex = 4;
            button8.Text = "<<";
            button8.UseVisualStyleBackColor = true;
            button8.Click += Back;
            // 
            // button7
            // 
            button7.Location = new System.Drawing.Point(402, 94);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(137, 23);
            button7.TabIndex = 3;
            button7.Text = "Добавить";
            button7.UseVisualStyleBackColor = true;
            button7.Click += Add;
            // 
            // button6
            // 
            button6.Location = new System.Drawing.Point(312, 302);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(75, 23);
            button6.TabIndex = 2;
            button6.Text = ">>";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Next;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(153, 359);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(130, 52);
            button1.TabIndex = 1;
            button1.Text = "Вывести песни";
            button1.UseVisualStyleBackColor = true;
            button1.Click += PrintSong;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(9, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(378, 289);
            dataGridView1.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(545, 12);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(40, 15);
            label8.TabIndex = 17;
            label8.Text = "Автор";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(548, 40);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(67, 15);
            label9.TabIndex = 18;
            label9.Text = "Имя песни";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(547, 68);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(69, 15);
            label10.TabIndex = 19;
            label10.Text = "Имя файла";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(402, 134);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(106, 15);
            label11.TabIndex = 20;
            label11.Text = "Песня по номеру:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pract2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pract3ToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

