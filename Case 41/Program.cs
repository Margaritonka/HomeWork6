// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 5
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// вариация задачи 41 - пользователь не задает сколько чисел он введет (то есть число M), а подсчет количества 
// чисел производится после того, как пользователь не ввел информацию и нажал Enter.

Console.WriteLine("Введите целые числа кроме 0, для окончания ввода введите 0 ");


int [] final = FillArray(1000000000);

int []  FillArray(int N)
{
int [] array = new int[N];
int count = 0;
for (int i = 0; i < array.Length; i++) 
{
    array[i] = Convert.ToInt32(Console.ReadLine());
    count+=1;
    if (array[i] == 0)
    {
        break;
    }
}

int [] final = new int[count-1];

for (int i = 0; i < final.Length; i++) 
{
    final[i] = array[i];
}

return final;
}



void PrintArray(int [] final)
{
    for (int i = 0; i < final.Length; i++)
    {
        if (i!=final.Length-1) Console.Write($"{final[i]}, ");
        else Console.Write($"{final[i]}");
    }
}

PrintArray(final);
Console.WriteLine();

int sum = 0;
for (int i = 0; i < final.Length; i++)
    if (final[i] > 0)
{
    sum+=1;
}
Console.WriteLine($"Сумма введённых цифр больше нуля -  {sum}");