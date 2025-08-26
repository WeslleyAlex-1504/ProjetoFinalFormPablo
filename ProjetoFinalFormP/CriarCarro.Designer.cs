namespace ProjetoFinalFormP
{
    partial class CriarCarro
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
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            button3 = new Button();
            button4 = new Button();
            textBox5 = new TextBox();
            label6 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Goldenrod;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(1, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(402, 78);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(99, 23);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(205, 32);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Carro";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(96, 159);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 2;
            label2.Text = "Placa:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(176, 159);
            textBox1.Margin = new Padding(2);
            textBox1.MaxLength = 7;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Digite a placa...";
            textBox1.Size = new Size(130, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(175, 224);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Digite o modelo...";
            textBox2.Size = new Size(130, 23);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(96, 224);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 4;
            label3.Text = "Modelo:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(176, 192);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Digite a marca...";
            textBox3.Size = new Size(130, 23);
            textBox3.TabIndex = 7;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(96, 192);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 6;
            label4.Text = "Marca:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(176, 254);
            textBox4.Margin = new Padding(2);
            textBox4.MaxLength = 4;
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Digite o ano...";
            textBox4.Size = new Size(130, 23);
            textBox4.TabIndex = 9;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(96, 253);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 8;
            label5.Text = "Ano:";
            // 
            // button3
            // 
            button3.BackColor = Color.Goldenrod;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(229, 331);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(124, 41);
            button3.TabIndex = 24;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Goldenrod;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(47, 331);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(124, 41);
            button4.TabIndex = 23;
            button4.Text = "Criar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(192, 89);
            textBox5.Margin = new Padding(2);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Digite o CPF do dono...";
            textBox5.Size = new Size(177, 23);
            textBox5.TabIndex = 26;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(31, 92);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(157, 20);
            label6.TabIndex = 25;
            label6.Text = "CPF do dono do carro:";
            // 
            // CriarCarro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 398);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(panel2);
            Margin = new Padding(2);
            Name = "CriarCarro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CriarCarro";
            Load += CriarCarro_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private Button button3;
        private Button button4;
        private TextBox textBox5;
        private Label label6;
    }
}