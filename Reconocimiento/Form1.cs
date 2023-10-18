using Tesseract;

namespace Reconocimiento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void BtnSubir_Click(object sender, EventArgs e)
        {
            //crea un objeto para abrir una carpeta en la cual guardar imagen, solo acepta formatos jpg y png
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Archivos de imagen|*.jpg; *.png";
            //el direcctorio inicial se abre en imagenes
            abrir.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            abrir.Title = "Seleccion la imagen";
            String text = "";


            if (abrir.ShowDialog() == DialogResult.OK)
            {
                //ponemos la imagen seleccionada al contendor de la interfaz grafica
                ContenedorImagen.Image = Image.FromFile(abrir.FileName);
                //asginamos la imagen a un string para ser procesada
                string imagen = abrir.FileName;

                //Procesamiento de imagen con con la carpeta tessdata ademas de darle el idioma
                using (var engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default))

                using (var img = Pix.LoadFromFile(imagen))
                {

                    using (var page = engine.Process(img))
                    {
                        //asignamos el texto obtenido por el procesamiento para ponerlo en la etiqueta
                        text = page.GetText();
                        LabelPlaca.Text = text;
                        TextRuta.Text = imagen;
                    }

                }
            }
        }
    }
}