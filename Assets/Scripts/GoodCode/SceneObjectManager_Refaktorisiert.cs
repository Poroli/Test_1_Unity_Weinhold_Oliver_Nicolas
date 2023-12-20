using UnityEngine;
using UnityEngine.UIElements;

public class SceneObjectManager_Refaktorisiert : MonoBehaviour
{
    [SerializeField] private GameObject[] enemiesArray;
    [SerializeField] private GameObject[] itemsArray;
    [SerializeField] private string[] enemyTypes = { "fire", "water", "ice", "stone" };
    [SerializeField] private Vector3 itemPositionRange = new Vector3(10f, 10f, 10f);

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

    private void GetAllObjects()
    {
        enemiesArray = GameObject.FindGameObjectsWithTag("Enemy");
        itemsArray = GameObject.FindGameObjectsWithTag("Item");
    }

    private void RandomEnemyTypeAssing()
    {
        // add every Enemy an EnemyDataHolder and saves an random type from the enemyTypesArray in it
        foreach (GameObject enemy in enemiesArray)
        {
            enemy.AddComponent<EnemyDataHolder>().EnemyType = enemyTypes[Random.Range(0, enemyTypes.Length)];
        }
    }

    private void RandomItemPositionAssing()
    {
        foreach (GameObject item in itemsArray)
        {
            item.transform.position = new Vector3(Random.Range(0, itemPositionRange.x),
                                                  Random.Range(0, itemPositionRange.y),
                                                  Random.Range(0, itemPositionRange.z));
        }
    }

    public void PrintAllItemsWithRandomPosition()
    {
        // funktionnen um alle Objekte zu finden + sortieren/ einordnen und Zufällige Positionen den Items zuzuordnen
        GetAllObjects();
        RandomItemPositionAssing();

        // ausgeben aller items + position aus entsprechendem Array in Konsole
        foreach (GameObject item in itemsArray)
        {
            print(item.name + " (" + item.transform.position + ")");
        }
    }

    public void PrintAllEnemysWithRandomType()
    {
        // funktionnen um alle Objekte zu finden + sortieren/ einordnen und Zufällige types den Enemys zuzuordnen
        GetAllObjects();
        RandomEnemyTypeAssing();

        // ausgeben aller Enyms + Type aus entsprechendem Array in Konsole
        foreach (GameObject enemy in enemiesArray)
        {
            print(enemy.name + " (" + enemy.GetComponent<EnemyDataHolder>().EnemyType + ")");
        }
    }
}

public class EnemyDataHolder : MonoBehaviour
{
    public string EnemyType;
}
