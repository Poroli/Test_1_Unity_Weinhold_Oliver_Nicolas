using UnityEngine;
using System;
using System.Collections.Generic;
using UnityEngine.UI;

public class WinterSportsGame_Refaktorisiert : MonoBehaviour
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

    public List<string> AchievementsListe = new(); 
    public GameObject SkiGameObject; 
    public int PlayerStamina = 100; 
    public float SkiingSpeed = 10f;
    
    private bool isSkiing; 
    
    private void CheckSkiing()
    {
        // überprüfung ob gerade Ski gefahren wird
        if (!isSkiing) 
        { 
            Debug.Log("Spieler kann nicht Ski fahren!");
            return;
        } 

        // Skifahren Steuerung
        var move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")); 
        SkiGameObject.transform.Translate(move * SkiingSpeed * Time.deltaTime);
    }

    private void CheckAchievements()
    {
        // überprüfung ob Achievements erlangt wurden
        if (AchievementsListe.Count <= 0) 
        { 
            Debug.Log("Keine Erfolge erzielt.");
            return;
        }

        // Auflistung aller "achievements" / Elemente aus Liste in Konsole
        foreach (var achievement in AchievementsListe) 
        { 
            Debug.Log("Erfolg: " + achievement); 
        } 
    }

    // fpr LoseStamina kein offensichtlicher Grund im Code warum public
    public void LoseStamina(int losingAmount) 
    { 
        // Stamina wird entsprechend loosingAmount abgezogen
        PlayerStamina -= losingAmount; 
        
        // überprüfung ob Stamina unter 0 gesunken ist -> dann auf 0 gesetzt
        if (PlayerStamina <= 0) 
        { 
            PlayerStamina = 0; 
        } 
    }
    
    // AddAchievement derzeit nicht offensichtlich im Code gebraucht -> kann gelöscht werden
    public void AddAchievement(string achievement) 
    { 
        if (!AchievementsListe.Contains(achievement)) 
        { 
            AchievementsListe.Add(achievement); 
        } 
    }

    // StartSkiing derzeit nicht offensichtlich im Code gebraucht -> kann gelöscht werden
    public void StartSkiing() 
    { 
        isSkiing = true; 
    }
    
    // StopSkiing derzeit nicht offensichtlich im Code gebraucht -> kann gelöscht werden
    public void StopSkiing() 
    { 
        isSkiing = false; 
    }

    void Start() 
    { 
        Debug.Log("WinterSports beginnt!"); 
        PlayerStamina = 100; // !mir ist unklar, warum die PlayerStamina überschrieben wird!
    }
    
    void Update() 
    { 
        // überprüfung ob Spieler noch Stamina hat
        if (PlayerStamina <= 0) 
        { 
            Debug.Log("Spiel beendet!"); 
        } 
        
        CheckSkiing(); 
        CheckAchievements(); 
    }
}
