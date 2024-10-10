namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Worlds!");

            Book buku = new Book();
            buku.Title = "Tutorial Jago PBO dalam 1 detik";

            buku.OrderCopy();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Judul Buku: {0}", buku.Title);
                Console.WriteLine("Copies: {0}", buku.GetCopy());
                Console.WriteLine("------------------------------");
                Console.WriteLine("1. Jalankan SellCopy");
                Console.WriteLine("2. Jalankan OrderCopy");
                Console.WriteLine("3. Exit");
                string input = Console.ReadLine();
                int intInput = int.Parse(input);

                switch (intInput)
                {
                    case 1:
                        buku.SellCopy();
                        break;
                    case 2:
                        buku.OrderCopy();
                        break;
                }

                if (intInput == 3) break;
            }
            Console.WriteLine("Program Selesai.");
            //Console.WriteLine("Copies: {0}", buku.GetCopy());
        }
    }

    class Publication
    {
        public string Title { get; set; }
        public string Price { get; set; }
        protected int Copies { get; set; }

        public Publication() {
            Title = string.Empty;
            Price = string.Empty;
        }

        public void SellCopy()
        {
            Copies -= 1;
        }

        public int GetCopy()
        {
            return Copies;
        }
    }

    class Book : Publication
    {
        public string Author { get; set; }

        public Book()
        {
            Author = string.Empty;
        }

        public void OrderCopy()
        {
            Copies += 1;
        }

    }

    class Magazine : Publication
    {
        public int OrderQty { get; set; }
        public string CurrentIssue { get; set; }

        public Magazine()
        {
            CurrentIssue = string.Empty;
        }

        public void AdjustQuantity(int quantity) {
            OrderQty = quantity;
        }

        public void RecNewIssue()
        {

        }
    }
}
