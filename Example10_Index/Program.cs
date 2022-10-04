int [] array = {10,52,73,43,15,52};
int n = array.Length;

int index = 0;
Console.WriteLine("Ввведите любое целое число");

int find = Convert.ToInt32(Console.ReadLine());

while  (index<n)

    {   if (array[index] == find)
        {Console.WriteLine("Индекс введенного числа = " + index);
        break;}

        index++;
    }

if (index == n)
Console.WriteLine("Не повезло - введенного числа нет в данном массиве, а значит и индекса тоже нет");

   
