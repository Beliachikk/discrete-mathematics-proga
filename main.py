rebra=[]
peaks=""
opPeaks=""
#задействованные вершины
count=0
VvodRebra = input()
'''Сначала вводим ребро1 ребро2 вес, а потом точку старта и финиша
Например, 
1 2 1
2 3 1
1 3 4
enter
начальная вершина
конечная
'''
while VvodRebra !='':#ребра и их веса
    s_rebra = [VvodRebra.split()[0], VvodRebra.split()[1], int(VvodRebra.split()[2])]
    if s_rebra[0] not in peaks:
        peaks += s_rebra[0]
    if s_rebra[1] not in peaks:
        peaks += s_rebra[1]
    count = max(count, s_rebra[2])
    rebra.append(s_rebra)
    VvodRebra = input()
#Даем максимальные значения вершинам
m = [count]*len(peaks)

a = int(input('Введите начальную вершину:')) - 1
b = int(input('Теперь конечную:')) - 1

opPeaks = str(a + 1)
for i in range(len(m)):#находим ребра для первой вершины
    for j in range(len(rebra)):
        if rebra[j][0] == str(a + 1) and rebra[j][1] == str(i+1):
            m[i] = rebra[j][2]


min_val = count
min_peak = None
for i in range(len(m)):#ищем минимальное для первой вершины
    if m[i] < min_val and str(i+1) not in opPeaks:
        min_val = m[i]
        min_peak = i
a = min_peak

while a != None:
    opPeaks += str(a + 1)
    for i in range(len(m)):
        for j in range(len(rebra)):
            if rebra[j][0] == str(a + 1) and rebra[j][1] == str(i+1):
                m[i] = min(rebra[j][2] + m[a], m[i])
    min_val = count
    min_peak = None
    for i in range(len(m)):#ищем минимальные для остальных
        if m[i] < min_val and str(i+1) not in opPeaks:
            min_val = m[i]
            min_peak = i
    a = min_peak

print(m[b])