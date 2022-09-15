//Console.WriteLine("Hello, World!");

string[] food = { "pasta", "pizza", "patatine", "burger", "tonno" };
Console.Write("numero di cibi " + food.Length);
//Console.Write(food.Length);
Console.WriteLine(" ");

food.ToList().ForEach(Console.WriteLine);
Console.WriteLine(" ");


Console.WriteLine(" ");
Console.Write("il mio cibo prefrito in assoluto è ");
Console.Write(food[1]);
Console.WriteLine(" ");
Console.Write("Il mio cibo preferito ma non troppo è ");
Console.Write(food[4]);

Console.WriteLine(" ");
Console.Write("Il mio cibo intermedio è ");
Console.Write(food[food.Length/2]);
