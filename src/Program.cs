using System;
using src.Models.Expresso;

Console.WriteLine("=== Sistema de Pedidos - Cafeteria ===\n");

// Abordagem 1: Classes específicas (explosão combinatória)
Console.WriteLine("--- Pedidos com classes específicas ---");

var cafe1 = new Espresso();
Console.WriteLine($"{cafe1.GetDescription()}: R$ {cafe1.GetCost():N2}");

var cafe2 = new EspressoComLeiteEChocolate();
Console.WriteLine($"{cafe2.GetDescription()}: R$ {cafe2.GetCost():N2}");

var cafe3 = new EspressoComLeiteEChocolate();
Console.WriteLine($"{cafe3.GetDescription()}: R$ {cafe3.GetCost():N2}");

// E se o cliente quiser Espresso com Leite, Chocolate, Chantilly e Caramelo?
// Precisaria criar outra classe!

Console.WriteLine("\n--- Pedidos com flags booleanas ---");


//
//             // Problema: Cliente pode esquecer de setar flags
//             var cafe5 = new BebidaComFlags("Espresso", 3.50m);
//             // Esqueci de configurar os complementos
//             Console.WriteLine($"{cafe5.GetDescription()}: R$ {cafe5.GetCost():N2}");
//
//             Console.WriteLine("\n=== PROBLEMAS ===");
//             Console.WriteLine("Abordagem 1 (Classes específicas):");
//             Console.WriteLine("✗ Explosão combinatória: N bebidas × 2^M complementos classes");
//             Console.WriteLine("✗ Código altamente duplicado");
//             Console.WriteLine("✗ Difícil adicionar novos complementos");
//             Console.WriteLine("✗ Impossível adicionar complementos dinamicamente");
//             Console.WriteLine();
//             Console.WriteLine("Abordagem 2 (Flags booleanas):");
//             Console.WriteLine("✗ Viola Open/Closed Principle");
//             Console.WriteLine("✗ Classe cresce a cada novo complemento");
//             Console.WriteLine("✗ Não é extensível sem modificação");
//             Console.WriteLine("✗ Difícil adicionar comportamento aos complementos");
//
//             // Perguntas para reflexão:
//             // - Como adicionar comportamento a um objeto dinamicamente?
//             // - Como combinar múltiplos comportamentos sem criar classes para cada combinação?
//             // - Como manter a interface compatível ao adicionar funcionalidades?
//             // - Como permitir que complementos sejam adicionados em tempo de execução?