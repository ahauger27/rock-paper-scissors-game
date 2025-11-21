Random opponentMove = new Random();

string? playerName;
string? playerMove;
int playerScore = 0;
int opponentScore = 0;
bool winCondition = false;
const int winningScore = 3;

Console.Write("What is your name? :");
playerName = Console.ReadLine();

Console.WriteLine($"\nHello, {playerName}!");
Console.WriteLine("Let's play a game of Rock, Paper, Scissors.");

// An array of possible moves
string[] moveList = ["ROCK", "PAPER", "SCISSORS"];

do
{
    Console.WriteLine("Make your move (ROCK, PAPER, or SCISSORS).");
    playerMove = Console.ReadLine().ToUpper();

    if (moveList.Contains(playerMove))
    {
        if ()

    }
    else
    {
        Console.WriteLine("Please input a valid move.");
    }

    if ((playerScore == winningScore) || (opponentScore == winningScore))
    {
        winCondition = true;
    }
} while (winCondition == false);

//  

