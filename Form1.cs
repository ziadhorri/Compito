using System.Reflection;
using AxWMPLib;
using WMPLib;

namespace Compito
{
    public partial class Main_Menu : Form
    {
        private bool wasPlaying = false;

        public Main_Menu()
        {
            InitializeComponent();
            PlayAudioFromResources();
        }

        private void PlayAudioFromResources()
        {
            // Ottieni il contenuto audio dalle risorse
            byte[] audioData = Properties.Resources.Bg_Music;

            // Percorso temporaneo per salvare il file audio
            string tempPath = Path.Combine(Path.GetTempPath(), "audio_temp.mp3"); // Usa l'estensione corretta del tuo file audio

            // Scrivi il file temporaneamente sul disco
            File.WriteAllBytes(tempPath, audioData);

            // Imposta il percorso del file audio nel controllo WMP
            axWindowsMediaPlayer1.URL = tempPath;

            axWindowsMediaPlayer1.settings.setMode("loop", true);

            // Avvia la riproduzione
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void Btn_CreateChar_Click(object sender, EventArgs e)
        {
            this.Hide();

            Char_Creator char_Creator = new Char_Creator(this);
            char_Creator.Show();
        }

        private void Btn_Intro_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                wasPlaying = true;
                axWindowsMediaPlayer1.Ctlcontrols.pause(); // Metti in pausa
            }

            // Crea e mostra il nuovo form
            Intro intro = new Intro(this);
            intro.FormClosed += (s, args) =>
            {
                // Riprendi la riproduzione se era in esecuzione
                if (wasPlaying)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    wasPlaying = false; // Resetta lo stato
                }
            };

            intro.Show();
        }


        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            string tempPath = Path.Combine(Path.GetTempPath(), "audio_temp.mp3");
            if (File.Exists(tempPath))
            {
                File.Delete(tempPath);
            }
        }

        private void Btn_LoadChar_Click(object sender, EventArgs e)
        {
            Char_Loader char_Loader = new Char_Loader(this);
            this.Hide();
            char_Loader.Show();
        }
    }
}
