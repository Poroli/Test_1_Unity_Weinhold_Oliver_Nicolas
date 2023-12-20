using UnityEngine;
using System.Collections.Generic;

public class ItemCollector_badCode : MonoBehaviour
{
    /*
    Aufgabenstellung: Refaktorisierung

    - Vereinfachen Sie die Methode 'CollectItems' mithilfe eines Arrays und einer foreach-Schleife.
    - Refaktorisieren Sie den Code gemäß den Best Practices der Code-Formatierung.
    - Ergänzen Sie Codeblöcke mit Kommentaren zur Beschreibung ihrer Funktion.
    - Nach jeder Refaktorisierung erfolgt ein Push auf Git mit deskriptiven Namen.
    - Nach Abschluss aller Refaktorisierungen laden Sie oli90martin@web.de als Collaborator zu Ihrer Git-Repository ein.
    */

                        public GameObject item1;
                        public GameObject item2;
                        public GameObject item3;
                        public GameObject item4;
                        public GameObject item5;
           private List<GameObject> collectedItems = new List<GameObject>();

            void Update()
            {
                CollectItems();
            }

    void CollectItems()
    {
        if (item1 != null)
        {
            collectedItems.Add(item1);
        }
        if (item2 != null)
        {
            collectedItems.Add(item2);
        }
        if (item3 != null)
        {
            collectedItems.Add(item3);
        }
        if (item4 != null)
        {
            collectedItems.Add(item4);
        }
        if (item5 != null)
        {
            collectedItems.Add(item5);
        }
    }
}
