namespace Homework
{
    internal class Program
    {
        static void Main(string[] args) {
            Team Team1 = new Team();
            List<FootballPlayer> FootballPlayersTeam1 = new List<FootballPlayer>();
            List<FootballPlayer> FootballPlayersTeam2 = new List<FootballPlayer>();
            int n;
            //Crating players for Team 1
            do
            {
                Console.Write("How many players do you want for Team 1: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 11 || n > 22);

            for (int i=0; i<n;i++) {
                Console.WriteLine("MENU:");
                Console.WriteLine("1.Create a goalkeaper");
                Console.WriteLine("2.Create a defender");
                Console.WriteLine("3.Create a midfielder");
                Console.WriteLine("4.Create a striker");
                Console.Write("Enter a option: ");
                int menu = int.Parse(Console.ReadLine());
                Console.Write("\nWhat is the name of the player: ");
                string name = Console.ReadLine();
                Console.Write("What is the number of the player: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("What is the age of the player: ");
                int age = int.Parse(Console.ReadLine());
                Console.Write("What is the height of the player: ");
                int height = int.Parse(Console.ReadLine());
                Console.Write("What is the rating of the player: ");
                int rating = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Goalkeeaper gk = new Goalkeeaper(name, number, age, height, rating);
                        FootballPlayersTeam1.Add(gk);
                        break;
                    case 2:
                        Defender def = new Defender(name, number, age, height, rating);
                        FootballPlayersTeam1.Add(def);
                        break;
                    case 3:
                        Midfield mid = new Midfield(name, number, age, height, rating);
                        FootballPlayersTeam1.Add(mid);
                        break;
                    case 4:
                        Striker stk = new Striker(name, number, age, height, rating);
                        FootballPlayersTeam1.Add(stk);
                        break;
                }

            }
            Team1.Players = FootballPlayersTeam1.ToArray();

            //Crating players for Team 2
            Team Team2  = new Team();
            do
            {
                Console.Write("\nHow many players do you want for Team 2: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 11 || n > 22);
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("MENU:");
                Console.WriteLine("1.Create a goalkeaper");
                Console.WriteLine("2.Create a defender");
                Console.WriteLine("3.Create a midfielder");
                Console.WriteLine("4.Create a striker");
                Console.Write("Enter a option: ");
                int menu = int.Parse(Console.ReadLine());
                Console.WriteLine("\nWhat is the name of the player: ");
                string name = Console.ReadLine();
                Console.Write("What is the number of the player: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("What is the age of the player: ");
                int age = int.Parse(Console.ReadLine());
                Console.Write("What is the height of the player: ");
                int height = int.Parse(Console.ReadLine());
                Console.Write("What is the rating of the player: ");
                int rating = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Goalkeeaper gk = new Goalkeeaper(name, number, age, height, rating);
                        FootballPlayersTeam2.Add(gk);
                        break;
                    case 2:
                        Defender def = new Defender(name, number, age, height, rating);
                        FootballPlayersTeam2.Add(def);
                        break;
                    case 3:
                        Midfield mid = new Midfield(name, number, age, height, rating);
                        FootballPlayersTeam2.Add(mid);
                        break;
                    case 4:
                        Striker stk = new Striker(name, number, age, height, rating);
                        FootballPlayersTeam2.Add(stk);
                        break;
                }
                Team2.Players = FootballPlayersTeam2.ToArray();
            }

            //Creating coach for both teams
            Console.Write("\nWhat is the name of the coach of Team 1: ");
            string nameCoach1 = Console.ReadLine();
            Console.Write("What is the age of the coach of Team 1: ");
            int ageCoach1 = int.Parse(Console.ReadLine());
            Team1.Coach = new Coach(nameCoach1,ageCoach1);
            Console.Write("\nWhat is the name of the coach of Team 2: ");
            string nameCoach2 = Console.ReadLine();
            Console.Write("What is the age of the coach of Team 2: ");
            int ageCoach2 = int.Parse(Console.ReadLine());
            Team2.Coach = new Coach(nameCoach2, ageCoach2);

            //Creating the referee staff
            Console.Write("\nWhat is the name of the referee: ");
            string nameReferee = Console.ReadLine();
            Console.Write("What is the age of the referee: ");
            int ageReferee = int.Parse(Console.ReadLine());
            Referee ref1 = new Referee(nameReferee,ageReferee);
            Console.Write("\nWhat is the name of the first assisten referee: ");
            string nameAsReferee1 = Console.ReadLine();
            Console.Write("What is the age of the first assistent referee: ");
            int ageAsReferee1 = int.Parse(Console.ReadLine());
            Referee asRef1 = new Referee(nameAsReferee1, ageAsReferee1);
            Console.Write("\nWhat is the name of the second assisten referee: ");
            string nameAsReferee2 = Console.ReadLine();
            Console.Write("What is the age of the second assistent referee: ");
            int ageAsReferee2 = int.Parse(Console.ReadLine());
            Referee asRef2 = new Referee(nameAsReferee2, ageAsReferee2);

            //rating of Team 1 (attaking and defending)
            int attackersTeam1 = 0;
            int defendersTeam1 = 0;
            double attackSumTeam1 = 0;
            double defenseSumTeam1 = 0;
            
            foreach (var item in Team1.Players)
            { 
                string type = item.GetType().Name;
                if (type == "Striker")
                {
                    Striker temp = (Striker)item;
                    attackersTeam1++;
                    attackSumTeam1 += temp.Attaking;
                }
                else if (type == "Midfield")
                {
                    Midfield temp = (Midfield)item;
                    attackersTeam1++;
                    attackSumTeam1 += temp.Attaking;
                }
                else if (type == "Defender")
                {
                    Defender temp = (Defender)item;
                    defendersTeam1++;
                    defenseSumTeam1 += temp.Defending;
                }
                else if (type == "Goalkeeper")
                {
                    Goalkeeaper temp = (Goalkeeaper)item;
                    defendersTeam1++;
                    defenseSumTeam1 += temp.Defending;
                }
            }
            attackSumTeam1 = attackSumTeam1 / attackersTeam1;
            defenseSumTeam1 = defenseSumTeam1 / defendersTeam1;
            //rating of Team 2 (attaking and defending)
            int attackersTeam2 = 0;
            int defendersTeam2 = 0;
            double attackSumTeam2 = 0;
            double defenseSumTeam2 = 0;
            
            foreach (var item in Team2.Players)
            {
                string type = item.GetType().Name;
                if (type == "Striker")
                {
                    Striker temp = (Striker)item;
                    attackersTeam2++;
                    attackSumTeam2 += temp.Attaking;
                }
                else if (type == "Midfield")
                {
                    Midfield temp = (Midfield)item;
                    attackersTeam2++;
                    attackSumTeam2 += temp.Attaking;
                }
                else if (type == "Defender")
                {
                    Defender temp = (Defender)item;
                    defendersTeam2++;
                    defenseSumTeam2 += temp.Defending;
                }
                else if (type == "Goalkeeper")
                {
                    Goalkeeaper temp = (Goalkeeaper)item;
                    defendersTeam2++;
                    defenseSumTeam2 += temp.Defending;
                }
            }
            attackSumTeam2 = attackSumTeam2 / attackersTeam2;
            defenseSumTeam2 = defenseSumTeam2 / defendersTeam2;
            
            Console.WriteLine();
            //Average age of Team 1 
            double avrAgeTeam1=0;
            foreach(var item in Team1.Players)
            {
                int age = (int)item.Age;
                avrAgeTeam1 += age;
            }
            avrAgeTeam1 /= attackersTeam1 + defendersTeam1;
            //Average age of Team 2
            double avrAgeTeam2 = 0;
            foreach (var item in Team2.Players)
            {
                int age = (int)item.Age;
                avrAgeTeam2 += age;
            }
            avrAgeTeam2 /= attackersTeam2 + defendersTeam2;
            //Creating the game
            Random rand = new Random();
            int goalT1 = 0;
            int goalT2 = 0;

            Console.WriteLine($"\nThe average age of Team 1 is: {avrAgeTeam1:f1}");
            Console.WriteLine($"The average age of Team 2 is: {avrAgeTeam2:f1}\n");
            for (int minute = 0; minute <= 45; minute++)
            {
                if (rand.Next(1, 101) <= attackersTeam1 + defendersTeam1)
                {
                    FootballPlayer scorer = Team1.Players[rand.Next(Team1.Players.Length)];
                    Console.WriteLine($"Goal for Team 1 in the {minute}! The goal was made from: {scorer.Name}");
                    goalT1++;
                }

            }
            for (int minute = 45; minute <= 90; minute++)
            {
                if (rand.Next(1, 101) <= attackersTeam2 + defendersTeam2)
                {
                    FootballPlayer scorer = Team2.Players[rand.Next(Team2.Players.Length)];
                    Console.WriteLine($"Goal for Team 2 in the {minute}! The goal was made from: {scorer.Name}");
                    goalT2++;
                }
            }
            Console.WriteLine("\nFinal Result!");
            Console.WriteLine($"Team 1 {goalT1} : {goalT2} Team 2");
 
        }
    }
  
}