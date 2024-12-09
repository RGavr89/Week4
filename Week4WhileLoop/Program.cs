

Random rnd = new Random();

int cpuRandom = rnd.Next(1, 4);

bool loopActive = true;

int numberOfTries = 0;  


while (numberOfTries < 3)
{
    Console.WriteLine("Try to gues the cpu number:");
    int userGuess = Convert.ToInt32(Console.ReadLine());

    numberOfTries++;

    if (userGuess == cpuRandom)
    {
        Console.WriteLine("You won");

        break;
     
        //loopActive = false; 
    }
}
Console.WriteLine($"The number of tries: {numberOfTries}");
Console.WriteLine("Have a nice day");
