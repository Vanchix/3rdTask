char t;
do {
Console.WriteLine("Введите количество строк массива");
var input1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
var input2 = Convert.ToInt32(Console.ReadLine());
var mass = new int[input1][];
var number1 = 0;
var number2 = 0;
Console.WriteLine("Введите элементы массива");
for (int i = 0; i < input1; i++)
{
    mass[i] = new int[input2];
    for (int j = 0; j < input2; j++)
    {
        mass[i][j] = Convert.ToInt32(Console.ReadLine());
    }
}
foreach (var i in mass)
{
    foreach (var j in i)
    {
        Console.Write($"{j}    ");
    }
    Console.WriteLine();
};
    do {
        Console.WriteLine("Выберите действие которое необходимо сделать \n" +
            "1) Вывести количество положительных и отрицательных элементов массива \n" +
            "2) Отсортировать каждую строку массива от меньшего элемента к большему \n" +
            "3) Отсортировать каждую строку массива от большего элемента к меньщему \n" +
            "4) Выполнить инверсию массива, то есть поменять первую и последнюю строку, вторую и предпоследнюю и т.д.");
        var choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case (1):
                for (int i = 0; i < input1; i++)
                {
                    for (int j = 0; j < input2; j++)
                    {
                        if (mass[i][j] > 0)
                        {
                            number1++;
                        }
                        else
                        {
                            number2++;
                        }
                    }

                }
                Console.WriteLine($"Количество положительных чисел {number1}");
                Console.WriteLine($"Количество отрицательных чисел {number2}");
                break;
            case (2):
                var k = 0;
                for (int i = 0; i < input1; i++)
                {
                    for(int j = 0; j < input2; j++)
                    {
                        for(int sort = 0; sort < input2 - 1; sort++)
                        if (mass[i][sort] > mass[i][sort + 1])
                        {
                            k = mass[i][sort + 1];
                            mass[i][j + 1] = mass[i][sort];
                            mass[i][sort] = k;
                        }
                    }
                }
                break;
            case (3):
                for (int i = 0; i < input1; i++)
                {
                    Array.Sort(mass[i]);
                    Array.Reverse(mass[i]);
                }
                break;
            case (4):
                Console.WriteLine("Измененный массив выглядит так");
                for (int i = input1 - 1; i >= 0; i--)
                {
                    var n = mass[i];
                    for(int j = 0; j < input2; j++)
                    {
                        Console.Write($"{n[j]}    ");
                    }
                    Console.WriteLine();
                }
                break;
        }
        if(choice != 4 && choice != 1)
        {
            Console.WriteLine("Измененный массив выглядит так");
            foreach (var i in mass)
            {
                foreach (var j in i)
                {
                    Console.Write($"{j}    ");
                }
                Console.WriteLine();
            };
        }
        Console.WriteLine("Нажмите f чтобы выйти из массива, иначе нажмите любую другую клавишу и вернитесь к выбору действия");
        t = Convert.ToChar(Console.ReadLine());
        } while (t != 'f');
        Console.WriteLine("Нажмите f чтобы выйти из программы, иначе нажмите любую другую клавишу и вернитесь к вводу массива");
    t = Convert.ToChar(Console.ReadLine());
} while (t != 'f') ;