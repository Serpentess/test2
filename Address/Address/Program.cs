namespace lesson1
{
    class Address
    {
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Street { get; set; }
        public string? House { get; set; }
        public string? Apartment { get; set; }
        public string? Index { get; set; }

    }
    class Program
    {
        static void Main()
        {
            Address address = new Address();
            address.Country = "Україна";
            address.City = "Київ";
            address.Street = "вул. Хрещатик";
            address.House = "19Б";
            address.Apartment = "2";
            address.Index = "010101011";
            Console.WriteLine(address.Country);
            Console.WriteLine(address.City);
            Console.WriteLine(address.Street);
            Console.WriteLine(address.House);
            Console.WriteLine(address.Apartment);
            Console.WriteLine(address.Index);
            Console.ReadKey();
        }
    }
}
