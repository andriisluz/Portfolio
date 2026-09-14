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

**Meine Antwort:** DEINE ANTWORT

### 32. Ordne die Begriffe zu

| Bedeutung | Git-/GitHub-Begriff |
|---|---|
| Aufgabe | DEINE ANTWORT |
| Arbeitszweig | DEINE ANTWORT |
| Speicherpunkt | DEINE ANTWORT |
| Änderungsantrag | DEINE ANTWORT |
| Zusammenführen | DEINE ANTWORT |

### 33. Welche Richtung beschreibt Push?

**Meine Antwort:** DEINE ANTWORT

### 34. Welche Richtung beschreibt Pull?

**Meine Antwort:** DEINE ANTWORT

### 35. Warum sind mehrere sinnvolle Commits oft besser als ein einziger riesiger Commit?

**Meine Antwort:** DEINE ANTWORT

### 36. Nenne ein Beispiel für eine gute Commit-Nachricht.

```text
DEINE COMMIT-NACHRICHT
```

### 37. Warum ist die Commit-Nachricht `update` wenig hilfreich?

**Meine Antwort:** DEINE ANTWORT

---

## 5 · Markdown und README

### 38. Überschrift Ebene 1

Ergänze darunter eine Markdown-Überschrift der Ebene 1:

DEINE ANTWORT

### 39. Ungeordnete Liste

Erstelle eine Liste mit mindestens drei Begriffen aus dieser Lernsession:

DEINE ANTWORT

### 40. Link

Erstelle einen funktionierenden Markdown-Link zu GitHub oder Microsoft Learn:

DEINE ANTWORT

### 41. Bild

Schreibe die Markdown-Syntax für ein Bild mit Alternativtext:

```text
DEINE ANTWORT
```

### 42. Inline-Code

Schreibe `git status` als Inline-Code in einem sinnvollen Satz:

DEINE ANTWORT

### 43. Codeblock

Ergänze mindestens drei Git-Befehle in diesem Codeblock:

```bash
# DEINE BEFEHLE
```

### 44. Was sollte ein gutes Portfolio-README mindestens leisten?

**Meine Antwort:** DEINE ANTWORT

---

## 6 · Mein fachlicher Lernnachweis

### Was habe ich heute über Git und GitHub gelernt?

DEINE ANTWORT

### Was habe ich heute praktisch umgesetzt?

DEINE ANTWORT

### Meine konkrete Verbesserung aus dem Selbst- oder Peer-Check

DEINE ANTWORT

### Mein nächster Portfolio-Schritt

DEINE ANTWORT

---

## 7 · Microsoft Learn · Abschlusskontrolle

- [ ] **Einführung in GitHub**: Übung, Modulbewertung und Zusammenfassung abgeschlossen
- [ ] **Effektive Kommunikation auf GitHub mithilfe von Markdown** abgeschlossen
- [ ] Ich habe meinen Lernfortschritt / meine Modulbewertung kontrolliert.

## 8 · Begriffe · deutsche Merkhilfe

Fülle die zweite Spalte mit einer kurzen deutschen Merkhilfe aus.

| Begriff | Deutsche Merkhilfe |
|---|---|
| Issue | DEINE ANTWORT |
| Branch | DEINE ANTWORT |
| Commit | DEINE ANTWORT |
| Push | DEINE ANTWORT |
| Pull | DEINE ANTWORT |
| Pull Request | DEINE ANTWORT |
| Review | DEINE ANTWORT |
| Merge | DEINE ANTWORT |
| Clone | DEINE ANTWORT |
| Repository | DEINE ANTWORT |

---

## 9 · Selbstcheck

- [ ] Ich kann **Git** und **GitHub** unterscheiden.
- [ ] Ich kann **Issue → Branch → Commit → Pull Request → Merge** erklären.
- [ ] Ich kenne den Unterschied zwischen **Commit** und **Push**.
- [ ] Ich kenne den Unterschied zwischen **Pull** und **Pull Request**.
- [ ] Ich kann Überschriften, Listen, Links, Bilder und Codeblöcke in Markdown verwenden.
- [ ] Mein README wird auf GitHub korrekt gerendert.
- [ ] Ich habe mindestens eine konkrete Verbesserung umgesetzt.
- [ ] Ich habe meine Änderung mit einer aussagekräftigen Commit-Nachricht dokumentiert.

## Meine Commit-Nachricht für diese Abgabe

```text
DEINE COMMIT-NACHRICHT
```
