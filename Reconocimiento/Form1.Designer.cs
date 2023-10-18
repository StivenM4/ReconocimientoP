namespace Reconocimiento
{
    partial class Form1
    {
        private const int V = 3;

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
            BtnSubir = new Button();
            TextRuta = new TextBox();
            panel1 = new Panel();
            ContenedorImagen = new PictureBox();
            panel3 = new Panel();
            LabelPlaca = new Label();
            label1 = new Label();
            ContenedorPlaca = new PictureBox();
            NombreApp = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ContenedorImagen).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ContenedorPlaca).BeginInit();
            SuspendLayout();
            // 
            // BtnSubir
            // 
            BtnSubir.BackColor = Color.SkyBlue;
            BtnSubir.Font = new Font("Book Antiqua", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSubir.Location = new Point(38, 19);
            BtnSubir.Name = "BtnSubir";
            BtnSubir.Size = new Size(114, 40);
            BtnSubir.TabIndex = 2;
            BtnSubir.Text = "SUBIR";
            BtnSubir.UseVisualStyleBackColor = false;
            BtnSubir.Click += BtnSubir_Click;
            // 
            // TextRuta
            // 
            TextRuta.BackColor = Color.Silver;
            TextRuta.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TextRuta.ForeColor = Color.Black;
            TextRuta.Location = new Point(180, 27);
            TextRuta.Name = "TextRuta";
            TextRuta.Size = new Size(447, 27);
            TextRuta.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaShell;
            panel1.Controls.Add(ContenedorImagen);
            panel1.Controls.Add(TextRuta);
            panel1.Controls.Add(BtnSubir);
            panel1.Location = new Point(-2, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(659, 689);
            panel1.TabIndex = 0;
            // 
            // ContenedorImagen
            // 
            ContenedorImagen.BorderStyle = BorderStyle.FixedSingle;
            ContenedorImagen.Location = new Point(38, 95);
            ContenedorImagen.Name = "ContenedorImagen";
            ContenedorImagen.Size = new Size(576, 392);
            ContenedorImagen.SizeMode = PictureBoxSizeMode.CenterImage;
            ContenedorImagen.TabIndex = 4;
            ContenedorImagen.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SkyBlue;
            panel3.Controls.Add(LabelPlaca);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(ContenedorPlaca);
            panel3.Controls.Add(NombreApp);
            panel3.Location = new Point(663, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(423, 683);
            panel3.TabIndex = 1;
            // 
            // LabelPlaca
            // 
            LabelPlaca.AutoSize = true;
            LabelPlaca.Font = new Font("Book Antiqua", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelPlaca.Location = new Point(219, 336);
            LabelPlaca.Name = "LabelPlaca";
            LabelPlaca.Size = new Size(133, 33);
            LabelPlaca.TabIndex = 3;
            LabelPlaca.Text = "###-###";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(59, 336);
            label1.Name = "label1";
            label1.Size = new Size(132, 33);
            label1.TabIndex = 2;
            label1.Text = "PLACA: ";
            // 
            // ContenedorPlaca
            // 
            ContenedorPlaca.BackColor = Color.SeaShell;
            ContenedorPlaca.BorderStyle = BorderStyle.Fixed3D;
            ContenedorPlaca.Location = new Point(59, 100);
            ContenedorPlaca.Name = "ContenedorPlaca";
            ContenedorPlaca.Size = new Size(321, 120);
            ContenedorPlaca.TabIndex = 1;
            ContenedorPlaca.TabStop = false;
            // 
            // NombreApp
            // 
            NombreApp.AutoSize = true;
            NombreApp.Font = new Font("Bell MT", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            NombreApp.Location = new Point(123, 33);
            NombreApp.Name = "NombreApp";
            NombreApp.Size = new Size(195, 31);
            NombreApp.TabIndex = 0;
            NombreApp.Text = "NOMBRE APP";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1078, 544);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ContenedorImagen).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ContenedorPlaca).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button BtnSubir;
        private TextBox TextRuta;
        private Panel panel1;
        private PictureBox ContenedorImagen;
        private Panel panel3;
        private Label NombreApp;
        private PictureBox ContenedorPlaca;
        private Label LabelPlaca;
        private Label label1;
    }
}