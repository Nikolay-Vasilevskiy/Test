//Контрольная задача.
// Напишите программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна три символа
Console.WriteLine(" Введите символы массива через пробел:");
string[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray(); //заполнение исходного массива

string[] resultMass = SelectMass(array, 3); //заполнение результирующего массива,ограниченного 3 символами

Console.WriteLine(string.Join(",", resultMass)); // Вывод результирующего массива
string[] SelectMass(string[] arr, int charNumber) // Создание метода
{
    string[] result = new string[arr.Count(x => x.Length <= charNumber)];// создание и заполнение массива
    int count = 0;
    foreach (string X in arr)
    {
        if (X.Length <= charNumber)
        {


            result[count] = X;
            count++;
        }
    }
    return result;
}