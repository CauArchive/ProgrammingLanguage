# Generator을 구현하지 못해습니다.
def sort_gen(lst):
    if not lst:
        return lst
    head, tail = lst[0], lst[1:]
    less = [v for v in tail if v < head]
    greater = [v for v in tail if v >= head]
    yield from sort_gen(less)
    yield head
    yield from sort_gen(greater)

data = [3,1,-5,7,-4,2,6,200,9,-2,4,3,0,-2]+[100]*10000
for _, val in zip(range(20), sort_gen(data)):
    print(val, end=' ')