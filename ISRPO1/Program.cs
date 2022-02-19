using System;

namespace ISRPO1
{
    abstract class HotDrink
    {
        protected int sugar = 0, milk = 0;
        public int getSugar
            abstract public string Drink();
        public void AddMilk(int milk)
        { this.milk = milk; }
        public void AddSugar(int sugar)
        { this.sugar = sugar; }
        {
            get { return sugar; }
        }
        public int getMilk
        {
            get { return milk; }
        }
        //abstract public string Drink();
        //public void AddMilk(int milk)
        //{ this.milk = milk; }
        //public void AddSugar(int sugar)
        //{ this.sugar = sugar; }
    }

interface ICup
{
    void Refill();
    void Wash();

    string Type { get; set; }
    double Capacity { get; set; }
}

class CupOfCoffee : HotDrink, ICup
{
    private string beanType = "Arabica";
    public string BeanType
    //{
    //    get { return beanType; }
    //    set { if (value != "") beanType = value; }
    //}

    //public void Refill()
    //{ Console.WriteLine("Повторить кофе объемом " + capacity + " мл"); }
    //public void Wash()
    //{ Console.WriteLine("Вымыть " + type + " чашку с кофе"); }

    //private string type = "Plastic";
    //public string Type
    //{
    //    get { return type; }
    //    set { if (value != "") type = value; }
    //}

    //private double capacity = 0.2;
    //public double Capacity
    //{
    //    get { return capacity; }
    //    set { if (value != null) capacity = value; }
    //}

    //public override string Drink()
    //{
    //    return "Вы попили кофе";
    //}
}

class CupOfTea : HotDrink, ICup
{
    private string leafType = "Green";
    public string LeafType
    {
        get { return leafType; }
        set { if (value != "") leafType = value; }
    }

    //public void Refill()
    //{ Console.WriteLine("Повторить чай объемом " + capacity + " мл"); }
    //public void Wash()
    //{ Console.WriteLine("Вымыть " + type + " чашку с чай"); }

    //private string type = "Plastic";
    //public string Type
    //{
    //    get { return type; }
    //    set { if (value != "") type = value; }
    //}

    //private double capacity = 0.3;
    //public double Capacity
    //{
    //    get { return capacity; }
    //    set { if (value != null) capacity = value; }
    //}
    //public override string Drink()
    //{
    //    return "Вы попили чай";
    //}
}

struct orders
{
    public string itemname;  //наименование
    public int unitCount;       //число единиц
    public double unitCost; //стоимость одной единицы
    public double order;
    public orders(string itemname, int unitCount, double unitCost)
    {
        this.itemname = itemname;
        this.unitCount = unitCount;
        this.unitCost = unitCost;
        this.order = unitCount * unitCost;
    }
    public void Writeorders()
    {

    }
}

class Program
{
        static void Main(string[] args)
        {
        Console.WriteLine("Сколько вы хотите напитков?");

        int chislo = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < chislo; i++)
        {
            Console.Write("Выберите напиток: Кофе (1) или Чай (2) => ");
            HotDrink Choice = null;
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
                Choice = new CupOfCoffee();
            else if (choice == 2)
                Choice = new CupOfTea();
            else return;
            ProcessCup(Choice);
            Console.ReadKey(true);
        }
        //Console.WriteLine(Choice.Drink());
        }
    static void ProcessCup(HotDrink Choice)
    {
        if (Choice is CupOfTea)
        {

            CupOfTea Tea = Choice as CupOfTea;
            Console.Write("Тип листьев: Green или Black (по умолч. " + Tea.LeafType + ") => ");
            Tea.LeafType = Console.ReadLine();
            if (Tea.LeafType == "Green")
            {
                orders green = new orders("Green", 70, 1);
            }
            else
            {
                orders black = new orders("Green", 50, 1);
            }
            Console.Write("Сахар: 0-5 (по умолч. " + Tea.getSugar + ") => ");
            String Validate = "";
            if ((Validate = Console.ReadLine()) != "")
                Tea.AddSugar(Convert.ToInt32(Validate));
            Console.Write("Молоко: 0-10 (по умолч. " + Tea.getMilk + ") => ");
            if ((Validate = Console.ReadLine()) != "")
                Tea.AddMilk(Convert.ToInt32(Validate));
            Console.Write("Тип стакана: Plastic или Glass (по умолч. " + Tea.Type + ") => ");
            Tea.Type = Console.ReadLine();
            Console.Write("Объём: 0,2 или 0,3 (по умолч. " + Tea.Capacity + ") => ");
            if ((Validate = Console.ReadLine()) != "")
                Tea.Capacity = Convert.ToInt32(Validate);

            Console.WriteLine("В чай добавлен сахар : " + Tea.getSugar +
                "\nВ чай добавлено молоко : " + Tea.getMilk +
                "\nПолучите чай с листьями : " + Tea.LeafType);
            Tea.Wash();
            Tea.Refill();
        }
        else
        {
            CupOfCoffee Coffee = Choice as CupOfCoffee;
            Console.Write("Тип зерен: Arabica или Robusta (по умолч. " + Coffee.BeanType + ") => ");
            Coffee.BeanType = Console.ReadLine();
            if (Coffee.BeanType == "Arabica")
            {
                orders arabica = new orders("Green", 1, 70);
            }
            else
            {
                orders robusta = new orders("Green", 1, 50);
            }
            Console.Write("Сахар: 0-5 (по умолч. " + Coffee.getSugar + ") => ");
            String Validate = "";
            if ((Validate = Console.ReadLine()) != "")
                Coffee.AddSugar(Convert.ToInt32(Validate));
            Console.Write("Молоко: 0-10 (по умолч. " + Coffee.getMilk + ") => ");
            if ((Validate = Console.ReadLine()) != "")
                Coffee.AddMilk(Convert.ToInt32(Validate));
            Console.Write("Тип стакана: Plastic или Glass (по умолч. " + Coffee.Type + ") => ");
            Coffee.Type = Console.ReadLine();
            Console.Write("Объём: 0,2 или 0,3 (по умолч. " + Coffee.Capacity + ") => ");
            if ((Validate = Console.ReadLine()) != "")
                Coffee.Capacity = Convert.ToInt32(Validate);

            Console.WriteLine("В кофе добавлен сахар : " + Coffee.getSugar +
                "\nВ кофе добавлено молоко : " + Coffee.getMilk +
                "\nПолучите кофе с зернами : " + Coffee.BeanType);
            Coffee.Wash();
            Coffee.Refill();

        }

    }
}

