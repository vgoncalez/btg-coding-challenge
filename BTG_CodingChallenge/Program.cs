List<List<int>> parede =
[
    [1, 2, 2, 1],
    [3, 1, 2],
    [1, 3, 2],
    [2, 4],
    [3, 1, 2],
    [1, 3, 1, 1]
];

Console.WriteLine(Calcular(parede));

int Calcular(List<List<int>> parede)
{
    var juncoes = new Dictionary<int, int>();

    foreach (var linha in parede)
    {
        int posicao = 0;

        for (int i = 0; i < linha.Count - 1; i++)
        {
            posicao += linha[i];

            if (!juncoes.TryAdd(posicao, 1))
                juncoes[posicao]++;
        }
    }

    int maximoDeJuncoes = juncoes.Count > 0 ? MaxValue(juncoes.Values) : 0;

    return parede.Count - maximoDeJuncoes;
}

int MaxValue(IEnumerable<int> valores)
{
    int max = 0;
    foreach (var v in valores)
        if (v > max) 
            max = v;
    
    return max;
}
