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

Mein Projekt ist eine Konsolen Applikation, die es dem Benutzer ermöglicht Texte zu verschlüsseln und zu entschlüsseln, sprich eine Codierungsgerät.

Mein Ziel war von Anfang an klar, ich wollte eine App machen , die es dem Benutzer ermöglicht Texte zu verschlüsseln und auch zu entschlüsseln das Ziel der App ist Nachrichten zu verschlüsseln um diese jemand anderem zu schicken, welcher die Nachricht mit dem richtigen Code entschlüsseln kann. Ausserdem war das ziel nochmals ein Objekt Orientiertes Programmieren (OOP) Projekt zu erstellen.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    | muss                |  funktional    | Als ein User möchte ich eine Textdatei auswählen können, damit man diese verschlüsseln oder entschlüsseln kann. |
| 2  |  muss                 | funktional      |Als ein User möchte ich eine Meldung bekommen, ob die Datei gefunden worden ist, damit ich sicher gehen kann das sie wirklich vorhanden ist.  |
| 3    | muss                | funktionel     | Als ein User möchte ich gefragt werden, ob der Text verschlüsselt oder entschlüsselt werden soll.|
| 4  |  muss               | funktional     | Als ein User möchte ich, dass der Text verschlüsselt wird, damit ich eine verschlüsselte Nachricht versenden kann.|
| 5    |  muss               | funktional     |Als ein User möchte ich, dass der verschlüsselte Text auch entschlüsselt werden kann, damit ich die verschlüsselte nachricht lesen kann.|
| 6  | kann                | funktional     | Als ein User möchte ich, dass der neue Text in ein neues File gespeichert wird, damit die alte Datei noch vorhanden ist. |
| 7   |  kann             |  qualität   | Als ein User möchte ich das der Text mit einem Delay ausgegeben wird, damit es einzigartiger wirkt.|
| 8  | kann                | qualität     | Als ein User möchte ich, das Fehler abgefangen werden, damit dass Programm nicht abstürzt.|

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
| 1.A  | 22.11      |  Lukas         |  Spieler soll sich bewegen können            |    50 Minuten           |
| 2.A  | 22.11      |  Lukas         |   Spieler soll springen können           |    50 Minuten           |
| 3.A  |  22.11     |  Lukas         |   Spieler soll sich ducken können           |  50 Minuten             |
|4.A   |22.11       |Lukas           |Einen Cursor machen                          |15 Minuten|
| 5.A  |  22.11     |   Lukas        |  Besiegbare Zombies            |  90 Minuten             |
| 6.A  |  22.11     |  Lukas         |  Waffen            |  90 Minuten             |
| 7.A  |  29.11     |  Lukas         |  Basis bauen            |  120 Minuten             |
| 8.A  |  29.11     |  Lukas        |  Items herstellen            |  120 Minuten             |
| 9.A  | 29.11      |  Lukas         |  Items aufsammeln            | 120 Minuten              |
| 10.A  | 29.11      |  Lukas         |   Bäume/Steine abbauen           |  120 Minuten             |
| 11.A  |  6.12     |  Lukas         |  Animationen einbauen            | 60 Minuten              |
| 12.A  |  6.12     |  Lukas         | Sounds einbauen             |  90 Minuten             |
| 13.A  | 6.12      |  Lukas         | Karte             | 60 Minuten              |
| 14.A  | 6.12      |  Lukas         |  Essen & Trinken            |  90 Minuten             |
| 15.A  | 6.12      |  Lukas         |   Fortbewegungsmittel           | 90 Minuten              |
| 19.A  | 20.12      |  Lukas         |  Lebensanzeige           |  45 Minuten             |
| 20.A  | 20.12      |  Lukas         |   Ausdaueranzeige           | 45 Minuten              |


## 3 Entscheiden

