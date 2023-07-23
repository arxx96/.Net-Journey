using APINew.Model.Dto;

namespace APINew.Data
{
    public class BookStore
    {
        public static List<BookDto> bookList = new List<BookDto>
        {
            new BookDto { ID =1 , Name="hello" , Description="aaaa" }
            , new BookDto { ID =2 ,Name="HI", Description="bbbb" }
        };

       
    }
}
