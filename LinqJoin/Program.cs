using LinqJoin;

//classları tanımlayıp listeler ile nesne ürettik
List<Book> books =new List<Book>()
{
    new Book
    {
        BookId = 1,
        Title = "Kar",
        AuthorId = 1,
    },

    new Book
    {
        BookId = 2,
        Title = "İstanbul",
        AuthorId = 1,
    },

    new Book
    {
        BookId = 3,
        Title = "10 Minutes 38 Seconds in This Strange World",
        AuthorId = 2,
    },

    new Book
    {
        BookId = 4,
        Title = "Beyoğlu Rapsodisi",
        AuthorId = 3,
    },
};


List<Author> authors = new List<Author>()
{
    new Author
    {
        AuthorId = 1,
        Name = "Orhan Pamuk"
    },

    new Author
    {
        AuthorId = 2,
        Name = "Elif Şafak"
    },

    new Author
    {
        AuthorId = 3,
        Name = "Ahmet Ümit"
    },
};

//burada join işlemini gerçekleştirdik.
var authorBookJoin = books.Join(authors, book => book.AuthorId, author => author.AuthorId, (book, author) => new
{
    BookTitle = book.Title,
    AuthorName = author.Name
});

//bilgileri ekrana yazdırma
foreach(var item in authorBookJoin)
{
    Console.WriteLine($"Kitap adı: {item.BookTitle}, Yazar adı: {item.AuthorName}");
}