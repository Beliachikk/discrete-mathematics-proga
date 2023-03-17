import math
v = [[0, 1, math.inf, math.inf, 6, 3],
     [1,0, 6, math.inf, math.inf,5],
     [math.inf,6, 0, 1,3,3],
     [math.inf,0,1,0,2, math.inf],
     [6,math.inf,3,2,0,4],
     [3,5,3, math.inf,4,0],
]
n=len(v)
P=[[v[i][j] for j in range(n)] for i in range(n)]
for k in range(n):
    for i in range(n):
        for j in range(n):
           if P[i][k]+P[k][j]<P[i][j]:
               P[i][j]=P[i][k]+P[k][j]
print(P)