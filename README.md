# Calcolatrice Lacertosa Edoardo

applicazione in C# creata durante le lezioni di informatica che implementa una calcolatrice.

# Funzionalità Principali

## Gestione dei Pulsanti
- I pulsanti vengono gestiti nel metodo `MakeButtons`, che crea e posiziona i bottoni sulla form in base alla matrice `buttons`.

## Gestione dei Click
- Il metodo `MyButton_Click` gestisce le azioni quando un pulsante viene premuto. 
  - Analizza il tipo di simbolo associato al pulsante e reagisce di conseguenza (es. inserimento di numeri, operazioni aritmetiche, cancellazione).

## Gestione degli Operatori
- Le operazioni tra operandi sono gestite dai metodi `ManageOperator` e `specialManageOp`.
  - `ManageOperator` calcola il risultato delle operazioni aritmetiche base (addizione, sottrazione, moltiplicazione, divisione).
  - `specialManageOp` gestisce operazioni speciali come percentuale, radice quadrata, reciproco, quadrato.

## Cancellazione e Reset
- Le funzioni di cancellazione sono gestite dai metodi `ClearAll` e `ClearEntry`.
  - `ClearAll` reimposta tutti i valori e l'interfaccia grafica.
  - `ClearEntry` cancella l'input corrente o resetta completamente la calcolatrice.

## Visualizzazione del Risultato
- La visualizzazione del risultato è gestita dal metodo `lbl_result_TextChanged`.
  - Si occupa di formattare correttamente il risultato in modo che sia leggibile e che si adatti alla dimensione della finestra.

## Altre Funzionalità
- Il programma supporta l'inserimento di numeri negativi, l'uso della virgola come separatore decimale e regola la dimensione del carattere in base alla lunghezza del testo.

# Utilizzo
1. Avviare l'applicazione.
2. Fare clic sui pulsanti per inserire numeri e eseguire operazioni.
3. Utilizzare i pulsanti speciali per funzioni aggiuntive.
4. Il risultato verrà visualizzato nella finestra principale.

# Legenda dei Pulsanti
- `%`: Percentuale
- `Œ`: Cancella Inserimento
- `C`: Cancella Tutto
- `⌫`: Backspace
- `⅟x`: Reciproco (1/x)
- `²`: Quadrato (x²)
- `√`: Radice Quadrata (√x)
- `÷`: Divisione
- `×`: Moltiplicazione
- `-`: Sottrazione
- `+`: Addizione
- `±`: Segno Più/Meno
- `,`: Punto Decimale
- `=`: Uguale