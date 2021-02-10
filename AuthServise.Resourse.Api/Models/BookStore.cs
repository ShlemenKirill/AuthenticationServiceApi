using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthServise.Resourse.Api.Models
{
    public class BookStore
    {
        public List<Book> Books => new List<Book>
        {
            new Book{ Id = 1, Author = "J. K. Rowling", Title = "Harry Potter", Price = 10.45M},
            new Book{ Id = 2, Author = "Herman Melvile", Title = "Moby-Dick", Price = 8.52M},
            new Book{ Id = 3, Author = "Jules Verne", Title = "The Mysterious Island", Price = 7.11M},
            new Book{ Id = 4, Author = "Carlo Collodi", Title = "Pinocchio", Price = 6.42M}
        };

        public Dictionary<Guid, int[]> Orders => new Dictionary<Guid, int[]>
        {
            { Guid.Parse("beddd6fb-3d2b-4e6d-8c2d-beffcae1888e"), new int[] { 1, 3} },
            { Guid.Parse("a599a0ac-19fa-4922-9f7d-f6799d0b9cce"), new int[] { 2, 3, 4} }
        };
    }
}
