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

    public int getTime
    {
        get
        {
            return time;
        }
    }
    public Aeroflot(string point, string day, string type, string number, int time)
    {
         this.point = point;
         this.day = day;
         this.type = type;
         this.number = number;
         this.time = time;
    }
    public string GetInfo()
    {
        return ("Тип самолёта: " + type + ", Пункт назначения: " + point + ", " +
            "Номер рейса: " + number + ", День: " + day + "."+ "\nВремя отправления: " + time + " часов");
    }
}