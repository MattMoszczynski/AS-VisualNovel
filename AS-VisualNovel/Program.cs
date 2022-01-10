/*
 * Tytuł historii:
 * Autor:
 * Ilość paneli:
 * Ilość zakończeń:
 * Oczekiwana ocena końcowa:
 * 
 */

using System;

using AS_VisualNovel.StoryPanels;

namespace AS_VisualNovel
{
    internal class Program
    {
        // Statyczna funkcja typu "pusty" TellStory()
        // - przyjmuje panel od którego ma opowiedzieć historię
        // --- Służy do opowiadania naszej historii
        static void TellStory(StoryPanel startPanel)
        {
            // Tworzymy sobie zmienną "currentPanel" typu StoryPanel, która ma pamiętać...
            // ...jaki jest obecnie wybrany panel z naszej historii


            // To jest główna pętla "while" naszej historii, kończy się ona...
            // ...gdy nie mamy ustawionego kolejnego panelu

        }

        static void Main(string[] args)
        {
            // Przykład zapisywania i wczytywania danych
            DataManager.SaveData("name", "Gregory");
            string name = DataManager.LoadData("name");

            // Tutaj tworzymy sobie panele od naszej wspaniałej historii!
            // Podczas tworzenia prostego panelu trzeba podać do konstruktora tekst od naszego panelu
            StoryPanel panel1 = new StoryPanel("To jest tekst panelu 1");

            StoryPanel panel2 = new StoryPanel("To jest tekst panelu 2");

            StoryPanel panel4 = new StoryPanel("To jest tekst panelu 4");

            StoryPanel panel5 = new StoryPanel("To jest tekst panelu 5");

            // To jest przykład tworzenia panelu od opcji, trzeba podać tekst oraz jego opcje
            //OptionStoryPanel panel3 = new OptionStoryPanel("To jest panel 3... jaki kolejny?", new[]
            //{
            //    new StoryOption() { text = "Panel 4",  panel = panel4 },
            //    new StoryOption() { text = "Panel 5",  panel = panel5 },
            //    new StoryOption() { text = "Kończymy :)",  panel = null }, // Ustawiając nextPanel na null sprawimy, że to będzie koniec historii
            //});

            // Tutaj łączymy ze sobą panele używając do tego funkcji SetNextPanel()
            // panel1.SetNextPanel(panel2);
            // panel2.SetNextPanel(panel3);
            // panel5.SetNextPanel(panel3);

            // Aby opowiedzieć naszą historię musimy skorzystać z funkcji TellStory() i podać od którego panelu...
            // ...nasza historia się rozpoczyna
            TellStory(panel1);
        }
    }
}
