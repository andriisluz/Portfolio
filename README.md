# IPT1 · Lernsession 03 · GitHub-Flow & Markdown

> **Name:** Andrii  
> **Datum:** 14.09.2026

## Ziel

Ich kann die wichtigsten Begriffe rund um **Git**, **GitHub**, den **GitHub-Flow** und **Markdown** kurz erklären und meinen Lernfortschritt mit einem eigenen README dokumentieren.

---

## 1 · Git und GitHub verstehen

### 1. Was ist Git?

**Meine Antwort:** Git ist ein Program, den wir benutzen können, um die Entwicklung unseres Projekts zu vereinfachen, indem er die Änderungen in jeder Datei jedes Commits verfolgt.

### 2. Was ist GitHub?

**Meine Antwort:** GitHub ist ein verteiltes System, der uns bietet, durch seine Website und seine API mit den Projekten zu 
interagieren und mit den anderen produktiv zusammenzuarbeiten. Jeder Projekt auf GitHub ist ein Git repo. 

### 3. Was ist der wichtigste Unterschied zwischen Git und GitHub?

**Meine Antwort:** Git ist ein Program auf meinem Computer, GitHub ist ein Website.

### 4. Funktioniert Git auch ohne GitHub?

**Meine Antwort:** Ja. In der Tat gab es Git lange vor es GitHub gab.

### 5. Was ist ein Repository (Repo)?

**Meine Antwort:** Ein Repo im Kontext von Git ist ein versteckter Verzeichnis `.git`, der für die Verfolgung von Änderungen eingesetzt ist. Er wird von Git verwaltet.

### 6. Was ist der `main`-Branch?

**Meine Antwort:** Das ist der erste Zweig, der erstellt ist. Dort findet man nur die Versionen von Projekt, die für Verwendung bereit sind. 
Alle Entwicklungszweigen werden von diesem Zweig erstellt.

### 7. Was ist Markdown?

**Meine Antwort:** Spezielle Dateityp, der für Menschen lesbar ist als auch kann in eine Stilisierte Datei konvertiert werden. Es funktioniert wie eine leichte Version von HTML.

### 8. Was bedeutet GitHub-Flavoured Markdown (GFM)?

**Meine Antwort:** Das GitHub-Flavoured Markdown hat manche Besonderheiten, die mit dem GitHub Plattform integriert sind. 
Zum Beispiel kann man sich auf eine Issue beziehen. Etwa so: andriisluz/IPT-github-start#7

---

## 2 · GitHub-Flow

### 9. Bringe die Schritte in die richtige Reihenfolge

`Commit · Issue · Pull Request · Branch`

**Meine Antwort:** `Issue · Branch · Commit · PR`

### 10. Was ist ein Issue?

**Meine Antwort:** Das ist ein Problem das diesen Projekt betrifft, das auf GitHub unter dem Menüpunkt "Issues" gepostet wurde.

### 11. Was ist ein Branch?

**Meine Antwort:** Ein Branch ist eine Verzweigung vom Hauptzweig. 

### 12. Warum arbeitet man für eine Änderung häufig auf einem eigenen Branch?

**Meine Antwort:** Er bietet eine isolierte Umgebung, damit wir eine Feature problemlos entwickeln können, ohne dass der Hauptprojekt sich ändert.

### 13. Was ist ein Commit?

**Meine Antwort:** Ein Commit ist ein "Schnappschuss" von gewählten Dateien im Projekt an einem Zeitpunkt.

### 14. Wozu dient eine Commit-Nachricht?

**Meine Antwort:** Es dient dazu, dass es in der Zukunft einfacher wird, die Änderungen zu finden.

### 15. Was ist ein Pull Request?

**Meine Antwort:** Das ist eine Anfrage von einem Entwickler an den Eigentümer vom GitHub Repo, um die Änderungen die der Entwickler vorschlägt, 
in den Hauptbranch zusammenzuführen.

### 16. Was bedeutet Review?

