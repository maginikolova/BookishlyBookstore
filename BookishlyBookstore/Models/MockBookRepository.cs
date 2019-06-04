using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookishlyBookstore.Models
{
    public class MockBookRepository : IBookRepository
    {
        private List<Book> _books;

        public MockBookRepository()
        {
            if (_books == null)
            {
                InitializeBooks();
            }
        }

        private void InitializeBooks()
        {
            _books = new List<Book>
            {
                new Book {Id = 1, Name = "Pride and Prejudice", Price = 6.6M, ShortDescription = "classics, fiction, romance", LongDescription = "Since its immediate success in 1813, Pride and Prejudice has remained one of the most popular novels in the English language. Jane Austen called this brilliant work \"her own darling child\" and its vivacious heroine, Elizabeth Bennet, \"as delightful a creature as ever appeared in print.\" The romantic clash between the opinionated Elizabeth and her proud beau, Mr. Darcy, is a splendid performance of civilized sparring. And Jane Austen's radiant wit sparkles as her characters dance a delicate quadrille of flirtation and intrigue, making this book the most superb comedy of manners of Regency England.", ImageUrl = "https://images.gr-assets.com/books/1320399351l/1885.jpg", IsBookOfTheWeek = false, ImageThumbnailUrl = "https://images.gr-assets.com/books/1320399351l/1885.jpg"},
                new Book {Id = 2, Name = "The Hunger Games", Price = 13.1M, ShortDescription = "young adult, fiction, dystopia, fantasy", LongDescription = "In the ruins of a place once known as North America lies the nation of Panem, a shining Capitol surrounded by twelve outlying districts. The Capitol is harsh and cruel and keeps the districts in line by forcing them all to send one boy and one girl between the ages of twelve and eighteen to participate in the annual Hunger Games, a fight to the death on live TV. Sixteen-year-old Katniss Everdeen, who lives alone with her mother and younger sister, regards it as a death sentence when she is forced to represent her district in the Games. But Katniss has been close to dead before - and survival, for her, is second nature. Without really meaning to, she becomes a contender. But if she is to win, she will have to start making choices that weigh survival against humanity and life against love.", ImageUrl = "https://images.gr-assets.com/books/1447303603l/2767052.jpg", IsBookOfTheWeek = true, ImageThumbnailUrl = "https://images.gr-assets.com/books/1447303603l/2767052.jpg"},
                new Book {Id = 3, Name = "Catching Fire", Price = 19.7M, ShortDescription = "young adult, fiction, dystopia, fantasy", LongDescription = "Against all odds, Katniss has won the Hunger Games. She and fellow District 12 tribute Peeta Mellark are miraculously still alive. Katniss should be relieved, happy even. After all, she has returned to her family and her longtime friend, Gale. Yet nothing is the way Katniss wishes it to be. Gale holds her at an icy distance. Peeta has turned his back on her completely. And there are whispers of a rebellion against the Capitol - a rebellion that Katniss and Peeta may have helped create. Much to her shock, Katniss has fueled an unrest she's afraid she cannot stop. And what scares her even more is that she's not entirely convinced she should try. As time draws near for Katniss and Peeta to visit the districts on the Capitol's cruel Victory Tour, the stakes are higher than ever. If they can't prove, without a shadow of a doubt, that they are lost in their love for each other, the consequences will be horrifying.", ImageUrl = "https://images.gr-assets.com/books/1358273780l/6148028.jpg", IsBookOfTheWeek = false, ImageThumbnailUrl = "https://images.gr-assets.com/books/1358273780l/6148028.jpg"},
                new Book {Id = 4, Name = "Mockingjay", Price = 20.5M, ShortDescription = "young adult, fiction, dystopia, fantasy", LongDescription = "Katniss Everdeen, girl on fire, has survived, even though her home has been destroyed. Gale has escaped. Katniss's family is safe. Peeta has been captured by the Capitol. District 13 really does exist. There are rebels. There are new leaders. A revolution is unfolding. The success of the rebellion hinges on Katniss's willingness to be a pawn, to accept responsibility for countless lives, and to change the course of the future of Panem. To do this, she must put aside her feelings of anger and distrust. She must become the rebels' Mockingjay--no matter what the personal cost.", ImageUrl = "https://images.gr-assets.com/books/1358275419l/7260188.jpg", IsBookOfTheWeek = false, ImageThumbnailUrl = "https://images.gr-assets.com/books/1358275419l/7260188.jpg"}
            };
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _books;
        }

        public Book GetBookById(int bookId)
        {
            return _books.FirstOrDefault(b => b.Id == bookId);
        }
    }
}
