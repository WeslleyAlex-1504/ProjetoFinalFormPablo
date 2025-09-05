namespace ProjetoFinalFormP
{
    partial class adicionarSerivico
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
            button4 = new Button();
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
            // button3
            // 
            button3.BackColor = Color.Goldenrod;
            button3.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(317, 582);
            button3.Name = "button3";
            button3.Size = new Size(177, 68);
            button3.TabIndex = 37;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Goldenrod;
            button4.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(66, 582);
            button4.Name = "button4";
            button4.Size = new Size(177, 68);
            button4.TabIndex = 36;
            button4.Text = "Criar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(263, 412);
            textBox4.MaxLength = 9999;
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Digite a peça usada...";
            textBox4.Size = new Size(280, 37);
            textBox4.TabIndex = 35;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(44, 415);
            label5.Name = "label5";
            label5.Size = new Size(62, 30);
            label5.TabIndex = 34;
            label5.Text = "Peça:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(263, 308);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Digite o nome...";
            textBox3.Size = new Size(280, 37);
            textBox3.TabIndex = 33;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(44, 311);
            label4.Name = "label4";
            label4.Size = new Size(130, 30);
            label4.TabIndex = 32;
            label4.Text = "Funcionario:";
            label4.Click += label4_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(263, 362);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Digite o serviço realizado...";
            textBox2.Size = new Size(280, 37);
            textBox2.TabIndex = 31;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(44, 362);
            label3.Name = "label3";
            label3.Size = new Size(187, 30);
            label3.TabIndex = 30;
            label3.Text = "Serviço Realizado:";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(263, 253);
            textBox1.MaxLength = 99;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Digite o Id...";
            textBox1.Size = new Size(280, 37);
            textBox1.TabIndex = 29;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 256);
            label2.Name = "label2";
            label2.Size = new Size(102, 30);
            label2.TabIndex = 28;
            label2.Text = "Id da OS:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Goldenrod;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(574, 130);
            panel2.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(120, 41);
            label1.Name = "label1";
            label1.Size = new Size(335, 48);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Serviço";
            label1.Click += label1_Click;
            // 
            // adicionarSerivico
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 663);
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
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "adicionarSerivico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "adicionarSerivico";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button4;
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