# Vom Problem zur Lösung

Wenn es einen Problem gibt, das wir als Informatiker lösen müssen, hilft es, jedes Teil zu isolieren:
* Problem
* Ziel
* Lösung

Wichtig ist, beim Erstellen von den Zielen, Kriterien testbar zu machen. Wir müssen klar verstehen, wann der Kriterium erfüllt ist.

Anstatt: "Das Programm muss richtig funktionieren", sollte man schreiben:
* Es gibt keine Fehler oder Abstürze.
* Während dem Testen, der Zielpersonal soll keine Fragen stellen müssen.

## Ablauf bei einem konkretem Beispiel

**Problem**: Das Programm entspricht nicht den Beürfnissen der Benutzer, indem Teil der Funktionalität fehlt.

**Ziel**: Es muss einen zuverlässigen Weg geben, wie die Benutzer Einkäufe berechnen müssen.

**Lösung**: Wir programmieren eine C# Lösung, die die ensprechende Funktionalität enthält.

Prüfkriterien:
    * Der Interface sll für den Benutzer intuitiv sein
        a. Es müssen keine Fragen während dem Testen entstehen.
    * Fehlerfreie Arbeit
        a. Es gibt keine Crashes oder Fehler Popups.
    * Preis wird genau berechnet
        a. Es müssen keine arithmetische Fehler entstehen.
    * Es muss schnell funkionieren 
        a. Die Latenz zwischen der Eingabe und Ausgabe ist weniger


## EVA Prinzip

**Eingabe:**

* Name der Wahre
* Einzelpreis
* Menge

**Verarbeitung:**

Einzelpreis mit Menge multiplizieren

**Ausgabe:**

Den Resultat von Multiplikation.

## Abstrakter Ablauf des Programms

```
1. Summe zu 0 einsetzen.
2. Artikelname eingeben
3. Einzelpreis eingeben
4. Menge eingeben
5. Menge mit Einzelpreis multiplizieren, zur Summe addieren.
6. Den Benutzer fragen, ob nächsten Artikel einzugeben.
7. Wenn ja, zum Schritt 2 gehen. Wenn nein, weitergehen.
8. Die Liste von Artikel formatiert ausgeben, die Summe ausgeben.

Überprüfung:
1. summe ist 0.
2. Apfelschörle eingeben
3. 2.50 eingeben
4. 3 eingeben
5. 2.50 * 3 = 7.50, 0 + 7.50 = 7.50, summe = 7.50
6. "Ja" eingeben
2. Sandwich eingeben
3. 5.80 eingeben
4. 2 eingeben
5. 5.80 * 2 = 11.60, 7.50 + 11.60 = 19.10, summe = 19.10
6. "Nein" eingeben
7. Weitergehen
8. Liste und Summe ausgeben.
```

[Lösung zum Arbeitsblatt Praxisfall Mensa](<../lernjournal proj/docs/LS4_Arbeitsblatt_Praxisfall_Mensa.pdf>)