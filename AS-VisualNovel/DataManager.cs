using System;
using System.IO;

namespace AS_VisualNovel
{
    /// <summary>
    /// Klasa pomocnicza służąca do zapisywania danych tekstowych
    /// </summary>
    public static class DataManager
    {
        // Zapis danych
        public static void SaveData(string filename, string data)
        {
            filename = "saves/" + filename + ".txt";

            try
            {
                // Sprawdź czy istnieje folder "saves" - jak nie to go stwórz
                if (!Directory.Exists("saves"))
                {
                    Directory.CreateDirectory("saves");
                }

                // Sprawdź czy istnieje nasz plik - jak nie to go stwórz
                if (!File.Exists(filename))
                {
                    var stream = File.Create(filename);
                    stream.Close();
                }

                // Zapisywanie tekstu do pliku
                StreamWriter sw = new StreamWriter(filename);
                sw.WriteLine(data);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e.Message);
            }
        }

        // Oczyt danych
        public static string LoadData(string filename)
        {
            filename = "saves/" + filename + ".txt";

            try
            {
                // Sprawdź czy istnieje folder "saves" - jak nie to go stwórz
                if (!Directory.Exists("saves"))
                {
                    Directory.CreateDirectory("saves");
                }

                // Sprawdź czy istnieje nasz plik - jak nie to zwróć null
                if (!File.Exists(filename))
                {
                    new Exception("Nieznalezionio pliku o nazwie " + filename);
                }

                // Odczytywanie z pliku tekstu
                StreamReader sr = new StreamReader(filename);
                string data = sr.ReadLine();
                sr.Close();

                return data;
            }
            catch (Exception e)
            {
                // Console.WriteLine("ERROR: " + e.Message);
                return null;
            }
        }
    }
}
