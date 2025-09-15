// Identify a dice game, Ceelo (NYC dice game)

// Ceelo is a dice game where people roll a set of 3d6's and if you roll a 4-5-6 it's an auto win, but if you roll 1-2-3 its and auto loss. players can gain single points by getting 2 of a kind in a single roll, exp roll could be 1-1-2 (results in a point)

// Describe dice 
// top of the dice a number between 1- 6
// number of sides is 6 (A d6)

// Dice behavior -
// 3 are rolled

// UML Dice Class

// private members
// - topSide:int
// - numOfSides:int

// public members
// +Dice()
// +Dice(int)
// +roll():void
// +TopSide:int
// +NumofSide:int  

//Test Case #1
// 1. Create a Dice object using the default constructor. 
// 2. Create a Dice object using with a positive number of sides.
// 3. Create a Dice ojject using with a non-positive number sides.
//4. Check the TopSide of the dice. Ensure it's within [1 to the maxsides].



using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

public class Dice
{
    private int topSide;
    private int numOfSides;


    public Dice()
    {
        numOfSides = 6;
    }

    public Dice(int sides)
    {
        if (sides < 1)
        {
            numOfSides = 6;
        }
        else
        {
         
        numOfSides = sides;
        }
    }

    public void roll()
    {
        Random dice = new Random();
        topSide = dice.Next(1, numOfSides+1);
    }
    
    public int TopSide {get { return topSide;}}
}

// public class DiceGame()
// {
//     public static void Main()
//     {
//         // test case #1, dice object with a default constructor
//         Dice dice1 = new Dice();
//         dice1.roll();
//         Console.WriteLine("rolling dice for case 1");
//         Console.WriteLine(dice1.TopSide);


//         //test case #2, dice object with a positive number of sides 
//         Dice dice2 = new Dice(20);
//         dice2.roll();
//         Console.WriteLine("\nrolling dice for case 2");
//         Console.WriteLine(dice2.TopSide);

//         //test case #3, dice object with a non-positive number of sides
//         Dice dice3 = new Dice(-1);
//         dice3.roll();
//         Console.WriteLine("\nrolling dice for case 3");
//         Console.WriteLine(dice3.TopSide);

//         // Test case #4 check the stop side and ensure it's within the limits of the dice 
//         Dice dice4 = new Dice(55);
//         dice4.roll();
//         if (dice4.TopSide <= 55 && dice4.TopSide >= 1)
//         {
//             Console.WriteLine("\nTest case 4 has passed");
//             Console.WriteLine(dice4.TopSide);
//         }
//         else
//         {
//             Console.WriteLine("\nTest case 4 has failed");
//             Console.WriteLine(dice4.TopSide);
//         }
//     }


// }

public class CeeloGame()
{
    public static void Main()
    {
        // creates player one's dice and rolls them, and stores the results in an array
        Dice p1Dice = new Dice();
        int[] p1DiceRolls = new int[3];

        for (int w = 0; w < 3; w++)
        {
            p1Dice.roll();
            p1DiceRolls[w] = p1Dice.TopSide;
        }

        for (int v = 0; v < 3; v++)
        {
            Console.WriteLine($"Player one's dice {v+1} rolled {p1DiceRolls[v]}\n");
        }   
        
        
        // creates player one's dice and rolls them, and stores the results in an array
        Dice p2Dice = new Dice();
        int[] p2DiceRolls = new int[3];

        for (int i = 0; i < 3; i++)
        {
            p2Dice.roll();
            p2DiceRolls[i] = p2Dice.TopSide;
        }    

         for (int j = 0; j < 3; j++)
        {
           Console.WriteLine($"Player two's dice {j+1} rolled {p2DiceRolls[j]}\n");
        }  
    }
}
