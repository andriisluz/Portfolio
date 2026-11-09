# IPT1 · LS6 – Die Mensa-Kasse lernt entscheiden

**Datum:** Montag, 09.11.2026 · **Zeit:** 08:00–11:25 (Pause 09:35–09:55)  
**Abgabe:** in Teams, Aufgabe «LS6», bis Ende Tag

---

## So benutzt du dieses Blatt

**Wichtig:** Du hast auch das PDF «LS6 · Verzweigungen in C#». **Heute arbeitest du nur mit diesem Blatt.** Hier steht alles aus dem PDF, genauer erklärt. Das PDF musst du **nicht** ausfüllen.

1. Arbeite die **Schritte 1 bis 9** der Reihe nach.
2. Bei jedem Schritt steht: **Zeit**, **allein oder zu zweit**, **was du machst** und **wann du fertig bist**.
3. Hake in der Liste «Mein Fortschritt» ab, was fertig ist. So weisst du immer, wo du bist.
4. Schreibe deine Antworten **direkt in diese Datei**. Am Ende gibst du diese Datei ab.

### Die Symbole

| Symbol | Bedeutung |
|---|---|
| 👤 | Du arbeitest **allein**. |
| 👥 | Ihr arbeitet **zu zweit**. |
| 🔁 | **Checkpoint:** Vergleicht eure Ergebnisse. Sind beide gleich? Dann weiter. |
| ✅ | **Fertig, wenn …** – so weisst du, dass der Schritt fertig ist. |
| 🆘 | **Hilfe-Tipp**, wenn du nicht weiterkommst. |

### Hilfe-Regel: «Erst 3, dann ich»

Du kommst nicht weiter? Mach es in dieser Reihenfolge:

1. Lies den Schritt und die **Wortliste** noch einmal.
2. Frag deine **Partnerin / deinen Partner**.
3. Frag ein **anderes Team**.
4. Dann frag die **Lehrperson**.

---

## Mein Fortschritt

| | Schritt | Zeit | Wann |
|---|---|---|---|
| ☐ | 1 · IST und SOLL | 5 Min. | Lektion 1 |
| ☐ | 2 · Entscheidungstabelle und SOLL-Werte | 20 Min. | Lektion 1 |
| ☐ | 3 · PAP erweitern | 25 Min. | Lektion 2 und Anfang Lektion 3 |
| ☐ | 4 · Programm erweitern | 35 Min. | Lektion 3 |
| ☐ | 5 · Testen | 12 Min. | Lektion 4 |
| ☐ | 6 · Kassen-Challenge | 5 Min. | Lektion 4 |
| ☐ | 7 · Git-Commit | 3 Min. | Lektion 4 |
| ☐ | 8 · Abgabe in Teams | 2 Min. | Lektion 4 |
| ☐ | 9 · Lernjournal 06 | 10 Min. | Ende Lektion 4 |

Zwischendurch gibt es Teile mit der ganzen Klasse (Einstieg, Spiel «Menschliche if-Kette», Vorzeigen der Lehrperson, Auswertung). Die Lehrperson sagt, wann.

---

## Wörter für heute

| Wort | Bedeutung | Beispiel |
|---|---|---|
| **Menge** | Wie viele Stück jemand kauft | 4 Gipfeli → Menge = 4 |
| **Einzelpreis** | Preis für **ein** Stück | CHF 1.80 |
| **Rabatt** | Ein Teil vom Preis wird abgezogen | 10 % Rabatt |
| **Zwischentotal** | Preis **vor** dem Rabatt: Einzelpreis × Menge | 1.80 × 4 = 7.20 |
| **Rabattbetrag** | So viele Franken werden abgezogen | 10 % von 7.20 = 0.72 |
| **Endtotal** | Preis **nach** dem Rabatt: Zwischentotal − Rabattbetrag | 7.20 − 0.72 = 6.48 |
| **ungültig** | nicht erlaubt, sinnlos | Menge 0 oder −1 |
| **Bedingung** | Eine Frage mit Ja oder Nein | Ist die Menge mindestens 5? |
| **Entscheidung** | Das Programm macht je nach Antwort etwas anderes | Ja → 20 %, Nein → weiter prüfen |
| **Grenzwert** | Die Zahl genau an der Grenze zwischen zwei Regeln | 2 und 3, 4 und 5 |
| **Entscheidungstabelle** | Tabelle: Welche Menge bekommt welchen Rabatt? | – |
| **PAP** | Programmablaufplan: eine Zeichnung, die den Ablauf zeigt | – |
| **Raute** | Das PAP-Symbol für eine Frage (Ja / Nein) | ◇ |
| **Zweig** | Ein Weg nach einer Entscheidung | der Ja-Weg, der Nein-Weg |
| **SOLL** | Das richtige Ergebnis. Du rechnest es **vorher** selbst aus. | – |
| **IST** | Das Ergebnis, das dein Programm **wirklich** zeigt | – |
| **Commit** | Dein Arbeitsstand wird in Git gespeichert | – |

