// 1.1.3
namespace Exercise1.Models
{
    class Product
    {
        public int Code { get; private set; }
        public string Name { get; private set; }
        public int Price { get; private set; }

        public Product(int code, string name, int price)
        {
            Code = code;
            Name = name;
            Price = price;
        }

        public int GetTax()
        {
            return (int)(Price * 0.08);
        }

        public int GetPriceIncludingTax()
        {
            return Price + GetTax();
        }
    }
}
