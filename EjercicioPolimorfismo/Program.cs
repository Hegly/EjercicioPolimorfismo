using EjercicioPolimorfismo;

List<Figura> figuras = new()
{
  new Circulo(5),
  new Circulo(3),
  new Circulo(1),
  new Rectangulo(4, 6),
  new Rectangulo(2, 4),
  new Rectangulo(3, 5),
  new Triangulo(3, 4, 5),
  new Triangulo(2, 4, 6),
  new Triangulo(4, 6, 8)
};

MostrarInformacion(figuras);

Console.ReadLine();
   

static void MostrarInformacion(List<Figura> figuras)
{
   foreach (var figura in figuras)
    {
      Console.WriteLine($"Figura: {figura.GetType().Name}");
      Console.WriteLine($"Área: {figura.CalcularArea()}");
      Console.WriteLine($"Perímetro: {figura.CalcularPerimetro()}");
      Console.WriteLine(); 
    }
}