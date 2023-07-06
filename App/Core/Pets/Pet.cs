using FINAL_CONTROL_WORK_ON_THE_SPECIALIZATION_BLOCK.View;

public abstract class Pet: Animal {
    protected Pet(int id, DateTime birthDay): base(id, birthDay) { }

   public void InHouse() {
        View.Print("Я в домике!");
    }

   public void OutsideHouse() {
       View.Print("Я гуляю по улице!");
   }
}