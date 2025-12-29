using System;

class SnakeAndLadder
{
    static int[,] ladders = { { 4, 87 }, { 9, 31 }, { 21, 42 }, { 28, 84 } };
    static int[,] snakes = { { 17, 7 }, { 89, 9 }, { 62, 19 }, { 52, 32 } };

    static Random random = new Random();

    static int RollDice()
    {
        return random.Next(1, 7);
    }

    static int MovePlayer(int currentPosition, int diceValue)
    {
        int nextPosition = currentPosition + diceValue;
        return nextPosition > 100 ? currentPosition : nextPosition;
    }

    static int ApplySnakeOrLadder(int position)
    {
        for (int i = 0; i < snakes.GetLength(0); i++)
        {
            if (position == snakes[i, 0])
            {
                Console.WriteLine("Bitten by a snake");
                return snakes[i, 1];
            }
        }

        for (int i = 0; i < ladders.GetLength(0); i++)
        {
            if (position == ladders[i, 0])
            {
                Console.WriteLine("Climbed the ladder");
                return ladders[i, 1];
            }
        }

        return position;
    }

    static bool HasPlayerWon(int position)
    {
        return position == 100;
    }

    static int ReadInt(string message)
    {
        int value;
        while (true)
        {
            Console.Write(message);
            if (int.TryParse(Console.ReadLine(), out value))
                return value;

            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }

    static void StartMultiplayerGame()
    {
        int playerCount = ReadInt("Enter number of players (2 to 4): ");

        if (playerCount < 2 || playerCount > 4)
        {
            Console.WriteLine("Invalid number of players.");
            return;
        }

        int[] playerPositions = new int[playerCount];
        Console.WriteLine("Game started. All players are at position 0.");

        while (true)
        {
            for (int playerIndex = 0; playerIndex < playerCount; playerIndex++)
            {
                string input;
                do
                {
                    Console.WriteLine($"\nPlayer {playerIndex + 1}, type 'roll' to roll the dice:");
                    input = Console.ReadLine().ToLower().Trim();
                }
                while (input != "roll");

                int diceValue = RollDice();
                int oldPosition = playerPositions[playerIndex];

                int newPosition = MovePlayer(oldPosition, diceValue);
                newPosition = ApplySnakeOrLadder(newPosition);

                playerPositions[playerIndex] = newPosition;

                Console.WriteLine($"Dice rolled: {diceValue}");
                Console.WriteLine($"Position moved: {oldPosition} → {newPosition}");

                if (HasPlayerWon(newPosition))
                {
                    Console.WriteLine($"\n🎉 Player {playerIndex + 1} wins the game!");
                    return;
                }
            }
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Snake and Ladder");
        Console.WriteLine("1. Start Multiplayer Game");

        int userChoice = ReadInt("Enter your choice: ");

        switch (userChoice)
        {
            case 1:
                StartMultiplayerGame();
                break;

            default:
                Console.WriteLine("Invalid choice. Restart the game.");
                break;
        }
    }
}
