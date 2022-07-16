// Программa, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
Console.WriteLine("Введите номе от 1 до 7");
int number = int.Parse(Console.ReadLine());
if (number >= 1 & number <= 5)
{
Console.WriteLine("Это будний день");
} else if (number >= 6 & number <= 7)
{
Console.WriteLine("Это выходной день");
}
else
{
Console.WriteLine("Это вообще не день недели");
}
