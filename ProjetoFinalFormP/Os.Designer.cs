namespace ProjetoFinalFormP
{
    partial class Os
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
            button6 = new Button();
            label3 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            button7 = new Button();
            label1 = new Label();
            button1 = new Button();
            button4 = new Button();
            button5 = new Button();
            button2 = new Button();
            button3 = new Button();
            button8 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(1264, 160);
            button6.Name = "button6";
            button6.Size = new Size(75, 51);
            button6.TabIndex = 23;
            button6.Text = "🔍";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(1001, 191);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 22;
            label3.Text = "Filtro:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(1001, 160);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 13;
            label2.Text = "Pesquisar:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Placa", "Descrição", "Cliente" });
            comboBox1.Location = new Point(1081, 190);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(176, 23);
            comboBox1.TabIndex = 21;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1081, 160);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Digite oque quer pesquisar...";
            textBox1.Size = new Size(176, 23);
            textBox1.TabIndex = 20;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 65);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(825, 566);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Goldenrod;
            panel1.Controls.Add(button7);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1383, 65);
            panel1.TabIndex = 19;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button7.BackColor = Color.DarkGray;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(1209, 20);
            button7.Margin = new Padding(2);
            button7.Name = "button7";
            button7.Size = new Size(130, 26);
            button7.TabIndex = 24;
            button7.Text = "Voltar";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(619, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(1363, 29);
            label1.TabIndex = 1;
            label1.Text = "Master Motors";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.DarkGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1209, 22);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(1313, 26);
            button1.TabIndex = 2;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Location = new Point(1047, 437);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(120, 34);
            button4.TabIndex = 18;
            button4.Text = "OS Finalizadas";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(1047, 348);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(120, 34);
            button5.TabIndex = 17;
            button5.Text = "Atualizar OS";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1047, 259);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(120, 34);
            button2.TabIndex = 15;
            button2.Text = "Criar Serviço";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1252, 585);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(120, 34);
            button3.TabIndex = 24;
            button3.Text = "Serviços";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button8
            // 
            button8.Location = new Point(829, 585);
            button8.Margin = new Padding(2);
            button8.Name = "button8";
            button8.Size = new Size(120, 34);
            button8.TabIndex = 25;
            button8.Text = "Carros";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Os
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1383, 630);
            Controls.Add(button8);
            Controls.Add(button3);
            Controls.Add(button6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button2);
            Margin = new Padding(2);
            Name = "Os";
            Text = "Os";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button6;
        private Label label3;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label1;
        private Button button1;
        private Button button4;
        private Button button5;
        private Button button2;
        private Button button7;
        private Button button3;
        private Button button8;
    }
}