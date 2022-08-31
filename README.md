# 📆 Agenda

![Agenda](https://user-images.githubusercontent.com/78277419/187724156-ab937cc0-0661-4194-8582-a59b1eabd7c5.png)

Qui ho caricato solo i file più importanti. Puoi scaricare l'applicazione integrale dal file [Agenda.zip](https://github.com/Grax03/Agenda/blob/main/Agenda.zip)

## Problema
Si vuole realizzare un'applicazione che gestisca i nostri appuntamenti. Ogni appuntamento è caratterizzato da: data, ora e descrizione.
Attraverso l'uso di un calendario, l'applicativo deve poter:
- Inserire un appuntamento
- Spostare un appuntamento
- Spostare tutti gli appuntamenti del giorno puntato dal calendario di una settimana
- Visualizzare gli appuntamenti del giorno
- Evidenziare l'appuntamento corrente
- Eliminare gli appuntamenti precedenti ad oggi

## Analisi

### Dalla descrizione del problema emergono le seguenti considerazioni:
- Ogni qualvolta l'utente inserisce un nuovo appuntamento bisogna caricare quest'ultimo su una ListView ma non prima di aver controllato che l'utente abbia inserito i dati richiesti. Controllo dunque che le textbox non siano vuote e successivamente aggiungo l'appuntamento alla lista.
- Per poter spostare un appuntamento faccio selezionare all'utente l'appuntamento che deve spostare e poi gli faccio cambiare la data e l'ora.
- Quando invece devo spostare l'appuntamento di una settimana converto il valore della data dell'appuntamento selezionato in Datetime in modo da essere sicuro che la data spostata sia corretta. <br>
Faccio notare che diversamente dall'inserimento o lo spostamento di un appuntamento, quando bisogna spostarlo di 7 giorni non si fa scegliere all'utente dal calendario la data corrispondente alla settimana successiva, bensì prelevando il valore della data di tipo string dalla lista bisogna convertirlo prima in Datetime per poter utilizzare le funzioni per aggiungere i giorni.
- Tutti gli appuntamenti vengono visualizzati immediatamente sulla lista quindi non c'è bisogno per l'utente di accedere ad un'altra sezione dell'applicazione perché tutto quello che gli serve lo può vedere subito. Stessa cosa per l'appuntamento corrente.
- Per eliminare un appuntamento l'utente deve prima selezionarlo dalla lista e poi cliccare sul tasto rimuovi
- Un'ulteriore funzione che ho aggiunto è il counter degli appuntamenti che ti dice quanti appuntamenti sono presenti in agenda. Per implementare questa funzione mi è bastato aggiungere una funzione che collegata a una label leggesse il numero di appuntamenti presenti nella lista e li mostrasse a schermo.

### Definizione dati
I dati che l'utente deve inserire per potere utilizzare l'applicazione sono:
- String per nome dell'evento, data e ora di inizio e fine attività
- Bool per la checkbox "Tutto il giorno"
- Datetime per le date
- Int per la modifica delle date

### Funzioni necessarie
- Crea_Appuntamento
- Sposta_Appuntamento
- Sposta7g_Appuntamento
- Visualizza_Appuntamenti_Odierni
- Evidenzia_Appuntamento_Corrente
- Rimuovi_Appuntamento

## Autore
- [Filippo Graziano](https://github.com/Grax03)
