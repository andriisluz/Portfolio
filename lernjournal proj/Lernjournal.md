# Lernjournal 

## Lernsession 1

Wichtige kommanden:

``` bash

git init -b main # Repo erstellen
git add . # Alle Dateien zum Staging Area einfügen
git status # Prüfen, ob die Dateien verfolgt sind
git commit -m "..." # Einen Schnappschuss des Repo erstellen
```

## Lersession 2

**Lernspur und Übergabepunkt sichern**

* Was ist der Unterschied zwischen Git und GitHub?

Git sist ein Versionskontrollesystem und GitHub ist eine Online-Platform, wo ich mein Projekt herunterladen kann und kooperieren.

* Welcher Git-Schritt ist für dich bereits sicher?

Ich kann sicher einen Ablauf durch führen, wo ich: 
	1. ein Git Repo erstelle
	2. Änderungen mache
	3. geänderte Dateien zum Staging-Bereich hinzufüge
	4. commit erstelle
	5. einen neuen Zweig erstelle
	6. diesen Zweig mit dem Hauptzweig zusammenführe
	7. Zurück mithilfe von "reset" gehe

* Wo stehst du im Microsoft-Learn-Modul Einführung in GitHub?

Vor dem Übung.

* Was ist dein nächster konkreter Schritt in Lernsession 03?

Als nächstes werde ich in Lernsession 03 einen GitHub-Flow erstellen.

**Exit-Ticket**

1. git commit -m "First"

2. "Feature" branch - ist der Zweig, wo ich etwas bearbeite und, nachdem es fertig ist, mit "main" Zweig zusammenführe.

3. Welche workflow sollen wir für den bevorstehenden Projekt benutzen.

## Lernsession 3

In GitHub können wir das Repo steuern:

![GitHub Tabs](<img/Screenshot 2026-10-12 091330.png>)

Diese Tabs helfen uns, die Einstellungen ändern und verschiedene Operationen mit unserem Repo ausführen. 

Für Beispiel, kann man:
* Pull Requests ansehen, zulassen oder ablehnen (Pull Requests)
* Probleme mit unserem Projekt ansehen, beantworten und erledigen (Issues)

## Lernsession 4 

Wenn es einen Problem gibt, das wir als Informatiker lösen müssen, hilft es, jedes Teil zu isolieren:
* Problem
* Ziel
* Lösung

Wichtig ist, beim Erstellen von den Zielen, Kriterien testbar zu machen. Wir müssen klar verstehen, wann der Kriterium erfüllt ist.

Anstatt: "Das Programm muss richtig funktionieren", sollte man schreiben:
* Es gibt keine Fehler oder Abstürze.
* Während dem Testen, der Zielpersonal soll keine Fragen stellen müssen.

[Lösung zum Arbeitsblatt Praxisfall Mensa](docs/LS4_Arbeitsblatt_Praxisfall_Mensa.pdf)


## Lernsession 5

Um unser Programm richtig zu erstellen, brauchen wir gute Anforderungen, die wir im Programm treffen müssen.

Dann erstellt man Testfälle, um sicherzustellen ob der Programm richtig funktioniert. Sie sehen etwa so aus:

| Nr | Eingaben | Soll | Ist | ok? |
|----|----------|------|-----|-----|
| 1 | Name: Brot, Preis: 1.50, Menge: 10| Eie Zeile mit "Brot, 10 Stück - 15CHF" | Brot, 10 Stück - 15CHF | Ja |
| 2 | Name: Cola, Preis: 2.30, Menge: 1| Eie Zeile mit "Cola, 1 Stück - 2.30CHF" | Cola, 1 Stück - 2.30CHF | Ja |
| 3 | Name: Keks, Preis: 1.00, Menge: 3| Eie Zeile mit "Brot, 3 Stück - 3CHF" | Brot, 3 Stück - 3CHF | Ja |

![Das Progarmmablaufdiagramm](<img/Screenshot 2026-10-12 105103.png>)