---

## Die Aufgabe des Tages

Deine Kasse aus LS5 rechnet: **Einzelpreis × Menge**. Sie rechnet immer gleich.  
**Neu gibt die Mensa Rabatt, wenn man mehr kauft.** Deine Kasse muss deshalb **entscheiden**.

### Die Regeln der Mensa

| Menge | Was passiert? |
|---|---|
| kleiner als 1 (0, −1, …) | **Fehler.** Das Programm zeigt eine Fehlermeldung und **keinen** Preis. Dann ist es fertig. |
| 1 oder 2 Stück | kein Rabatt (0 %) |
| 3 oder 4 Stück | 10 % Rabatt |
| 5 Stück oder mehr | 20 % Rabatt |

### So rechnest du

1. **Zwischentotal** = Einzelpreis × Menge
2. **Rabattbetrag** = Zwischentotal × Rabatt-Prozent / 100
3. **Endtotal** = Zwischentotal − Rabattbetrag

### Rechenbeispiel (Sandwich, CHF 5.80, Menge 3)

| | Rechnung | Ergebnis |
|---|---|---|
| Zwischentotal | 5.80 × 3 | 17.40 |
| Rabatt-Prozent | Menge 3 → Regel «3 oder 4 Stück» | 10 % |
| Rabattbetrag | 17.40 × 10 / 100 | 1.74 |
| Endtotal | 17.40 − 1.74 | **15.66** |

> **Wichtig:** Tippe heute nur Zahlen ein, zum Beispiel `2.50` und `3`. Was bei Buchstaben passiert, lernen wir in LS7.

---

## Lernziele (von der Lernplattform)

1. Du beschreibst den Ausgangsstand aus LS5 korrekt: eine Artikelposition, Eingabe von Artikelname, Einzelpreis und Menge, lineare Berechnung des Gesamtpreises und Ausgabe; es gibt dort noch keinen Rabatt.
2. Du formulierst die erstmals in LS6 eingeführten Mengenrabattregeln in einer Entscheidungstabelle mit den drei disjunkten Bereichen 1–2 Stück = 0 %, 3–4 Stück = 10 %, ab 5 Stück = 20 %.
3. Du erweiterst den bisherigen PAP um vollständige Entscheidungen und überträgst sie in C# mit `if`, `else if` und `else`; du erklärst die Reihenfolge der Prüfbedingungen.
4. Du berechnest für genau eine Artikelposition Zwischenbetrag, Rabattbetrag und Endsumme mit dem Geld-Datentyp `decimal` und gibst die Ergebnisse verständlich in CHF aus.
5. Du prüfst den neuen Programmstand mit den Grenzwerten 1, 2, 3, 4 und 5 sowie einer ungültigen ganzen Menge (z. B. 0); du dokumentierst Soll/Ist und sicherst den bestandenen Stand mit einem aussagekräftigen Git-Commit.

**Einfach gesagt – heute lernst du:**

1. Ich kann sagen, was meine LS5-Kasse kann und was ihr fehlt.
2. Ich kann die Rabatt-Regeln in eine Tabelle schreiben. Jede Menge passt in genau **eine** Regel.
3. Ich kann Entscheidungen im PAP zeichnen und mit `if`, `else if` und `else` programmieren. Ich kann erklären, warum die Reihenfolge wichtig ist.
4. Ich kann Zwischentotal, Rabattbetrag und Endtotal mit `decimal` berechnen und in CHF anzeigen.
5. Ich kann mein Programm testen, SOLL und IST vergleichen und meine Arbeit mit Git speichern.

