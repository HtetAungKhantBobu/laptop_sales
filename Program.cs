using System;
namespace LaptopSales
{

    class Laptop
    {
        public string brand;
        public string model;

        public int year;
        public string os;
        public bool is_touchscreen;
        public double price;
        public int stock;

        public Laptop(
            string lbrand,
            string lmodel,
            int lyear,
            string los,
            bool ltouch,
            double lprice,
            int lstock
        )
        {
            brand = lbrand;
            model = lmodel;
            year = lyear;
            os = los;
            is_touchscreen = ltouch;
            price = lprice;
            stock = lstock;
        }

        public void sell()
        {
            if (stock < 1)
            {
                Console.WriteLine("Out of stock!");
                return;
            }
            Console.WriteLine($"Sold 1 {brand} - {model}!");
            stock--;
        }

        public void discount(double percent)
        {
            double discounted_price = price * (percent / 100);
            Console.WriteLine($"Discounted price is {discounted_price}$!");
        }
    }
    class LaptopSales
    {
        public static void Main(string[] args)
        {

            Laptop laptop1 = new Laptop("Apple", "Air M3", 2023, "Mac", false, 1400.00, 10);
            Laptop laptop2 = new Laptop("Lenovo", "Thinkpad Carbon", 2023, "Windows", false, 2000.00, 10);
            Laptop laptop3 = new Laptop("MSI", "MSI-XXX", 2023, "Windows", false, 1200.00, 2);

            laptop3.sell();
            laptop3.sell();
            laptop3.sell();

            laptop2.discount(50.0);
        }
    }
}