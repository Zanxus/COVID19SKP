using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAndGuessingGame
{
    static class JSONHandler
    {
        static readonly string PATH = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Hiscores_JSON.txt");
        public static void Exporter(ObservableCollection<Hiscore> hiscores)
        {
            File.WriteAllText(PATH, JsonConvert.SerializeObject(hiscores));
        }

        public static ObservableCollection<Hiscore> Importer()
        {
            if (!File.Exists(PATH))
            {
                Exporter(GuessingGameWindow.HighscoreTableContent);
            }
            using (StreamReader reader = new StreamReader(PATH))
            {
                string InportString = reader.ReadToEnd();
                ObservableCollection<Hiscore> hiscores = JsonConvert.DeserializeObject<ObservableCollection<Hiscore>>(InportString);
                return hiscores;
            }
        }
    }
}
