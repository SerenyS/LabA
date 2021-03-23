using System;

namespace LabA {
    
    public class Type{
    
    public string name {get;set;}
    
        public virtual void statement(){
            Console.WriteLine("Type not available");
        }
    }

    class Dog: Type {

        public override void statement(){
            Console.WriteLine("Dog created");
        }
    }

    class Cat: Type {
        public override void statement()
        {
            Console.WriteLine("Cat created");
        }
    }

class Person: Type {
        public override void statement()
        {
            Console.WriteLine("Person created");
        }
    }

}