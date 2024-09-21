namespace Proyecto_Cuatro_Cuenta_Atras
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
            bt1Inicio = new Button();
            tmrInicio = new System.Windows.Forms.Timer(components);
            btnCuentaAtras = new Button();
            SuspendLayout();
            // 
            // bt1Inicio
            // 
            bt1Inicio.BackColor = Color.MediumSeaGreen;
            bt1Inicio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            bt1Inicio.ForeColor = SystemColors.ActiveCaptionText;
            bt1Inicio.Location = new Point(280, 86);
            bt1Inicio.Name = "bt1Inicio";
            bt1Inicio.Size = new Size(173, 77);
            bt1Inicio.TabIndex = 0;
            bt1Inicio.Text = "Inicio";
            bt1Inicio.UseVisualStyleBackColor = false;
            bt1Inicio.Click += bt1Inicio_Click;
            // 
            // tmrInicio
            // 
            tmrInicio.Interval = 1000;
            tmrInicio.Tick += bt1Inicio_Click;
            // 
            // btnCuentaAtras
            // 
            btnCuentaAtras.BackColor = Color.White;
            btnCuentaAtras.Font = new Font("Segoe UI", 40F, FontStyle.Bold);
            btnCuentaAtras.Location = new Point(280, 180);
            btnCuentaAtras.Name = "btnCuentaAtras";
            btnCuentaAtras.Size = new Size(173, 142);
            btnCuentaAtras.TabIndex = 1;
            btnCuentaAtras.Text = "0";
            btnCuentaAtras.UseVisualStyleBackColor = false;
            btnCuentaAtras.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCuentaAtras);
            Controls.Add(bt1Inicio);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button bt1Inicio;
        private System.Windows.Forms.Timer tmrInicio;
        private Button btnCuentaAtras;
    }
}
