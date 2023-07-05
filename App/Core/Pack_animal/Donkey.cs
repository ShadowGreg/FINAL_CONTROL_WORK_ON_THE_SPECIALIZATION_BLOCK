public class Donkey: PackAnimal {
    public Donkey(int id, DateTime birthDay): base(id, birthDay) { }

    public override void Pack_animalSey() {
        View.Print($"Я – маленький ослик {Name}, и мне живётскя не сладко");
    }
}