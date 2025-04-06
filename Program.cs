int ConsumidoresAlcool;
int NaoConsumidoresAlcool;
int Criancas;
double carne, acompanhamentos, cerveja, refrigerante, agua;

Console.WriteLine("Quantos adultos consumidores de bebida alcoólicas estarão presentes na festa?");
ConsumidoresAlcool = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Quantos adultos estarão presentes na festa?");
NaoConsumidoresAlcool = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Quantos adultos estarão presentes na festa?");
Criancas = Convert.ToInt32(Console.ReadLine()!);
Console.Clear();

Console.WriteLine("--- Churrasco ---");
Console.WriteLine($"\nAdultos (que consomem bebidas alcoólicas).......: {ConsumidoresAlcool}");
Console.WriteLine($"Adultos (que não consomem bebidas alcoólicas)...: {NaoConsumidoresAlcool}");
Console.WriteLine($"Crianças........................................: {Criancas}");

carne = (ConsumidoresAlcool + NaoConsumidoresAlcool) * 0.4 + Criancas * 0.2;
acompanhamentos = (ConsumidoresAlcool + NaoConsumidoresAlcool) * 0.2 + Criancas * 0.2;
cerveja = ConsumidoresAlcool * 2;
refrigerante = (ConsumidoresAlcool + NaoConsumidoresAlcool) * 0.5 + Criancas * 0.5;
agua = (ConsumidoresAlcool + NaoConsumidoresAlcool) * 0.4 + Criancas * 0.4; 

Console.WriteLine($"\nCarne.............: {carne:N1}kg");
Console.WriteLine($"Acompanhamentos...: {acompanhamentos:N1}kg");
Console.WriteLine($"Cerveja...........: {cerveja:N1}L");
Console.WriteLine($"Refrigerante......: {refrigerante:N1}L");
Console.WriteLine($"Água..............: {agua:N1}L");