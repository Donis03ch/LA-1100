# Projekt-Dokumentation LA 1100

☝️ Alle Text-Stellen, welche mit einem ✍️ beginnen, können Sie löschen, sobald Sie die entsprechende Stellen ausgefüllt haben.

Brandon Spaqi

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|       | 0.0.1   | ✍️ Jedes Mal, wenn Sie an dem Projekt arbeiten, fügen Sie hier eine neue Zeile ein und beschreiben in *einem* Satz, was Sie erreicht haben. |
|       | ...     |                                                              |
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

Ich erstelle ein Zahlenratespiel, wobei eine zufällige Zahl gespeichert wird und der User die Zahl raten muss.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    | muss            | Funktionalität     | Als ein Spieler möchte ich, dass der Computer eine Zufallszahl zwischen 1 - 100 speichert, damit man eine Zahl raten |
| 2    | muss            | Funktionalität     | Als ein Spieler möchte ich eine Zahl raten, damit ich punkten kann.                                   |
| 3    | muss            | Funktionalität | Als ein Spieler möchte ich, dass mir der Computer Hinweise gibt, damit ich eine bessere Ratechance habe. |
| 4    | kann            | Qualität | Als ein Spieler möchte ich, dass mir der Computer die Anzahl versuche zeigt, damit ich mich mit anderen messen kann |
| 5    | muss            | Qualität | Als ein Spieler möchte ich, dass das Programm Fehleingaben umgeht/vermeidet, damit ich spielen kann |
| 6    | kann            | Randanforderung | Als ein Spieler möchte ich, dass das Programm neue Feature annimmt und spannend bleibt, damit ich keine langeweile habe. |

✍️ Jede User Story hat eine ganzzahlige Nummer (1, 2, 3 etc.), eine Verbindlichkeit (Muss oder Kann?), und einen Typ (Funktional, Qualität, Rand). Die User Story selber hat folgende Form: *Als ein 🤷‍♂️ möchte ich 🤷‍♂️, damit 🤷‍♂️*.

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Computer startet und generiert Zahl             | 200        |   Die Zahl muss zwischen 1 - 100 sein!                |
| 1.2  | Computer startet und generiert Zahl             |  40       |  Die Zahl ist grösser als die Geheimzahl                 |
| 1.3  | Computer startet und generiert Zahl             |  22       |  Die Zahl ist kleiner als die Geheimzahl                 |
| 1.4  | Computer startet und generiert zahl             | -77        | Die Zahl muss zwischen 1 - 100 sein!                  |
| 2.1  | Computer generiert Zahl. erwartet Eingabe             |  Affe       | Bitte geben sie eine Zahl zwischen 1 - 100 ein!                  |
| 2.2  | Computer generiert Zahl. erwartet Eingabe             |  +-       |  Bitte geben sie eine Zahl zwischen 1 - 100 ein!                 |
| 2.3  | Computer generiert Zahl. erwartet Eingabe             |  40       |  Zahl wird mit der Geheimzahl verglichen                 |
| 3.1  | Computer generiert Zahl. Eingabe verglichen mit Geheimzahl             | 40        |  Hinweis(Zahl ist grösser als die Geheimzahl)                 |
| 3.2  | Computer generiert Zahl. Eingabe verglichen mit Geheimzahl             | 7        | Hinweis(Zahl ist kleiner als die Geheimzahl)                  |
| 4.1  | Eingabe verglichen mit Geheimzahl             | falsche Zahl        | Versuch: 1                  |
| 4.2  | Eingabe verglichen mit Geheimzahl             | nochmal falsche Zahl        | Versuch: 2                  |
| 5.1  | Eingabe verglichen mit Geheimzahl. Versuche: 1             | x#we        |  Bitte geben sie eine gültige Zahl zwischen 1 - 100                 |

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.

### 1.4 Diagramme

✍️ Hier können Sie PAPs, Use Case- und Gantt-Diagramme oder Ähnliches einfügen. <img width="539" alt="image" src="https://user-images.githubusercontent.com/111046453/186597964-a3cdcdcc-30f4-4c4b-a771-58d14d0c74b5.png">


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |  1.9     |  Brandon         |  Lernen wie man einen Zufallszahlgenerator programmier            |  45min             |
| 2.A  |  1.W     |  Brandon         |  Eingabe von Zahl erstellen            |  45min             |
| 3.A  |  1.W     |  Brandon         |  Hinweise programmieren           |  45min             |
| 4.A  |  1.W     |  Brandon         |  Anzeige von Versuchen erstellen            |  45min             |
| 5.A  |  8.9     |  Brandon         |  Lernen wie man im Programm Fehlermeidungen programmiert             |  45min             |
| 6.A  |  2.W     |  Brandon         |  Erweiterte Programmierungen eingeben            |  45min             |
| 7.A  |  2.W     |  Brandon         |  Gewinnsystem programieren            |  45min             |
| 8.A  |  2.W     |  Brandon         |  Rangliste programmieren            |  45min             |
| 9.A  |  15.9    | Brandon          |  Neue Stufen einfügen            |  45min             |
| 10.A |  3.W     | Brandon          |  Musik einfügen            |  45min             |
| 11.A |  3.W     | Brandon         |  Musik Stummschaltung programmieren            | 45min             |
| 12.A |  3.W     | Brandon         |  Layout ändern            | 45min              |

Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |  01.09.2022     |   Brandon        | 80min.              |   50min.                |
| 2.A  |  01.09.2022     |   Brandon        | 45min.              |   40min.                |
| ...  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
