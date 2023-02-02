// See https://aka.ms/new-console-template for more information
using System.Text;
using TestTaskHotels;
string[] cities = { "Москва", "Санкт-петербург", "Воронеж"};
Task1 task1 = new Task1(cities);
Console.WriteLine(task1.GetFormattedString()); //10 min
double num = 27.6;
Task2 task2 = new Task2(num);
Console.WriteLine(task2.GetRoundedNumber());//7 min
int amount = 100;
Task3 task3 = new Task3(amount);
Console.WriteLine(task3.GetFormattedString());//7 min
int primeTest = 101;
Task4 task4 = new Task4(primeTest);
Console.WriteLine(task4.IsPrime()); //7min
int[] arr1 = { 7, 17, 1, 9, 1, 17, 56, 56, 23, 9, 9 };
int[] arr2 = { 56, 17, 17, 1, 23, 34, 23, 1, 8, 1, 9, 9 };
Task5 task5 = new Task5(arr1, arr2);
int[] task5answ = task5.GetCrossedArray();
StringBuilder stringBuilder = new StringBuilder();
stringBuilder.Append("[ ");
foreach (int i in task5answ){
    stringBuilder.Append(i.ToString()).Append(" ");
}
stringBuilder.Append("]");
Console.WriteLine(stringBuilder.ToString());//25 min
int limit = 10;
Task6 task6 = new Task6(limit);
Console.WriteLine(task6.GetMultiplicationSquare());//20-35 min
