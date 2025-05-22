#x = 1 / n ---> nx - 1 = 0 ---> f(x) = nx - 1 = n - 1/x
# xk = x - f(x)/f(x)'
# n - 1/x / -1/x^2
# 1️⃣
# n = 0.25
# x = 0.002
# last = 0
# while last < x:
#     print(x)
#     last = x
#     x = x * (2 - (n * x))
# 2️⃣
# x = 1
# last = 0
# while abs(x - last) > 1e-8:
#     print(x)
#     last = x
#     x = ((x ** 2) + 4) / (2 * x)
# 3️⃣
x = 1
last = 0
while abs(x - last) > 1e-8:
    print(x)
    last = x
    x = (2 *( x ** 3) + x + 2) / (3 * (x ** 2) - 1)