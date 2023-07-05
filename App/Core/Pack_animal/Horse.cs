public class Horse: PackAnimal {
    public Horse(int id, DateTime birthDay): base(id, birthDay) { }
    public override void Pack_animalSey() {
        View.Print($"Я – маленькая лошадка {Name}, но стою очень много денег");
    }
}