using System;
class Test1 {
    public static void Print() {
        Animal dog = new Dog("Tommy", 3);
        Animal cat = new Cat("Hunter", 2);
        Animal bird = new Bird("Ginni", 1);
        dog.MakeSound(); 
        cat.MakeSound(); 
        bird.MakeSound(); 
    }
}
class Animal {
    public string Name ;
    public int Age ;  
    public Animal(string name, int age) {
        this.Name = name;
        this.Age = age;
    }
    // Virtual method to  override
    public virtual void MakeSound() {
        Console.WriteLine("Animal makes a sound");
    }
}

// child classs
class Dog : Animal {
    public Dog(string name, int age) : base(name, age) { 
        Console.WriteLine("Dog Constructor");
    }

    // Overriding
    public override void MakeSound() {
        Console.WriteLine("Dog barks");
    }
}

// Subclass: Cat
class Cat : Animal {
    public Cat(string name, int age) : base(name, age) { 
        Console.WriteLine("Cat Constructor");

    }

    // Overriding 
    public override void MakeSound() {
        Console.WriteLine("Cat meow meow");
    }
}

// Subclass: Bird
class Bird : Animal {
    public Bird(string name, int age) : base(name, age) {

        Console.WriteLine("Bird Constructor");
     }
    public override void MakeSound() {
        Console.WriteLine("Bird chirps");
    }
}
