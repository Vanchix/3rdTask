char t;
do { 
var input1 = Convert.ToInt32(Console.ReadLine());
var input2 = Convert.ToInt32(Console.ReadLine());
var mass = new int[input1][];
var mass2 = new int[input1][];
var number1 = 0;
var number2 = 0;
for (int i = 0; i < input1; i++)
{
    mass[i] = new int[input2];
    for (int j = 0; j < input2; j++)
    {
        mass[i][j] = Convert.ToInt32(Console.ReadLine());
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
foreach (var i in mass)
{
    foreach (var j in i)
    {
        Console.Write($"{j}    ");
    }
    Console.WriteLine();
};
    do { 
        var choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case (1):
                Console.WriteLine($"{number1} {number2}");
                break;
            case (2):
                for (int i = 0; i < input1; i++)
                {
                    Array.Sort(mass[i]);
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
                for (int i = 0, k = input1 - 1; i < input1; i++, k--)
                {
                    for (int j = 0, m = input2 - 1; j < input2; j++, m--)
                    {
                        mass2[i][j] = mass[k][m];
                        Console.Write(" " + mass2[i][j] + " ");
                    }
                }

                /*for (int i = input1-1; i <= 0; i--)
                {
                        mass = mass[i];
                }*/
                break;

                /*default:
                Console.WriteLine();
                break;*/
        }
        foreach (var i in mass)
        {
            foreach (var j in i)
            {
                Console.Write($"{j}    ");
            }
            Console.WriteLine();
        };
        Console.WriteLine("Нажмите f чтобы выйти из массива");
        t = Convert.ToChar(Console.ReadLine());
        } while (t != 'f');
        Console.WriteLine("Нажмите f чтобы выйти из программы");
    t = Convert.ToChar(Console.ReadLine());
} while (t != 'f') ;