using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Compito
{
    internal class Character
    {
        public string Name { get; private set; }
        public string Gender { get; private set; }
        public int Strength { get; set; }
        public int Perception { get; set; }
        public int Endurance { get; set; }
        public int Charisma { get; set; }
        public int Intelligence { get; set; }
        public int Agility { get; set; }
        public int Luck { get; set; }

        // Costruttore della classe
        public Character(string name, string gender, int strength, int perception, int endurance, int charisma,
                         int intelligence, int agility, int luck)
        {
            Name = name;
            Gender = gender;
            Strength = strength;
            Perception = perception;
            Endurance = endurance;
            Charisma = charisma;
            Intelligence = intelligence;
            Agility = agility;
            Luck = luck;
        }

        public void SaveCharacterToFile()
        {

            // Percorso della sottocartella "Character"
            string characterPath = Path.Combine(Directory.GetCurrentDirectory(), "Character");

            // Controlla se la cartella "Character" esiste, altrimenti la crea
            if (!Directory.Exists(characterPath))
            {
                Directory.CreateDirectory(characterPath);
            }

            // Percorso completo del file basato sul nome del personaggio
            string fileName = $"{this.Name}.json";
            string filePath = Path.Combine(characterPath, fileName);

            // Serializza l'oggetto in formato JSON
            var options = new JsonSerializerOptions
            {
                WriteIndented = true // Rende il JSON indentato
            };
            string json = JsonSerializer.Serialize(this, options);

            // Salva il JSON su disco
            File.WriteAllText(filePath, json);

            MessageBox.Show($"Character salvato in: {filePath}");
        }

        // Metodo per visualizzare i dati del personaggio
        public override string ToString()
        {
            return $"Name: {Name}\nGender: {Gender}\n" +
                   $"\nStrength: {Strength}\nPerception: {Perception}\nEndurance:{Endurance}\n" +
                   $"Charisma: {Charisma}\nIntelligence: {Intelligence}\nAgility: {Agility}\nLuck: {Luck}";
        }
    }
}
