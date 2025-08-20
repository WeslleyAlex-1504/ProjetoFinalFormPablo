namespace ProjetoFinalFormP
{
    partial class CriarCarro
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
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Goldenrod;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(2, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(574, 130);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(197, 41);
            label1.Name = "label1";
            label1.Size = new Size(192, 48);
            label1.TabIndex = 0;
            label1.Text = "Criar Carro";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(137, 238);
            label2.Name = "label2";
            label2.Size = new Size(67, 30);
            label2.TabIndex = 2;
            label2.Text = "Placa:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(252, 239);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Digite a placa...";
            textBox1.Size = new Size(184, 31);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(250, 347);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Digite o modelo...";
            textBox2.Size = new Size(184, 31);
            textBox2.TabIndex = 5;

            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(137, 346);
            label3.Name = "label3";
            label3.Size = new Size(94, 30);
            label3.TabIndex = 4;
            label3.Text = "Modelo:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(252, 293);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Digite a marca...";
            textBox3.Size = new Size(184, 31);
            textBox3.TabIndex = 7;

            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(137, 294);
            label4.Name = "label4";
            label4.Size = new Size(78, 30);
            label4.TabIndex = 6;
            label4.Text = "Marca:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(252, 396);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Digite o ano...";
            textBox4.Size = new Size(184, 31);
            textBox4.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(137, 395);
            label5.Name = "label5";
            label5.Size = new Size(57, 30);
            label5.TabIndex = 8;
            label5.Text = "Ano:";
            // 
            // button1
            // 
            button1.Location = new Point(98, 534);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 10;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(369, 536);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 11;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // CriarCarro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 664);
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
            Name = "CriarCarro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CriarCarro";
            Load += CriarCarro_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private Button button1;
        private Button button2;
    }
}