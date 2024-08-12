using HomeWork11;

var data = new List<object>() {
  "Hello",
  new Book() { Author = "Terry Pratchett", Name = "Guards! Guards!", Pages = 810 },
  new List<int>() {4, 6, 8, 2},
  new string[] {"Hello inside array"},
  new Film() { Author = "Martin Scorsese", Name= "The Departed", Actors = new List<Actor>() {
    new Actor() { Name = "Jack Nickolson", Birthdate = new DateTime(1937, 4, 22)},
    new Actor() { Name = "Leonardo DiCaprio", Birthdate = new DateTime(1974, 11, 11)},
    new Actor() { Name = "Matt Damon", Birthdate = new DateTime(1970, 8, 10)}
  }},
  new Film() { Author = "Gus Van Sant", Name = "Good Will Hunting", Actors = new List<Actor>() {
    new Actor() { Name = "Matt Damon", Birthdate = new DateTime(1970, 8, 10)},
    new Actor() { Name = "Robin Williams", Birthdate = new DateTime(1951, 8, 11)},
}},
  new Book() { Author = "Stephen King", Name="Finders Keepers", Pages = 200},
  "Leonardo DiCaprio"
};

//1. Виведіть усі елементи, крім ArtObjects
//Console.WriteLine(String.Join(", ",data.Except(data.OfType<ArtObject>()).ToArray()));

//2. Виведіть імена всіх акторів
//Console.WriteLine(String.Join(",",data.OfType<Film>().SelectMany(l => l.Actors).Select(a => a.Name)));

//3. Виведіть кількість акторів, які народилися в серпні
//Console.WriteLine(String.Join(",", data.OfType<Film>().SelectMany(a =>a.Actors).Where(a => a.Birthdate.Month == 8).Select(a => a.Name).Distinct()));

//4. Виведіть два найстаріших імена акторів
Console.WriteLine(String.Join(",",data.OfType<Film>().SelectMany(l=>l.Actors).OrderBy(a => a.Birthdate).Take(2).Select(a => a.Name)));

/*
 * 
5. Вивести кількість книг на авторів
6. Виведіть кількість книг на одного автора та фільмів на одного режисера
7. Виведіть, скільки різних букв використано в іменах усіх акторів
8. Виведіть назви всіх книг, упорядковані за іменами авторів і кількістю сторінок
9. Виведіть ім'я актора та всі фільми за участю цього актора
10. Виведіть суму загальної кількості сторінок у всіх книгах і всі значення int у всіх послідовностях у даних
11. Отримати словник з ключем - автор книги, значенням - список авторських книг
12. Вивести всі фільми "Метт Деймон", за винятком фільмів з акторами, імена яких представлені в даних у вигляді рядків
*/


