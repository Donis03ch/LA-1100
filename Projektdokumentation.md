# Projekt-Dokumentation LA 1100



Brandon Spaqi

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|       | 0.0.1   | Ich habe eine Zufallszahl generiert, Hinweise angegeben und die Eingabe einer Zahl programmiert. |
|       | 0.0.2     |  Ich habe die Anzahl der Versuche programmiert und die Wiederhol-Funktion, ohne das Programm zu schliessen programmiert.                     |
|       | 1.0.0   | Ich habe das Testprotokoll durchgeführt.                                                             |

## 1 Informieren

### 1.1 Ihr Projekt

Ich erstelle ein Zahlenratespiel, wobei eine zufällige Zahl gespeichert wird und der User die Zahl raten muss.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    | muss            | Funktionalität     | Als ein Spieler möchte ich, dass der Computer eine Zufallszahl zwischen 1 - 100 speichert, damit man eine Zahl raten  kann |
| 2    | muss            | Funktionalität     | Als ein Spieler möchte ich eine Zahl raten, damit ich punkten kann.                                   |
| 3    | muss            | Funktionalität | Als ein Spieler möchte ich, dass mir der Computer Hinweise gibt, damit ich eine bessere Ratechance habe. |
| 4    | kann            | Qualität | Als ein Spieler möchte ich, dass mir der Computer die Anzahl versuche zeigt, damit ich mich mit anderen messen kann |
| 5    | muss            | Qualität | Als ein Spieler möchte ich, dass das Programm nochmal eine Zahl generiert, damit ich nochmal spielen kann ohne das Programm zu schliessen |
| 6    | kann            | Randanforderung | Als ein Spieler möchte ich, dass das Programm neue Feature annimmt und spannend bleibt, damit ich keine langeweile habe. |



### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Computer startet und generiert Zahl             | 200        |   Die Zahl muss zwischen 1 - 100 sein!                |
| 1.2  | Computer startet und generiert Zahl             |  Zahl > generierte Zahl       |  Die Zahl ist grösser als die Geheimzahl                 |
| 1.3  | Computer startet und generiert Zahl             |  Zahl < generierte zahl       |  Die Zahl ist kleiner als die Geheimzahl                 |
| 1.4  | Computer startet und generiert zahl             | -77        | Die Zahl muss zwischen 1 - 100 sein!                  |
| 2.1  | Computer generiert Zahl. erwartet Eingabe             |  Affe       | Bitte geben sie eine Zahl zwischen 1 - 100 ein!                  |
| 2.2  | Computer generiert Zahl. erwartet Eingabe             |  +-       |  Bitte geben sie eine Zahl zwischen 1 - 100 ein!                 |
| 2.3  | Computer generiert Zahl. erwartet Eingabe             |  40       |  Zahl wird mit der Geheimzahl verglichen                 |
| 3.1  | Computer generiert Zahl. Eingabe verglichen mit Geheimzahl             | Zahl > Geheimzahl      |  Hinweis(Zahl ist grösser als die Geheimzahl)                 |
| 3.2  | Computer generiert Zahl. Eingabe verglichen mit Geheimzahl             | Zahl < Gehimzahl      | Hinweis(Zahl ist kleiner als die Geheimzahl)                  |
| 4.1  | Eingabe verglichen mit Geheimzahl             | falsche Zahl        | Versuch: 1                  |
| 5.1  | Eingabe verglichen mit Geheimzahl. Versuche: 1             | x#we        |  Bitte geben sie eine gültige Zahl zwischen 1 - 100                 |



