using UnityEngine;
using System.Collections.Generic;

public class NumberFilter_Refaktorisiert : MonoBehaviour
{
    /*
   Aufgabenstellung: Refaktorisierung

   - Refaktorisieren Sie das Skript, um die Zahlenreihe effizienter nach geraden und ungeraden Zahlen zu filtern.
   - Nutzen Sie Arrays und foreach-Schleifen für die Refaktorisierung.
   - Ergänzen Sie Codeblöcke mit Kommentaren zur Beschreibung ihrer Funktion.
   - Fügen Sie zwei Methoden hinzu, die jeweils alle geraden bzw. ungeraden Zahlen lesbar in die Konsole schreiben.
   - Nach jeder Refaktorisierung erfolgt ein Push auf Git mit deskriptiven Namen.
   - Nach Abschluss aller Refaktorisierungen laden Sie oli90martin@web.de als Collaborator zu Ihrer Git-Repository ein.
   */

    [SerializeField] private int[] numbersArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // alle publics wurden zu [SerializeField] private geändert da kein Grund für public ersichtlich
    [SerializeField] private int[] evenNumbersArray; // alle publics wurden zu [SerializeField] private geändert da kein Grund für public ersichtlich
    [SerializeField] private int[] oddNumbersArray; // alle publics wurden zu [SerializeField] private geändert da kein Grund für public ersichtlich

    private void SortNumbers()
    {
        // neue tmp Listen um Zahlen schnell und einfach zuordnen zu können
        List<int> tmpEvenInts = new();
        List<int> tmpOddInts = new();
        
        for (int i = 0; i < numbersArray.Length; i++)
        {
            // überprüfung ob Zahl gerade ist um sie temporärer Liste hinzuzufügen
            if (numbersArray[i] % 2 == 0)
            {
                tmpEvenInts.Add(numbersArray[i]);
                continue;
            }
            tmpOddInts.Add(numbersArray[i]);
        }

        // setzen der Arrays auf die tmp Listen Inhalte
        evenNumbersArray = tmpEvenInts.ToArray();
        oddNumbersArray = tmpOddInts.ToArray();
    }

    public void PrintAllEvenNumbers()
    {
        // funktion zum einordnen/ Sortieren der Zahlen nach Gerade/ Ungerade
        SortNumbers();

        // ausgeben aller Zahlen aus entsprechendem Array in Konsole
        foreach (int evenNumber in evenNumbersArray)
        {
            print(evenNumber);
        }
    }

    public void PrintAllOddNumbers()
    {
        // funktion zum einordnen/ Sortieren der Zahlen nach Gerade/ Ungerade
        SortNumbers();

        // ausgeben aller Zahlen aus entsprechendem Array in Konsole
        foreach (int oddNumber in oddNumbersArray)
        {
            print(oddNumber);
        }
    }
}
