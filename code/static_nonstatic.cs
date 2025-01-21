using System;

class Example {
    void nonStaticMethod() {
        Console.WriteLine("nonStaticMethod called");
    }

    static void staticMethod() {
        Example example = new Example();
        example.nonStaticMethod(); // Instance required
    }

    static void Main(string[] args) {
        Console.WriteLine("In a namespace!");
        staticMethod(); // Call staticMethod to demonstrate functionality
    }
}
