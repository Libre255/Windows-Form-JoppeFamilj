﻿using static System.Console;
using System.IO;

namespace JoppesDjurFamilj
{
    public class PetOwner
    {
        public int AgeOwner = 35;
        public string[] petsNames;
        public List<Animal> Pets = new List<Animal>()
        {
            new Puppy("Lopu", 10),
            new Dog("Kappa", 2),
            new Cat("Oly", 5)
        };
        public Ball Ball = new Ball();
        public Laser Laser = new Laser();

        public PetOwner()
        {
            petsNames = Pets.Select(pet => pet.Name).ToArray();
        }
        
        public void Check_Ball()
        {
            WriteLine(Ball.ToString());
            if(Ball.Quality <= 1)
            {
                WriteLine("Time to buy a new boll");
            }
        }
        public void Check_Laser()
        {
            WriteLine(Laser.ToString());
            if (Laser.Battery <= 1)
            {
                WriteLine("Time to recharge Battery");
            }
        }
        public void List_animals()
        {
            WriteLine("List of Joppes pets" + "\n");
            foreach (Animal pet in Pets)
            {
                WriteLine(pet.ToString());
            }
        }
		public void Fetch()
        {
            Menu playWithPetMenu = new Menu("Which pet would you like to play with?", petsNames);
            int selectedPetIndex = playWithPetMenu.Run();
            if(Pets[selectedPetIndex].ID == 0)
            {
                Pets[selectedPetIndex].Interact(Ball);
            }else if(Pets[selectedPetIndex].ID == 1)
            {
                Pets[selectedPetIndex].Interact(Laser);
            }
            
        }
        public void Feed()
        {
            Menu feedPetMenu = new Menu("Select pet to feed", petsNames);
            int selectedPetIndex = feedPetMenu.Run();
            string userInput;
            do
            {
                Clear();
                WriteLine("Please write the favorite animal food name");

                userInput = ReadLine();
                
            } while (userInput == "" || userInput.Any(c => !char.IsLetter(c)) );
            Pets[selectedPetIndex].eat(userInput);
        }
        public void menu()
        {
            string[] Options = {    
            "Play fetch", "Feed Animal", "List Animals", "Check ball status", 
            "Check laser status", "Print out all Joppes pets" 
            };
            Menu mainMenu = new Menu("What would you like to do?", Options);
            int SelectedOption = mainMenu.Run();

            switch (SelectedOption)
            {
                case 0:Fetch();
                    break;
                case 1:Feed();
                    break;
                case 2:List_animals();
                    break;
                case 3:Check_Ball();
                    break;
                case 4:Check_Laser();
                    break;
                case 5:Print_Out_Animals();
                    break;
            }
            ReturnToMenu();
        }
        private void Print_Out_Animals()
        {
            try
            {
                using (StreamWriter Printer = new StreamWriter("../../../JoppePetsInformation.txt", false))
                {
                    foreach (var pet in Pets)
                    {
                        Printer.WriteLine(pet.ToString());
                    }
                    Printer.Close();
                    WriteLine("All pets information have been printed out in your current folder!");
                }
            }catch(Exception ex)
            {
                WriteLine(ex.Message);
            }
        }
        private void ReturnToMenu()
        {
            WriteLine("Press any key to go back to the menu");
            ReadKey(true);
            menu();
        }
        
        public override string ToString()
        {
            return $"Joppe Class, age {AgeOwner} with {Pets.Count} animals";
        }
    }
}