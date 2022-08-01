// вид 1 (Методы ничего не принимают, 
// ничего не возвращают)
void Method1()
{
   Console.WriteLine("Автор ...");
}
Method1();

// вид 2 (не возвращают, 
// но могут принимать какие-то аргументы)

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("текст сообщения");

void Method21(string msg, int count)
{
    int i= 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("Текст", 4);

// вид 3 что-то возвращают, но ничего не принимают

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

// вид 4
// что-то принимают и что-то возвращают

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "b");
Console.WriteLine(res);

for (int i = 2; i<=10; i++)
{
    for (int j=2; j<= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i* j}");
    }
    Console.WriteLine();
}
