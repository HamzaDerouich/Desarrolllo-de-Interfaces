using Cinesa.Clases;
using MySqlX.XDevAPI;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using System.Net.Mime;
namespace Cinesa.Formularios
{
    public partial class Cesta : Form
    {
        List<ClaseCartelera> listado_productos;
        public Cesta(List<ClaseCartelera> lista)
        {
            InitializeComponent();
            this.listado_productos = lista;

            CargarCesta();
        }

        private void CargarCesta()
        {
            lblCantidad.Text = listado_productos.Count.ToString();
            foreach (ClaseCartelera clase in listado_productos)
            {
                // Especificamos el namespace completo para el Panel
                System.Windows.Forms.Panel panel = new System.Windows.Forms.Panel();
                panel.Width = 50;
                panel.Height = 50;
                panel.BorderStyle = BorderStyle.FixedSingle;

                MemoryStream memoryStream = new MemoryStream(clase.Cartel);
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Image.FromStream(memoryStream);
                pictureBox.Width = 50;
                pictureBox.Height = 40;
                pictureBox.BorderStyle = BorderStyle.FixedSingle;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Dock = DockStyle.Top;

                Label label = new Label();
                label.Text = clase.Titulo.ToString();
                label.AutoSize = true;
                label.Dock = DockStyle.Bottom;

                panel.Controls.Add(pictureBox);
                panel.Controls.Add(label);

                flowLayoutPanel1.Controls.Add(panel);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ClaseCartelera cartel in listado_productos)
            {
                GenerarCodigoQr(cartel);
               
            }
        }

        private void GenerarCodigoQr(ClaseCartelera cartelera)
        {
            // Generamos la clave QR 
            string claveQR = cartelera.Fecha + "X" + cartelera.Titulo + "X" + cartelera.Sala + "X" + cartelera.Minutos;

            // Limpiar el nombre del archivo de caracteres no válidos
            claveQR = LimpiarNombreArchivo(claveQR);

            // Generador de QR

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(claveQR, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);

            // Crear imagen del QR

            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            // Ruta de almacenamiento del QR

            string folderPath = @"C:\QR_CINESA";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);  // Crear la carpeta si no existe
            }

            // Guardar el archivo de imagen

            string fileName = Path.Combine(folderPath, claveQR + ".png");
            qrCodeImage.Save(fileName, ImageFormat.Png);

            // Enviar QR por correo electrónico
            EnviarCorreo(fileName, cartelera);
        }

        public void EnviarCorreo(string rutaPdf, ClaseCartelera cartelera)
        {
            MailMessage correo = new MailMessage();
            correo.From = new MailAddress("hamsaderouich141@gmail.com");
            correo.To.Add("profeaugustobriga@gmail.com");
            correo.Subject = "CINES NAVALMORAL DE LA MATA";


            correo.IsBodyHtml = true;
            string htmlBody = @"
            <html>
            <body style='font-family: Arial, sans-serif;'>
            <h2 style='color: #4CAF50;'>Compra de Ticket de Película</h2>
            <p><strong>Título de la película:</strong> " + cartelera.Titulo + @"</p>
            <p><strong>Duración:</strong> " + cartelera.Minutos + @" minutos</p>
            <p><strong>Sala:</strong> " + cartelera.Sala + @"</p>
            <hr style='border-top: 1px solid #ccc;'/>
            <p style='font-size: 0.9em;'>Fecha de envío: <em>" + DateTime.Now.ToString("f") + @"</em></p>
            <p>Gracias por su compra. ¡Disfrute de la película!</p>
            </body>
            </html>
            ";

            // Crear una vista alternativa en HTML para el correo
            AlternateView avHtml = AlternateView.CreateAlternateViewFromString(htmlBody, null, MediaTypeNames.Text.Html);

          
            // Agregar la vista alternativa al correo

            correo.AlternateViews.Add(avHtml);

            // Adjuntar el PDF

            correo.Attachments.Add(new Attachment(rutaPdf));

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential("hamsaderouich141@gmail.com", "slpb pwbk hlsg jfdl");
            smtp.EnableSsl = true;

            try
            {
                smtp.Send(correo);
                MessageBox.Show("Correo enviado correctamente.");
                flowLayoutPanel1.Controls.Clear();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar el correo: " + ex.Message);
            }
        }

        private string LimpiarNombreArchivo(string nombre)
        {
            // Eliminar caracteres no válidos en nombres de archivos
            foreach (char c in Path.GetInvalidFileNameChars())
            {
                nombre = nombre.Replace(c.ToString(), "");
            }
            return nombre;
        }
    }
}
