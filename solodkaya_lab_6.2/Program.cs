try
{
    Console.Write("Введите количество инжунеров:");
    int n = int.Parse(Console.ReadLine());
    Ingener[] ingeners = new Ingener[n];
    for (int i = 0; i < n; i++)
    {
        ingeners[i] = new Ingener();
        Console.WriteLine("Введите фамилию: ");
        ingeners[i].Lastname = Console.ReadLine();
        Console.WriteLine("Введите имя: ");
        ingeners[i].Name = Console.ReadLine();
        Console.WriteLine("Введите отчество: ");
        ingeners[i].MiddleName= Console.ReadLine();
        Console.WriteLine("Введите пол: ");
        ingeners[i].Gender= Console.ReadLine();

        Console.Write("Введите год рождения:");
        int year = int.Parse(Console.ReadLine());
        Console.Write("Введите месяц рождения:");
        int month = int.Parse(Console.ReadLine());
        Console.Write("Введите день рождения:");
        int day = int.Parse(Console.ReadLine());
        ingeners[i].Birthdate = new DateTime(year, month, day);
    }
    foreach (Ingener ingener in ingeners)
    {
        int nowYear = DateTime.Now.Year;
        int toYear = ingener.Birthdate.Year;
        if (nowYear-toYear>60)
        {
            Console.WriteLine(ingener.Lastname);
            Console.WriteLine(ingener.Name);
            Console.WriteLine(ingener.MiddleName);
            Console.WriteLine(ingener.Gender);
            Console.WriteLine(ingener.Birthdate);
        }
    }
 
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}      


struct Ingener
{
    public string Lastname;
    public string Name;
    public string MiddleName;
    public string Gender;
    public DateTime Birthdate;
}
