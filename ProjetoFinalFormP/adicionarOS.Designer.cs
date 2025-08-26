namespace ProjetoFinalFormP
{
    partial class adicionarOS
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
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            dateTimePicker1 = new DateTimePicker();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.Goldenrod;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(228, 330);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(124, 41);
            button3.TabIndex = 37;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Goldenrod;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(46, 330);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(124, 41);
            button4.TabIndex = 36;
            button4.Text = "Criar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(95, 191);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 32;
            label4.Text = "Dia:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(174, 223);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Digite a placa do carro...";
            textBox2.Size = new Size(130, 23);
            textBox2.TabIndex = 31;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(95, 223);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 30;
            label3.Text = "Placa:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(175, 158);
            textBox1.Margin = new Padding(2);
            textBox1.MaxLength = 99999;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Digite a descrição...";
            textBox1.Size = new Size(130, 23);
            textBox1.TabIndex = 29;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(95, 158);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 28;
            label2.Text = "Descrição:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Goldenrod;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, -1);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(402, 78);
            panel2.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(99, 23);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(179, 32);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de OS";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(174, 189);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(130, 23);
            dateTimePicker1.TabIndex = 40;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // adicionarOS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 398);
            Controls.Add(dateTimePicker1);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(panel2);
            MaximizeBox = false;
            Name = "adicionarOS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "adicionarOS";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button3;
        private Button button4;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Panel panel2;
        private Label label1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private DateTimePicker dateTimePicker1;
    }
}