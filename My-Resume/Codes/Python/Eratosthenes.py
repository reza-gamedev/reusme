n = 100
prime = [True] * (n + 1)
for i in range(2, int(n ** 0.5) + 1):
    for j in range(i * i, n + 1, i):
        prime[j] = False
for j in range(2, n + 1):
    if prime[j]:
        print(j,", ",sep="",end="")