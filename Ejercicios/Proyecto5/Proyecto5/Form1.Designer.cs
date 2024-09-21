namespace Proyecto5
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
            bntRandoms = new Button();
            button2 = new Button();
            grbAleatorios = new GroupBox();
            SuspendLayout();
            // 
            // bntRandoms
            // 
            bntRandoms.Location = new Point(290, 52);
            bntRandoms.Name = "bntRandoms";
            bntRandoms.Size = new Size(153, 73);
            bntRandoms.TabIndex = 0;
            bntRandoms.Text = "btnRandom";
            bntRandoms.UseVisualStyleBackColor = true;
            bntRandoms.Click += bntRandoms_Click;
            // 
            // button2
            // 
            button2.Location = new Point(554, 129);
            button2.Name = "button2";
            button2.Size = new Size(8, 8);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // grbAleatorios
            // 
            grbAleatorios.Location = new Point(203, 149);
            grbAleatorios.Name = "grbAleatorios";
            grbAleatorios.Size = new Size(328, 219);
            grbAleatorios.TabIndex = 2;
            grbAleatorios.TabStop = false;
            grbAleatorios.Text = "Aleatorios";
            grbAleatorios.Enter += grbAleatorios_Enter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grbAleatorios);
            Controls.Add(button2);
            Controls.Add(bntRandoms);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button bntRandoms;
        private Button button2;
        private GroupBox grbAleatorios;
    }
}
