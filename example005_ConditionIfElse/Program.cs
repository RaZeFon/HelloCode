Console.Write("Введите своё имя: ");
string username = Console.ReadLine();
if(username.ToLower() == "masha")
{
    Console.WriteLine("Ура это Masha");
}
else
{
    Console.Write("Привет ");
    Console.WriteLine(username);
}

