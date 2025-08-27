namespace ProjetoFinalFormP
{
    partial class AtualizarCliente
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
            comboBox1 = new ComboBox();
            label7 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
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
            label8 = new Label();
            textBox6 = new TextBox();
            label9 = new Label();
            comboBox2 = new ComboBox();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO" });
            comboBox1.Location = new Point(230, 417);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(225, 33);
            comboBox1.TabIndex = 41;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(114, 417);
            label7.Name = "label7";
            label7.Size = new Size(82, 30);
            label7.TabIndex = 40;
            label7.Text = "Estado:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(230, 465);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Digite o pais do cliente...";
            textBox5.Size = new Size(225, 31);
            textBox5.TabIndex = 39;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(114, 465);
            label6.Name = "label6";
            label6.Size = new Size(54, 30);
            label6.TabIndex = 38;
            label6.Text = "Pais:";
            // 
            // button2
            // 
            button2.BackColor = Color.Goldenrod;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(327, 580);
            button2.Name = "button2";
            button2.Size = new Size(177, 68);
            button2.TabIndex = 37;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Goldenrod;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(67, 580);
            button1.Name = "button1";
            button1.Size = new Size(177, 68);
            button1.TabIndex = 36;
            button1.Text = "Atualizar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(229, 368);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Digite a cidade...";
            textBox4.Size = new Size(225, 31);
            textBox4.TabIndex = 35;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(114, 368);
            label5.Name = "label5";
            label5.Size = new Size(86, 30);
            label5.TabIndex = 34;
            label5.Text = "Cidade:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(229, 272);
            textBox3.MaxLength = 11;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Digite o CPF do Cliente...";
            textBox3.Size = new Size(225, 31);
            textBox3.TabIndex = 33;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(114, 272);
            label4.Name = "label4";
            label4.Size = new Size(55, 30);
            label4.TabIndex = 32;
            label4.Text = "CPF:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(227, 320);
            textBox2.MaxLength = 11;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Digite o telefone...";
            textBox2.Size = new Size(225, 31);
            textBox2.TabIndex = 31;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(114, 320);
            label3.Name = "label3";
            label3.Size = new Size(101, 30);
            label3.TabIndex = 30;
            label3.Text = "Telefone:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(229, 223);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Digite o nome do cliente...";
            textBox1.Size = new Size(225, 31);
            textBox1.TabIndex = 29;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(114, 223);
            label2.Name = "label2";
            label2.Size = new Size(78, 30);
            label2.TabIndex = 28;
            label2.Text = "Nome:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Goldenrod;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-1, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(574, 130);
            panel2.TabIndex = 27;
            panel2.Paint += panel2_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(153, 42);
            label1.Name = "label1";
            label1.Size = new Size(278, 48);
            label1.TabIndex = 0;
            label1.Text = "Atualizar Cliente";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(17, 157);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(378, 32);
            label8.TabIndex = 42;
            label8.Text = "CPF do cliente que quer modificar";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(374, 157);
            textBox6.Margin = new Padding(4, 5, 4, 5);
            textBox6.MaxLength = 11;
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "CPF do cliente...";
            textBox6.Size = new Size(180, 31);
            textBox6.TabIndex = 43;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(114, 512);
            label9.Name = "label9";
            label9.Size = new Size(68, 30);
            label9.TabIndex = 44;
            label9.Text = "Ativo:";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "false", "true" });
            comboBox2.Location = new Point(230, 510);
            comboBox2.Margin = new Padding(4, 5, 4, 5);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(225, 33);
            comboBox2.TabIndex = 45;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // AtualizarCliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 663);
            Controls.Add(comboBox2);
            Controls.Add(label9);
            Controls.Add(textBox6);
            Controls.Add(label8);
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
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "AtualizarCliente";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AtualizarCliente";
            Load += AtualizarCliente_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label7;
        private TextBox textBox5;
        private Label label6;
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
        private Label label8;
        private TextBox textBox6;
        private Label label9;
        private ComboBox comboBox2;
    }
}