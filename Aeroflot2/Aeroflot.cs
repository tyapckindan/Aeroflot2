class Aeroflot
{
    string point, day, type, number;
    public int time;
    public string getDay
    {
        get
        {
            return day;
        }
    }

    public string getPoint
    {
        get
        {
            return point;
        }
    }

    // Конструктор
    public Aeroflot(string point, string day, string type, string number, int time)
    {
        this.point = point;
        this.day = day;
        this.type = type;
        this.number = number;
        this.time = time;
    }

    // конструктор
    Aeroflot(string point, string day, string type)
    {
        this.point = point;
        this.day = day;
        this.type = type;
    }

    // конструктор

    Aeroflot(string number)
    {
        this.number = number;
    }
    public string GetInfo()
    {
        return ("Тип самолёта: " + type + ", Пункт назначения: " + point + ", " +
            "Номер рейса: " + number + ", День: " + day + "." + "\nВремя отправления: " + time + " часов");
    }
    public class MyClass
    {
        int k;

        // Конструктор
        public MyClass(int i)
        {
            k = i;
        }

        // Деструктор
        ~MyClass()
        {
            Console.WriteLine("Объект {0} уничтожен", k);
        }

        // Метод создающий и тут же уничтожающий объект
        public void objectGenerator(int i)
        {
            MyClass ob = new MyClass(i);
        }
    }
}