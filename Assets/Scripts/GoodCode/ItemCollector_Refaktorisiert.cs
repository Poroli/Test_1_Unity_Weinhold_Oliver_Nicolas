using UnityEngine;
using System.Collections.Generic;

public class ItemCollector_Refaktorisiert : MonoBehaviour
{
    /*
    Aufgabenstellung: Refaktorisierung

    - Vereinfachen Sie die Methode 'CollectItems' mithilfe eines Arrays und einer foreach-Schleife.
    - Refaktorisieren Sie den Code gemäß den Best Practices der Code-Formatierung.
    - Ergänzen Sie Codeblöcke mit Kommentaren zur Beschreibung ihrer Funktion.
    - Nach jeder Refaktorisierung erfolgt ein Push auf Git mit deskriptiven Namen.
    - Nach Abschluss aller Refaktorisierungen laden Sie oli90martin@web.de als Collaborator zu Ihrer Git-Repository ein.
    */

    [SerializeField] private GameObject[] items;
    private List<GameObject> collectedItems = new List<GameObject>();

    void Update()
    {
        CollectItems();
    }

    void CollectItems()
    {
        // durchgehen durch alle Elemente in items und hinzufügen der Liste
        foreach (GameObject item in items)
        {
            if (item != null)
            {
                collectedItems.Add(item);
            }
        }
    }
}
