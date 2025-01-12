using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace Compito
{
    public partial class Char_Creator : Form
    {
        private Main_Menu menu;
        private int pointsAvailable = 5;
        private int[] stats = new int[7]; // Array per le statistiche SPECIAL
        private readonly string[] statNames = { "Strength", "Perception", "Endurance", "Charisma", "Intelligence", "Agility", "Luck" };

        public Char_Creator(Main_Menu menu)
        {
            InitializeComponent();
            this.menu = menu;
        }

        private void InfoChange(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                // Cambia l'immagine della PictureBox in base al Label cliccato
                switch (clickedLabel.Name)
                {
                    case "Lbl_S":
                        Pb_statInfo.Image = Properties.Resources.Strength;
                        break;
                    case "Lbl_P":
                        Pb_statInfo.Image = Properties.Resources.Perception;
                        break;
                    case "Lbl_E":
                        Pb_statInfo.Image = Properties.Resources.Endurance;
                        break;
                    case "Lbl_C":
                        Pb_statInfo.Image = Properties.Resources.Charisma;
                        break;
                    case "Lbl_I":
                        Pb_statInfo.Image = Properties.Resources.Intelligence;
                        break;
                    case "Lbl_A":
                        Pb_statInfo.Image = Properties.Resources.Agility;
                        break;
                    case "Lbl_L":
                        Pb_statInfo.Image = Properties.Resources.Luck;
                        break;
                    default:
                        break;
                }
            }
        }

        private void UpdateStatLabel(int statIndex)
        {
            // Aggiorna la label della statistica specifica
            Gbox_Special.Controls[$"Lbl_value{statIndex}"].Text = stats[statIndex].ToString();
        }

        private void UpdatePointsLabel()
        {
            // Aggiorna il contatore dei punti disponibili
            Lbl_points.Text = pointsAvailable.ToString("00");
        }


        private void Char_Creator_Load(object sender, EventArgs e)
        {
            // Inizializza le statistiche e l'interfaccia
            for (int i = 0; i < stats.Length; i++)
            {
                stats[i] = 5; // Valore base di ogni statistica
                UpdateStatLabel(i);
            }

            UpdatePointsLabel();

        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            // Identifica il pulsante cliccato
            Button button = sender as Button; // Cast al tipo Button
            if (button == null) return; // Se non è un Button, esci dalla funzione

            // Legge l'indice della statistica dal Tag del pulsante
            int statIndex = int.Parse(button.Tag.ToString());

            // Controlla se ci sono punti disponibili e la statistica non supera il massimo
            if (pointsAvailable > 0)
            {
                stats[statIndex]++;         // Incrementa la statistica
                pointsAvailable--;          // Decrementa i punti disponibili
                UpdateStatLabel(statIndex); // Aggiorna il valore della statistica nella Label
                UpdatePointsLabel();        // Aggiorna i punti disponibili
            }
            else { MessageBox.Show("No more points available!"); }
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            // Identifica quale statistica decrementare
            Button button = sender as Button;
            int statIndex = int.Parse(button.Tag.ToString());

            if (stats[statIndex] > 1)
            {
                stats[statIndex]--;
                pointsAvailable++;
                UpdateStatLabel(statIndex);
                UpdatePointsLabel();
            }
            else { MessageBox.Show("Minimum points for each Stat is 1"); }
        }

        private void Btn_done_Click(object sender, EventArgs e)
        {
            string name = Txt_name.Text;
            string gender = RdoMale.Checked ? "Male" : "Female";

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Enter a name for the character!");
                return;
            }

            if (pointsAvailable > 0)
            {
                MessageBox.Show("Unused points still available!");
                return;
            }

            int strength = int.Parse(Lbl_value0.Text);
            int perception = int.Parse(Lbl_value1.Text);
            int endurance = int.Parse(Lbl_value2.Text);
            int charisma = int.Parse(Lbl_value3.Text);
            int intelligence = int.Parse(Lbl_value4.Text);
            int agility = int.Parse(Lbl_value5.Text);
            int luck = int.Parse(Lbl_value6.Text);

            Character newCharacter = new Character(name, gender, strength, perception, endurance, charisma,
                                          intelligence, agility, luck);

            MessageBox.Show("Character created succesfully!\n\n" + newCharacter.ToString());

            newCharacter.SaveCharacterToFile();

            menu.Show();
            this.Close();
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }
    }
}
