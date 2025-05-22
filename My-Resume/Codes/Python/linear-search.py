#1️⃣
# lst = [1, 2, 5, 10, 12, 4, 3, 7, 22]
# x = 4
# i = 0
# while i < len(lst):
#     if lst[i] == x:
#         print(f"{x} at position lst[{i}]")
#         break
#     i += 1
# if i >= len(lst):
#     print(f"{x} is not in {lst}")
# 2️⃣
# lst = [1, 2, 5, 10, 12, 4, 3, 7, 22]
# x = 4
# i = 0
# while i < len(lst):
#     if lst[i] == x:
#         print(f"{x} at position lst[{i}]")
#         break
#     i += 1
# else:
#     print(f"{x} is not in {lst}")
# 3️⃣
# lst = [1, 2, 5, 10, 12, 4, 3, 7, 22]
# x = 23
# found = False
# for i in range(len(lst)):
#     if lst[i] == x:
#         print(f"{x} at position lst[{i}]")
#         found = True
#         break
# if not found:
#     print(f"{x} is not in {lst}")
# 4️⃣
# lst = [1, 2, 5, 10, 12, 4, 3, 7, 22]
# x = 23
# found = False
# for i in range(len(lst)):
#     if lst[i] == x:
#         print(f"{x} at position lst[{i}]")
#         found = True
#         break
# else:
#     print(f"{x} is not in {lst}")
# 5️⃣
lst = [1, 2, 5, 10, 12, 4, 3, 7, 22]
x = 4
if x in lst:
    print(f"{x} at position lst[{lst.index(x)}]")
else:
    print(f"{x} is not in {lst}")