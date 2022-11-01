//Scrivete nel vostro programma principale Program.cs le seguenti funzioni di base:
//void StampaArray(int[] array): che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]“. Potete prendere quella fatta in classe questa mattina
//int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.
//int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato. Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione! Vi ricordate perchè? Pensateci (vedi slide)
//int SommaElementiArray(int[] array): che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.
//Una volta completate queste funzioni di utilità di base, e dato il seguente array di numeri [2, 6, 7, 5, 3, 9] già dichiarato nel vostro codice, si vogliono utilizzare le funzioni per:
//Stampare l’array di numeri fornito a video
//Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato (Verificare che l’array originale non sia stato modificato quindi ristampare nuovamente l’array originale e verificare che sia rimasto [2, 6, 7, 5, 3, 9])
//Stampare la somma di tutti i numeri
//Stampare la somma di tutti i numeri elevati al quadrato


//BONUS: Convertire le funzioni appena dichiarate in funzioni generiche, ossia funzioni che possono lavorare con array di numeri interi di lunghezza variabile, ossia debbono poter funzionare sia che gli passi array di 5 elementi, sia di 6, di 7, di ... e così via. A questo punto modificare il programma in modo che chieda all’utente quanti numeri voglia inserire, e dopo di che questi vengono inseriti a mano dall’utente esternamente.
//Rieseguire il programma con l’input preso esternamente dall’utente.

// Definizione delle funzioni di base:

using System;



// CIFRARIO DI CESARE
//Realizzare un programma in grado di CRIPTARE e DECRIPTARE una stringa inserita nell’utente con la strategia di criptazione nota come “IL CIFRARIO DI CESARE”
//l’utente inserisce una stringa da criptare / decriptare
//l’utente inserisce una chiave numerica per effettuare la criptazione / decriptazione della stringa inserita


// Definizione delle variabili iniziali standard e dei valori iniziali di criptazione
int encryption = 0, key = 0;
string userSendsText = "", encryptedText = "";

// // // // Variabili di decriptazione
int decryption = 0;
string decryptText = "";

// Richiesta all'utente di definire la frase da criptare e la chiave che desidera utilizzare
Console.WriteLine("Scrivi la frase o la parola che desideri criptare: ");
userSendsText = Console.ReadLine();

Console.WriteLine("Inserisci la chiave che desideri utilizzare: ");
key = Convert.ToInt32(Console.ReadLine());

// Ciclo per sostituire le lettere in base al valore della chiave
for (int i = 0; i < userSendsText.Length; i++)
{
    int txtUser = (int)userSendsText[i];

    // Sostituzione del testo in base alla posizione dichiarata nella chiave
    encryption = txtUser + key;

    // Utilizzo dei caratteri speciali
    encryptedText += Char.ConvertFromUtf32(encryption);
}

// Riporta la frase criptata
Console.WriteLine($"Testo Criptato: {encryptedText}");


// Ciclo per decriptare la frase sottraendo il valore dichiarato della chiave dalla posizione della lettera
for (int i = 0; i < encryptedText.Length; i++)
{
    int encrypted = (int)encryptedText[i];

    // Sostituzione del testo in base alla sottrazione della posizione dichiarata nella chiave
    decryption = encrypted - key;

    decryptText += Char.ConvertFromUtf32(decryption);
}

// Riporta la frase decriptata
Console.WriteLine("");
Console.WriteLine($"Testo Decriptato: {decryptText}");



return;



// Esercizio Fibonacci
//Si chiede di implementare due funzioni che eseguano le corrsipettive funzioni matematiche:
//1 - Fattoriale di un numero
//1) il fattoriale di un numero può essere calcolato solo su numeri positivi:
//0! = 1 1! = 1 2! = 2 3! = 6 4! = 24 5! = 120 N! = ???
//    risolverla in modo RICORSIVO o anche in modo ITERATIVO (FOR)




{

    // Calcolo di un fattoriale di un numero

    int i, number, fact;
    Console.WriteLine("Inserire il numero:");
    number = int.Parse(Console.ReadLine());
    fact = number;
    for (i = number - 1; i >= 1; i--)
    {
        fact = fact * i;
    }
    Console.WriteLine("\nIl fattoriale del numero inserito é: " + fact);
    Console.ReadLine();

}


return;



////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


void StampaArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1)
            Console.Write(", ");
    }
    Console.WriteLine(" ]");
}
int Quadrato(int numero)
{
    return numero * numero;
}
int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] arrayQuadrato = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arrayQuadrato[i] = Quadrato(array[i]);
    }
    return arrayQuadrato;
}
int SommaElementiArray(int[] array)
{
    int somma = 0;
    for (int i = 0; i < array.Length; i++)
    {
        somma += array[i];
    }
    return somma;
}

//////////////////////////////////

// Definizione dell'array di numeri:

//int[] myArray = { 2, 6, 7, 5, 3, 9 };

//////////////////////////////////

// L'utente definisce la lunghezza dell'array:

Console.Write("Inserire di quanti numeri si vuole comporre l'array: ");
int N = Convert.ToInt32(Console.ReadLine());


// Creazione dell'array con lunghezza definita dall'utente:

int[] myArray = new int[N];

// Ciclo per l'aggiunta dei numeri da inserire nell'array:

for (int i = 0; i < N; i++)
{
    Console.Write("Aggiungi il numero all'array: ");
    myArray[i] = Convert.ToInt32(Console.ReadLine());
}

// Stampa array a video

StampaArray(myArray);

Console.WriteLine();

// Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato

int[] arrayAlQuadrato = ElevaArrayAlQuadrato(myArray);
StampaArray(arrayAlQuadrato);

Console.WriteLine();

// Stampare la somma di tutti i numeri

Console.WriteLine("Somma dei numeri dell'array: " + SommaElementiArray(myArray));

Console.WriteLine();

// Stampare la somma di tutti i numeri elevati al quadrato

Console.WriteLine("Somma dei numeri dell'array al quadrato: " + SommaElementiArray(arrayAlQuadrato));

