# Lab06-ZooApp

this is a simple Zoo application made using C#.
the purpose of this app is to practice OOP principles (Abstraction, Encapsulation, Inheritance, Polymorphism)
this app has 5 types of animals:

- Mammals
- Birds
- Fish
- Reptile
- Amphibian


## UML diagram
![UML](UML.png)

## Object Oriented Principles:

- Polymorphism:
Polymorphism is when the same method has different outputs depending on which object calls it.
example in this project:
animals methods like eat, sleep, and sound, will be executed differently based on the object.
-  Encapsulation:
Encapsulation is the process of restricting access to a component from other classes.
- Abstraction:
Abstraction is basically hiding complexity, it hides the irrelevant data about a method in an object, this will increase efficiency.
- Inheritance:
Inheritance is very useful, it allows classes to inherit properties and behaviors from other classes, it will reduce code size and make it more organized.
example used in this project:
there are 5 types of animals like fish, mammals, ...etc, and each type has some example animals that inherit all the common methods from the Animal class, and the specific methods from the animal type.
