
Book Book1 = new Book ("Foundation", "Asimov", "6548546541", 1981, "sifi");

Console.WriteLine("type a title\n");

string userQueryTitle = "Foundation";

bool matchTitle = Book1.IsMatch(userQueryTitle);

Console.WriteLine(matchTitle);

