
namespace App.DataBase; 

public interface IRepository {
   void AddAnimal(Animal inAnimal);
   int GetLastId();
   List<Animal> GetAnimalList();
}