namespace ProjetoFinalFormP
{
    partial class atualizarOS
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
            dateTimePicker1 = new DateTimePicker();
            button3 = new Button();
            button4 = new Button();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(245, 354);
            dateTimePicker1.Margin = new Padding(4, 5, 4, 5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(224, 37);
            dateTimePicker1.TabIndex = 49;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // button3
            // 
            button3.BackColor = Color.Goldenrod;
            button3.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 11F);
            button3.Location = new Point(327, 582);
            button3.Name = "button3";
            button3.Size = new Size(177, 68);
            button3.TabIndex = 48;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Goldenrod;
            button4.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 11F);
            button4.Location = new Point(66, 582);
            button4.Name = "button4";
            button4.Size = new Size(177, 68);
            button4.TabIndex = 47;
            button4.Text = "Atualizar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(129, 359);
            label4.Name = "label4";
            label4.Size = new Size(49, 30);
            label4.TabIndex = 46;
            label4.Text = "Dia:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(274, 153);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Digite o Id da OS...";
            textBox2.Size = new Size(208, 37);
            textBox2.TabIndex = 45;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(113, 153);
            label3.Name = "label3";
            label3.Size = new Size(102, 30);
            label3.TabIndex = 44;
            label3.Text = "Id da OS:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(246, 302);
            textBox1.MaxLength = 99999;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Digite a descrição...";
            textBox1.Size = new Size(223, 37);
            textBox1.TabIndex = 43;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(129, 305);
            label2.Name = "label2";
            label2.Size = new Size(111, 30);
            label2.TabIndex = 42;
            label2.Text = "Descrição:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Goldenrod;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(574, 130);
            panel2.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(60, 41);
            label1.Name = "label1";
            label1.Size = new Size(454, 48);
            label1.TabIndex = 0;
            label1.Text = "Atualizar  ordem de serviço";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(129, 415);
            label5.Name = "label5";
            label5.Size = new Size(75, 30);
            label5.TabIndex = 50;
            label5.Text = "Status:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Finalizado", "Incompleto" });
            comboBox1.Location = new Point(245, 412);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(224, 38);
            comboBox1.TabIndex = 51;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // atualizarOS
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(573, 663);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(panel2);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "atualizarOS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "atualizarOS";
            Load += atualizarOS_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button button3;
        private Button button4;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Panel panel2;
        private Label label1;
        private Label label5;
        private ComboBox comboBox1;
    }
}