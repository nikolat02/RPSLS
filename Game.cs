using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        Random random = new Random();
        List<string> options = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
        public Player creatingPlayer()
        {
            Console.WriteLine("You're a Homosapien!  Get ready to play Rock, Paper, Scissors, Lizard, Spock!");
            Player Human = new Human(Console.ReadLine());
            return Human;
        }


        public Player makePC()
        {
            Player computer = new Computer("SkyNet");
            return computer;
        }

        public string askingTwoPlayers()
        {
            Console.WriteLine("Are there 2 players?");
            string response = (Console.ReadLine());
            return response;
        }

        
        public void Start()
        {
            
            Console.WriteLine("Choose rock, paper, scissors, lizard, spock!")
            string Pick = Console.ReadLine();
            switch (Pick)
            {
                case "Paper":
                
                {
                    case "Paper":
                        return draw;
                        break;
                    case "Rock":
                        return win;
                        break;
                    case "Scissors":
                        return lose;
                        break;
                    case "Lizard":
                        return lose;
                        break;
                    case "Spock":
                        return win;
                        break;
                    default: throw new Exception("Error...Maybe you should watch your CAPS.");
                }
            case "Rock":
                {
                    case  "Paper":
                        return lose;
                        break;
                    case  "Rock":
                        return draw;
                        break;
                    case  "Scissors":
                        return win;
                        break;
                    case "Lizard":
                        return win;
                        break;
                    case "Spock":
                        return lose;
                        break;
                    default: throw new Exception("Error...Maybe you should watch your CAPS.");
                }
            case "Scissors":
                switch (options)
                {
                    case "Paper":
                        return win;
                        break;
                    case "Rock":
                        return lose;
                        break;
                    case "Scissors":
                        return draw;
                        break;
                    case "Lizard":
                        return win;
                        break;
                    case "Spock":
                        return lose;
                        break;
                    default: throw new Exception("Error...Maybe you should watch your CAPS.");
                }
            default: throw new Exception("Error...Maybe you should watch your CAPS.");

            case "Spock":
                switch
                {
                    case "Paper":
                        return lose;
                    case "Rock":
                        return win;
                    case "Scissors":
                        return win;
                    case "Lizard":
                        return lose;
                    case "Spock":
                        return draw;
                    default: throw new Exception("Error...Maybe you should watch your CAPS.");
                }

            case "Lizard":
                switch 
                {
                    case "Paper":
                        return win;
                        break;
                    case "Rock":
                        return lose;
                        break;
                    case "Scissors":
                        return lose;
                        break;
                    case "Lizard":
                        return draw;
                        break;
                    case "Spock":
                        return win;
                        break;
                    default: throw new Exception("Error...Maybe you should watch your CAPS.");

                }
        } }

    public string computerchoice()
    {
        string random = random.choice("Rock", "Paper", "Scissors", "Lizard", "Spock",);
        return random string;
    }

    
    } 