---

## So arbeitet ihr zu zweit

- Die Lehrperson sagt euch, wer euer Partner oder eure Partnerin ist. Bei drei Personen ist es ein Dreierteam.
- Ihr sitzt **nebeneinander**.
- **Jede Person arbeitet in ihrem eigenen Projekt** und schreibt in ihre eigene Datei.
- Ihr löst jeden Schritt **gemeinsam**: Ihr redet, erklärt und vergleicht.
- Bist du schneller? Dann **erkläre**. Diktiere nicht. Sag zum Beispiel: «Schau, diese Zeile macht …»

---

## Schritt 1 · IST und SOLL

**Zeit:** 5 Min. · 👤 allein

**Ziel:** Du siehst, was deiner Kasse fehlt.

**So geht es:**

1. Öffne dein **LS5-Projekt** in Visual Studio.
2. Starte das Programm (**Strg + F5**).
3. Tippe ein: **Apfelschorle**, **2.50**, **5**.
4. Schreibe auf, was passiert (IST).
5. Schreibe auf, was neu passieren soll (SOLL). Schau dafür bei «Die Regeln der Mensa».

| | Was passiert? |
|---|---|
| **IST** (heute, LS5): | Apfelschorle, 5 Stück - 12.50 CHF |
| **SOLL** (neu, LS6): | Apfelschorle, 5 Stück - 10 CHF (20% Mengenrabatt) |

6. Ergänze den Satz:

> Meine Kasse braucht eine Entscheidung, weil die alte Lösung ihrer Bedürfnissen und Anforderungen nicht mehr entsprechend ist.

✅ **Fertig, wenn:** IST, SOLL und der Satz ausgefüllt sind.

🆘 **Dein LS5-Programm startet nicht oder fehlt?** Sag es **sofort** der Lehrperson. Du bekommst einen Startcode.

---

## Schritt 2 · Entscheidungstabelle und SOLL-Werte

**Zeit:** 20 Min. · 👤 5 Min. allein, dann 👥 15 Min. zu zweit

**Ziel:** Du weisst **vor** dem Programmieren, welches Ergebnis richtig ist.

**So geht es:**

1. 👤 Fülle Tabelle 2a aus. Schau dafür bei «Die Regeln der Mensa».
2. 👤 Rechne Tabelle 2b **auf Papier oder im Kopf** aus. Benutze **nicht** dein Programm. Hilfe: das Rechenbeispiel oben.
3. 👥 Vergleicht eure Tabellen. Sind die Zahlen verschieden? Rechnet gemeinsam noch einmal.

### 2a · Entscheidungstabelle

Schreibe bei «Was passiert?» genau, was das Programm macht. «normal» ist zu ungenau.  
**Gutes Beispiel:** «Beleg ohne Rabatt. Endtotal = Zwischentotal.»  
**Tipp:** Bei ungültigen Mengen gibt es keinen Rabatt. Schreibe dort «–».

| Menge | Rabatt in % | Was passiert? |
|---|---|---|
| −1 | kein | Fehlermeldung: ungültige Eingabe. |
| 0 | kein | Fehlermeldung: ungültige Eingabe. |
| 1 | kein | Endtotal = Einzelnpreis |
| 2 | kein | Endtotal = Zwischenergebnis |
| 3 | 10% | Endtotal = Zwischenergebnis * 0.9 |
| 4 | 10% | Endtotal = Zwischenergebnis * 0.9 |
| 5 | 20% | Endtotal = Zwischenergebnis * 0.8 |
| 6 | 20% | Endtotal = Zwischenergebnis * 0.8 |


### 2b · SOLL-Werte (Apfelschorle, CHF 2.50)

Immer 2 Stellen nach dem Punkt schreiben: **5.00**, nicht 5.

