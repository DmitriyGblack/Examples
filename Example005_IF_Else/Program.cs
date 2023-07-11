// Проверка условий
Console.Write("Введите имя - ");
string username = Console.ReadLine ();
if (username.ToLower() == "маша")
{
                        
                        Console.WriteLine("Ура,это же Маша! Цветы Маше!");
}
else
{

                        Console.Write("Опс. Ну привет ");
                        Console.WriteLine (username);
}