**Meine Antwort:** Ein Review ist wann die Team einen Commit anschaut und bespricht, ob es sinnvoll wäre es zusammenzuführen.

### 17. Was bedeutet Merge?

**Meine Antwort:** Zusammenführung von Änderungen von einem Zweig in den anderen.

### 18. Wann sollte ein Pull Request gemergt werden?

**Meine Antwort:** Wann die Entwickler sich einig sind, dass die Lösung die Anforderungen erfüllt.

---

## 3 · Wichtige Git-Begriffe und Befehle

### 19. Was bedeutet Push?

**Meine Antwort:** Das Senden eines Git Repos auf eine Platform wie GitHub.

### 20. Was bedeutet Pull?

**Meine Antwort:** Das Herunterladen eines Git Repos von GitHub auf mein lokaler Computer.

### 21. Was ist der Unterschied zwischen Commit und Push?

**Meine Antwort:** Commit macht ein Schnappschuss von Dateien auf meinem Computer. Push nimmt alle diese Schnappschüsse und sendet sie auf ein anderer Computer, GitHub Server.

### 22. Was ist der Unterschied zwischen Pull und Pull Request?

**Meine Antwort:** Git pull nimmt die letzten Änderungen von GitHub und ladet sie herunter. Pull Request ist ein Bitte an den Eigentümer vom Repo, um diese
Änderungen zu akzeptieren.

### 23. Was bedeutet Clone?

**Meine Antwort:** Clone bedeutet, dass man ein Repo von GitHub auf sein eigenes Computer kopiert, damit er es bearbeten kann.

### 24. Was macht `git status`?

**Meine Antwort:** Er zeigt uns die Infos über welche Änderungen verfolgt sind und welche nicht.

### 25. Was macht `git add`?

**Meine Antwort:** Es hinzufügt die geänderte Dateien, die gewählt wurden zur Staging Area.

### 26. Was ist die Staging Area?

**Meine Antwort:** Wenn man einen Commit erstellen will, werden nur die Dateien von Staging Area in diesem Commit gespeichert.

### 27. Was macht `git log`?

**Meine Antwort:** Es zeigt den Verlauf von Commits.

### 28. Was bedeutet Branch wechseln?

**Meine Antwort:** Das bedeutet das eingeben: `git switch <branch-name>`. Das heisst, die folgenden Commits werden nicht zum Hauptzweig hinzugefügt,
sondern zu diesem Zweig.

### 29. Speichert `git add` bereits eine neue Version?

**Meine Antwort:** Nein. Es fügt die Datei zur Staging Area einfach zu.

### 30. Speichert `git push` deine noch nicht committeten Dateiänderungen?

**Meine Antwort:** Nein.

---

## 4 · GitHub-Flow praktisch erklären

### 31. Erkläre den GitHub-Flow in einem kurzen Satz.

**Meine Antwort:** GitHub flow hat nur 2 Branches: main und Feature. 

### 32. Ordne die Begriffe zu

| Bedeutung | Git-/GitHub-Begriff |
|---|---|
| Aufgabe | Task |
| Arbeitszweig | Branch |
| Speicherpunkt | Commit |
| Änderungsantrag | Diffs |
| Zusammenführen | Merge |

### 33. Welche Richtung beschreibt Push?

**Meine Antwort:** Git -> GitHub

### 34. Welche Richtung beschreibt Pull?

**Meine Antwort:** GitHub -> Git

### 35. Warum sind mehrere sinnvolle Commits oft besser als ein einziger riesiger Commit?

**Meine Antwort:** So kann man einen fehlerhaften Commit finden und zurückzurollen, ohne dass man die guten Änderungen löscht.

### 36. Nenne ein Beispiel für eine gute Commit-Nachricht.

```text
Login Hooks Fehler mit unauthorisiertem Zugang zu Admin Console behebt.
```

### 37. Warum ist die Commit-Nachricht `update` wenig hilfreich?

**Meine Antwort:** Wir wissen nicht genau was update bedeutet. Man sollte schreiben was sich verändert hat. 

---

## 5 · Markdown und README

