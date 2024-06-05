// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

var firstName = "Neil";
var lastName = "Kelsey";

// {0} is a placeholder which will be replaced with firstName
string fullName = string.Format("{0} {1}", firstName, lastName);

Console.WriteLine(firstName + " " + lastName);
Console.WriteLine(fullName);

var numbers = new int[3] { 1, 2, 3};
string list = string.Join(",", numbers);

Console.WriteLine(numbers[0]);
Console.WriteLine(list);

char firstChar = firstName[0];

Console.WriteLine(firstChar);

// There are also escape characters
// Backslash is a special escape character so we need to place a \ in front of it
// Which ends up as a double \\
// Look at my Google Keeps notes for more infor on escape characters

string path = "c:\\projects\\projects1\\folder1";
Console.WriteLine(path);

// But you can also do this

string pathClean = @"c:\projects\projects1\folder1";
Console.WriteLine(pathClean);
