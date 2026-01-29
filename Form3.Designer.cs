namespace promestudents26
{
    partial class Form3
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 192, 192);
            button3.Location = new Point(649, 275);
            button3.Name = "button3";
            button3.Size = new Size(116, 57);
            button3.TabIndex = 36;
            button3.Text = "Limpiar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 64, 0);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(649, 341);
            button2.Name = "button2";
            button2.Size = new Size(115, 61);
            button2.TabIndex = 35;
            button2.Text = "SALIR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Location = new Point(213, 353);
            button1.Name = "button1";
            button1.Size = new Size(272, 37);
            button1.TabIndex = 34;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(407, 281);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 33;
            label6.Text = "Nota 4:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 278);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 32;
            label5.Text = "Nota 3:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(407, 210);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 31;
            label4.Text = "Nota 2:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 207);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 30;
            label3.Text = "Nota 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Snap ITC", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1, 48);
            label2.Name = "label2";
            label2.Size = new Size(800, 37);
            label2.TabIndex = 29;
            label2.Text = "CALCULO DE NOTAS DE EXTRAORDINARIO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 133);
            label1.Name = "label1";
            label1.Size = new Size(277, 25);
            label1.TabIndex = 28;
            label1.Text = "Ingrese las notas del estudiante";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(478, 278);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 27;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(124, 275);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 26;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(478, 210);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 25;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(124, 204);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 24;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 413);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}