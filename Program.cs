Random randomMove = new Random();

string? playerName;
string? playerMove;
string opponentMove;
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
    opponentMove = moveList[randomMove.Next(0, 3)].ToUpper();

    if (moveList.Contains(playerMove))
    {
        if (playerMove == opponentMove)
        {
            Console.WriteLine("This round is a DRAW.");
        }
        else if ((playerMove == "ROCK") && (opponentMove == "PAPER"))
        {
            Console.WriteLine("The opponent wins this round.");
            opponentScore += 1;
        }
        else if ((playerMove == "ROCK") && (opponentMove == "SCISSORS"))
        {
            Console.WriteLine("You win this round!")
        } 
        else
        {
            Console.WriteLine("yippee");
        }
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

