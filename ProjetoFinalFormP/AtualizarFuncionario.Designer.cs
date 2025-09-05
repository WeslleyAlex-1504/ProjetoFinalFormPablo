namespace ProjetoFinalFormP
{
    partial class AtualizarFuncionario
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
            comboBox2 = new ComboBox();
            label9 = new Label();
            textBox6 = new TextBox();
            label8 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Empregado", "Demitido" });
            comboBox2.Location = new Point(231, 395);
            comboBox2.Margin = new Padding(4, 5, 4, 5);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(284, 38);
            comboBox2.TabIndex = 64;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(117, 398);
            label9.Name = "label9";
            label9.Size = new Size(68, 30);
            label9.TabIndex = 63;
            label9.Text = "Ativo:";
            label9.Click += label9_Click;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 11F);
            textBox6.Location = new Point(361, 162);
            textBox6.Margin = new Padding(4, 5, 4, 5);
            textBox6.MaxLength = 11;
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Id do Funcionario...";
            textBox6.Size = new Size(199, 37);
            textBox6.TabIndex = 62;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 165);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(350, 30);
            label8.TabIndex = 61;
            label8.Text = "Id do Funcionario que quer mudar:";
            label8.Click += label8_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Goldenrod;
            button2.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 11F);
            button2.Location = new Point(327, 582);
            button2.Name = "button2";
            button2.Size = new Size(177, 68);
            button2.TabIndex = 56;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Goldenrod;
            button1.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11F);
            button1.Location = new Point(66, 582);
            button1.Name = "button1";
            button1.Size = new Size(177, 68);
            button1.TabIndex = 55;
            button1.Text = "Atualizar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F);
            textBox1.Location = new Point(231, 330);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Digite o nome do cliente...";
            textBox1.Size = new Size(284, 37);
            textBox1.TabIndex = 48;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(117, 330);
            label2.Name = "label2";
            label2.Size = new Size(78, 30);
            label2.TabIndex = 47;
            label2.Text = "Nome:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Goldenrod;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-1, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(574, 130);
            panel2.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(110, 41);
            label1.Name = "label1";
            label1.Size = new Size(354, 48);
            label1.TabIndex = 0;
            label1.Text = "Atualizar Funcionario";
            // 
            // AtualizarFuncionario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 663);
            Controls.Add(comboBox2);
            Controls.Add(label9);
            Controls.Add(textBox6);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(panel2);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "AtualizarFuncionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AtualizarFuncionario";
            Load += AtualizarFuncionario_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox2;
        private Label label9;
        private TextBox textBox6;
        private Label label8;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private Panel panel2;
        private Label label1;
    }
}