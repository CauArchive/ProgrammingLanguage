class new_flatten:
    def __init__(self, lst):
        self.lst = lst
        self.current = 0
        self.stop = len(lst)
        self.tempList = None
        self.tempListLen = 0
      
    def hasNext(self):
        if self.current < self.stop:
            return True
        else:
            return False
    
    def next(self):
        if self.tempList:
            if self.tempList.hasNext():
                return self.tempList.next()
            else:
                self.tempList = None
                self.current += 1
        if self.current < self.stop:
            item = self.lst[self.current]
            if isinstance(item, list) and len(item) > 0:
                ft = new_flatten(item)
                self.tempList = ft
                self.tempListLen = len(item)
                return ft.next()
            elif isinstance(item, list) and  len(item) == 0:
                self.current += 1
                return self.next()
            else:
                self.current += 1
                return item

def flatten(lst):
    for item in lst:
        if isinstance(item, list):
            yield from flatten(item)
        else:
            yield item
  

# Add up numbers until the sum becomes greater than 10
data = [1, [2, [[[4]]], [0, 5], [], 3], [4], 2, 7]
data = [[[]]]


sum = 0
flattener = new_flatten(data)
while flattener.hasNext():
  result = flattener.next()
  print(result)
  # next의 값으로 None이 나오는 것을 해결하지 못했습니다.
  # 따라서 임시방편으로 None이 나올 경우 continue를 하도록 했습니다.
  # if result == None:
  #   continue
  # sum += result
  # if sum > 10:
  #   break
  # print('Result:', sum)
