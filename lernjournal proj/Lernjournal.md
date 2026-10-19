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

Unten gibt es einen simplen Code für den Rechner von der vorherigen Lernsession.

Er führt diese Schritte aus:

```
1. Summe zu 0 einsetzen.
2. Artikelname eingeben
3. Einzelpreis eingeben
4. Menge eingeben
5. Menge mit Einzelpreis multiplizieren, zur Summe addieren.
6. Den Benutzer fragen, ob nächsten Artikel einzugeben.
7. Wenn ja, zum Schritt 2 gehen. Wenn nein, weitergehen.
8. Die Liste von Artikel formatiert ausgeben, die Summe ausgeben.
```

Wir geben die Werte ein (input): Name, Menge und Einzelpreis und geben die Antworten aus (Output).

``` C#
// Ausgabe
Console.WriteLine("Wilkommen zum Mensa Rechner");
Console.WriteLine("___________________________");

while (true)
{
	// Ausgabe
    Console.WriteLine("Neuen Einkauf starten?\n(J fur Ja): ");
    // Eingabe
	string ?isNewPurchaseStr = Console.ReadLine();
	// Verarbeitung
    bool isNewPurchase = false;

    if (isNewPurchaseStr != null)
    {
        isNewPurchase = (isNewPurchaseStr == "J");
    }
    
    // When user doesn't start a new purchase, the loop starts over
    if (!isNewPurchase) return;

    // Input product name
    string productName = "";
    while (true)
    {
		// Ausgabe
        Console.WriteLine("Produktname: ");
		// Eingabe
        string ?product = Console.ReadLine();
		// Verarbeitung
        if (product == null)
        {
            Console.WriteLine("Bitte, geben sie den Namen des Produkts ein.");
            continue;
        } else
        {
            productName = product;
            break;
        }
    }

    // Input product price
	// Ausgabe
    decimal productPrice = -1.0m;
    while (true)
    {
		// Ausgabe
        Console.WriteLine("Preis pro Stück: ");
		// Eingabe
        string ?priceStr = Console.ReadLine();
        if (priceStr == null)
        {
			// Ausgabe
            Console.WriteLine("Bitte, geben sie den Namen des Produkts ein.");
            continue;
        }
		// Verarbeitung
        decimal price = decimal.Parse(priceStr);
        productPrice = price;
        break;
    }

    // Eingabe Menge
    decimal productAmount = 1.0m;
    while (true)
    {
		// Ausgabe
        Console.WriteLine("Menge: ");
		// Eingabe
        string ?amountStr = Console.ReadLine();
		// Verarbeitung
        if (amountStr == null)
        {
			// Ausgabe
            Console.WriteLine("Bitte, geben sie den Namen des Produkts ein.");
            continue;
        }
		// Verarbeitung
        decimal amount = decimal.Parse(amountStr);
        productAmount = amount;
        break;
    }

    // Ausgabe + Verarbeitung
    Console.WriteLine("Einkauf: ");
    Console.WriteLine(productName + ", " + productAmount + " Stück - " + (productPrice*productAmount) + "CHF\n\n");
}
```

![Das Progarmmablaufdiagramm](<img/Screenshot 2026-10-12 105103.png>)

**Fälle fürs Testen erstellen:**
-------
**Fall 1**

Name: "Brot"

Preis: "1.50"

Menge: "10"

Erwartete Resultat: "Brot, 10 Stück - 15CHF"

**Fall 2**

Name: "Cola"

Preis: "2.30"

Menge: "1"

Erwartete Resultat: "Cola, 1 Stück - 2.30CHF"

**Fall 3**

Name: "Keks"

Preis: "1.0"

Menge: "3"

Erwartete Resultat: "Brot, 3 Stück - 3CHF"

## Lernsession 6