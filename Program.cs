Decimal Compra, Valor, Troco;
Console.Write ("Qual é o valor da compra.:  ");
 Compra = Convert.ToDecimal (Console.ReadLine());

 Console.Write ("Quanto voce pagou.:  ");
  Valor = Convert.ToDecimal (Console.ReadLine());

  Troco = Compra - Valor;

 Console.WriteLine($"\nTroco: {Troco:C}");
