namespace FINAL_CONTROL_WORK_ON_THE_SPECIALIZATION_BLOCK.View;

public static class ViewText {
    private const string MinMenu = "Цифра 0 - Главное меню\n";

    public const string MainMenuText = MinMenu + "EXIT - Для выхода наберите\n" +
                                       "Цифра 1 - Добавить новое животное\n" +
                                       "Цифра 2 - Посмотреть всех животных\n" +
                                       "Цифра 3 - Выбрать животное\n";


    public const string CreateAnimalMenuText = MinMenu +
                                               "Цифра 1 - Выбрать класс животного\n" +
                                               "Цифра 2 - Посомтреть список команд животного\n" +
                                               "Цифра 3 - Обучить новым командам\n" +
                                               "Цифра 4 - Попросить животное сказать свою коронную фразу\n";

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