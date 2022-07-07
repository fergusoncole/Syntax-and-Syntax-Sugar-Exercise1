//inferred typing, string interpolation, ternary operator
var answer = 4;
string response = "";
response = (answer < 9) ? $"{answer} is less than nine." :
                                           $"{answer} is equal to or greater than nine.";
Console.WriteLine(response);


