namespace FundamentosApp;

public class Fila<T>
{
    private T[] _items;
    private int _head;
    private int _tail;
    private int _count;

    public Fila(int capacidadeInicial = 4)
    {
        if (capacidadeInicial < 1)
        {
            capacidadeInicial = 4;
        }

        _items = new T[capacidadeInicial];
        _head = 0;
        _tail = 0;
        _count = 0;
    }

    public int Count => _count;

    public int ObterQuantidade() => _count;

    public void Enqueue(T item)
    {
        if (_count == _items.Length)
        {
            Redimensionar();
        }

        _items[_tail] = item;
        _tail = (_tail + 1) % _items.Length;
        _count++;
    }

    public T Dequeue()
    {
        if (_count == 0)
        {
            throw new InvalidOperationException("A fila está vazia.");
        }

        T item = _items[_head];
        _items[_head] = default!;
        _head = (_head + 1) % _items.Length;
        _count--;
        return item;
    }

    public T Peek()
    {
        if (_count == 0)
        {
            throw new InvalidOperationException("A fila está vazia.");
        }

        return _items[_head];
    }

    private void Redimensionar()
    {
        int novaCapacidade = _items.Length * 2;
        T[] novoArray = new T[novaCapacidade];

        for (int i = 0; i < _count; i++)
        {
            novoArray[i] = _items[(_head + i) % _items.Length];
        }

        _items = novoArray;
        _head = 0;
        _tail = _count;
    }
}
