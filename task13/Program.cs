// Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number > 99)
{
while (number > 999)
   {  
       number = number/10;  
   }
  Console.WriteLine(number%10);
}
else
{
    Console.WriteLine("В этом числе нет третьей цыфры");
} 
 