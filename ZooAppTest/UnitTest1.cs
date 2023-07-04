using Animals;

namespace ZooAppTest
{
    public class UnitTest1
    {
        [Fact]
        public void Dog_MethodsTest()
        {
            // Arrange
            Dog dog = new Dog();

            // Act
            string eatResult = dog.Eat();
            string sleepResult = dog.Sleep();

            // Assert
            Assert.Equal("Dog Eats food", eatResult);
            Assert.Equal("Dog is Sleeping", sleepResult);
        }

        [Fact]
        public void Parrot_MethodsTest()
        {
            // Arrange
            Parrot parrot = new Parrot();

            // Act
            string eatResult = parrot.Eat();
            string sleepResult = parrot.Sleep();

            // Assert
            Assert.Equal("Parrot is eating", eatResult);
            Assert.Equal("Parrot is sleeping", sleepResult);
        }
        [Fact]
        public void Fish_MethodsTest()
        {
            // Arrange
            Shark shark = new Shark();

            // Act
            string eatResult = shark.Eat();
            string sleepResult = shark.Sleep();

            // Assert
            Assert.Equal("shark is eating", eatResult);
            Assert.Equal("shark is sleeping", sleepResult);
        }
        [Fact]
        public void Snake_MethodsTest()
        {
            // Arrange
            Snake snake = new Snake();

            // Act
            string eatResult = snake.Eat();
            string sleepResult = snake.Sleep();

            // Assert
            Assert.Equal("snake is eating", eatResult);
            Assert.Equal("snake is sleeping", sleepResult);
        }

        //// interfaces tests:
        ///

        [Fact]
        public void Check_Classes_Implement_Interfaces()
        {
            // Arrange
            Dog dog = new Dog();
            Amphibian amphibian = new Amphibian();
            Parrot parrot = new Parrot();

            // Act
            bool dogImplementsSwimming = dog is ISwim;
            bool amphibianImplementsSwimming = amphibian is ISwim;
            bool parrotIplementsFlying = parrot is IFly;

            // Assert
            Assert.True(dogImplementsSwimming);
            Assert.True(amphibianImplementsSwimming);
            Assert.True(parrotIplementsFlying);
        }

        // this test will check if animal actually inherits from Animal class
        [Fact]
        public void Check_Animals_InheritFrom_Animal_Class()
        {
            Dog dog = new Dog();
            Parrot parrot = new Parrot();
            Snake snake = new Snake();
            Amphibian amphibian = new Amphibian();

            bool dogInheritsFromAnimal = dog is Animal;
            bool parrotInheritsFromAnimal = parrot is Animal;
            bool snakeInheritsFromAnimal = snake is Animal;
            bool amphibianInheritsFromAnimal = amphibian is Animal;

            Assert.True(dogInheritsFromAnimal);
            Assert.True(parrotInheritsFromAnimal);
            Assert.True(snakeInheritsFromAnimal);
            Assert.True(amphibianInheritsFromAnimal);
        }

        // to test overridden methods:
        [Fact]
        public void Check_Overridden_Methods_If_Called()
        {
            Dog dog = new Dog();
            Parrot parrot = new Parrot();

            string dogSleepResult = dog.Sleep();
            string parrotEatResult = parrot.Eat();

            Assert.Equal("Dog is Sleeping", dogSleepResult);
            Assert.Equal("Parrot is eating", parrotEatResult);
        }
        // to test polymorphism:
        [Fact]
        public void Check_Polymorphism_For_Interfaces()
        {
            ISwim dogSwimmer = new Dog();
            ISwim amphibianSwimmer = new Amphibian();

            string dogSwimResult = dogSwimmer.Swimming();
            string amphibianSwimResult = amphibianSwimmer.Swimming();

            Assert.Equal("The dog is swimming.", dogSwimResult);
            Assert.Equal("Amphibian is swimming", amphibianSwimResult);
        }

        // to prove that parrot is an animal:
        [Fact]
        public void Dog_Must_Be_An_Animal()
        {
            Parrot parrot = new Parrot();

            bool isAnimal = parrot is Animal;


            Assert.True(isAnimal);
        }
    }
}