| Menge | Zwischentotal | Rabatt in % | Rabattbetrag | Endtotal |
|---|---|---|---|---|
| 0 | – | – | – | Fehlermeldung |
| 1 | 2.50  | 0%  | 0.00 | 2.50 |
| 2 | 5.00  | 0%  | 0.00 | 5.00 |
| 3 | 7.50  | 10% | 0.75 | 6.75 |
| 4 | 10.00 | 10% | 1.00 | 9.00 |
| 5 | 12.50 | 20% | 2.50 | 10.00 |
| 6 | 15.00 | 20% | 3.00 | 12.00 |

🔁 **Checkpoint 1:** Habt ihr beide die gleichen Endtotale? Wo sind die **Grenzwerte**? Ergänze:

> Die Grenzen sind zwischen Menge 2 und 3 und zwischen Menge 4 und 5.

✅ **Fertig, wenn:** beide Tabellen voll sind und ihr die gleichen Zahlen habt.

🆘 **Hilfe:** Zuerst das Zwischentotal rechnen, dann den Rabatt. Mach es genau wie im Rechenbeispiel (Sandwich) – nur mit 2.50.

---

## Schritt 3 · PAP erweitern

**Zeit:** 25 Min. · 👥 zu zweit

**Ziel:** Ihr zeichnet den Ablauf **mit Entscheidungen**, bevor ihr programmiert.

### Die PAP-Symbole

| Symbol | Form | Wofür? |
|---|---|---|
| Start / Ende | Oval ⬭ | Anfang und Schluss |
| Eingabe / Ausgabe | Parallelogramm ▱ | Etwas eintippen oder anzeigen |
| Verarbeitung | Rechteck ▭ | Etwas berechnen |
| Entscheidung | Raute ◇ | Eine Frage mit **Ja** und **Nein** |

**So geht es:**

1. Öffnet euren PAP aus LS4/LS5.
   - **Ihr habt keinen PAP, nur Text oder eine Liste?** Dann zeichnet zuerst diesen Ablauf: Start → Artikelname eingeben → Einzelpreis eingeben → Menge eingeben → Zwischentotal berechnen → Ausgabe → Ende (ca. 5 Min.).
2. Fügt **nach** «Menge eingeben» eine Raute ein: **Ist die Menge kleiner als 1?**
   - **Ja** → Fehlermeldung ausgeben → Ende.
   - **Nein** → weiter zur Berechnung.
3. Fügt **nach** «Zwischentotal berechnen» Rauten für den Rabatt ein. Jede Raute ist **eine** Frage.
   - Bei **Ja**: ein Rechteck mit dem Prozentsatz, z. B. «Rabatt = 20 %».
   - Bei **Nein**: weiter zur nächsten Raute.
4. Alle Rabatt-Wege kommen danach **wieder zusammen**. Dann folgen zwei Rechtecke: «Rabattbetrag berechnen» und «Endtotal berechnen».
5. Am Schluss: Ausgabe des Belegs → Ende.
6. **Nummeriert** im PAP diese fünf Dinge:  
   ① ungültige Menge · ② Zwischentotal · ③ Rabatt-Prozent · ④ Rabattbetrag · ⑤ Endtotal
7. Schreibt an jede Rabatt-Raute: Wird sie im Code ein `if`, ein `else if` oder ein `else`?

### Kontrolliert euren PAP

![PAP LS 6](<img/PAP LS 6.png>)

- [x] Die Frage «Menge kleiner als 1?» kommt **vor** jeder Berechnung.
- [x] **Jede** Raute hat einen Weg mit **Ja** und einen Weg mit **Nein**.
- [x] Bei jedem Rabatt-Weg steht der Prozentsatz.
- [x] Rabattbetrag und Endtotal werden nur **einmal** berechnet.
- [x] Ein Weg teilt sich **nur** bei einer Raute, nie bei einem Rechteck.

### Beantwortet die Fragen

Benutzt die Satzanfänge.

1. Welche Frage verhindert, dass bei Menge 0 gerechnet wird?
   > Die Frage «…» verhindert das, weil …
2. In welcher Reihenfolge fragt ihr nach dem Rabatt? Warum?
   > Wir fragen zuerst …, dann …, weil …
3. Was passiert mit Menge 5, wenn ihr die Reihenfolge umdreht?
   > Wenn wir die Reihenfolge umdrehen, bekommt Menge 5 …, weil …
