using FINAL_CONTROL_WORK_ON_THE_SPECIALIZATION_BLOCK.DataBase;

namespace AppTests;

public class AnimalsRepositoryTests {
    [Test]
    public void GetLastId_Test() {
        // Arrange
        var repo = AnimalsRepository.GetConnection("");

        // Act
        int actual = repo.GetLastId();

        // Assert
        Assert.NotNull(actual);
    }

    [Test]
    public void AddAnimal_Test() {
        // Arrange
        var repo = AnimalsRepository.GetConnection("");
        Cat cat = new Cat(1, DateTime.Parse("2022-12-03"));
        int expected = 7;

        // Act
        repo.AddAnimal(cat);
        int actual = repo.GetLastId();

        // Assert
        Assert.AreEqual(expected, actual);
    }
}