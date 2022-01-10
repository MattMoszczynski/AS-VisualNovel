using System;

namespace AS_VisualNovel.StoryPanels
{
    // PUBLICZNA! struktura StotyOption
    // zawiera:
    // - PUBLICZNY! ciąg tekstowy "text" od treści opcji
    // - PUBLICZNY! StoryPanel "panel" od panelu powiązanego z tą opcją
    // --- Ta struktura reprezentuje opcje jakie gracz może wybrać dla panelu typu OptionStoryPanel


    /// <summary>
    /// To jest klasa przedstawiająca panel historii z opcjami do wyboru przez gracza...
    /// ... W zależności od wybranej opcji ciąg historii może potoczyć się inaczej
    /// </summary>
    public class OptionStoryPanel : StoryPanel
    {
        // ----------[ ZMIENNE ]----------
        // PRYWATNA zmienna typu liczby całkowitej "choosedOption"
        // --- Przechowuje jaką opcję wybrał gracz


        // PRYWATNA zmienna StoryOption w formie tablicy "choosedOption"
        // --- Przechowuje opcje do wyboru przez gracza powiązane z tym panelem


        // ----------[ KONSTRUKTORY I FUNKCJE ]----------
        // Konstruktor OptionStoryPanel
        // - przymuje tekst pod ten panel
        // - przyjmuje tablicę możliwych opcji do wyboru
        public OptionStoryPanel(string text) : base(text)
        {
        }

        // Zmieniona funkcja typu StoryPanel NextPanel() - patrz StoryPanel.cs


        // Zmieniona funkcja typu "pusty" NextPanel() - patrz StoryPanel.cs


        // Zmieniona funkcja typu "pusty" Display() - patrz StoryPanel.cs

    }
}
