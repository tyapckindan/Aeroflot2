class Program
{
    static void Main(string[] args)
    {
        List<Aeroflot> planes = new List<Aeroflot>();
        planes.Add(new Aeroflot("Лондон", "Понедельник", "Boening-1", "1070", 17));
        planes.Add(new Aeroflot("Москва", "Вторник", "Boening-2", "1071", 12));
        Console.Write("Введите день недели: ");
        string request = Console.ReadLine();
        string response = "";
        foreach (Aeroflot plane in planes)
        {
            if (plane.getDay == request)
            {
                response = plane.GetInfo();
                break;
            }
        }
        if (response != "")
            Console.WriteLine(response);
        else Console.WriteLine("Рейсы на данный день недели отсутствуют.");
        response = "";

        Console.Write("Введите пункт назначения: ");
        request = Console.ReadLine();
        foreach (Aeroflot plane in planes)
        {
            if (plane.getPoint == request)
            {
                response = plane.GetInfo();
                break;
            }
        }
        if (response != "")
            Console.WriteLine(response);
        else Console.WriteLine("Рейсы на данный пункт назначения отсутствуют.");
        response = "";

        Console.Write("Введите день недели: ");
        request = Console.ReadLine();
        Console.Write("Введите время вылета: ");
        int time = int.Parse(Console.ReadLine());
        foreach (Aeroflot plane in planes)
        {
            if (plane.getDay == request && plane.time > time)
            {
                response = plane.GetInfo();
                break;
            }
        }
        if (response != "")
            Console.WriteLine(response);
        else Console.WriteLine("Рейсы на данный день недели, время вылета которых больше заданного отсутствуют.");
    }
}