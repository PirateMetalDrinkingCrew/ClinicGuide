# Quadropole
 [Challanges](https://healthhackathon.quattropole.org/challenges#content)
 
## Saarbrücken - Überwindung sprachlich-kultureller Barrieren
### Wie kann man diese zum Beispiel bei der Patientenaufnahme oder bei der Behandlungserklärung überwinden?
#### Patientenaufnahme
- Anonymisierte (oder personalisierte) Accounts (mit Zeitlimit) in einer App
- Auth per QR Code
- Download der Dokumente in jeweiliger Sprache

#### Behandlungserklärung
- Unterlagen in mehreren Sprachen bereitstellen u. dem Patienten einen QR-Code geben der zur App führt
- In der App werden dann die Unterlagen in der jeweiligen Sprache abgerufen
- Skizzierte/Animierte Videos (mit Symbolen) die, die Behandlung erklären

### Realisierung
- Dokumenten-Templates bereitstellen
- Patientenaufnahme gibt daten ein und bekommt Dokumente in Deutsch. diese werden bei absenden/bereitstellen auch an den Patienten in seiner Sprache geschickt.

    - Ablauf:
        - Aufnahme gibt Daten ein
        - Daten werden roh abgespeichert
        - Bei Klick auf "bereitstellen/absenden" werden für deutsch und für die Patientensprache, je ein template abgerufen und mit den Daten gefüllt
        - Daraus werden dann entsprechende Dokumente erstellt: deutsch für beide Seiten + in Patientensprache für den Patienten

    - Benötigte/Vorgeschlagene Technologien:
        - .NET MAUI mit Blazor (wegen der Möglichkeit der Nutzung von HTML Code)
        - Erstellung von QR-Code in C#
        - Erstellung von PDF aus einem Template in C#