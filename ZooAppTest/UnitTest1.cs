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



    }
}