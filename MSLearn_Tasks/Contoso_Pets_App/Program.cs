using System;

namespace Pets_app
{
    class Program
    {
        static void Main()
        {
            string menuSelection = "";

            Console.WriteLine("Welcome to Contoso Pets App");

            int animalCount = 4;
            string[,] ourAnimals = new string[8, 6];

            for(int i = 0; i < animalCount; i++)
            {
                if(i == 0)
                {
                    ourAnimals[i, 0] = "ID001";
                    ourAnimals[i, 1] = "Dog";
                    ourAnimals[i, 2] = "2";
                    ourAnimals[i, 3] = "Brown dog";
                    ourAnimals[i, 4] = "Friendly";
                    ourAnimals[i, 5] = "Buddy";
                } else if (i == 1) {
                    ourAnimals[i, 0] = "ID002";
                    ourAnimals[i, 1] = "Cat";
                    ourAnimals[i, 2] = "1";
                    ourAnimals[i, 3] = "White cat";
                    ourAnimals[i, 4] = "Calm";
                    ourAnimals[i, 5] = "Snowy";
                } else if (i == 2)
                {
                    ourAnimals[i, 0] = "ID003";
                    ourAnimals[i, 1] = "Dog";
                    ourAnimals[i, 2] = "3";
                    ourAnimals[i, 3] = "Black dog";
                    ourAnimals[i, 4] = "Energetic";
                    ourAnimals[i, 5] = "Rocky";
                } else if (i == 3)
                {
                    ourAnimals[i, 0] = "ID004";
                    ourAnimals[i, 1] = "Cat";
                    ourAnimals[i, 2] = "?";
                    ourAnimals[i, 3] = "Gray cat";
                    ourAnimals[i, 4] = "Unknown";
                    ourAnimals[i, 5] = "Misty";
                }
            }
            do
            {
                Console.WriteLine("\nMenu Options:");
                Console.WriteLine("1. List all pets");
                Console.WriteLine("2. Add new pet");
                Console.WriteLine("3. Ensure complete data");
                Console.WriteLine("4. Update pet info");
                Console.WriteLine("5. Search dogs by characteristic");
                Console.WriteLine("6. Search cats by characteristic");
                Console.WriteLine("Type 'exit' to quit");

                Console.Write("Enter your choice: ");
                menuSelection = Console.ReadLine();

                Console.WriteLine($"You selected: {menuSelection}");

                switch (menuSelection)
                {
                    case "1":
                        Console.WriteLine("Listing all pets...");
                        string[] labels = { "ID", "Species", "Age", "Physical", "Personality", "Nickname" };

                        for (int i = 0; i < animalCount; i++)
                        {
                            Console.WriteLine("\nPet Details:");

                            for (int j = 0; j < 6; j++)
                            {
                                Console.WriteLine($"{labels[j]}: {ourAnimals[i, j]}");
                            }
                        }
                        break;

                    case "2":
                        Console.WriteLine("Adding new pet...");

                        string choice = "y";

                        while (choice.ToLower() == "y")
                        {
                            if (animalCount >= 8)
                            {
                                Console.WriteLine("No more space to add new pets!");
                                break;
                            }

                            string species = "";

                            while (string.IsNullOrWhiteSpace(species) || 
                                (species.ToLower() != "dog" && species.ToLower() != "cat"))
                            {
                                Console.Write("Enter species (dog/cat): ");
                                species = Console.ReadLine();
                            }

                            string age = "";

                            while (string.IsNullOrWhiteSpace(age))
                            {
                                Console.Write("Enter age: ");
                                age = Console.ReadLine();
                            }

                            string physical = "";

                            while (string.IsNullOrWhiteSpace(physical))
                            {
                                Console.Write("Enter physical description: ");
                                physical = Console.ReadLine();
                            }

                            string personality = "";

                            while (string.IsNullOrWhiteSpace(personality))
                            {
                                Console.Write("Enter personality: ");
                                personality = Console.ReadLine();
                            }

                            string nickname = "";

                            while (string.IsNullOrWhiteSpace(nickname))
                            {
                                Console.Write("Enter nickname: ");
                                nickname = Console.ReadLine();
                            }

                            string id = "ID00" + (animalCount + 1);

                            ourAnimals[animalCount, 0] = id;
                            ourAnimals[animalCount, 1] = species;
                            ourAnimals[animalCount, 2] = age;
                            ourAnimals[animalCount, 3] = physical;
                            ourAnimals[animalCount, 4] = personality;
                            ourAnimals[animalCount, 5] = nickname;

                            animalCount++;

                            Console.Write("Add another pet? (y/n): ");
                            choice = Console.ReadLine();
                        }
                        break;


                    case "3":
                        Console.WriteLine("Ensuring complete data...");
                        
                        for(int i = 0; i < animalCount; i++)
                        {
                            if(ourAnimals[i,2] == "?" || ourAnimals[i,4] == "Unknown")
                            {
                                Console.WriteLine($"\nPet ID: {ourAnimals[i, 0]} has incomplete data.");
                                if (ourAnimals[i, 2] == "?")
                                {
                                    Console.Write("Enter correct age: ");
                                    string newAge = Console.ReadLine();
                                    ourAnimals[i, 2] = newAge;
                                }
                                if (ourAnimals[i, 4] == "Unknown")
                                {
                                    Console.Write("Enter personality: ");
                                    string newPersonality = Console.ReadLine();
                                    ourAnimals[i, 4] = newPersonality;
                                }
                            }
                        }
                        break;

                    case "4":
                        Console.WriteLine("Updating pet info...");
                        Console.Write("Enter Pet ID to update: ");
                        string searchId = Console.ReadLine();
                        bool found = false;

                        for(int i = 0; i < animalCount; i++)
                        {
                            if (ourAnimals[i, 0] == searchId)
                            {
                                found = true;
                                Console.WriteLine("Pet found!");

                                Console.WriteLine("1. Update Age");
                                Console.WriteLine("2. Update Personality");
                                Console.Write("Choose option: ");
                                string updateChoice = Console.ReadLine();
                                if (updateChoice == "1")
                                {
                                    Console.Write("Enter new age: ");
                                    string newAge = Console.ReadLine();
                                    ourAnimals[i, 2] = newAge;
                                }
                                else if (updateChoice == "2")
                                {
                                    Console.Write("Enter new personality: ");
                                    string newPersonality = Console.ReadLine();
                                    ourAnimals[i, 4] = newPersonality;
                                }
                                break;
                            }
                        }
                        if (!found)
                        {
                            Console.WriteLine("Pet ID not found!");
                        }
                        break;
                    
                    case "5":
                        Console.Write("Enter keyword to search in dogs: ");
                        string dogSearch = Console.ReadLine().ToLower();

                        bool dogFound = false;

                        for (int i = 0; i < animalCount; i++)
                        {
                            if (ourAnimals[i, 1].ToLower() == "dog" &&
                                (ourAnimals[i, 3].ToLower().Contains(dogSearch) ||
                                ourAnimals[i, 4].ToLower().Contains(dogSearch)))
                            {
                                dogFound = true;

                                Console.WriteLine("\nMatching Dog:");
                                Console.WriteLine($"ID: {ourAnimals[i, 0]}");
                                Console.WriteLine($"Breed/Physical: {ourAnimals[i, 3]}");
                                Console.WriteLine($"Personality: {ourAnimals[i, 4]}");
                            }
                        }

                        if (!dogFound)
                        {
                            Console.WriteLine("No matching dogs found.");
                        }

                        break;

                    case "6":
                        Console.Write("Enter keyword to search in cats: ");
                        string catSearch = Console.ReadLine().ToLower();

                        bool catFound = false;

                        for (int i = 0; i < animalCount; i++)
                        {
                            if (ourAnimals[i, 1].ToLower() == "cat" &&
                                (ourAnimals[i, 3].ToLower().Contains(catSearch) ||
                                ourAnimals[i, 4].ToLower().Contains(catSearch)))
                            {
                                catFound = true;

                                Console.WriteLine("\nMatching Cat:");
                                Console.WriteLine($"ID: {ourAnimals[i, 0]}");
                                Console.WriteLine($"Physical: {ourAnimals[i, 3]}");
                                Console.WriteLine($"Personality: {ourAnimals[i, 4]}");
                            }
                        }

                        if (!catFound)
                        {
                            Console.WriteLine("No matching cats found.");
                        }

                        break;

                    case "exit":
                        Console.WriteLine("Exiting application...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice, try again.");
                        break;
                }
            } while (menuSelection != "exit");   
        }
    }
}