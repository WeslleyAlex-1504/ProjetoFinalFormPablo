namespace ProjetoFinalFormP
{
    partial class Clientes
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1727, 37);
            button1.Name = "button1";
            button1.Size = new Size(185, 43);
            button1.TabIndex = 2;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1179, 943);
            dataGridView1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(1496, 432);
            button2.Name = "button2";
            button2.Size = new Size(171, 56);
            button2.TabIndex = 4;
            button2.Text = "Criar Cliente";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1496, 528);
            button3.Name = "button3";
            button3.Size = new Size(171, 56);
            button3.TabIndex = 5;
            button3.Text = "Criar Carro";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1496, 728);
            button4.Name = "button4";
            button4.Size = new Size(171, 56);
            button4.TabIndex = 7;
            button4.Text = "Ver Inativo";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(1496, 624);
            button5.Name = "button5";
            button5.Size = new Size(171, 56);
            button5.TabIndex = 6;
            button5.Text = "Atualizar Cliente";
            button5.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Goldenrod;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1924, 109);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(884, 34);
            label1.Name = "label1";
            label1.Size = new Size(257, 48);
            label1.TabIndex = 1;
            label1.Text = "Master Motors";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1544, 267);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Digite oque quer pesquisar...";
            textBox1.Size = new Size(249, 31);
            textBox1.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Nome", "CPF", "Telefone", "Cidade", "Estado", "Pais" });
            comboBox1.Location = new Point(1544, 316);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(249, 33);
            comboBox1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(1430, 266);
            label2.Name = "label2";
            label2.Size = new Size(108, 30);
            label2.TabIndex = 3;
            label2.Text = "Pesquisar:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(1430, 319);
            label3.Name = "label3";
            label3.Size = new Size(67, 30);
            label3.TabIndex = 11;
            label3.Text = "Filtro:";
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1050);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Name = "Clientes";
            Text = "Form3";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
    }
}