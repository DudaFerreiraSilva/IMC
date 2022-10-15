double altura, peso, imc;

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.Write("Altura (m)..: ");
altura = Convert.ToDouble(Console.ReadLine());
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.Write("Peso (kg)...: ");
peso = Convert.ToDouble(Console.ReadLine());
Console.ResetColor();

imc = peso / Math.Pow(altura, 2);

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"\nIMC: {imc:N1} kg/m²");
Console.ResetColor();
