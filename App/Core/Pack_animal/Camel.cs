public class Camel: PackAnimal {
    public Camel(int id, DateTime birthDay): base(id, birthDay) { }

    public override void Pack_animalSey() {
        View.Print($"Где-то в Каракумах был один верблюд," + "\n" +
                                           "Мудрый и гордый, скептик одногорбый…" + "\n" +
                                           "Ел кусты да травку, пил два раза в год," + "\n" +
                                           "Но, собой доволен, жил он без забот." + "\n");
    }
}