### 1.4 Diagramme

 <img width="539" alt="image" src="https://user-images.githubusercontent.com/111046453/186597964-a3cdcdcc-30f4-4c4b-a771-58d14d0c74b5.png">


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |  1.9     |  Brandon         |  Lernen wie man einen Zufallszahlgenerator programmier            |  45min             |
| 2.A  |  1.W     |  Brandon         |  Eingabe von Zahl erstellen            |  45min             |
| 3.A  |  1.W     |  Brandon         |  Hinweise programmieren           |  45min             |
| 4.A  |  1.W     |  Brandon         |  Anzeige von Versuchen erstellen            |  45min             |
| 5.A  |  8.9     |  Brandon         |  Lernen wie man das Spiel nochmal spielen kann             |  45min             |
| 6.A  |  2.W     |  Brandon         |  Erweiterte Programmierungen eingeben            |  45min             |
| 7.A  |  2.W     |  Brandon         |  Gewinnsystem programieren            |  45min             |
| 8.A  |  2.W     |  Brandon         |  Rangliste programmieren            |  45min             |
| 9.A  |  15.9    | Brandon          |  Neue Stufen einfügen            |  45min             |
| 10.A |  3.W     | Brandon          |  Musik einfügen            |  45min             |
| 11.A |  3.W     | Brandon         |  Musik Stummschaltung programmieren            | 45min             |
| 12.A |  3.W     | Brandon         |  Layout ändern            | 45min              |

Total: 



## 3 Entscheiden



## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |  01.09.2022     |   Brandon        | 80min.              |   70min.                |
| 2.A  |  01.09.2022     |   Brandon        | 40min.              |   50min.                |
| 3.A  |  01.09.2022     |   Brandon        | 50min.              |   45min.                |
| 4.A  |  01.09.2022     |   Brandon        | 50min.              |   60min.                |
| 5.A  |  08.09.2022     |   Brandon        | 60min.              |   40min.                |
| 6.A  |  08.09.2022     |   Brandon        | 45min.              |   45min.                |
| 7.A  | -       | -           | -             | -                   |
| 8.A  | -       | -           | -             | -                   |
| 9.A  | -       | -           | -             | -                   |
| 10.A  | -       | -           | -             | -                   |
| 11.A  | -       | -           | -             | -                   |
| 12.A  | -       | -           | -             | -                   |



## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester | Fazit |
| ---- | ----- | -------- | ------ | ----- |
| 1.1  | 22.09.2022      | Funktioniert nicht         | Spaqi Brandon       | Es ist nicht nötig um es zu spielen, sondern übersichtlicher. |
| 1.2  | 22.09.2022      | Funktioniert         | Spaqi Brandon       | Es ist nötig um es zu spielen, es macht es übersichtlicher. |
| 1.3  | 22.09.2022      | Funktioniert         | Spaqi Brandon       | Es ist nötig um es zu spielen, es macht es übersichtlicher. |
| 1.4  | 22.09.2022      | Funktioniert nicht         | Spaqi Brandon       | Es ist nicht nötig um es zu spielen, sondern übersichtlicher. |
| 2.1  | 22.09.2022      | Funktioniert nicht         | Spaqi Brandon       | Es ist nötig um eine gültige Zahl zu fordern und das Spiel weiterhin funktioniert. |
| 2.2  | 22.09.2022      | Funktioniert nicht         | Spaqi Brandon       | Es ist nötig um eine gültige Zahl zu fordern und das Spiel weiterhin funktioniert. |
| 2.3  | 22.09.2022      | Funktioniert nicht         | Spaqi Brandon       | Es ist nicht nötig um es zu spielen. |
| 3.1  | 22.09.2022      | Funktioniert         | Spaqi Brandon       | Es ist nicht nötig um es zu spielen, es macht das Spielerlebnis schöner. |
| 3.2  | 22.09.2022      | Funktioniert         | Spaqi Brandon       | Es ist nicht nötig um es zu spielen, es macht das Spielerlebnis schöner. |
| 4.1  | 22.09.2022      | Funktioniert nicht         | Spaqi Brandon       | Es ist nicht nötig um es zu spielen, es macht es nur schöner. |
| 5.1  | 22.09.2022      | Funktioniert nicht         | Spaqi Brandon       | Es ist nicht nötig um es zu spielen, es macht es nur schöner. |




## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
