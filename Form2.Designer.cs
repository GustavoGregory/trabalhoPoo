namespace Cadastro_de_peças
{
    partial class Form2
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
            panel1_1 = new Panel();
            label5 = new Label();
            Label1_1 = new Label();
            panel3_1 = new Panel();
            pictureBox1_1 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1_1.SuspendLayout();
            panel3_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1_1).BeginInit();
            SuspendLayout();
            // 
            // panel1_1
            // 
            panel1_1.BackColor = Color.FromArgb(16, 83, 76);
            panel1_1.BorderStyle = BorderStyle.FixedSingle;
            panel1_1.Controls.Add(label5);
            panel1_1.Dock = DockStyle.Top;
            panel1_1.Location = new Point(0, 0);
            panel1_1.Name = "panel1_1";
            panel1_1.Size = new Size(1184, 50);
            panel1_1.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(551, 6);
            label5.Name = "label5";
            label5.Size = new Size(270, 37);
            label5.TabIndex = 1;
            label5.Text = "Tela de visualização";
            // 
            // Label1_1
            // 
            Label1_1.AutoSize = true;
            Label1_1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            Label1_1.Location = new Point(60, 10);
            Label1_1.Name = "Label1_1";
            Label1_1.Size = new Size(209, 28);
            Label1_1.TabIndex = 0;
            Label1_1.Text = "Cadastro de material";
            // 
            // panel3_1
            // 
            panel3_1.BackColor = Color.FromArgb(236, 236, 236);
            panel3_1.Controls.Add(Label1_1);
            panel3_1.Location = new Point(0, 50);
            panel3_1.Name = "panel3_1";
            panel3_1.Size = new Size(1185, 50);
            panel3_1.TabIndex = 2;
            // 
            // pictureBox1_1
            // 
            pictureBox1_1.BackColor = SystemColors.ActiveCaption;
            pictureBox1_1.Location = new Point(78, 179);
            pictureBox1_1.Name = "pictureBox1_1";
            pictureBox1_1.Size = new Size(286, 214);
            pictureBox1_1.TabIndex = 3;
            pictureBox1_1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(16, 83, 76);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1062, 588);
            button1.Name = "button1";
            button1.Size = new Size(75, 36);
            button1.TabIndex = 4;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(412, 220);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 5;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(425, 281);
            label2.Name = "label2";
            label2.Size = new Size(43, 21);
            label2.TabIndex = 6;
            label2.Text = "Tipo:";
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(20, 16, 83, 76);
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(474, 220);
            label3.Name = "label3";
            label3.Size = new Size(400, 21);
            label3.TabIndex = 7;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(20, 16, 83, 76);
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(474, 281);
            label4.Name = "label4";
            label4.Size = new Size(400, 21);
            label4.TabIndex = 8;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 646);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBox1_1);
            Controls.Add(panel3_1);
            Controls.Add(panel1_1);
            Name = "Form2";
            Text = "Form2";
            panel1_1.ResumeLayout(false);
            panel1_1.PerformLayout();
            panel3_1.ResumeLayout(false);
            panel3_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1_1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1_1;
        private Label Label1_1;
        private Panel panel3_1;
        private PictureBox pictureBox1_1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}