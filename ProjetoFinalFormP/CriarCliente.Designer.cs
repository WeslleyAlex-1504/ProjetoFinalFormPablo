namespace ProjetoFinalFormP
{
    partial class CriarCliente
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
            textBox5 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            comboBox1 = new ComboBox();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Goldenrod;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(229, 325);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(124, 41);
            button2.TabIndex = 22;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Goldenrod;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(47, 325);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(124, 41);
            button1.TabIndex = 21;
            button1.Text = "Criar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(160, 202);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Digite a cidade...";
            textBox4.Size = new Size(160, 23);
            textBox4.TabIndex = 20;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(80, 202);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 19;
            label5.Text = "Cidade:";
            label5.Click += label5_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(160, 144);
            textBox3.Margin = new Padding(2);
            textBox3.MaxLength = 11;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Digite o CPF do Cliente...";
            textBox3.Size = new Size(160, 23);
            textBox3.TabIndex = 18;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(80, 144);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 17;
            label4.Text = "CPF:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(159, 173);
            textBox2.Margin = new Padding(2);
            textBox2.MaxLength = 11;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Digite o telefone...";
            textBox2.Size = new Size(161, 23);
            textBox2.TabIndex = 16;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(80, 173);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 15;
            label3.Text = "Telefone:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(160, 115);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Digite o nome do cliente...";
            textBox1.Size = new Size(160, 23);
            textBox1.TabIndex = 14;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(80, 115);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 13;
            label2.Text = "Nome:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Goldenrod;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(402, 78);
            panel2.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(90, 23);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(223, 32);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Cliente";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(160, 260);
            textBox5.Margin = new Padding(2);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Digite o nome do cliente...";
            textBox5.Size = new Size(160, 23);
            textBox5.TabIndex = 24;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(80, 260);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 23;
            label6.Text = "Pais:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(80, 231);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 25;
            label7.Text = "Estado:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO" });
            comboBox1.Location = new Point(161, 231);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(159, 23);
            comboBox1.TabIndex = 26;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // CriarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 398);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label6);
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
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "CriarCliente";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CriarCliente";
            Load += CriarCliente_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private TextBox textBox5;
        private Label label6;
        private Label label7;
        private ComboBox comboBox1;
    }
}