# def fun_zipped(lst1, lst2):
#     zipped = []
#     if len(lst1) > len(lst2):
#         Len = len(lst2)
#     else:
#         Len = len(lst1)
#     zipped = [(lst1[i], lst2[i]) for i in range(Len)]
#     return zipped
# def fun_zipped(*lst):
#     zipped = []
#     min_len = min(len(l) for l in lst)
#     zipped = [tuple(l[i] for l in lst) for i in range(min_len)]
#     return zipped