using tdd_oop_interface_dependency_injection.CSharp.Main;
using tdd_oop_interface_dependency_injection.CSharp.Main.Alphabets;

English english = new English();
string englishWord = "Hello";

Greek greek = new Greek();
string greekWord = "γεια";

Russian russian = new Russian();
string russianWord = "привет";

Scrabble scrabble = new Scrabble(russian);

Console.WriteLine(scrabble.score(russianWord));



