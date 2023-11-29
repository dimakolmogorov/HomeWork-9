// using System;

// class Program
// {
//     static void Main()
//     {
//         // Введите значение k
//         Console.Write("Введите значение k: ");
//         int k = Convert.ToInt32(Console.ReadLine());

//         // Вызов функции для печати фразы
//         PrintMushroomPhrase(k);

//         // Ждем нажатия клавиши перед завершением программы
//         Console.ReadKey();
//     }

//     static void PrintMushroomPhrase(int k)
//     {
//         // Вычисляем остаток от деления k на 100
//         int remainder = k % 100;

//         // Определяем окончание слова "гриб" в зависимости от остатка
//         string ending;

//         if (remainder >= 11 && remainder <= 19)
//         {
//             ending = "грибов";
//         }
//         else
//         {
//             // Вычисляем остаток от деления k на 10
//             int lastDigit = k % 10;

//             // Определяем окончание в зависимости от последней цифры
//             switch (lastDigit)
//             {
//                 case 1:
//                     ending = "гриб";
//                     break;
//                 case 2:
//                 case 3:
//                 case 4:
//                     ending = "гриба";
//                     break;
//                 default:
//                     ending = "грибов";
//                     break;
//             }
//         }

//         // Выводим фразу на консоль
//         Console.WriteLine($"Мы нашли {k} {ending} в лесу");
//     }
// }


{
        {
        // Введите значение года
        Console.Write("Введите год: ");
        int year = Convert.ToInt32(Console.ReadLine());

        // Получим название года и его цвет
        string[] yearInfo = GetChineseYearInfo(year);

        // Выведем результат на консоль
        Console.WriteLine($"Год {year} - {yearInfo[0]}, {yearInfo[1]}");

        // Ждем нажатия клавиши перед завершением программы
        Console.ReadKey();
    }

    // Функция для получения информации о годе по китайскому календарю
    static string[] GetChineseYearInfo(int year)
    {
        // Массивы с названиями животных и цветов
        string[] animals = { "Крыса", "Корова", "Тигр", "Заяц", "Дракон", "Змея", "Лошадь", "Овца", "Обезьяна", "Петух", "Собака", "Свинья" };
        string[] colors = { "Зеленый", "Красный", "Желтый", "Белый", "Черный" };

        // Рассчитываем номер в 60-летнем цикле
        int cycleNumber = (year - 1984) % 60;

        // Рассчитываем номер в подцикле (12-летний)
        int subCycleNumber = cycleNumber % 12;

        // Рассчитываем номер цвета
        int colorNumber = cycleNumber / 12 % 5;

        // Формируем название года и его цвета
        string animal = animals[subCycleNumber];
        string color = colors[colorNumber];

        // Возвращаем результат в виде массива
        return new string[] { animal, color };
    }
}