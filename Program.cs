using System;
using System.Collections.Generic;

namespace LabA
{
    class Program
    {
        static void Main(string[] args)
        {
            mainMenu();

        static void mainMenu(){
            
            var list= new List<Type>();

            Console.WriteLine("Select animal type:");
            Console.WriteLine("1.CAT");
            Console.WriteLine("2.DOG");
            Console.WriteLine("3.PERSON");
            Console.WriteLine("0.EXIT");
             var TypeChosen = Console.ReadLine();
             
             if (TypeChosen.Equals("1")){
                 Cat nuevoCat= new Cat();
                 nuevoCat.statement();

                 Console.Write("What's the cat name?");
                 var CatName = Console.ReadLine();

                 nuevoCat.name = CatName;

                 Console.WriteLine(nuevoCat.name +" the cat has been created and added to the list");
                 list.Add(nuevoCat); 
                 mainMenu();
  
             }   else if (TypeChosen.Equals("2")){

                  Dog nuevoDog= new Dog();
                 nuevoDog.statement();

                 Console.Write("What's the dog's name?");
                 var DogName= Console.ReadLine();

                 nuevoDog.name = DogName;

                 Console.WriteLine(nuevoDog.name +" the dog has been created and added to the list");
                 list.Add(nuevoDog);
                 mainMenu();

             } else if (TypeChosen.Equals("3")){ 
                 
                  Person nuevoPerson= new Person();
                 nuevoPerson.statement();

                 Console.Write("What's the Persons name?");
                 var PersonName= Console.ReadLine();

                 nuevoPerson.name = PersonName;

                 Console.WriteLine(nuevoPerson.name +" the person has been created and added to the list");
                 list.Add(nuevoPerson);
                 mainMenu();


             } else if (TypeChosen.Equals("0")){

             } else {
                 Console.WriteLine ("Not a valid response try again");
                 mainMenu();

             }
        }

             }

        }
    }

