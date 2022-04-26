Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "анжелика")
{
    Console.WriteLine("Ура, это же Анжелика!");
}    
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}