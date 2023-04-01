from sys import maxsize
def BellmanFord(graph, V, E, start):
    dist = [maxsize] * V#заполняем бесконечностями
    dist[start] = 0

    for i in range(V - 1):
        for j in range(E):
            if dist[graph[j][0]]+graph[j][2] < dist[graph[j][1]]:
                dist[graph[j][1]] = dist[graph[j][0]]+graph[j][2]

    for i in range(E):#проверка на отрицательный цикл
        x = graph[i][0]
        y = graph[i][1]
        weight = graph[i][2]
        if dist[x] != maxsize and dist[x]+weight < dist[y]:
            print("Найден отрицательный цикл(")

    print("Вершина Путь до исходной вершины")
    for i in range(V):
        print("%d\t\t%d" % (i, dist[i]))

if __name__ == "__main__":
    V = 5 #число вершин
    E = 8#число ребер

    graph = [[0, 1, -1], [0, 2, 4], [1, 2, 3],
             [1, 3, 2], [1, 4, 2], [3, 2, 5],
             [3, 1, 1], [4, 3, -3]]
    BellmanFord(graph, V, E, 0)