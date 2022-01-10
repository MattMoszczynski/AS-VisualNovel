using System;

namespace AS_VisualNovel.StoryPanels
{
    /// <summary>
    /// To jest klasa przedstawiająca prosty panel naszej historii
    /// </summary>
    public class StoryPanel
    {
        // ----------[ ZMIENNE ]----------
        // PRYWATNA zmienna typu ciągu tekstowego "text"
        // - domyślnie ustawiamy tekst pusty
        // --- Przechowuje treść naszego panelu


        // CHRONIONA zmienna typu StoryPanel "nextPanel"
        // --- Służy do przechowywania i wynierania kolejnego panelu historii


        // ----------[ KONSTRUKTORY I FUNKCJE ]----------
        // Konstruktor StoryPanel
        // - przymuje tekst pod ten panel
        public StoryPanel(string text)
        {
        }

        // Funkcja typu "pusty" SetNextPanel()
        // - przyjmuje panel
        // --- Służy do ustawiania kolejnego panelu od historii


        // Wirtualna funkcja typu StoryPanel NextPanel()
        // --- Wybiera dla nas kolejny panel historii


        // Wirtualna funkcja typu "pusty" Display()
        // --- Służy do wyświetlania głównego tekstu od panelu


        // Wirtualna funkcja typu "pusty" Action()
        // --- Służy do wykonywania i informowania użytkownika jaką akcję ma zrobić

    }
}
