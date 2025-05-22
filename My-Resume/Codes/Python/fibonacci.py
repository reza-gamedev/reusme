def fibonacci():
    fibo = [0, 1]
    num = int(input("Enter an integer number: "))
    if num == 1:
        print(fibo[0])
    elif num == 2:
        print(fibo[1])
    else:
        for i in range(2, num):
            fibo.append(fibo[i - 1] + fibo[i - 2])
    print(fibo)
fibonacci()