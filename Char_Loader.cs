using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Compito
{
    public partial class Char_Loader : Form
    {
        private Main_Menu menu;
        private List<Bitmap> images;
        private List<string> imageNames;
        private int currentImageIndex = 0; // Indice attuale dell'immagine

        public Char_Loader(Main_Menu main_Menu)
        {
            InitializeComponent();

            this.menu = main_Menu;

            images = new List<Bitmap>
            {
                Properties.Resources.Albert,
                Properties.Resources.Max,
                Properties.Resources.Natalia
            };

            imageNames = new List<string>
            {
                "Albert",
                "Max_Stone",
                "Natalia"
            };
            ShowImage();
        }

        private void ShowImage()
        {
            if (images.Count > 0)
            {
                selectedChar.Image = images[currentImageIndex];
            }
        }

        private void Btn_arrowL_Click(object sender, EventArgs e)
        {
            currentImageIndex = (currentImageIndex - 1 + images.Count) % images.Count;
            ShowImage();
        }

        private void Btn_arrowR_Click(object sender, EventArgs e)
        {
            currentImageIndex = (currentImageIndex + 1) % images.Count;
            ShowImage();
        }

        private void Btn_create_Click(object sender, EventArgs e)
        {
            string currentImageName = imageNames[currentImageIndex];

            string jsonPath = Path.Combine(Directory.GetCurrentDirectory(), "Character", "BaseCharacters", $"{currentImageName}.json");

            using (StreamReader reader = new StreamReader(jsonPath))
            {
                // Leggi il contenuto del file
                string jsonContent = reader.ReadToEnd();

                // Deserializza il contenuto del file in un oggetto Character
                Character character = JsonSerializer.Deserialize<Character>(jsonContent);

                MessageBox.Show("Character created succesfully!\n\n" + character.ToString());
                menu.Show();
                this.Close();
            }
        }

        private void Btn_take_Click(object sender, EventArgs e)
        {
            using (openFileDialog1 = new OpenFileDialog())
            {
                // Imposta la directory predefinita per l'esplorazione
                openFileDialog1.InitialDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Character");

                // Imposta il filtro per selezionare solo i file JSON
                openFileDialog1.Filter = "File JSON (*.json)|*.json";

                // Mostra la finestra di dialogo e verifica se l'utente ha selezionato un file
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Ottieni il percorso del file selezionato
                    string selectedFilePath = openFileDialog1.FileName;

                    using (StreamReader reader = new StreamReader(selectedFilePath))
                    {
                        // Leggi il contenuto del file
                        string jsonContent = reader.ReadToEnd();

                        // Deserializza il contenuto del file in un oggetto Character
                        Character character = JsonSerializer.Deserialize<Character>(jsonContent);

                        MessageBox.Show("Character created succesfully!\n\n" + character.ToString());
                        menu.Show();
                        this.Close();
                    }
                }
            }
        }


        private void Btn_back_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }
    }
}
