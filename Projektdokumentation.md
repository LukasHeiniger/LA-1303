# LA-1303
# Projekt-Dokumentation
Lukas Heiniger

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 31.1      | 0.0.1   | Angefangen mit der Programmierung  |
| 07.2      | 0.0.2   |Zweiter programmier Tag |
| 07.2 -21.2      | 0.0.3   |   Weitere Arbeit am Projekt   |
| 21.2     | 0.1.0   |   Erster Prototyp|
| 27.2     | 1.0.0   |Fertige Version von CypherEcho |

## 1 Informieren

### 1.1 Ihr Projekt

Mein Projekt ist eine Konsolen-Applikation, die es dem Benutzer ermöglicht, Texte zu verschlüsseln und zu entschlüsseln, sprich ein Codierungsgerät.

Mein Ziel war von Anfang an klar, ich wollte eine App machen, die es dem Benutzer ermöglicht, Texte zu verschlüsseln und auch zu entschlüsseln, das Ziel der App ist, Nachrichten zu verschlüsseln, um diese jemand anderem zu schicken, welcher die Nachricht mit dem richtigen Code entschlüsseln kann. Ausserdem war das Ziel nochmals ein Objekt orientiertes Programmieren (OOP) Projekt zu erstellen.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    | muss                |  funktional    | Als ein User möchte ich eine Textdatei auswählen können, damit man diese verschlüsseln oder entschlüsseln kann. |
| 2  |  muss                 | funktional      |Als ein User möchte ich eine Meldung bekommen, ob die Datei gefunden worden ist, damit ich sicher gehen kann, dass sie wirklich vorhanden ist.  |
| 3    | muss                | funktionel     | Als ein User möchte ich gefragt werden, ob der Text verschlüsselt oder entschlüsselt werden soll.|
| 4  |  muss               | funktional     | Als ein User möchte ich, dass der Text verschlüsselt wird, damit ich eine verschlüsselte Nachricht versenden kann.|
| 5    |  muss               | funktional     |Als ein User möchte ich, dass der verschlüsselte Text auch entschlüsselt werden kann, damit ich die verschlüsselte Nachricht lesen kann.|
| 6  | kann                | funktional     | Als ein User möchte ich, dass der neue Text in ein neues File gespeichert wird, damit die alte Datei noch vorhanden ist. |
| 7   |  kann             |  qualität   | Als ein User möchte ich, dass der Text mit einem Delay ausgegeben wird, damit es einzigartiger wirkt.|
| 8  | kann                | qualität     | Als ein User möchte ich, dass Fehler abgefangen werden, damit dass Programm nicht abstürzt.|

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Programm wurde gestartet und Frag nach Dateiname.           |  Dateiname     | Info,ob die Datei gefunden worden ist.                 |
| 2.1  | Dateiname wird eingegeben            | / | Datei wurde gefunden/Datei wurde nicht gefunden.             |
| 3.1  | Datei wird eingegeben            | Dateiname | Möchten sie enschlüssen oder verschlüssln.             |
| 4.1  | Datei wurde gefunden.           | 2 | Programm fordert User auf ein Verschlüsselungscode zu wählen.             |
| 4.2  | Programm fordert User auf ein Verschlüsselungscode zu wählen.          | 3 Zahlen werden hintereinander eigegeben |Datei wird mit diesem Verschlüsselungscode verschlüsselt|
| 5.1  |Datei wurde gefunden           | 1 | User wird aufgeforder den Code wieder einzugeben.             |
| 5.2  |User wird aufgeforder den Code wieder einzugeben. | Die richtigen 3 Zahlen werden eigegeben | Datei wird entschlüsselt.            |
| 6.1  | Text wurde verschlüsselt            | Ja | Verschlüsselter Text wird in neue Datei gespeichert.             |
| 7.1  | Programm wird gesrartet.           | / | Text wird mit Delay abgespielt.             |
| 8.1  |Eingabe auforderung. (Zahl wird gefordert)           | String | Bitte geben sie eine Zahl ein.          |
| 8.2  |Eingabe auforderung. (Dateiname)           | Falsche Datei | Bitte fügen sie ein Textdokumment ein, welches sich auf dem Desktop befinded.           |





## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  | 24.01.24      |  Lukas         |  User soll nach der gewünschten Datei gefragt werden           |    20 Minuten           |
| 1.B  | 24.01.24      |  Lukas         |  Datei soll gefunden werden.           |    45 Minuten           |
| 7.A  | 24.01.24      |  Lukas         |  Text soll mit Delay ausgegeben werden.         |    45 Minuten           |
| 2.A  | 24.01.24      |  Lukas         |  Ausgabe ob Datei gefunden worden ist oder nicht.           |    15 Minuten           |
| 3.A  | 24.01.24      |  Lukas         |  User soll gefragt werden ob verschlüsseln oder entschlüsseln.           |    20 Minuten           |
| 4.A  | 24.01.24      |  Lukas         |  Text soll verschlüsselt werden.           |   200min Minuten           |
| 5.A  | 14.02.24      |  Lukas         |  Text soll entschlüsselt werden.           |    200min Minuten           |
| 6.A  | 14.02.24      |  Lukas         |  Verschlüsselter Text soll in ein neues Text Dokumment gespeichert werden.          |    45 Minuten           |
| 8.A  | 14.02.24      |  Lukas         |  Fehler sollen im ganzen Projekt abgefangen werden        |    60 Minuten           |
| 9.A  | 21.02.24      |  Lukas         |  Lernbericht           |    120min          |
| 9.B  | 21.02.24      |  Lukas         |  Projekdokummentation           |    120min          |




## 3 Entscheiden

Ich habe mich am Anfang gegen eine vor gefertigte Codierlösung entschieden, da ich den Verschlüsselungs- und Entschlüsselungsmechanismus selber machen wollte, ansonsten hätte ich auch nicht viel anderes mehr machen können.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |  22.11     |  Lukas|   20 Minuten            |   20 Minuten                |
| 1.B  |  22.11     |  Lukas|   45 Minuten            |   40 Minuten                |
| 7.A  |  22.11     |  Lukas|   45 Minuten            |   45 Minuten                |
| 2.A  |  22.11     |  Lukas|   15 Minuten            |   15 Minuten                |
| 3.A  |  22.11     |  Lukas|   20 Minuten            |   25 Minuten                |
| 4.A  |  22.11     |  Lukas|   200 Minuten            |   ca. 200 Minuten                |
| 5.A  |  22.11     |  Lukas|   200 Minuten            |   100 Minuten                |
| 6.A  |  22.11     |  Lukas|   45 Minuten            |   45 Minuten                |
| 8.A  |  22.11     |  Lukas|   60 Minuten            |   60 Minuten                |
| 9.A  |  22.11     |  Lukas|   120 Minuten            |   160 Minuten                |
| 9.B  |  22.11     |  Lukas|   120 Minuten            |   120 Minuten                |




## 5 Kontrollieren

| TC-№ | Datum | Resultat | Tester |Testumgebung|
| ---- | ----- | -------- | ------ | ---------|
| 1.1  | 27.02.24|  funktioniert        | Lukas       | Zuhause am Schreibtisch |
| 2.1  | 27.02.24|  funktioniert        | Lukas       | Zuhause am Schreibtisch |
| 3.1  | 27.02.24|  funktioniert        | Lukas       | Zuhause am Schreibtisch |
| 4.1  | 27.02.24|  funktioniert       | Lukas       | Zuhause am Schreibtisch |
| 4.2  | 27.02.24| funktionier        | Lukas       | Zuhause am Schreibtisch |
| 5.1  | 27.02.24| funktioniert         | Lukas       | Zuhause am Schreibtisch |
| 5.2  | 27.02.24| funktioniert         | Lukas       | Zuhause am Schreibtisch |
| 6.1  | 27.02.24| funktioniert          | Lukas       | Zuhause am Schreibtisch |
| 7.1  | 27.02.24| funktioniert          | Lukas       | Zuhause am Schreibtisch |
| 8.1  | 27.02.24| funktioniert       | Lukas       | Zuhause am Schreibtisch |
| 8.2  | 27.02.24| funktioniert          | Lukas       | Zuhause am Schreibtisch |

Fazit:

Ich bin relativ mit dem Resultat zu frieden, jedoch hätte die Verschlüsselung noch ein wenig besser sein können. Es war nicht mein bestes, aber auch nicht ein schlechtes Projekt, ich würde sagen, es liegt im Mittelfeld, also ganz okay, aber auch nichts Weltbewegendes.


