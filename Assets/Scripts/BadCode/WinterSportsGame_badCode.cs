using UnityEngine;
using System;
using System.Collections.Generic;
using UnityEngine.UI;

public class WinterSportsGame_badCode : MonoBehaviour
{
    /*
    Aufgabenstellung: Refaktorisierung

    - Refaktorisieren Sie das Skript gemäß den Best Practices der Code-Formatierung.
    - Ergänzen Sie Codeblöcke mit Kommentaren zur Beschreibung ihrer Funktion.
    - Achten Sie auf die konsistente Benennung von Variablen und Methoden.
    - Nach jeder Refaktorisierung erfolgt ein Push auf Git mit deskriptiven Namen.
    - Zum Abschluss soll vor Abgabe ein Finaler Push zur mit dem Namen Abgabe erfolgen.
    - Nach Abschluss ALLER Refaktorisierungen laden Sie oli90martin@web.de als Collaborator zu Ihrer Git-Repository ein.
    */

    public int playerStamina = 100; public GameObject ski; public List<string> Achievements = new List<string>(); private bool isSkiing; public float speed = 10f;
    void Start() { playerStamina = 100; Debug.Log("WinterSports beginnt!"); }
    void Update() { if (playerStamina > 0) { CheckSkiing(); CheckAchievements(); } else { Debug.Log("Spiel beendet!"); } }
    void CheckSkiing()
    { if (isSkiing) { var move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")); ski.transform.Translate(move * speed * Time.deltaTime); } else { Debug.Log("Spieler kann nicht Ski fahren!"); } }
    void CheckAchievements()
    {
        if (Achievements.Count == 0) { Debug.Log("Keine Erfolge erzielt."); } else { foreach (var achievement in Achievements) { Debug.Log("Erfolg: " + achievement); } }
    }
    public void LoseStamina(int amount) { playerStamina -= amount; if (playerStamina < 0) { playerStamina = 0; } }
    public void AddAchievement(string achievement) { if (!Achievements.Contains(achievement)) { Achievements.Add(achievement); } }
    public void StartSkiing() { isSkiing = true; }
    public void StopSkiing() { isSkiing = false; }
}
