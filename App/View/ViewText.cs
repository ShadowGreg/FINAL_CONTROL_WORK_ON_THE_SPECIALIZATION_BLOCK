namespace FINAL_CONTROL_WORK_ON_THE_SPECIALIZATION_BLOCK.View;

public static class ViewText {
    private const string MinMenu = "Цифра 0 - Главное меню\n";
    private const string EXIT = "EXIT - Для выхода наберите\n";
    private const string NumFirst = "Цифра 1";
    private const string NumSecond = "Цифра 2";
    private const string NumThird = "Цифра 3";
    private const string NumFourth = "Цифра 4";
    private const string NumFifth = "Цифра 5";
    private const string NumSixth = "Цифра 6";
    private const string NumSeventh = "Цифра 7";


    public const string MainMenuText = MinMenu + EXIT +
                                       NumFirst + " - Добавить новое животное\n" +
                                       NumSecond + " - Посмотреть всех животных\n" +
                                       NumThird + " - Выбрать животное по номеру\n";


    public const string CreateAnimalMenuText = MinMenu +
                                               " - Выбрать класс животного\n" +
                                               " - Посомтреть список команд животного\n" +
                                               " - Обучить новым командам\n" +
                                               " - Попросить животное сказать свою коронную фразу\n";

    public const string AnimalMenuText = MinMenu +
                                         "Цифра 1 - Посомтреть список команд животного\n" +
                                         "Цифра 2 - Обучить новым командам\n" +
                                         "Цифра 3 - Попросить животное сказать свою коронную фразу\n";

    public const string AnimalCommandsMenuText = MinMenu +
                                                 "Цифра 1 - GO\n" +
                                                 "Цифра 2 - STOP\n" +
                                                 "Цифра 3 - COME_UP\n" +
                                                 "Цифра 4 - LIE\n" +
                                                 "Цифра 5 - JUMP\n" +
                                                 "Цифра 6 - TRUP\n" +
                                                 "Цифра 7 - STAND__UP\n";
}