Wir haben uns nach dem Informieren und Planen dafür entschieden, das wir nur die wichtigsten Funktionen implementieren, da der rest sonst viel zu lange gedauert hätte.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |  22.11     |  Mirhan Özden         |   50 Minuten            |   40 Minuten                |
| 2.A  | 22.11       | Mirhan Özden          |    50 Minuten           |   40 Minuten                |
|3.A|22.11 |Mirhan Özden| 50 Minuten| 45 Minuten   |
|4.A|22.11|Mirhan Özden|10 Minuten|10 Minuten|
|5.A|22.11|Lukas Heiniger|90min|180min|
|6.A|22.11|Lukas Heiniger|90min|240min|
|7.A|29.11|Lukas Heiniger|120min|nicht angefangen|
|8.A|29.11|Mirhan Özden|120 Minuten| 200 Minuten (Funktioniert nicht ganz)|
|9.A|29.11|Mirhan Özden|120 Minuten|150 Minuten|
|10.A|29.11|Mirhan Özden|120 Minuten|(Wegen der Zeit nicht geschafft)|
|11.A|6.12|Lukas Heiniger|60min|60min||
|12.A|6.12|Mirhan Özden|90 Minuten|70 Minuten|
|13.A|6.12|Lukas Heiniger|60min|60min||
|14.A|6.12|Lukas Heiniger||||
|15.A|6.12|Lukas Heiniger||||
|16.A|6.12|Mirhan Özden|120 Minuten|200 Minuten|
|17.A|6.12|Mirhan Özden|120 Minuten|150 Minuten|
|18.A|13.12|Mirhan Özden|90 Minuten|120 Minuten|
|19.A|9.1|Lukas Heiniger|45min|90min|
|20.A|9.1|Lukas Heiniger|45min|100min|



## 5 Kontrollieren

| TC-№ | Datum | Resultat | Tester |Testumgebung|
| ---- | ----- | -------- | ------ | ---------|
| 1.1  | 10.01.24|  funktioniert        | Lukas       | Zuhause am Schreibtisch |
| 2.1  | 10.01.24|  funktioniert        | Lukas       | Zuhause am Schreibtisch |
| 3.1  | 10.01.24|  funktioniert        | Lukas       | Zuhause am Schreibtisch |
| 4.1  | 10.01.24|  ist vorhanden       | Lukas       | Zuhause am Schreibtisch |
| 5.1  | 10.01.24| funktioniert bis auf das wechseln         | Lukas       | Zuhause am Schreibtisch |
| 5.2  | 10.01.24| funktioniert         | Lukas       | Zuhause am Schreibtisch |
| 6.1  | 10.01.24| funktioniert nicht         | Lukas       | Zuhause am Schreibtisch |
| 7.1  | 10.01.24| funktioniert          | Lukas       | Zuhause am Schreibtisch |
| 8.1  | 10.01.24| funktioniert          | Lukas       | Zuhause am Schreibtisch |
| 9.1  | 10.01.24| nicht vorhanden        | Lukas       | Zuhause am Schreibtisch |
| 9.2  | 10.01.24| nicht vorhanden          | Lukas       | Zuhause am Schreibtisch |
| 10.1  | 10.01.24| ist vorhanden         | Lukas       | Zuhause am Schreibtisch |
| 11.1  | 10.01.24| ist vorhanden         | Lukas       | Zuhause am Schreibtisch |
| 12.1  | 10.01.24| ist vorhanden         | Lukas       | Zuhause am Schreibtisch |
| 13.1  | 10.01.24| nicht vorhanden         | Lukas       | Zuhause am Schreibtisch |
| 14.1  | 10.01.24| nicht vorhanden         | Lukas       | Zuhause am Schreibtisch |
| 15.1  | 10.01.24| nicht vorhanden         | Lukas       | Zuhause am Schreibtisch |
| 15.2  | 10.01.24| nicht vorhanden         | Lukas       | Zuhause am Schreibtisch |
| 16.1  | 10.01.24| nicht vorhanden        | Lukas       | Zuhause am Schreibtisch |
| 16.2  | 10.01.24| nicht vorhanden         | Lukas       | Zuhause am Schreibtisch |


Da wir nicht alles in der vorgegebene Zeit schaffen konnten haben wir uns auf die wichtigsten Funktionen fokussiert. Trozdem sind wir recht zufrieden mit dem Ergebnis


