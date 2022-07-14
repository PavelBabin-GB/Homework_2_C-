// Программa, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
Console.WriteLine("Введите номе от 1 до 7");
int number = int.Parse(Console.ReadLine());

if (number > 7 ) 
{
    Console.WriteLine("ЭТА ЦЫФРА НЕ ПРИНАДЛЕЖИТ НИ ОДНОМУ ДНЮ НЕДЕЛИ");
}    
else
{
    if (number == 1) Console.WriteLine("Будни");
    if (number == 2) Console.WriteLine("Будни");
    if (number == 3) Console.WriteLine("Будни");
    if (number == 4) Console.WriteLine("Будни");
    if (number == 5) Console.WriteLine("Будни");
    if (number == 6) Console.WriteLine("Выходной");
    if (number == 7) Console.WriteLine("Выходной");
}
