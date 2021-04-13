using System;

namespace for_foreach_while_and_class_structure
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.Name = "Satranç";
            book1.Author = "Stefan Zweig";
            book1.Price = 4.90;

            Book book2 = new Book();
            book2.Name = "1984";
            book2.Author = "George Orwell";
            book2.Price = 9.80;

            Book book3 = new Book();
            book3.Name = "Sineklerin Tanrısı";
            book3.Author = "William Golding";
            book3.Price = 11.20;

            Book book4 = new Book();
            book4.Name = "İnsan Neyle Yaşar?";
            book4.Author = "Lev Nikolayeviç Tolstoy";
            book4.Price = 7.00;

            Book book5 = new Book();
            book5.Name = "Hayvan Çiftliği";
            book5.Author = "George Orwell";
            book5.Price = 5.60;

            Book book6 = new Book();
            book6.Name = "Suç ve Ceza";
            book6.Author = "Fyodor Mihayloviç Dostoyevski";
            book6.Price = 15.40;

            Book[] books = new Book[] { book1, book2, book3, book4, book5, book6 };

            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine("Ad: " + books[i].Name);
                Console.WriteLine("Yazar: " + books[i].Author);
                Console.WriteLine("Fiyat: " + books[i].Price);
            }

            foreach (var book in books)
            {
                Console.WriteLine("Ad: " + book.Name);
                Console.WriteLine("Yazar: " + book.Author);
                Console.WriteLine("Fiyat: " + book.Price);
            }

            int j = 0;
            while (j < books.Length)
            {
                Console.WriteLine("Ad: " + books[j].Name);
                Console.WriteLine("Yazar: " + books[j].Author);
                Console.WriteLine("Fiyat: " + books[j].Price);
                ++j;
            }
        }
    }
    class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
    }
}
