# Quadropole
 [Challanges](https://healthhackathon.quattropole.org/challenges#content)
 
## Saarbr�cken - �berwindung sprachlich-kultureller Barrieren
### Wie kann man diese zum Beispiel bei der Patientenaufnahme oder bei der Behandlungserkl�rung �berwinden?
#### Patientenaufnahme
- Anonymisierte (oder personalisierte) Accounts (mit Zeitlimit) in einer App
- Auth per QR Code
- Download der Dokumente in jeweiliger Sprache

#### Behandlungserkl�rung
- Unterlagen in mehreren Sprachen bereitstellen u. dem Patienten einen QR-Code geben der zur App f�hrt
- In der App werden dann die Unterlagen in der jeweiligen Sprache abgerufen
- Skizzierte/Animierte Videos (mit Symbolen) die, die Behandlung erkl�ren

### Realisierung
- Dokumenten-Templates bereitstellen
- Patientenaufnahme gibt daten ein und bekommt Dokumente in Deutsch. diese werden bei absenden/bereitstellen auch an den Patienten in seiner Sprache geschickt.

    - Ablauf:
        - Aufnahme gibt Daten ein
        - Daten werden roh abgespeichert
        - Bei Klick auf "bereitstellen/absenden" werden f�r deutsch und f�r die Patientensprache, je ein template abgerufen und mit den Daten gef�llt
        - Daraus werden dann entsprechende Dokumente erstellt: deutsch f�r beide Seiten + in Patientensprache f�r den Patienten

    - Ben�tigte/Vorgeschlagene Technologien:
        - .NET MAUI mit Blazor (wegen der M�glichkeit der Nutzung von HTML Code)
        - Erstellung von QR-Code in C#
        - Erstellung von PDF aus einem Template in C#