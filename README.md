# Emne_8_Cloud

## Beskrivelse

Emne_8_Cloud er en .NET-basert applikasjon som tilbyr et REST API for administrasjon av data i en database. 
Applikasjonen bruker MediatR for å håndtere forespørsler, noe som gjør det enklere å administrere forretningslogikk og separasjon av lagene. 
Applikasjonen kjøres i Docker-kontainere, noe som muliggjør enkel distribusjon og skalering.

## Funksjoner

* **GetAll:** Henter alle poster fra databasen.
* **AddRecord:** Legger til en ny post i databasen.
* **DeleteById:** Sletter en post fra databasen basert på ID.
* **UpdateRecordById:** Oppdaterer en post i databasen basert på ID.

## Krav

* Docker
* Docker Compose

## Kjøre applikasjonen

1. Klon repositoriet:

2. Kjør Docker Compose for å bygge og starte kontainerne:

   ```bash
   docker-compose up -d
   
   curl http://localhost:8080/db/GetAll
   
   curl -X POST http://localhost/api/db/AddRecord -H "Content-Type: application/json" -d "{\"Titel\": \"value\", \"Description\": \"value\"}"
   
   curl -X DELETE http://localhost/api/db/DeleteById/1
   
   curl -X PUT http://localhost/api/Db/UpdateRecordById/3 -H "Content-Type: application/json" -d "{\"Titel\": \"new_value1\", \"Description\": \"new_value2\"}"

   
