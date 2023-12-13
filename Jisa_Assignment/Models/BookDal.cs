namespace Jisa_Assignment.Models
{
    public class BookDal
    {
        List<Book> list;
        public BookDal()
        { 
            list = new List<Book>();
            {
                new Book() { Id = 1, Title = "DotNet", AuthorName = "abc" };
                new Book() { Id = 2, Title = "Java", AuthorName = "def" };
            };
        }
        public List<Book> AddBook(Book book)
        {
            list.Add(book);
            return list;
        }
        public List<Book> DeleteBook(Book book)
        {
            foreach(Book book1 in list)
            {
                if(book1.Id == book.Id)
                {
                    list.Remove(book1);
                    break;
                }
            }
            return list;
        }

        public List<Book> UpdateBook(Book book)
        {

            list.Add(book);

            return list;
        }
        public List<Book> GetAllBook()
        {
            return list;
        }
    }
}