### 38. Überschrift Ebene 1

Ergänze darunter eine Markdown-Überschrift der Ebene 1:

# Titel

### 39. Ungeordnete Liste

Erstelle eine Liste mit mindestens drei Begriffen aus dieser Lernsession:

* Markdown
* Merge
* Branch

### 40. Link

Erstelle einen funktionierenden Markdown-Link zu GitHub oder Microsoft Learn:

[GitHub](https://github.com)

### 41. Bild

Schreibe die Markdown-Syntax für ein Bild mit Alternativtext:

```text
![Alternativtext](Link-zum-Bild)
```

### 42. Inline-Code

Schreibe `git status` als Inline-Code in einem sinnvollen Satz:

Der Befehl `git status` hilft uns zu sehen welche Dateien momentan verfolgt sind.

### 43. Codeblock

Ergänze mindestens drei Git-Befehle in diesem Codeblock:

```bash
git pull
git branch --list
git checkout feature
git add ./src/*
git commit -m "Fixed the burger menu blocking the view on mobile devices"
git push
```

### 44. Was sollte ein gutes Portfolio-README mindestens leisten?

**Meine Antwort:** Wenn es ein Projekt mit Code ist soll es solche Struktur haben:
```
# Titel

![Screenshot](...)

Funktionalität:
- Erstens
- Zweitens
- Drittens

Was habe ich gelernt:
- Erstens
- Zweitens
- Drittens
```

---

## 6 · Mein fachlicher Lernnachweis

### Was habe ich heute über Git und GitHub gelernt?

Ich habe gelernt wie man mit Issues praktisch umgeht.

### Was habe ich heute praktisch umgesetzt?

Ich habe eine Issue erstellt, Kommentare hinzugefügt, einen separaten Zweig erstellt, pullte das Repo, machte die Änderung, committete, pushte, erstellte einen Pull Reqest, führte die Zweige zusammen. 

### Meine konkrete Verbesserung aus dem Selbst- oder Peer-Check

Ich wusste den Algorhythm von wie man die Issues bearbeitet. Jetzt weiss ich ihn.

### Mein nächster Portfolio-Schritt

Nächste Lernsession bearbeiten und auf GitHub ein Repo mit Lernnachweisen erstellen.

---

## 7 · Microsoft Learn · Abschlusskontrolle

- [x] **Einführung in GitHub**: Übung, Modulbewertung und Zusammenfassung abgeschlossen
- [x] **Effektive Kommunikation auf GitHub mithilfe von Markdown** abgeschlossen
- [x] Ich habe meinen Lernfortschritt / meine Modulbewertung kontrolliert.

## 8 · Begriffe · deutsche Merkhilfe

Fülle die zweite Spalte mit einer kurzen deutschen Merkhilfe aus.

| Begriff | Deutsche Merkhilfe |
|---|---|
| Issue | Problem |
| Branch | Zweig |
| Commit | Schnappschuss |
| Push | hochladen |
| Pull | herunterladen |
| Pull Request | Anforderung um Zusammenführung |
| Review | Überprüfung |
| Merge | Zusammenführung |
| Clone | kopieren |
| Repository | Verzeichnis |

---

## 9 · Selbstcheck

- [x] Ich kann **Git** und **GitHub** unterscheiden.
- [x] Ich kann **Issue → Branch → Commit → Pull Request → Merge** erklären.
- [x] Ich kenne den Unterschied zwischen **Commit** und **Push**.
- [x] Ich kenne den Unterschied zwischen **Pull** und **Pull Request**.
- [x] Ich kann Überschriften, Listen, Links, Bilder und Codeblöcke in Markdown verwenden.
- [x] Mein README wird auf GitHub korrekt gerendert.
- [x] Ich habe mindestens eine konkrete Verbesserung umgesetzt.
- [x] Ich habe meine Änderung mit einer aussagekräftigen Commit-Nachricht dokumentiert.

## Meine Commit-Nachricht für diese Abgabe

```text
Das Quiz fertig ausgefüllt.
```
