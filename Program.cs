// Salem's Dice Roll Simulator
#nullable disable

Random rnd = new Random();
int dieOne = 0, dieTwo = 0;

// WELCOME
Console.Clear();
Console.WriteLine("Salem's Dice Roll Simulator");

// MAIN LOOP
while (true)
{


    // INPUT
    WriteMenu();
    Console.Write("Select an option (1-5): ");
    string menuSelection = Console.ReadLine();
    Console.WriteLine();

    // PROCESS + OUTPUT
    if (menuSelection == "1")
    {
        // roll dice once
        Console.WriteLine("Roll Dice Once");
        RollDice();
    }
    else if (menuSelection == "2")
    {
        // roll dice 5 times
        Console.WriteLine("Roll Dice 5 Times");
        for (int x = 1; x <= 5; x++)
        {
            RollDice();
        }
    }
    else if (menuSelection == "3")
    {
        // roll dice n times
        Console.WriteLine("Roll Dice n Times");
        Console.Write("Enter Number of Rolls: ");
        int rollCount = Convert.ToInt16(Console.ReadLine());
        for (int x = 1; x <= rollCount; x++)
        {
            RollDice();
        }
    }
    else if (menuSelection == "4")
    {
        // roll dice until snake eyes
        Console.WriteLine("Roll Dice until Snake Eyes");
        int rollCount = 0;
        while (true)
        {
            RollDice();
            rollCount++;
            if (dieOne + dieTwo == 2) break;
        }
        Console.WriteLine($"Snake Eyes! It took {rollCount} rolls to get snake eyes.");
    }
    else if (menuSelection == "5")
    {
        // exit
        break;
    }
    else
    {
        Console.WriteLine("Invalid Input");
    }

}

// FUNCTIONS
void WriteMenu()
{
    Console.WriteLine();
    Console.WriteLine("Dice Roll Simulator Menu");
    Console.WriteLine("1. Roll Dice Once");
    Console.WriteLine("2. Roll Dice 5 Times");
    Console.WriteLine("3. Roll Dice n Times");
    Console.WriteLine("4. Roll Dice until Snake Eyes");
    Console.WriteLine("5. Exit");
}

void RollDice()
{
    dieOne = rnd.Next(1, 7);
    dieTwo = rnd.Next(1, 7);
    Console.WriteLine($"{dieOne},{dieTwo} (sum: {dieOne + dieTwo})");
}