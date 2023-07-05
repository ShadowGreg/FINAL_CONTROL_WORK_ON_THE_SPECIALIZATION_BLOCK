using System.Data;
using App.DataBase;
namespace FINAL_CONTROL_WORK_ON_THE_SPECIALIZATION_BLOCK.DataBase {
    public class AnimalsRepository: IRepository {
        private string _url;
        private readonly Counter _count;
        private readonly List<List<string>> _data;

        private AnimalsRepository(string url) {
            _url = url;
            _data = DataBase.GetSomeData();
            _count = new Counter();
            _count.SetStartNum(GetLastId());
        }


        public static AnimalsRepository GetConnection(string url) {
            return new AnimalsRepository(url);
        }


        public void AddAnimal(Animal inAnimal) {
            List<string> temp = new();
            if (inAnimal.GetType() == typeof(Cat)) NewMethod(inAnimal, temp, "cat");
            else if (inAnimal.GetType() == typeof(Dog)) NewMethod(inAnimal, temp, "dog");
            else if (inAnimal.GetType() == typeof(Hamster)) NewMethod(inAnimal, temp, "hamster");
            else if (inAnimal.GetType() == typeof(Camel)) NewMethod(inAnimal, temp, "camel");
            else if (inAnimal.GetType() == typeof(Donkey)) NewMethod(inAnimal, temp, "donkey");
            else if (inAnimal.GetType() == typeof(Horse)) NewMethod(inAnimal, temp, "horse");
            _data.Add(temp);
        }

        private void NewMethod(Animal inAnimal, List<string> temp, string className) {
            int tempNum = _count.GetNumber();
            string commands =
                inAnimal.Commands.Commands.Aggregate(string.Empty, (current, command) => current + (command + " "));
            temp.Add($"ID{tempNum}");
            temp.Add(className);
            temp.Add(tempNum.ToString());
            temp.Add(inAnimal.DateOfBirth.ToString("yyyy-MM-dd"));
            temp.Add(inAnimal.Name);
            temp.Add(commands);
        }

        public int GetLastId() {
            int maxId = 0;

            if (_data != null) {
                foreach (List<string> animals in _data) {
                    foreach (string fields in animals) {
                        int temp;
                        if (fields.Contains("ID")) {
                            temp = int.Parse(fields.Replace("ID", string.Empty));
                            if (temp > maxId) {
                                maxId = temp;
                            }
                        }
                    }
                }

                return maxId;
            }
            else {
                throw new DataException("Отсуствует соединение с базой данных");
            }
        }

        public List<Animal> GetAnimalList() {
            throw new NotImplementedException();
        }
    }
}