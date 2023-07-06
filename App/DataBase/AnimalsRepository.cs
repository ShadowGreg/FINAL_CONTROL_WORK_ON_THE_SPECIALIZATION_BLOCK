using System.Data;

namespace FINAL_CONTROL_WORK_ON_THE_SPECIALIZATION_BLOCK.DataBase {
    public class AnimalsRepository: IRepository {
        private string _url;
        private Counter _count;
        private List<List<string>> _data;

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
                inAnimal.PetCommands.Commands.Aggregate(string.Empty, (current, command) => current + (command + " "));
            temp.Add($"ID{tempNum}");
            temp.Add(className);
            temp.Add(tempNum.ToString());
            temp.Add(inAnimal.DateOfBirth.ToString("yyyy-MM-dd"));
            temp.Add(inAnimal.Name);
            temp.Add(commands);
        }

        public int GetLastId() {
            int maxId = 0;

            foreach (List<string> animals in _data) {
                foreach (string fields in animals) {
                    int temp;
                    if (fields != null && fields.Contains("ID")) {
                        temp = int.Parse(fields.Replace("ID", string.Empty));
                        if (temp > maxId) {
                            maxId = temp;
                        }
                    }
                }
            }

            return maxId;
        }

        public List<string> GetAnimalsNumList() {
            List<string> list = new List<string>();
            foreach (List<string> animals in _data) {
                foreach (string fields in animals) {
                    
                    if (fields != null && fields.Contains("ID")) {
                        list.Add(fields.Replace("ID", string.Empty));
                    }
                }
            }

            return list;
        }

        public List<Animal> GetAnimalList() {
            List<Animal> result = new List<Animal>();
            foreach (List<string> animal in _data) {
                Animal tempAnimal;
                switch (animal[1]) {
                    case "cat":
                        tempAnimal = new Cat(
                            int.Parse(animal[0].Replace("ID", string.Empty)),
                            DateTime.Parse(animal[3]));
                        FillFields(tempAnimal, animal);

                        result.Add(tempAnimal);
                        break;
                    
                    case "dog":
                        tempAnimal = new Dog(
                            int.Parse(animal[0].Replace("ID", string.Empty)),
                            DateTime.Parse(animal[3]));
                        FillFields(tempAnimal, animal);

                        result.Add(tempAnimal);
                        break;
                                        
                    case "hamster":
                        tempAnimal = new Hamster(
                            int.Parse(animal[0].Replace("ID", string.Empty)),
                            DateTime.Parse(animal[3]));
                        FillFields(tempAnimal, animal);

                        result.Add(tempAnimal);
                        break;
                    
                    case "camel":
                        tempAnimal = new Camel(
                            int.Parse(animal[0].Replace("ID", string.Empty)),
                            DateTime.Parse(animal[3]));
                        FillFields(tempAnimal, animal);

                        result.Add(tempAnimal);
                        break;
                                        
                    case "donkey":
                        tempAnimal = new Donkey(
                            int.Parse(animal[0].Replace("ID", string.Empty)),
                            DateTime.Parse(animal[3]));
                        FillFields(tempAnimal, animal);

                        result.Add(tempAnimal);
                        break;
                    
                                                            
                    case "horse":
                        tempAnimal = new Horse(
                            int.Parse(animal[0].Replace("ID", string.Empty)),
                            DateTime.Parse(animal[3]));
                        FillFields(tempAnimal, animal);

                        result.Add(tempAnimal);
                        break;
                }
            }
            return result;
        }

        private static void FillFields(Animal tempAnimal, List<string> animal) {
            tempAnimal.Number = int.Parse(animal[2]);
            tempAnimal.Name = animal[4];
            PetCommands petCommands = new PetCommands();
            foreach (string command in animal[5].Split(" ")) {
                petCommands.AddCommand(command);
            }

            tempAnimal.PetCommands = petCommands;
        }
    }
}