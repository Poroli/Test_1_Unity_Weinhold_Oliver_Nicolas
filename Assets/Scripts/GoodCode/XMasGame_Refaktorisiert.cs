using UnityEngine;
using System.Collections.Generic;
public class XMasGame_Refaktorisiert : MonoBehaviour
{

  /*
  Aufgabenstellung: Refaktorisierung
  - Legen Sie ein neues Unity-Projekt mit dem Namen "Test_Refaktorisierung" an.
  - Erstellen Sie eine neue private Git-Repository: "Test_1_Unity_[IhrName]".
  - Initialisieren Sie das Projekt mit den notwendigen Inhalten und pushen Sie es in Ihre Repository.
  - Im Projekt erstellen Sie einen Ordner "Scripts" mit zwei Unterordnern: "badCode" und "goodCode".
  - Im "badCode"-Ordner speichern Sie alle orig.-Skripte wie "XMasGame_badCode.cs".
  - Refaktorisieren Sie die badCode Skripte gemäß den Best Practices der Code-Formatierung und
    speichern Sie die verbesserte Version im "goodCode"-Ordner ohne den Zusatz _badCode z.B.: "XMasGame.cs".
    (Achten Sie darauf, sowohl den Dateinamen als auch den Klassennamen im Skript zu ändern.)
  - Ergänzen Sie Codeblöcke mit Kommentaren zur Beschreibung ihrer Funktion
  - Nach jeder Refaktorisierungen erfolgt ein Push auf Git mit deskriptiven Namen.
  - NumberFilter.cs und SceneObjectManager.cs sollen um Screenshots der jeweiligen Button Funktionen, also die
    entsprechenden ConsolenAusgabe ergänzt werden. Laden Sie die Screenshoots mit entsprechnder Bezeichnung zu ihrer Repo .md hoch.
  - Der Einsatz von KI-Tools wie ChatGPT etc. ist nicht gestattet
  - Hilfestellungen untereinander sind nicht gestattet
  - Zum Abschluss soll vor Abgabe ein Finaler Push zur mit dem Namen Abgabe erfolgen.
  - Nach Abschluss ALLER Refaktorisierungen laden Sie oli90martin@web.de als Collaborator zu Ihrer Git-Repository ein.
   */
  
  [SerializeField] private int PresentsAmount = 4; // derzeit nicht gebraucht -> kann gelöscht werdenalle publics wurden zu [Serializefield] privates geändert da keine verwendung duch andere Scripts ersichtlich
  [SerializeField] private string Winning; // derzeit nicht gebraucht -> kann gelöscht werdenalle publics wurden zu [Serializefield] privates geändert da keine verwendung duch andere Scripts ersichtlich
  [SerializeField] private int SantasHealthPoints = 100; // alle publics wurden zu [Serializefield] privates geändert da keine verwendung duch andere Scripts ersichtlich
  [SerializeField] private List<string> InventoryGiftsList = new List<string>(); // alle publics wurden zu [Serializefield] privates geändert da keine verwendung duch andere Scripts ersichtlich
  [SerializeField] private GameObject SantaGameObject; // sehe keine Verwendung hier im Code -> kann gelöscht werdenalle publics wurden zu [Serializefield] privates geändert da keine verwendung duch andere Scripts ersichtlich
  [SerializeField] private GameObject SleightGameObject; // alle publics wurden zu [Serializefield] privates geändert da keine verwendung duch andere Scripts ersichtlich
  
  private bool isFlying; // evtl. überflüssig da Start-/ StopFlying nicht offensichtlich im Code gebraucht
  private float flyingSpeed = 10f; 
  
  void FlyingMovement()
  {
    // überprüfung ob Santa gerade fliegt/ fliegen kann
    if (!isFlying)
    {
      Debug.Log("Santa kann nicht fliegen!");
      return;
    }

    // Flugsteuerung
    var move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    SleightGameObject.transform.Translate(move * flyingSpeed * Time.deltaTime);
  }

  void CheckInventory()
  {
    // überprüfung ob überhaupt Elemente in Liste sind 
    if (InventoryGiftsList.Count <= 0) 
    { 
      Debug.Log("Keine Geschenke vorhanden.");
      return;
    }

    // Auflistung aller "Geschenke" / Elemente aus Liste in Konsole
    foreach (var gift in InventoryGiftsList) 
    { 
      Debug.Log("Geschenk im Inventar: " + gift); 
    } 
  }

  public void TakeDamage(int damage) 
  { 
    // Healthpoints werden entsprechend Schaden abgezogen
    SantasHealthPoints -= damage;

    // überprüfung ob Healthpoints unter 0 gesunken sind -> dann auf 0 gesetzt
    if (SantasHealthPoints < 0) 
    { 
      SantasHealthPoints = 0; 
    } 
  }

  // AddGiftToInventory derzeit nicht offensichtlich im Code gebraucht -> kann gelöscht werden
  public void AddGiftToInventory(string gift) 
  { 
    if (!InventoryGiftsList.Contains(gift)) 
    { 
      InventoryGiftsList.Add(gift); 
    } 
  }

  // StartFlying derzeit nicht offensichtlich im Code gebraucht -> kann gelöscht werden
  public void StartFlying() 
  { 
    isFlying = true; 
  }

  // StopFlying derzeit nicht offensichtlich im Code gebraucht -> kann gelöscht werden
  public void StopFlying() 
  { 
    isFlying = false; 
  }

  void Start() 
  { 
    Debug.Log("Weihnachtsabenteuer beginnt!");
    SantaGameObject = GameObject.Find("Santa"); // evtl. überflüssig da SantaGameObject anscheinend nicht gebraucht wird
    SantasHealthPoints = 80; // !mir ist unklar, warum die Healthpoints überschrieben werden!
  }

  void Update() 
  { 
    // überprüfung ob Santas Healthpoints auf 0 gesunken sind -> = 0 sollte reichen/funktionieren doch sicher ist sicher
    if (SantasHealthPoints <= 0) 
    { 
      Debug.Log("Weihnachten ist vorbei!");
      return;
    }

    FlyingMovement(); 
    CheckInventory(); 
  } 
}
