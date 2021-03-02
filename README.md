# CalculatorService

Mit dem vorliegenden Code wird ein **einfacher API basierter Microservice** erstellt. Dieser Service stellt einen Rechner für die Grundrechenarten 
Addition, Subtraktion, Multiplikation und Division bereit und ist ein Beispiel für die Umsetzung einer **WebAPI** mit Hilfe von **.NET Core 5**.

Bei der Umsetzung wurde bewußt nur die Kernfunktionalität in den Voredergrund gerückt, um das Prinzip zu verdeutlichen. In einem realen Einsatz 
müsste zumindest eine Fehlerabfangung ergänzt werden.

## Umsetzung
Rein formal handelt es sich um eine **.NET Core 5** und somit einer **ASP.net** Anwendung (Visual Studio Projekt). Die Anwendung basiert auf die Nutzung 
von Controllern, jedoch wird kein MVC Pattern umgesetzt. Hierbei unterstützt Visual Studio die Entwicklung mit einem soliden und ausführbaren 
Grundgerüst.

Es kommt **MapController** für das Routing zum Einsatz. Hierbei werden beim Starten der Anwendung die Endpunkte (Endpoints/mögliche Ziele von 
Aufrufen) anhand der Annotierungen im Code festgelegt. Es ist hierbei eine feste Konvention, Controller im Verzeichnis Controllers und hier 
den Klassen- und Dateinamen um Controller zu erweitern. So liegt der Controller addition in **./Controllers/AdditionController.cs**.

Es ist möglich, bereits im Routing eine feste Validierung z.B. des Types vorzunehmen, jedoch wurde dies explizit nicht gemacht, um sich auf das 
Essenzielle konzentrieren zu können. Auch sind andere Möglichkeiten der Datenübergabe, wie beispielsweise JSON möglich. Hier wurde jedoch 
bewußt auf **GET** und der Übergabe von genau **zwei Zahlen** und einer **Rechenart** gesetzt, um die Schnittstelle möglichst einfach zu gestalten.

## Befehle
Der Rechner unterstützt die vier Grundrechenarten. Die Syntax zur Nutzung des Rechners ist die Webadresse, gefolgt von der Rechenart sowie 
die Angabe zweier Zahlen, wie hier zu sehen: **https://domain/[addition/subtract/multiply/divide]/[Zahl1]/[Zahl2]** (z.B. localhost:8080/divide/3/2). 
Je nach Start des Containers sowie beim lokalen Testen ist hierbei gegebenenfalls der genutzte Port mit anzugeben.

## Docker
Das Beispiel ist als Docker Container [**ckitte/apibasedmicroservice**](https://hub.docker.com/r/ckitte/apibasedmicroservice) verfügbar. Nach dem herunterladen kann er mit dem Befehl **docker run -p 8080:80 ckitte/apibasedmicroservice** 
gestartet werden. Hierbei ist 8080 der Port außerhalb des Containers, hier localhost:8080, und 80 der Port innerhalb des Containers. **Somit horcht 
der Service im Container am Port 80 und ich spreche ihn von außen mit 8080 an**. Das Buildscript ist teil des Codes.


