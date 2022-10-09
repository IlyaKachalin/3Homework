// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
Console.Clear();

Console.Write("Введите пятизначное число  ");
string text = Convert.ToString (Console.ReadLine());

int length = text.Length;

    if (length==5)
    {
        if (text[0]==text[4] && text[1]==text[3])
        Console.WriteLine ("Палиндром");
        else Console.WriteLine ("Не является палиндромом");
    }

else Console.WriteLine ("Введите пятизначное число");

    


    


