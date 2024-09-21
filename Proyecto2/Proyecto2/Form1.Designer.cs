namespace Proyecto2
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
            tmrNumerosMayoresMenores = new System.Windows.Forms.Timer(components);
            btnPausar = new Button();
            btnEmpezar = new Button();
            btnSalir = new Button();
            listBoxMayores = new ListBox();
            listBoxMenores = new ListBox();
            labelNumeroMayorMenor = new Label();
            SuspendLayout();
            // 
            // tmrNumerosMayoresMenores
            // 
            tmrNumerosMayoresMenores.Enabled = true;
            tmrNumerosMayoresMenores.Interval = 1000;
            tmrNumerosMayoresMenores.Tick += btnEmpezar_Click;
            // 
            // btnPausar
            // 
            btnPausar.Location = new Point(332, 33);
            btnPausar.Name = "btnPausar";
            btnPausar.Size = new Size(135, 66);
            btnPausar.TabIndex = 0;
            btnPausar.Text = "Pausar";
            btnPausar.UseVisualStyleBackColor = true;
            btnPausar.Click += btnPausar_Click;
            // 
            // btnEmpezar
            // 
            btnEmpezar.Location = new Point(40, 33);
            btnEmpezar.Name = "btnEmpezar";
            btnEmpezar.Size = new Size(135, 66);
            btnEmpezar.TabIndex = 1;
            btnEmpezar.Text = "Empezar";
            btnEmpezar.UseVisualStyleBackColor = true;
            btnEmpezar.Click += btnEmpezar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(634, 40);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(135, 59);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // listBoxMayores
            // 
            listBoxMayores.FormattingEnabled = true;
            listBoxMayores.ItemHeight = 15;
            listBoxMayores.Location = new Point(40, 154);
            listBoxMayores.Name = "listBoxMayores";
            listBoxMayores.Size = new Size(135, 259);
            listBoxMayores.TabIndex = 3;
            // 
            // listBoxMenores
            // 
            listBoxMenores.FormattingEnabled = true;
            listBoxMenores.ItemHeight = 15;
            listBoxMenores.Location = new Point(634, 154);
            listBoxMenores.Name = "listBoxMenores";
            listBoxMenores.Size = new Size(135, 259);
            listBoxMenores.TabIndex = 4;
            // 
            // labelNumeroMayorMenor
            // 
            labelNumeroMayorMenor.AutoSize = true;
            labelNumeroMayorMenor.Font = new Font("Segoe UI", 40F, FontStyle.Bold, GraphicsUnit.Point, 6);
            labelNumeroMayorMenor.Location = new Point(370, 223);
            labelNumeroMayorMenor.Name = "labelNumeroMayorMenor";
            labelNumeroMayorMenor.Size = new Size(61, 72);
            labelNumeroMayorMenor.TabIndex = 5;
            labelNumeroMayorMenor.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(800, 450);
            Controls.Add(labelNumeroMayorMenor);
            Controls.Add(listBoxMenores);
            Controls.Add(listBoxMayores);
            Controls.Add(btnSalir);
            Controls.Add(btnEmpezar);
            Controls.Add(btnPausar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer tmrNumerosMayoresMenores;
        private Button btnPausar;
        private Button btnEmpezar;
        private Button btnSalir;
        private ListBox listBoxMayores;
        private ListBox listBoxMenores;
        private Label labelNumeroMayorMenor;
    }
}
