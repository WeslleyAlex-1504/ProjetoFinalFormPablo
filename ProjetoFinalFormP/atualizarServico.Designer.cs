namespace ProjetoFinalFormP
{
    partial class atualizarServico
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
            textBox2 = new TextBox();
            label3 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Finalizado", "incompleto" });
            comboBox2.Location = new Point(273, 427);
            comboBox2.Margin = new Padding(4, 5, 4, 5);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(227, 38);
            comboBox2.TabIndex = 73;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(87, 432);
            label9.Name = "label9";
            label9.Size = new Size(68, 30);
            label9.TabIndex = 72;
            label9.Text = "Ativo:";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 11F);
            textBox6.Location = new Point(374, 158);
            textBox6.Margin = new Padding(4, 5, 4, 5);
            textBox6.MaxLength = 11;
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Id do Serviço...";
            textBox6.Size = new Size(180, 37);
            textBox6.TabIndex = 71;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(17, 158);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(323, 30);
            label8.TabIndex = 70;
            label8.Text = "Id do serviço que deseja mudar:";
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
            button2.TabIndex = 69;
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
            button1.Location = new Point(67, 582);
            button1.Name = "button1";
            button1.Size = new Size(177, 68);
            button1.TabIndex = 68;
            button1.Text = "Atualizar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F);
            textBox1.Location = new Point(273, 298);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Digite o serviço realizado...";
            textBox1.Size = new Size(227, 37);
            textBox1.TabIndex = 67;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(87, 301);
            label2.Name = "label2";
            label2.Size = new Size(183, 30);
            label2.TabIndex = 66;
            label2.Text = "Serviço realizado:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Goldenrod;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-1, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(574, 130);
            panel2.TabIndex = 65;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(153, 42);
            label1.Name = "label1";
            label1.Size = new Size(283, 48);
            label1.TabIndex = 0;
            label1.Text = "Atualizar Serviço";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 11F);
            textBox2.Location = new Point(273, 362);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Digite o peça...";
            textBox2.Size = new Size(227, 37);
            textBox2.TabIndex = 75;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(87, 365);
            label3.Name = "label3";
            label3.Size = new Size(124, 30);
            label3.TabIndex = 74;
            label3.Text = "Peça usada:";
            // 
            // atualizarServico
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 663);
            Controls.Add(textBox2);
            Controls.Add(label3);
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
            Name = "atualizarServico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "atualizarServico";
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
        private TextBox textBox2;
        private Label label3;
    }
}