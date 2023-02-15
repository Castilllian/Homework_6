// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// k1 = 2, b1 = 5, k2 = 4, b2 = 9 -> (-0,5; -0,5)

float[] CalculateInterSection(float[] arr)
{
    if(arr[0] == arr[2])
    {
        Console.WriteLine("Прямые совпадают");
        return null;
    }
    
    float x = (arr[3]-arr[1])/(arr[0]-arr[2]);
    float y = arr[0]*x + arr[1];
    float[] answerArray= {x, y};
    return answerArray;
}

float[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    float[] res = new float[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = float.Parse(nums[i]);
    }
    return res;
}

string Promt(string message)
{
    Console.Write(message);
    string input = Console.ReadLine();
    return input;
}
Console.Clear();
string userInput = Promt("Введите значения координат k1, b1, k2, b2 через пробел: ");
float [] inputArray = GetArrayFromString(userInput);
float[] answer = CalculateInterSection(inputArray);
Console.WriteLine($"Пересечение линий происходит в координатах: x = {answer[0]}, y = {answer[1]}");
