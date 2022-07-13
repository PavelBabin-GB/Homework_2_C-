// Программa, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
Console.WriteLine("Введите номе от 1 до 7");
int nomber = int.Parse(Console.ReadLine());

if (nomber > 7 ) 
{
    Console.WriteLine("ЭТА ЦЫФРА НЕ ПРИНАДЛЕЖИТ НИ ОДНОМУ ДНЮ НЕДЕЛИ");
}    
else
{
    if (nomber == 1) Console.WriteLine("Будни");
    if (nomber == 2) Console.WriteLine("Будни");
    if (nomber == 3) Console.WriteLine("Будни");
    if (nomber == 4) Console.WriteLine("Будни");
    if (nomber == 5) Console.WriteLine("Будни");
    if (nomber == 6) Console.WriteLine("Выходной");
    if (nomber == 7) Console.WriteLine("Выходной");
}
