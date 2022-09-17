string frase1, frase2;

Console.WriteLine("Digite sua flase: ");
frase1 =  Console.ReadLine()!;

frase2  = frase1
  .Replace("r", "l")
  .Replace("R", "L");

Console.WriteLine(frase2);