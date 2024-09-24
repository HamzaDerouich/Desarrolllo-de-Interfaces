using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primitiva
{
    public partial class Form1 : Form
    {
       
        Random random = new Random();
        int contadorAciertos = 0; // Contador para los números acertados
        int numeroGanador1 = 0; // Primer número ganador
        int numeroGanador2 = 0; // Segundo número ganador
        int numeroGanador3 = 0; // Tercer número ganador
        int numeroGanador4 = 0; // Cuarto número ganador
        int numeroGanador5 = 0; // Quinto número ganador
        int numeroGanador6 = 0; // Sexto número ganador
        int numero1 = 0; // Primer número del usuario
        int numero2 = 0; // Segundo número del usuario
        int numero3 = 0; // Tercer número del usuario
        int numero4 = 0; // Cuarto número del usuario
        int numero5 = 0; // Quinto número del usuario
        int numero6 = 0; // Sexto número del usuario
        Boolean acertados = false; // Variable que controla si hay aciertos

        public Form1()
        {
            InitializeComponent();
        }

        // Evento KeyPress del textBox1 para verificar cuando el usuario presiona Enter
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; 
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Si el número ingresado es válido, se desactiva el textbox y se enfoca en el siguiente
                if (!ValidarNumeros(numero1))
                {
                    textBox1.Enabled = false;
                    textBox2.Select();
                }
                else
                {
                    MensajeError(); 
                }
            }
        }

        // Evento KeyPress del textBox2 para verificar cuando el usuario presiona Enter
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; 
                numero2 = Convert.ToInt16(textBox2.Text); 
                numero1 = Convert.ToInt16(textBox1.Text);
                // Validar que el número ingresado sea válido y no esté repetido
                if (!ValidarNumeros(numero2) && !NumerosIguales(numero1, numero2))
                {
                    textBox2.Enabled = false; 
                    textBox3.Select();
                }
                else
                {
                    MensajeError(); 
                }
            }
        }

        // Evento KeyPress del textBox3 para verificar cuando el usuario presiona Enter
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                numero2 = Convert.ToInt16(textBox2.Text);
                numero1 = Convert.ToInt16(textBox1.Text);
                numero3 = Convert.ToInt16(textBox3.Text);
                // Comprobar que el número es válido y no repetido
                if (!ValidarNumeros(numero3) && !NumerosIguales(numero3, numero1) && !NumerosIguales(numero3, numero2))
                {
                    textBox3.Enabled = false;
                    textBox4.Select();
                }
                else
                {
                    MensajeError();
                }
            }
        }

        // Evento KeyPress del textBox4 para verificar cuando el usuario presiona Enter
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                numero1 = Convert.ToInt16(textBox1.Text);
                numero2 = Convert.ToInt16(textBox2.Text);
                numero3 = Convert.ToInt16(textBox3.Text);
                numero4 = Convert.ToInt16(textBox4.Text);
                // Comprobar que el número es válido y no repetido
                if (!ValidarNumeros(numero4) && !NumerosIguales(numero4, numero3) && !NumerosIguales(numero4, numero2) && !NumerosIguales(numero4, numero1))
                {
                    textBox4.Enabled = false;
                    textBox5.Select();
                }
                else
                {
                    MensajeError();
                }
            }
        }

        // Evento KeyPress del textBox5 para verificar cuando el usuario presiona Enter
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                numero1 = Convert.ToInt16(textBox1.Text);
                numero2 = Convert.ToInt16(textBox2.Text);
                numero3 = Convert.ToInt16(textBox3.Text);
                numero4 = Convert.ToInt16(textBox4.Text);
                numero5 = Convert.ToInt16(textBox5.Text);
                // Comprobar que el número es válido y no repetido
                if (!ValidarNumeros(numero5) && !NumerosIguales(numero5, numero4) && !NumerosIguales(numero5, numero3) && !NumerosIguales(numero5, numero2) && !NumerosIguales(numero5, numero1))
                {
                    textBox5.Enabled = false;
                    textBox6.Select();
                }
                else
                {
                    MensajeError();
                }
            }
        }

        // Evento KeyPress del textBox6 para verificar cuando el usuario presiona Enter
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                numero1 = Convert.ToInt16(textBox1.Text);
                numero2 = Convert.ToInt16(textBox2.Text);
                numero3 = Convert.ToInt16(textBox3.Text);
                numero4 = Convert.ToInt16(textBox4.Text);
                numero5 = Convert.ToInt16(textBox5.Text);
                numero6 = Convert.ToInt16(textBox6.Text);
                // Comprobar que el número es válido y no repetido
                if (!ValidarNumeros(numero6) && !NumerosIguales(numero6, numero5) && !NumerosIguales(numero6, numero4) && !NumerosIguales(numero6, numero3) && !NumerosIguales(numero6, numero2) && !NumerosIguales(numero6, numero1))
                {
                    textBox6.Enabled = false;
                }
                else
                {
                    MensajeError();
                }
            }
        }

        // Método que limpia los TextBox para empezar un nuevo juego
        private void LimpiarTextBox()
        {
            textBox1.Select(); // Selecciona el primer TextBox
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

            // Rehabilita todos los TextBox
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;

            acertados = false; // Reiniciar la variable de aciertos
        }

        // Método que comprueba cuántos números han sido acertados
        private void ComprobarAciertos()
        {
            GenerarNumerosGanadores(); // Generar los números ganadores
            ObtenerNumeros(); // Obtener los números ingresados por el usuario
            MostrarNumerosGandores(); // Mostrar los números ganadores

            // Arrays que contienen los números del usuario y los ganadores
            int[] numeros = { numero1, numero2, numero3, numero4, numero5, numero6 };
            int[] numerosGandores = { numeroGanador1, numeroGanador2, numeroGanador3, numeroGanador4, numeroGanador5, numeroGanador6 };
            int[] acertados = new int[6]; // Array para almacenar los números acertados
            int a = 0;
            for (int i = 0; i < numerosGandores.Length; i++)
            {
                for (int j = 0; j < numeros.Length; j++)
                {
                    if (numeros[i] == numerosGandores[j])
                    {
                        contadorAciertos++; // Incrementar contador si hay un acierto
                        acertados[a] = numeros[i]; // Guardar el número acertado
                        a++;
                    }
                }
            }

            lblAciertos.Text = contadorAciertos.ToString(); // Mostrar el número de aciertos
            MostrarAciertos(acertados); // Mostrar los números acertados
        }

        // Método que muestra los números acertados en el FlowLayoutPanel
        private void MostrarAciertos(int[] acertados)
        {
            for (int i = 0; i < acertados.Length; i++)
            {
                if (acertados[i] != 0)
                {
                    Label label = new Label(); 
                    label.Text = acertados[i].ToString(); 
                    flpanelAcertados.Controls.Add(label);
                }
            }
        }

        // Método para obtener los números ingresados por el usuario desde los TextBox
        private void ObtenerNumeros()
        {
            numero1 = Convert.ToInt16(textBox1.Text);
            numero2 = Convert.ToInt16(textBox2.Text);
            numero3 = Convert.ToInt16(textBox3.Text);
            numero4 = Convert.ToInt16(textBox4.Text);
            numero5 = Convert.ToInt16(textBox5.Text);
            numero6 = Convert.ToInt16(textBox6.Text);
        }

        // Método que muestra los números ganadores en las etiquetas correspondientes
        private void MostrarNumerosGandores()
        {
            label1.Text = numeroGanador1.ToString();
            label2.Text = numeroGanador2.ToString();
            label3.Text = numeroGanador3.ToString();
            label4.Text = numeroGanador4.ToString();
            label5.Text = numeroGanador5.ToString();
            label6.Text = numeroGanador6.ToString();
        }

        // Método que genera los números ganadores aleatoriamente
        private void GenerarNumerosGanadores()
        {
            numeroGanador1 = random.Next(1, 60);
            numeroGanador2 = random.Next(1, 60);
            numeroGanador3 = random.Next(1, 60);
            numeroGanador4 = random.Next(1, 60);
            numeroGanador5 = random.Next(1, 60);
            numeroGanador6 = random.Next(1, 60);
        }

        // Método que valida si un número es válido (debe estar entre 1 y 60)
        private Boolean ValidarNumeros(int a)
        {
            if (a < 0 || a > 60)
            {
                return true; // Número no válido
            }
            else
            {
                return false; // Número válido
            }
        }

        // Método que comprueba si dos números son iguales
        private Boolean NumerosIguales(int a, int b)
        {
            if (a == b)
            {
                return true; // Son iguales
            }
            else
            {
                return false; // No son iguales
            }
        }

        // Método que muestra un mensaje de error cuando los números no son válidos o son repetidos
        private void MensajeError()
        {
            MessageBox.Show("Números iguales, valores no validos!!");
        }

        // Evento que comprueba si existen números iguales y muestra un mensaje si los hay
        private void button2_Click(object sender, EventArgs e)
        {
            int contadorIguales = 0;
            Boolean iguales = false;

            TextBox[] listado = groupBox1.Controls.OfType<TextBox>().ToArray(); // Convertir el groupBox en un array de TextBox
            for (int i = 0; i < listado.Length; i++)
            {
                for (int j = i + 1; j < listado.Length; j++)
                {
                    if (Convert.ToInt16(listado[i].Text) == Convert.ToInt16(listado[j].Text))
                    {
                        contadorIguales++; // Incrementar el contador si encuentra números iguales
                    }
                }
            }

            if (!iguales)
            {
                MessageBox.Show("Error, existen " + contadorIguales + " numeros iguales!!");
                LimpiarTextBox(); // Limpiar los TextBox si hay números repetidos
            }
        }

        // Evento click que comprueba los aciertos en el juego
        private void button1_Click(object sender, EventArgs e)
        {
            ComprobarAciertos(); // Comprobar cuántos aciertos tiene el usuario
            LimpiarTextBox(); // Limpiar los TextBox para iniciar un nuevo juego
            LimpiarAcertados(); // Limpiar los números acertados mostrados en pantalla
        }

        // Método que limpia el FlowLayoutPanel de los números acertados
        private void LimpiarAcertados()
        {
            if (acertados.Equals(true))
            {
                acertados = false;
                flpanelAcertados.Controls.Clear(); // Limpiar el panel de controles
            }
        }

        // Evento KeyPress que cierra la aplicación cuando se presiona la tecla Escape
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                
                DialogResult = MessageBox.Show("¿Quieres salir?", "Ventana Salida", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                if (DialogResult == DialogResult.Yes)
                {
                    Close(); 
                }
            }
        }
    }
}
