// See https://aka.ms/new-console-template for more information

// Snack #1 utente inserisce due numeri in successione, stampare il maggiore

/* Console.WriteLine("Inserisci un numero");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Inserisci un altro numero");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2)
{
    Console.WriteLine("i numeri sono uguali");
}
else
{
    if (number1 > number2)
    {
        Console.WriteLine($"Il numero maggiore è {number1}");
    }
    else
    {
        Console.WriteLine($"Il numero maggiore è {number2}");
    }
}

*/

// Snack 2 utente inserisce due parole e il software stampa la parola piu corta

/*

Console.WriteLine("Inserisci una parola");
string sentence1 = Console.ReadLine();

Console.WriteLine("Inserisci una parola");
string sentence2 = Console.ReadLine();

if (sentence1.Length > sentence2.Length)
{
    Console.WriteLine($"La parola più lunga è {sentence1}");

} else if(sentence1.Length < sentence2.Length)
{
    Console.WriteLine($"La parola più lunga è {sentence2}");
}
else
{
    Console.WriteLine("Le parole sono lunghe uguali");
}
*/

// Snack #3 

/* int[] numbers = new int[10];
Console.WriteLine("Inserisci 10 numeri");
for (int i = 0; i < 10; i++)
{
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

int sumNumbers = 0;
for (int i = 0; i < numbers.Length; i++)
{
    sumNumbers += numbers[i];
}

Console.WriteLine($"la somma è = {sumNumbers}");

*/

// Snack #4 somma e media dei numeri da 2 a 10

/* int[] numbersArray = {2,3,4,5,6,7,8,9,10};

int sumNumbers = 0;
for (int i = 0; i < numbersArray.Length; i++)
{
    sumNumbers += numbersArray[i];

}

// media
decimal media = Convert.ToDecimal(sumNumbers / numbersArray.Length);
Console.WriteLine($"la somma è {sumNumbers} e la media è {media}");
*/

// Snack 5 

/*
Console.WriteLine("Inserisci un numero");
int numberUser = Convert.ToInt32(Console.ReadLine());

if (numberUser % 2 == 0)
{
    Console.WriteLine($"Il numero è pari {numberUser}");
}
else
{
    Console.WriteLine($"il numero è dispari, +1 = {numberUser + 1}");
}
*/

// Snack 6
/*
 
string[] guestsGatsby = { "Bob", "James", "Francis", "Jack", "David" };
Console.WriteLine("Inserisci il tuo nome");
string firstNameUser = Console.ReadLine();

for (int i = 0; i < guestsGatsby.Length; i++)
{
    if (firstNameUser == guestsGatsby[i])
    {
        Console.WriteLine("Puoi partecipare alla festa");
        break;
    } else if(i == guestsGatsby.Length - 1)
    {
        Console.WriteLine("Non puoi partecipare alla festa");
    }
};

*/

// Snack 7 6 numeri all'utente se dispari inseriscili in un array
/*
 

int[] numbers = new int[6];
Console.WriteLine("Inserisci 6 numeri");

for (int i = 0; i < numbers.Length; i++)
{

    int numberUser = Convert.ToInt32(Console.ReadLine());
    if (numberUser % 2 != 0)
    {
        numbers[i] = numberUser;
    }
  
}

*/

// Snack 8

/*
int[] numbersRandom = { 3, 5, 7, 12, 24, 35, 46, 58, 33 };
int sum = 0;

for (int i = 0; i < numbersRandom.Length; i++)
{
    
    if(i % 2 != 0)
    {
        sum += numbersRandom[i];
    }
}

Console.WriteLine($"La somma dei numeri in posizione dispari è {sum}");

*/

// Snack 9












