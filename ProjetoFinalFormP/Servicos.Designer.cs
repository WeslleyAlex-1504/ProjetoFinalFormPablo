namespace ProjetoFinalFormP
{
    partial class Servicos
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
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            button4 = new Button();
            button6 = new Button();
            label3 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            button2 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button3
            // 
            button3.FlatAppearance.MouseOverBackColor = SystemColors.ButtonFace;
            button3.Font = new Font("Segoe UI", 9F);
            button3.Location = new Point(1486, 577);
            button3.Name = "button3";
            button3.Size = new Size(171, 57);
            button3.TabIndex = 42;
            button3.Text = "Atualizar Serviço";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1179, 943);
            dataGridView1.TabIndex = 36;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Goldenrod;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1924, 108);
            panel1.TabIndex = 39;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(864, 30);
            label1.Name = "label1";
            label1.Size = new Size(265, 48);
            label1.TabIndex = 1;
            label1.Text = "Master Motors";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.DarkGray;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(179, 179, 179);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(1729, 35);
            button1.Name = "button1";
            button1.Size = new Size(134, 43);
            button1.TabIndex = 2;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button4
            // 
            button4.FlatAppearance.MouseOverBackColor = SystemColors.ButtonFace;
            button4.Font = new Font("Segoe UI", 9F);
            button4.Location = new Point(1486, 685);
            button4.Name = "button4";
            button4.Size = new Size(171, 57);
            button4.TabIndex = 38;
            button4.Text = "Ver Incompletos";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(1747, 375);
            button6.Margin = new Padding(4, 5, 4, 5);
            button6.Name = "button6";
            button6.Size = new Size(107, 85);
            button6.TabIndex = 47;
            button6.Text = "🔍";
            button6.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(1371, 427);
            label3.Name = "label3";
            label3.Size = new Size(67, 30);
            label3.TabIndex = 46;
            label3.Text = "Filtro:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(1371, 375);
            label2.Name = "label2";
            label2.Size = new Size(108, 30);
            label2.TabIndex = 43;
            label2.Text = "Pesquisar:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Nome", "CPF", "Telefone", "Cidade", "Estado", "Pais" });
            comboBox1.Location = new Point(1486, 425);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 38);
            comboBox1.TabIndex = 45;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(1486, 375);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Digite oque quer pesquisar...";
            textBox1.Size = new Size(250, 37);
            textBox1.TabIndex = 44;
            // 
            // button2
            // 
            button2.FlatAppearance.MouseOverBackColor = SystemColors.ButtonFace;
            button2.Font = new Font("Segoe UI", 11F);
            button2.Location = new Point(1185, 850);
            button2.Name = "button2";
            button2.Size = new Size(171, 57);
            button2.TabIndex = 48;
            button2.Text = "OS";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button5
            // 
            button5.FlatAppearance.MouseOverBackColor = SystemColors.ButtonFace;
            button5.Font = new Font("Segoe UI", 11F);
            button5.Location = new Point(1740, 850);
            button5.Name = "button5";
            button5.Size = new Size(171, 57);
            button5.TabIndex = 49;
            button5.Text = "Funcionarios";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Servicos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1050);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(panel1);
            Controls.Add(button4);
            Name = "Servicos";
            Text = "Servicos";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label1;
        private Button button1;
        private Button button4;
        private Button button6;
        private Label label3;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button button2;
        private Button button5;
    }
}