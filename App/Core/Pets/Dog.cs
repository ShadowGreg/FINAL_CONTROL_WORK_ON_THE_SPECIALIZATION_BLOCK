﻿using FINAL_CONTROL_WORK_ON_THE_SPECIALIZATION_BLOCK.View;

public class Dog: Pet {
    public Dog(int id, DateTime birthDay): base(id, birthDay) { }

    public void DogSay() {
        View.Print("Я говорю РРРР, Гав! Гав! ");
    }
}