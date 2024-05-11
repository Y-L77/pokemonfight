using System;

//simple terminal game made by Y-L77, Game doesn't have functionality like check stats, fighting back or more things I would've liked to add but I've already understood methods I think which was the purpose of this simple terminal project.
public class Pokemon {

    public string Name;
    public int Health;
    public int Attack;
}

class Program {
    static void Main(string[] args) {

        Pokemon Pikachu = new Pokemon();
        Pikachu.Name = "Pikachu";
        Pikachu.Health = 700;
        Pikachu.Attack = 30;

        Pokemon Charizard = new Pokemon();
        Charizard.Name = "Charizard";
        Charizard.Health = 1200;
        Charizard.Attack = 55;

        Console.WriteLine("Welcome trainer! You're going to face against a Charizard in this terminal game. Best of luck!");

        while(Pikachu.Health > 0 && Charizard.Health > 0) {

            Console.WriteLine("Select your move!");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Flee");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice) {
                case 1:
                    Options.Attack(Pikachu, Charizard); //args for option.attack | this comment is for learning ik it not good to repeat code in english
                    break;
                case 2:
                    Options.Flee();
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}

public class Options{
    public static void Flee(){
        Console.WriteLine("You have sucessfully fleed!");
        Environment.Exit(0);
    }

    public static void Attack(Pokemon attacker, Pokemon defender){
        defender.Health -= attacker.Attack;
        Console.WriteLine($"{attacker.Name} Attacks {defender.Name}, it does {attacker.Attack}");
                
                
        }
    }
