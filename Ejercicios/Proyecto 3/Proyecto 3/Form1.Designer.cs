namespace Proyecto_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnRandomMenor100 = new Button();
            btnReset = new Button();
            textBox = new TextBox();
            RandomLabel = new Label();
            ContadorLabel = new Label();
            txtContadorLabel = new Label();
            txtRandomLabel = new Label();
            timerRandom = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnRandomMenor100
            // 
            btnRandomMenor100.Location = new Point(24, 24);
            btnRandomMenor100.Name = "btnRandomMenor100";
            btnRandomMenor100.Size = new Size(115, 58);
            btnRandomMenor100.TabIndex = 0;
            btnRandomMenor100.Text = "Buscar";
            btnRandomMenor100.UseVisualStyleBackColor = true;
            btnRandomMenor100.Click += btnBuscarNumero;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(166, 24);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(115, 58);
            btnReset.TabIndex = 1;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // textBox
            // 
            textBox.Location = new Point(64, 100);
            textBox.Name = "textBox";
            textBox.Size = new Size(184, 23);
            textBox.TabIndex = 2;
            textBox.KeyPress += textBoxKeyPrees;
            textBox.KeyUp += textBoxKeyUp;
            // 
            // RandomLabel
            // 
            RandomLabel.AutoSize = true;
            RandomLabel.Location = new Point(43, 149);
            RandomLabel.Name = "RandomLabel";
            RandomLabel.Size = new Size(52, 15);
            RandomLabel.TabIndex = 3;
            RandomLabel.Text = "Random";
            // 
            // ContadorLabel
            // 
            ContadorLabel.AutoSize = true;
            ContadorLabel.Location = new Point(43, 193);
            ContadorLabel.Name = "ContadorLabel";
            ContadorLabel.Size = new Size(57, 15);
            ContadorLabel.TabIndex = 4;
            ContadorLabel.Text = "Contador";
            // 
            // txtContadorLabel
            // 
            txtContadorLabel.AutoSize = true;
            txtContadorLabel.Location = new Point(196, 202);
            txtContadorLabel.Name = "txtContadorLabel";
            txtContadorLabel.Size = new Size(13, 15);
            txtContadorLabel.TabIndex = 5;
            txtContadorLabel.Text = "0";
            // 
            // txtRandomLabel
            // 
            txtRandomLabel.AutoSize = true;
            txtRandomLabel.Location = new Point(196, 149);
            txtRandomLabel.Name = "txtRandomLabel";
            txtRandomLabel.Size = new Size(13, 15);
            txtRandomLabel.TabIndex = 6;
            txtRandomLabel.Text = "0";
            // 
            // timerRandom
            // 
            timerRandom.Tick += timerRandom_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtRandomLabel);
            Controls.Add(txtContadorLabel);
            Controls.Add(ContadorLabel);
            Controls.Add(RandomLabel);
            Controls.Add(textBox);
            Controls.Add(btnReset);
            Controls.Add(btnRandomMenor100);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRandomMenor100;
        private Button btnReset;
        private TextBox textBox;
        private Label RandomLabel;
        private Label ContadorLabel;
        private Label txtContadorLabel;
        private Label txtRandomLabel;
        private System.Windows.Forms.Timer timerRandom;
    }
}
