
namespace Proyecto3
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
            btnBuscar = new Button();
            btnReset = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            labelContador = new Label();
            labelRandom = new Label();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Enabled = false;
            btnBuscar.Location = new Point(52, 23);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(128, 65);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += BtnBuscar_Click;
            btnBuscar.KeyPress += BtnKeyPress;
            btnBuscar.KeyUp += BtnBuscarkeyUp;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(52, 139);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(128, 65);
            btnReset.TabIndex = 1;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += BtnReset_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(236, 107);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(464, 73);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 3;
            label1.Text = "Random";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(464, 218);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "Contador";
            // 
            // labelContador
            // 
            labelContador.AutoSize = true;
            labelContador.Font = new Font("Segoe UI", 50F, FontStyle.Bold);
            labelContador.Location = new Point(613, 190);
            labelContador.Name = "labelContador";
            labelContador.Size = new Size(77, 89);
            labelContador.TabIndex = 5;
            labelContador.Text = "0";
            // 
            // labelRandom
            // 
            labelRandom.AutoSize = true;
            labelRandom.Font = new Font("Segoe UI", 50F, FontStyle.Bold);
            labelRandom.Location = new Point(613, 41);
            labelRandom.Name = "labelRandom";
            labelRandom.Size = new Size(77, 89);
            labelRandom.TabIndex = 6;
            labelRandom.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(800, 450);
            Controls.Add(labelRandom);
            Controls.Add(labelContador);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(btnReset);
            Controls.Add(btnBuscar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnBuscarKeyPress(object sender, UICuesEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btnBuscar;
        private Button btnReset;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label labelContador;
        private Label labelRandom;
    }
}