4. Wann gilt 20 % Rabatt? Wann 10 %? Wann 0 %?
   > 20 % gilt, wenn … · 10 % gilt, wenn … · 0 % gilt, wenn …
5. Wo im PAP werden Rabattbetrag und Endtotal berechnet?
   > Rabattbetrag und Endtotal werden berechnet, nachdem …

🔁 **Checkpoint 2:** Fahrt mit dem Finger durch den PAP: Menge 0, 2, 3 und 5. Kommt jede Menge zum richtigen Ergebnis?

✅ **Fertig, wenn:** Alle Punkte der Kontrollliste sind abgehakt, die drei Fragen sind beantwortet, und der PAP ist als **Bild (PNG) oder PDF** gespeichert.

🆘 **Hilfe:** Denkt an das Spiel «Menschliche if-Kette» aus der Klasse. Jede Person war eine Raute.

---

## Schritt 4 · Programm erweitern

**Zeit:** 35 Min. · 👥 zu zweit, jede Person im **eigenen** Projekt

**Ziel:** Deine Kasse prüft die Menge, gibt Rabatt und zeigt einen Beleg.

**Wichtig:** Benutze dein **LS5-Projekt**. Mach **kein** neues Projekt.  
**Nach jedem Teil:** Programm starten (**Strg + F5**) und testen.

### Teil A · Eingaben behalten

Deine drei Eingaben aus LS5 bleiben gleich:

- Artikelname → `string`
- Einzelpreis → `decimal`
- Menge → `int`

### Teil B · Menge prüfen

Schreibe **direkt nach** dem Einlesen der Menge:

- Wenn die Menge kleiner als 1 ist:
  - Gib eine Fehlermeldung aus, die man versteht.
  - Beende das Programm mit `return;`

🔁 **Checkpoint 3:** Teste Menge **0**. Kommt die Fehlermeldung? Kommt **kein** Preis?

### Teil C · Zwischentotal berechnen

Speichere das Ergebnis von Einzelpreis × Menge in einer Variable `zwischentotal` (Typ `decimal`).

### Teil D · Rabatt-Prozent bestimmen

- Mach eine Variable `rabattProzent`.
- Bestimme den Wert mit `if`, `else if` und `else`.
- In den Klammern `{ }` setzt du **nur** den Prozentsatz. Du rechnest und schreibst dort noch nichts.

### Teil E · Rabattbetrag und Endtotal berechnen

Schreibe die zwei Formeln **nach** dem `if`/`else`-Block. Schau bei «So rechnest du».

### Teil F · Beleg ausgeben

Dein Beleg zeigt: Artikel, Menge, Zwischentotal, Rabatt (in % und in CHF), Endtotal.  
Für 2 Stellen nach dem Punkt benutzt du `.ToString("F2")`, zum Beispiel:

```csharp
Console.WriteLine("Endtotal: CHF " + endtotal.ToString("F2"));
```

🔁 **Checkpoint 4:** Teste Menge **3** und **5**. Zeigen eure beiden Programme das Gleiche? Stimmt es mit Tabelle 2b?

### Syntax-Hilfe

So sieht eine `if`-Kette aus. Das Beispiel ist zu einem **anderen** Thema. Du musst es auf die Mensa übertragen.

```csharp
int punkte = Convert.ToInt32(Console.ReadLine());
string bewertung;

if (punkte >= 90)          // 1. Frage: mindestens 90?
{
    bewertung = "sehr gut";
}
else if (punkte >= 70)     // 2. Frage: nur wenn die 1. Frage NEIN war
{
    bewertung = "gut";
}
else                       // alle anderen
{
    bewertung = "genügend";
}

Console.WriteLine("Bewertung: " + bewertung);
```

**Merke:** Das Programm prüft von oben nach unten. Die **erste** Frage mit «Ja» gewinnt. Danach prüft es nichts mehr.

| Zeichen | Bedeutung |
|---|---|
| `<` | kleiner als |
| `>` | grösser als |
| `<=` | kleiner oder gleich |
| `>=` | grösser oder gleich (mindestens) |
| `==` | gleich (vergleichen) |
| `=` | Wert speichern (nicht vergleichen!) |

