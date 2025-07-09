# Solução

## Descrição do Problema

Dada uma parede composta por linhas de tijolos de comprimentos variados (mas cuja soma em cada linha é a mesma), devemos traçar **uma linha vertical** do topo à base que **corte o menor número possível de tijolos**.

Uma linha que passa **exatamente na junção entre dois tijolos** não conta como corte.  
Não é permitido traçar a linha pelas bordas externas da parede.

---

## Complexidade Assintótica

| Métrica  | Valor | Justificativa |
|----------|-------|---------------|
| **Tempo** | **O(T)** | Cada tijolo (exceto o último por linha) é visitado uma única vez, e cada operação no `Dictionary` é O(1). |
| **Espaço** | **O(T)** | No pior caso, existe uma entrada no dicionário para cada junção distinta. |

Onde **T** é o número total de tijolos (≤ 20 000).
