using System;

class Program
{
    static string animalSpecies = "";
    static string animalID = "";
    static string animalAge = "";
    static string animalPhysicalDescription = "";
    static string animalPersonalityDescription = "";
    static string animalNickname = "";

    static string? readResult;
    static string menuSelection = "";
    static int petCount = 0;
    static string anotherPet = "y";
    static bool validEntry = false;
    static int petAge = 0;

    static int maxPets = 8;
    static string[,] ourAnimals = new string[maxPets, 6];

    static void Main()
    {
        // create some initial ourAnimals array entries
        for (int i = 0; i < maxPets; i++)
        {
            switch (i)
            {
                case 0:
                    animalSpecies = "dog";
                    animalID = "d1";
                    animalAge = "2";
                    animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
                    animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
                    animalNickname = "lola";
                    break;

                case 1:
                    animalSpecies = "dog";
                    animalID = "d2";
                    animalAge = "9";
                    animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
                    animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
                    animalNickname = "loki";
                    break;

                case 2:
                    animalSpecies = "cat";
                    animalID = "c3";
                    animalAge = "1";
                    animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
                    animalPersonalityDescription = "friendly";
                    animalNickname = "Puss";
                    break;

                case 3:
                    animalSpecies = "cat";
                    animalID = "c4";
                    animalAge = "?";
                    animalPhysicalDescription = "";
                    animalPersonalityDescription = "";
                    animalNickname = "";
                    break;

                default:
                    animalSpecies = "";
                    animalID = "";
                    animalAge = "";
                    animalPhysicalDescription = "";
                    animalPersonalityDescription = "";
                    animalNickname = "";
                    break;

            }

            ourAnimals[i, 0] = "ID #: " + animalID;
            ourAnimals[i, 1] = "Species: " + animalSpecies;
            ourAnimals[i, 2] = "Age: " + animalAge;
            ourAnimals[i, 3] = "Nickname: " + animalNickname;
            ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
            ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
        }

        do
        {
            Console.Clear();

            Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
            Console.WriteLine(" 1. List all of our current pet information");
            Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
            Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
            Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
            Console.WriteLine(" 5. Edit an animal’s age");
            Console.WriteLine(" 6. Edit an animal’s personality description");
            Console.WriteLine(" 7. Display all cats with a specified characteristic");
            Console.WriteLine(" 8. Display all dogs with a specified characteristic");
            Console.WriteLine();
            Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

            readResult = Console.ReadLine();
            if (readResult != null)
            {
                menuSelection = readResult.ToLower();
            }

            switch (menuSelection)
            {
                case "1":
                    // List all of our current pet information
                    for (int i = 0; i < maxPets; i++)
                    {
                        if (ourAnimals[i, 0] != "ID #: ")
                        {
                            Console.WriteLine();
                            for (int j = 0; j < 6; j++)
                            {
                                Console.WriteLine(ourAnimals[i, j].ToString());
                            }
                        }
                    }
                    Console.WriteLine("\n\rPress the Enter key to continue");
                    readResult = Console.ReadLine();
                    break;

                case "2":
                    // Add a new animal friend to the ourAnimals array
                    AddNewAnimal();
                    break;

                case "3":
                    // Ensure animal ages and physical descriptions are complete
                    EnsureCompleteAgesAndDescriptions();
                    Console.WriteLine("\n\rAge and physical description fields are complete for all of our friends. \n\rPress the Enter key to continue");
                    readResult = Console.ReadLine();
                    break;

                case "4":
                    // Ensure animal nickname and personality descriptions are complete
                    EnsureCompleteNicknamesAndPersonality();
                    Console.WriteLine("\n\rNickname and personality description fields are complete for all of our friends. \n\rPress the Enter key to continue");
                    readResult = Console.ReadLine();
                    break;

                case "5":
                    // Edit an animal’s age
                    Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
                    Console.WriteLine("Press the Enter key to continue.");
                    readResult = Console.ReadLine();
                    break;

                case "6":
                    // Edit an animal’s personality description
                    Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
                    Console.WriteLine("Press the Enter key to continue.");
                    readResult = Console.ReadLine();
                    break;

                case "7":
                    // Display all cats with a specified characteristic
                    Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
                    Console.WriteLine("Press the Enter key to continue.");
                    readResult = Console.ReadLine();
                    break;

                case "8":
                    // Display all dogs with a specified characteristic
                    Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
                    Console.WriteLine("Press the Enter key to continue.");
                    readResult = Console.ReadLine();
                    break;

                default:
                    break;
            }

        } while (menuSelection.ToLower() != "exit");
    }

