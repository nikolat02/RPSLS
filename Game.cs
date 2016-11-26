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

        }

        public void makePC()
        {
            Console.WriteLine("Skynet will be playing you!");

        }

        public void StartGame()
        {
            creatingPlayer();
            askingTwoPlayers();
            makePC();
            Start();
            while (true)
            {
                Console.WriteLine("You will be be selecting a number 1-5 for each corresponding choice.  Choose rock (1), paper (2), scissors (3), lizard (4), spock (5)");
                int playerChoice = Convert.ToInt32(Console.ReadLine());
                int cpuChoice = computerchoice();
                analayzeChoices(playerChoice, cpuChoice);
                Console.WriteLine("--------------------------------------------------------------------------------------------");
                if (isCPUWin() || isPlayerWin())
                    break;
            }
            declareWinner();


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
                cpuWins++;
            
            }
            if (playerObj == "Rock" && cpuObj == "Scissors")
            {
                victoryMessage = "Rock Smashes Scissors!";
                declareSessionWinner(playerObj, cpuObj, victoryMessage, true);//true for player wins
                playerWins++;
            }
            if (playerObj == "Rock" && cpuObj == "Lizard")
            {
                victoryMessage = "Rock crushes Lizard!";
                declareSessionWinner(playerObj, cpuObj, victoryMessage, true);
                playerWins++;

            }
            if (playerObj == "Rock" && cpuObj == "Spock")
            {
                {
                    victoryMessage = "Spock vaporizes Rock!";
                    declareSessionWinner(playerObj, cpuObj, victoryMessage, false);
                    cpuWins++;
                }
            }
            if (playerObj == "Rock" && cpuObj == "Rock")
            {
                Console.WriteLine("Tie!");
            };
            //PAPER
            if (playerObj == "Paper" && cpuObj == "Scissors")
            {
                victoryMessage = "Scissors cuts Paper!";
                declareSessionWinner(playerObj, cpuObj, victoryMessage, false);
                cpuWins++;
            }

            if (playerObj == "Paper" && cpuObj == "Lizard")
            {
                victoryMessage = "Lizard eats Paper!";
                declareSessionWinner(playerObj, cpuObj, victoryMessage, false);
                cpuWins++;
            }
            if (playerObj == "Paper" && cpuObj == "Spock")
            {
                victoryMessage = "Paper disproves Spock!";
                declareSessionWinner(playerObj, cpuObj, victoryMessage, true);
                playerWins++;
            }

            if (playerObj == "Paper" && cpuObj == "Paper")
            {
                Console.WriteLine("Tie!");
            };
            //SCISSORS 
            if (playerObj == "Scissors" && cpuObj == "Lizard")
            {
                victoryMessage = "Scissors decapitates Lizard!";
                declareSessionWinner(playerObj, cpuObj, victoryMessage, true);
                playerWins++;
            }
            if (playerObj == "Scissors" && cpuObj == "Spock")
            {
                victoryMessage = "Spock smashes Scissors!";
                declareSessionWinner(playerObj, cpuObj, victoryMessage, false);
                cpuWins++;
            }
            if (playerObj == "Scissors" && cpuObj == "Scissors")
            {
                Console.WriteLine("Tie!");
            };
            //LIZARD
            if (playerObj == "Lizard" && cpuObj == "Spock")
            {
                victoryMessage = "Lizard poisons Spock!";
                declareSessionWinner(playerObj, cpuObj, victoryMessage, true);
                playerWins++;
            }
            if (playerObj == "Lizard" && cpuObj == "Lizard")
            {
                Console.WriteLine("Tie!");
            };
            //SPOCK
            if (playerObj == "Spock" && cpuObj == "Rock")
            {
                victoryMessage = "Spock vaporizes Rock!";
                declareSessionWinner(playerObj, cpuObj, victoryMessage, true);
                playerWins++;
            }

            if (playerObj == "Spock" && cpuObj == "Spock")
            {
                Console.WriteLine("Tie!");
            };

            ///CPU below is to the left!

            //ROCK
            if (playerObj == "Paper" && cpuObj == "Rock")
            {
                victoryMessage = "Paper covers Rock!";
                declareSessionWinner(playerObj, cpuObj, victoryMessage, true);
                playerWins++;
            }
            if (playerObj == "Scissors" && cpuObj == "Rock")
            {
                victoryMessage = "Rock smashes Scissors!";
                declareSessionWinner(playerObj, cpuObj, victoryMessage, false);
                cpuWins++;
            }
            if (playerObj == "Lizard" && cpuObj == "Rock")
            {
                victoryMessage = "Rock crushes Lizard!";
                declareSessionWinner(playerObj, cpuObj, victoryMessage, false);
                cpuWins++;
            }
            if (playerObj == "Rock" && cpuObj == "Spock")
            {
                victoryMessage = "Spock vaporizes Rock!";
                declareSessionWinner(playerObj, cpuObj, victoryMessage, false);
                cpuWins++;
            }

            if (cpuObj == "Rock" && playerObj == "Rock")
            {
                Console.WriteLine("Tie!");
            }
            //PAPER
            if (playerObj == "Scissors" && cpuObj == "Paper")
            {
                victoryMessage = "Scissors cuts Paper!";
                declareSessionWinner(playerObj, cpuObj, victoryMessage, true);
                cpuWins++;
            }
            if (playerObj == "Lizard" && cpuObj == "Paper")
            {
                victoryMessage = "Lizard eats Paper!";
                declareSessionWinner(playerObj, cpuObj, victoryMessage, true);
                playerWins++;
            }
            if (playerObj == "Spock" && cpuObj == "Paper")
            {
                victoryMessage = "Paper disproves Spock!";
                declareSessionWinner(playerObj, cpuObj, victoryMessage, false);
                cpuWins++;
                
            }
            if (cpuObj == "Paper" && playerObj == "Paper")
            {
                Console.WriteLine("Tie!");
            }
            //SCISSORS 
            if (playerObj == "Lizard" && cpuObj == "Scissors")
            {
                victoryMessage = "Scissors decapitates Lizard!";
                declareSessionWinner(playerObj, cpuObj, victoryMessage, false);
                cpuWins++;
            }
            if (playerObj == "Spock" && cpuObj == "Scissors")
            {
                victoryMessage = "Spock smashes Scissors!";
                declareSessionWinner(playerObj, cpuObj, victoryMessage, true);
                playerWins++;
            }
            if (cpuObj == "Scissors" && playerObj == "Scissors")
            {
                Console.WriteLine("Tie!");
            }
            //LIZARD
            if (playerObj == "Spock" && cpuObj == "Lizard")
            {
                victoryMessage = "Lizard poisons Spock!";
                declareSessionWinner(playerObj, cpuObj, victoryMessage, false);
                cpuWins++;
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
            Console.WriteLine("You chose {0} and Skynet chose {1}", playerObj, cpuObj);
            Console.WriteLine(victoryMessage);
            if (isPlayerWin)
                Console.WriteLine("You win this session");

            else
                Console.WriteLine("Oops Skynet wins this session");
        }

        private bool isCPUWin()
        {
            return cpuWins == MAXWINS;
        }

        private bool isPlayerWin()
        {
            return playerWins == MAXWINS;
        }
        private void declareWinner()
        {
            if (isCPUWin())
                Console.WriteLine("Skynet out played you this time!");
            else if(isPlayerWin())
                Console.WriteLine("You win...Congratulations...You have registered three wins");
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
    }
}















