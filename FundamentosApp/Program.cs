using FundamentosApp;

var fila = new Fila<string>();

fila.Enqueue("Item A");
fila.Enqueue("Item B");
fila.Enqueue("Item C");

Console.WriteLine($"Quantidade de itens na fila: {fila.ObterQuantidade()}");
Console.WriteLine($"Próximo item da fila: {fila.Peek()}");

var removido = fila.Dequeue();
Console.WriteLine($"Item removido: {removido}");
Console.WriteLine($"Quantidade de itens após remoção: {fila.ObterQuantidade()}");

fila.Enqueue("Item D");
Console.WriteLine($"Quantidade de itens após adicionar Item D: {fila.ObterQuantidade()}");

ViewItemsRemoved(fila);

static void ViewItemsRemoved(Fila<string> fila)
{
    while (fila.ObterQuantidade() > 0)
    {
        Console.WriteLine($"Removendo {fila.Dequeue()} - itens restantes: {fila.ObterQuantidade()}");
    }
}
