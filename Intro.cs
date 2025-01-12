using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;

namespace Compito
{
    public partial class Intro : Form
    {
        private Main_Menu menu;
        public Intro(Main_Menu main_Menu)
        {
            InitializeComponent();
            menu = main_Menu;
            PlayVideoFromResources();
        }

        private void PlayVideoFromResources()
        {
            byte[] videoData = Properties.Resources.Fallout_intro;

            string tempPath = Path.Combine(Path.GetTempPath(), "video_temp.mp4"); // Cambia l'estensione se il tuo video è in un altro formato

            // Salva il file sul disco
            File.WriteAllBytes(tempPath, videoData);

            // Riproduci il video con il controllo WMP
            axWindowsMediaPlayer1.URL = tempPath;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                menu.Show();

                this.Close();
                return true; // Indica che il tasto è stato gestito
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Intro_FormClosed(object sender, FormClosedEventArgs e)
        {
            string tempPath = Path.Combine(Path.GetTempPath(), "video_temp.mp4");
            if (File.Exists(tempPath))
            {
                File.Delete(tempPath);
            }
        }
    }
}