    private static void AddNewAnimal()
    {
        // Add a new animal friend to the ourAnimals array
        anotherPet = "y";
        petCount = 0;
        for (int i = 0; i < maxPets; i++)
        {
            if (ourAnimals[i, 0] != "ID #: ")
            {
                petCount += 1;
            }
        }

        if (petCount < maxPets)
        {
            Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
        }

        while (anotherPet == "y" && petCount < maxPets)
        {
          

            // store the pet information in the ourAnimals array (zero based)
            ourAnimals[petCount, 0] = "ID #: " + animalID;
            ourAnimals[petCount, 1] = "Species: " + animalSpecies;
            ourAnimals[petCount, 2] = "Age: " + animalAge;
            ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
            ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
            ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

            // increment petCount (the array is zero-based, so we increment the counter after adding to the array)
            petCount = petCount + 1;

            // check maxPet limit
            if (petCount < maxPets)
            {
                // another pet?
                Console.WriteLine("Do you want to enter info for another pet (y/n)");
                do
                {
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        anotherPet = readResult.ToLower();
                    }

                } while (anotherPet != "y" && anotherPet != "n");
            }
            // NOTE: The value of anotherPet (either "y" or "n") is evaluated in the while statement expression - at the top of the while loop
        }

        if (petCount >= maxPets)
        {
            Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
        }
    }

    private static void EnsureCompleteAgesAndDescriptions()
    {
        for (int i = 0; i < maxPets; i++)
        {
            if (ourAnimals[i, 2] == "Age: ?" && ourAnimals[i, 0] != "ID #: ")
            {
                do
                {
                    Console.WriteLine($"Enter an age for {ourAnimals[i, 0]}");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalAge = readResult;
                        validEntry = int.TryParse(animalAge, out petAge);
                    }
                } while (validEntry == false);
                ourAnimals[i, 2] = "Age: " + animalAge.ToString();
            }

            if (ourAnimals[i, 4] == "Physical description: " && ourAnimals[i, 0] != "ID #: ")
            {
                do
                {
                    Console.WriteLine($"Enter a physical description for {ourAnimals[i, 0]} (size, color, gender, weight, housebroken)");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPhysicalDescription = readResult.ToLower();
                        if (animalPhysicalDescription == "")
                        {
                            validEntry = false;
                        }
                        else
                        {
                            validEntry = true;
                        }

                    }
                } while (validEntry == false);

                ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
            }
        }
    }

    private static void EnsureCompleteNicknamesAndPersonality()
    {
        for (int i = 0; i < maxPets; i++)
        {
            if (ourAnimals[i, 3] == "Nickname: " && ourAnimals[i, 0] != "ID #: ")
            {
                do
                {
                    Console.WriteLine($"Enter a nickname for {ourAnimals[i, 0]}");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalNickname = readResult;
                        if (animalNickname == "")
                        {
                            validEntry = false;
                        }
                        else
                        {
                            validEntry = true;
                        }

                    }

                } while (validEntry == false);

                ourAnimals[i, 3] = "Nickname: " + animalNickname;
            }

            if (ourAnimals[i, 5] == "Personality: " && ourAnimals[i, 0] != "ID #: ")
            {
                do
                {
                    //"Enter a description of the pet's personality (likes or dislikes, tricks, energy level"
                    Console.WriteLine($"Enter a personality description for {ourAnimals[i, 0]} (likes or dislikes, tricks, energy level)");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPersonalityDescription = readResult.ToLower();
                        if (animalPersonalityDescription == "")
                        {
                            validEntry = false;
                        }
                        else
                        {
                            validEntry = true;
                        }
                    }
                } while (validEntry == false);

                ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
            }
        }
    }
}
