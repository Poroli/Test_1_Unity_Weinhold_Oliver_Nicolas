using UnityEngine;

public class SceneObjectManager_badCode : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject[] items;
    public string[] enemyTypes = { "fire", "water", "ice", "stone" };
    public Vector3 itemPositionRange = new Vector3(10f, 10f, 10f);

    /*
    Aufgabenstellung: Refaktorisierung

    - Refaktorisieren Sie das Skript, um alle Objekte mit dem Tag "Enemy" einem Array von Feinden und alle Objekte mit dem Tag "Item" einem Array von Gegenständen effizient hinzuzufügen.
    - Weisen Sie jedem "Enemy"-Objekt einen zufälligen Typ aus dem enemyTypes-Array zu.
    - Weisen Sie jedem "Item"-Objekt eine zufällige Position innerhalb des angegebenen itemPositionRange-Bereichs zu.
    - Erstellen Sie 2 Button Methoden, Button 1 soll jeden Enemy mit dem dazugehörigen Typ in die Console schreiben. Botton 2 soll jedes Item mit der jeweilig dazugehörigen Position in die Console schreiben.
    - Ergänzen Sie Codeblöcke mit Kommentaren zur Beschreibung ihrer Funktion.
    - Nach jeder Refaktorisierung erfolgt ein Push auf Git mit deskriptiven Namen.
    - Nach Abschluss aller Refaktorisierungen laden Sie oli90martin@web.de als Collaborator zu Ihrer Git-Repository ein.
    */
}
