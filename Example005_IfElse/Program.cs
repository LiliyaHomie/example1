Console.WriteLine("Введите имя");
string username = Console.ReadLine();

if(username.ToLower() == "лиля")
{
    Console.WriteLine("WOW, это же Лиля");
}
else
{
    Console.Write("Hi ");
    Console.WriteLine(username);
}