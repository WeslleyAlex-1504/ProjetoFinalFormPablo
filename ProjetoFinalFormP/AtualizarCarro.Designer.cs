namespace ProjetoFinalFormP
{
    partial class AtualizarCarro
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
            textBox6 = new TextBox();
            label8 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox6
            // 
            textBox6.Location = new Point(262, 97);
            textBox6.MaxLength = 11;
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Placa do Carro...";
            textBox6.Size = new Size(127, 23);
            textBox6.TabIndex = 62;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(-1, 97);
            label8.Name = "label8";
            label8.Size = new Size(256, 21);
            label8.TabIndex = 61;
            label8.Text = "Placa do carro que deseja modificar";
            // 
            // button2
            // 
            button2.BackColor = Color.Goldenrod;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(228, 349);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(124, 41);
            button2.TabIndex = 56;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Goldenrod;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(46, 349);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(124, 41);
            button1.TabIndex = 55;
            button1.Text = "Atualizar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(159, 272);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Digite o ano do Carro...";
            textBox4.Size = new Size(159, 23);
            textBox4.TabIndex = 54;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(79, 272);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 53;
            label5.Text = "Ano:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(159, 214);
            textBox3.Margin = new Padding(2);
            textBox3.MaxLength = 11;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Digite a marca do Carro...";
            textBox3.Size = new Size(159, 23);
            textBox3.TabIndex = 52;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(79, 214);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 51;
            label4.Text = "Marca:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(158, 243);
            textBox2.Margin = new Padding(2);
            textBox2.MaxLength = 11;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Digite a marca do Carro...";
            textBox2.Size = new Size(159, 23);
            textBox2.TabIndex = 50;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(79, 243);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 49;
            label3.Text = "Modelo:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(159, 185);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Digite a placa do Carro...";
            textBox1.Size = new Size(159, 23);
            textBox1.TabIndex = 48;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(79, 185);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 47;
            label2.Text = "Placa:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Goldenrod;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-2, -1);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(402, 78);
            panel2.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(107, 25);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(170, 32);
            label1.TabIndex = 0;
            label1.Text = "Atualizar Carro";
            // 
            // AtualizarCarro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 398);
            Controls.Add(textBox6);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(panel2);
            MaximizeBox = false;
            Name = "AtualizarCarro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AtualizarCarro";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox6;
        private Label label8;
        private Button button2;
        private Button button1;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Panel panel2;
        private Label label1;
    }
}