
public abstract class PackAnimal: Animal {
    protected PackAnimal(int id, DateTime birthDay): base(id, birthDay) { }



    public override void AddCommand(Commands command) {
        throw new Exception("Я не знаю ни одной команды, в этой программе и не обучаемый");
    }
}