✅ **Fertig, wenn:** Das Programm startet, Menge 0 eine Fehlermeldung zeigt und Menge 3 und 5 einen Beleg mit Rabatt zeigen.

🆘 **Häufige Fehler:**

- Menge 5 bekommt nur 10 % → Prüfe die **Reihenfolge** deiner Fragen.
- Fehlermeldung **und** Beleg erscheinen → `return;` fehlt.
- Der Rabatt ist immer 0 → Schreibe die Formel genau so: `zwischentotal * rabattProzent / 100`.
- Bei `2.50` passiert etwas Seltsames → Probiere `2,50` und sag es der Lehrperson.

---

## Schritt 5 · Testen: zuerst SOLL, dann IST

**Zeit:** 12 Min. · 👥 zu zweit

**Ziel:** Du beweist, dass deine Kasse richtig rechnet.

**So geht es:**

1. Schreibe die SOLL-Werte aus **Tabelle 2b** in die Spalte SOLL.
2. **Erst jetzt** startest du das Programm. Teste jede Menge.
3. Schreibe in die Spalte IST **genau**, was auf dem Bildschirm steht.
4. Gleich? Dann ☑. Nicht gleich? Dann Fehler suchen → korrigieren → noch einmal testen.

| Menge | Rabatt in % | SOLL Endtotal | IST Endtotal (genau wie am Bildschirm) | OK? |
|---|---|---|---|---|
| 0 | – | Fehlermeldung | - | ✅ |
| 1 | 0% | 2.50 | 2.50 | ✅ |
| 2 | 0% | 5.00 | 5.00 | ✅ |
| 3 | 10% | 6.75 | 6.75 | ✅ |
| 4 | 10% | 9.00 | 9.00 | ✅ |
| 5 | 20% | 10.00 | 10.00 | ✅ |
| 6 | 20% | 12.00 | 12.00 | ✅ |

Hattest du einen Fehler? Schreibe auf, was falsch war:

> Alle Test waren richtig.

✅ **Fertig, wenn:** Alle 7 Tests haben ☑.

---

## Schritt 6 · Kassen-Challenge

**Zeit:** 5 Min. · 👥 Team mit Team

**Ziel:** Ein anderes Team testet deine Kasse.

**So geht es:**

1. Tauscht die Laptops mit diesem Team: **A ↔ B · C ↔ D · E ↔ F · G ↔ H**
2. Testet die Kasse des anderen Teams:
   - [ ] Menge 2, 3 und 5
   - [ ] Menge 0
   - [ ] einen Grenzwert, den ihr wählt
3. Stellt dem anderen Team diese drei Fragen:
   - «Zeigt uns im PAP: Welche Raute ist welches `if` im Code?»
   - «Warum bekommt Menge 5 nicht nur 10 %?»
   - «Warum zeigt das Programm bei Menge 0 keinen Preis?»
4. Prüft zusammen: Passen **PAP, Code und Testtabelle** zusammen? Zeigen alle drei dasselbe?
5. Laptops zurück. Tragt das Ergebnis ein:

> Getestet von Team: A · Ergebnis: [x] alles richtig ☐ Fehler gefunden: …

✅ **Fertig, wenn:** Ein anderes Team hat eure Kasse getestet, und ihr habt das Ergebnis eingetragen.

---

## Schritt 7 · Git-Commit

**Zeit:** 3 Min. · 👤 allein

**Ziel:** Deine Arbeit ist sicher gespeichert. Mach das **erst**, wenn alle Tests richtig sind.

**Variante 1 · Terminal** (im Projektordner):

```bash
git add .
git commit -m "Add quantity discount rules to mensa checkout"
git push
```

**Variante 2 · Visual Studio:**

1. Menü **Ansicht → Git-Änderungen**.
2. Nachricht eingeben.
3. **Alle committen** klicken.
4. **Pushen** (Pfeil nach oben) klicken.

**Gute Nachricht:** sagt genau, was neu ist.  
✅ «Add quantity discount rules to mensa checkout»  
✅ «Mengenrabatt 0/10/20 % und Mengenprüfung ergänzt»  
❌ «update» · ❌ «LS6» · ❌ «fix»

