using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApi.Models
{
    public interface IBookStoreDatabaseSettings
    {
        string BooksCollectionName { get; set; }
        string CollectionString { get; set; }
        string DatabaseName { get; set; }
    }
    public class BookStoreDatabaseSettings : IBookStoreDatabaseSettings
    {
        public string BooksCollectionName { get; set; }
        public string CollectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
