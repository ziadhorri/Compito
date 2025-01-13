using System.Reflection;
using AxWMPLib;
using WMPLib;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Compito
{
    public partial class Main_Menu : Form
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool FreeConsole();



        public Character Character { get; set; }
        private bool wasPlaying = false;

        public Main_Menu()
        {
            InitializeComponent();
            PlayAudioFromResources();
        }

        private void StartGame()
        {
            if (Character == null)
            {
                MessageBox.Show("No character initialized! Please create a character first.");
                return;
            }
            Console.WriteLine($"Starting game with character: {Character.Name}");
            Console.WriteLine("Press Enter to confirm...");
            Console.ReadLine();

            Console.Clear();

            // Intro del membro anziano del Vault
            WriteWithDelay("Vault Overseer: Welcome, citizen.");
            WriteWithDelay("Our water purification chip has failed, and our supplies of clean water are running dangerously low.");
            WriteWithDelay("You have been chosen to leave Vault 13 and search for a replacement water chip.");
            WriteWithDelay("You must find the chip and return within 150 days, or our vault will perish.");
            WriteWithDelay("Your Pip-Boy 2000 will guide you. Good luck.");
            WriteWithDelay("\nPress Enter to begin your journey...");
            Console.ReadLine();

            Console.Clear();
            WriteWithDelay("You stand at the entrance of Vault 13. The heavy metal door slides open with a deafening roar.");
            WriteWithDelay("A cold breeze rushes in, carrying the scent of the unknown. The wasteland awaits...");
            WriteWithDelay("\nYou step outside into a dark cave. You notice the creepy surroundings and can't help but hear all the mutant noises.");
            WriteWithDelay("\nDo you:");
            WriteWithDelay("1. Venture deeper into the cave.");
            WriteWithDelay("2. Return to the safety of the vault.");

            string choice = Console.ReadLine();
            if (choice == "2")
            {
                WriteWithDelay("\nYou return to the vault, but the Overseer scolds you for your cowardice.");
                WriteWithDelay("You are exiled, and your people perish without water.");
                WriteWithDelay("GAME OVER!");
                WriteWithDelay("Press any key to exit...");
                Console.ReadKey();
                return;
            }

            Console.Clear();
            WriteWithDelay("You venture deeper into the cave. It's dark and eerily quiet...");
            WriteWithDelay("Suddenly, a mutant cave rat appears in front of you. Its red eyes gleam with hunger.");
            WriteWithDelay("\nDo you:");
            WriteWithDelay("1. Attack the cave rat.");
            WriteWithDelay("2. Ignore the rat and try to sneak past it.");

            choice = Console.ReadLine();
            if (choice == "1")
            {
                if (Character.Strength < 5)
                {
                    WriteWithDelay("Your Strength is too low!");
                    WriteWithDelay("\nYou swing your fists at the cave rat, but your weak punches barely faze it.");
                    WriteWithDelay("The rat retaliates, biting you viciously.");
                    WriteWithDelay("You succumb to your injuries.");
                    WriteWithDelay("GAME OVER.");
                    WriteWithDelay("Press any key to exit...");
                    Console.ReadKey();
                    return;
                }
                else
                {
                    WriteWithDelay("\nUsing your strength, you crush the cave rat with a single blow.");
                    WriteWithDelay("The path is clear.");
                }
            }
            else if (choice == "2")
            {
                if (Character.Agility < 7)
                {
                    WriteWithDelay("Your Agility is too low!");
                    WriteWithDelay("You try to quietly make your way around but you're too noisy and clumsy.");
                    WriteWithDelay("The rat bites you viciously.");
                    WriteWithDelay("You succumb to your injuries.");
                    WriteWithDelay("GAME OVER.");
                    WriteWithDelay("Press any key to exit...");
                    Console.ReadKey();
                    return;
                }
                else
                {
                    WriteWithDelay("\nYou quietly step around the cave rat, avoiding its gaze. It doesn't notice you.");
                }
            }
            else
            {
                WriteWithDelay("\nYou hesitate, and the rat attacks!");
                WriteWithDelay("You are caught off guard and fall victim to its claws.");
                WriteWithDelay("GAME OVER.");
                WriteWithDelay("Press any key to exit...");
                Console.ReadKey();
                return;
            }

            WriteWithDelay("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            WriteWithDelay("As you move deeper into the cave, you hear skittering sounds. A group of giant ants blocks your path.");
            WriteWithDelay("\nDo you:");
            WriteWithDelay("1. Fight the ants.");
            WriteWithDelay("2. Try to scare them off using a torch.");

            choice = Console.ReadLine();
            if (choice == "1")
            {
                if (Character.Strength < 7)
                {
                    WriteWithDelay("\nThe ants overwhelm you with their numbers. You fight bravely, but your strength is insufficient.");
                    WriteWithDelay("You fall to the ground, defeated.");
                    WriteWithDelay("GAME OVER.");
                    WriteWithDelay("Press any key to exit...");
                    Console.ReadKey();
                    return;
                }
                else
                {
                    WriteWithDelay("\nWith your superior strength, you crush the ants and clear the path.");
                }
            }
            else if (choice == "2")
            {
                if (Character.Intelligence < 3)
                {
                    WriteWithDelay("\nYou try to light the torch, but your lack of common sense leads to failure.");
                    WriteWithDelay("The ants swarm you.");
                    WriteWithDelay("GAME OVER.");
                    WriteWithDelay("Press any key to exit...");
                    Console.ReadKey();
                    return;
                }
                else
                {
                    WriteWithDelay("\nYou light the torch and wave it in front of the ants. They scatter in fear.");
                }
            }
            else
            {
                WriteWithDelay("\nYour hesitation costs you dearly. The ants swarm you.");
                WriteWithDelay("GAME OVER.");
                WriteWithDelay("Press any key to exit...");
                Console.ReadKey();
                return;
            }

            WriteWithDelay("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            WriteWithDelay("You finally emerge from the cave into the open wasteland. The sunlight blinds you for a moment.");
            WriteWithDelay("Ahead lies a vast desert, and in the distance, you see the ruins of an old town.");
            WriteWithDelay("\nYour journey has just begun...");
            WriteWithDelay("\nCongratulations! You have survived the first step of your adventure.");
        }
    

        public static void WriteWithDelay(string message)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(10); // Ritardo tra ogni lettera
            }
            Console.WriteLine(); // Vai a capo alla fine
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

        private void Btn_NewGame_Click(object sender, EventArgs e)
        {
            this.Hide();

            try
            {
                AllocConsole(); // Alloca la console
                Console.ForegroundColor = ConsoleColor.Green;
                StartGame(); // Avvia il gioco
            }
            finally //Quando il metodo StartGame termina il codice passa al blocco finally
            {
                this.Close();
                FreeConsole(); //Chiudi la Console
            }
        }
    }
}