✅ **Fertig, wenn:** Du siehst deinen Commit auf GitHub. Mach davon einen **Screenshot**.

---

## Schritt 8 · Abgabe in Teams

**Zeit:** 2 Min. · 👤 allein

1. Speichere diese Datei als **`LS06_Vorname_Nachname.md`**.
2. Öffne **Teams → Aufgaben → LS6**.
3. Klicke auf **Arbeit hinzufügen** und lade hoch:
   - [ ] diese Datei (mit Schritt 1, 2, 3, 5, 6 und 9)
   - [ ] deinen **PAP** (PNG oder PDF)
   - [ ] den **Screenshot** von deinem Commit
4. Klicke auf **Abgeben**.

✅ **Fertig, wenn:** In Teams steht «Abgegeben».

---

## Schritt 9 · Lernjournal 06

**Zeit:** 10 Min. · 👤 allein · Schreibe in ganzen Sätzen. Benutze die Satzanfänge.

**Name:** ……………… **Partner/in:** ………………

### 1 · Das habe ich heute gelernt

> Eine `if` / `else if` / `else`-Kette macht … Das Programm prüft … Wenn eine Frage «Ja» ist, dann …

### 2 · Erkläre es einer Person, die heute gefehlt hat

Warum bekommt Menge 5 in deinem Programm 20 % und nicht nur 10 %?

> Menge 5 bekommt 20 %, weil …

### 3 · Wie gut kann ich das?

1 = noch unsicher · 2 = mit Hilfe · 3 = allein · 4 = ich kann es anderen erklären

| Ich kann … | 1 | 2 | 3 | 4 |
|---|---|---|---|---|
| … die Rabatt-Regeln in eine Tabelle schreiben | ☐ | ☐ | ☐ | ☐ |
| … einen PAP mit Rauten zeichnen | ☐ | ☐ | ☐ | ☐ |
| … `if` / `else if` / `else` in C# schreiben | ☐ | ☐ | ☐ | ☐ |
| … Rabattbetrag und Endtotal mit `decimal` berechnen | ☐ | ☐ | ☐ | ☐ |
| … Grenzwerte testen und SOLL / IST vergleichen | ☐ | ☐ | ☐ | ☐ |

### 4 · Das war schwierig

> Schwierig war für mich … Ich habe es so gelöst: … / Ich brauche noch Hilfe bei …

### 5 · Zusammenarbeit

> In unserem Team hat gut funktioniert, dass … Nächstes Mal machen wir anders: …

### 6 · Blick nach vorne (LS7)

Was passiert, wenn jemand bei der Menge «drei» tippt statt «3»? Wie kann man das lösen?

> Wenn jemand «drei» tippt, dann … Man könnte …

### 7 · Mein Yogi-Tee-Spruch und mein Wunsch vom Morgen

> Mein Spruch war: …  
> Mein Wunsch war: …  
> Mein Wunsch wurde ☐ erfüllt ☐ teilweise erfüllt ☐ nicht erfüllt, weil …

✅ **Fertig, wenn:** Alle 7 Punkte sind ausgefüllt, und die Datei ist in Teams abgegeben.

---

## Ich bin fertig – was jetzt?

1. Kontrolliere «Mein Fortschritt»: Ist alles abgehakt?
2. **Hilf einem anderen Team.** Erkläre, aber tippe nicht für sie.
3. Mach eine **Zusatzaufgabe** (freiwillig):
   - **Zusatz A · Mit `&&`:** Schreibe die Rabatt-Regeln so, dass jede Frage ihren Bereich ganz beschreibt. `&&` bedeutet «und». Beispiel: `menge >= 3 && menge <= 4` heisst «mindestens 3 **und** höchstens 4».
     > Ich finde besser lesbar: …, weil …
   - **Zusatz B · Mit `switch`:** Am Schluss fragt die Kasse nach der Zahlungsart: 1 = Bar, 2 = Karte, 3 = TWINT. Der Beleg zeigt die Zahlungsart. Die Rabatt-Regeln bleiben gleich. Suche im Internet nach «C# switch case» oder frag die Lehrperson.
