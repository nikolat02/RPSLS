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
        int rock = 1;
        int paper = 2;
        int scissors = 3;
        int lizard = 4;
        int spock = 5;
        int cpuWins = 0;
        int playerWins = 0;
        bool isCPUVictory = false;
        bool isPlayerVictory = false;
        const int MAXWINS = 3;
        string victoryMessage = string.Empty;

        public void creatingPlayer()
        {
            Console.WriteLine("You're a Homosapien!  Get ready to play Rock, Paper, Scissors, Lizard, Spock!");
            //Player Human = new Human(Console.ReadLine());
            //return Human;
        }

        public void makePC()
        {
            Console.WriteLine("Skynet will be playing you!");
               
            //Player computer = new Computer("SkyNet");
            //return computer;
        }

        public void StartGame()
        {
            creatingPlayer();
            askingTwoPlayers();
            makePC();
            Start();
            Console.WriteLine("You will be be selecting a number 1-5 for each corresponding choice.  Choose rock (1), paper (2), scissors (3), lizard (4), spock (5)");
            //use a write or writeline to promt the use for an input
            //write a readline code to accept an interger as string, convert to int
            int playerChoice = Convert.ToInt32(Console.ReadLine());
            //call for computer input
            int cpuChoice = computerchoice();
            //tell player what choice the computer has made
            analayzeChoices(playerChoice, cpuChoice);
            //CALL METHOD TO PLAY AGAIN OR EXIT//
        }


        public string askingTwoPlayers()
        {
            Console.WriteLine("Are there 2 players?");
            string response = (Console.ReadLine());
            return response;
        }

        public void Start()
        {
            int option;
            int rock = 1;
            int paper = 2;
            int scissors = 3;
            int lizard = 4;
            int spock = 5;
        }

       
        /// /PUBLIC VOID START GAME was here
        
        public int computerchoice()
        {
            return random.Next(4) + 1;

        }

        private void analayzeChoices(int player, int CPU)
        {
            string playerObj = interpretPlayerChoice(player);
            string cpuObj = interpretPlayerChoice(CPU);
            //ROCK
            if (playerObj == "Rock" && cpuObj == "Paper")
            {
               victoryMessage = "Paper covers Rock!";
                declareSessionWinner(playerObj, cpuObj, victoryMessage, false);//false for computer wins
                if (isCPUWin())
                {
                    isCPUVictory = true;
                    declareWinner();
                }
            }
           else if (playerObj == "Rock" && cpuObj == "Scissors")
            {
                    victoryMessage = "Rock Smashes Scissors";
                    declareSessionWinner(playerObj, cpuObj, victoryMessage, true);//true for player wins
                   
                    if (isPlayerWin())
                    {
                        isPlayerVictory = true;
                        declareWinner();
                    }
                }
            if (playerObj == "Rock" && cpuObj == "Lizard")
            {
                Console.WriteLine("Rock crushes Lizard!");
            }
            if (playerObj == "Rock" && cpuObj == "Spock")
            {
                Console.WriteLine("Spock vaporizes Rock!");
            }
            if (playerObj == "Rock" && cpuObj == "Rock")
            {
                Console.WriteLine("Tie!");
            };
            //PAPER
            if (playerObj == "Paper" && cpuObj == "Scissors")
            {
                Console.WriteLine("Scissors cuts Paper!");
            };
            if (playerObj == "Paper" && cpuObj == "Lizard")
            {
                Console.WriteLine("Lizard eats Paper!");
            };
            if (playerObj == "Paper" && cpuObj == "Spock")
            {
                Console.WriteLine("Paper disproves Spock!");
            };
            if (playerObj == "Paper" && cpuObj == "Paper")
            {
                Console.WriteLine("Tie!");
            };
            //SCISSORS 
            if (playerObj == "Scissors" && cpuObj == "Lizard")
            {
                Console.WriteLine("Scissors decapitates Lizard!");
            };
            if (playerObj == "Scissors" && cpuObj == "Spock")
            {
                Console.WriteLine("Spock smashes Scissors!");
            };
            if (playerObj == "Scissors" && cpuObj == "Scissors")
            {
                Console.WriteLine("Tie!");
            };
            //LIZARD
            if (playerObj == "Lizard" && cpuObj == "Spock")
            {
                Console.WriteLine("Lizard poisons Spock!");
            };
            if (playerObj == "Lizard" && cpuObj == "Lizard")
            {
                Console.WriteLine("Tie!");
            };
            //SPOCK
            if (playerObj == "Spock" && cpuObj == "Spock")
            {
                Console.WriteLine("Tie!");
            };

            /////CPU below is to the left!

            //ROCK
            if (cpuObj == "Rock" && playerObj == "Paper")
            {
                //Console.WriteLine("You chose Paper and Skynet  chosed Rock");
                //Console.WriteLine("Paper covers Rock!");
                //Console.WriteLine("You win this session");
            }
            if (cpuObj == "Rock" && playerObj == "Scissors")
            {
                Console.WriteLine("Rock smashes Scissors!");
            };
            if (cpuObj == "Rock" && playerObj == "Lizard")
            {
                Console.WriteLine("Rock crushes Lizard!");
            }
            if (cpuObj == "Rock" && playerObj == "Spock")
            {
                Console.WriteLine("Spock vaporizes Rock!");
            }
            if (cpuObj == "Rock" && playerObj == "Rock")
            {
                Console.WriteLine("Tie!");
            }
            //PAPER
            if (cpuObj == "Paper" && playerObj == "Scissors")
            {
                Console.WriteLine("Scissors cuts Paper!");
            }
            if (cpuObj == "Paper" && playerObj == "Lizard")
            {
                Console.WriteLine("Lizard eats Paper!");
            }
            if (cpuObj == "Paper" && playerObj == "Spock")
            {
                Console.WriteLine("Paper disproves Spock!");
            }
            if (cpuObj == "Paper" && playerObj == "Paper")
            {
                Console.WriteLine("Tie!");
            }
            //SCISSORS 
            if (cpuObj == "Scissors" && playerObj == "Lizard")
            {
                Console.WriteLine("Scissors decapitates Lizard!");
            }
            if (cpuObj == "Scissors" && playerObj == "Spock")
            {
                Console.WriteLine("Spock smashes Scissors!");
            };
            if (cpuObj == "Scissors" && playerObj == "Scissors")
            {
                Console.WriteLine("Tie!");
            }
            //LIZARD
            if (cpuObj == "Lizard" && playerObj == "Spock")
            {
                Console.WriteLine("Lizard poisons Spock!");
            }
            if (cpuObj == "Lizard" && playerObj == "Lizard")
            {
                Console.WriteLine("Tie!");
            }
            //SPOCK
            if (cpuObj == "Spock" && playerObj == "Spock")
            {
                Console.WriteLine("Tie!");
            }
        }

        private void declareSessionWinner(string playerObj, string cpuObj, string victoryMessage, bool isPlayerWin)
        {
            Console.WriteLine("You chose {0} and Skynet  chosed {1}", playerObj, cpuObj);
            Console.WriteLine(victoryMessage);
            if (isPlayerWin)
                Console.WriteLine("You win this session");
            else
                Console.WriteLine("Oops Skynet wins this sessiong");
        }

        private bool isCPUWin()
        {
            return cpuWins++ == MAXWINS;
        }

        private bool isPlayerWin()
        {
            return playerWins++ == MAXWINS;
        }
        private void declareWinner()
        {
            if (isCPUVictory)
                Console.WriteLine("Computer out played you this time! registering the maximum wins of three");
            else
                Console.WriteLine("You win...Congratultion...You have registered three wins");
        }

        private string interpretPlayerChoice(int choice)
        {
            string playerobj = string.Empty;

            switch (choice)
            {
                case 1:
                    playerobj = "Rock";
                    break;
                case 2:
                    playerobj = "Paper";
                    break;
                case 3:
                    playerobj = "Scissors";
                    break;
                case 4:
                    playerobj = "Lizard";
                    break;
                case 5:
                    playerobj = "Spock";
                    break;
                default:
                    break;
            }

            return playerobj;
        }
        
       
        public  bool playAgain()//static in this context means that you do not need an instance of the class to call this method
        {//this method can be call directly with the class name. eg. Game.playAgain()
            Console.WriteLine("Play again?(y/n)");
            String playerreset = Console.ReadLine();
            if (playerreset=="y")
            {
                return true;
            }
            else if (playerreset=="n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid Input");

            }


            return false;
        }
    }
               
    }


     


    


   

    
    



