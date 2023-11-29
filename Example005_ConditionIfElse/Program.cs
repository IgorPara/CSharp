Console.Write ("Напишите своё имя и нажмите клавишу Ввод(Enter): ");
string username = Console.ReadLine();
if (username.ToLower() == "маша")
{
    Console.WriteLine ("Ура, это же МАША!");
}
else
{
    Console.Write ("Привет, ");
    Console.WriteLine (username);
}

