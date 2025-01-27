class Solution:
    def calPoints(self, operations: List[str]) -> int:
        stack = deque()
        for op in operations:
            if op == '+':
                stack.append(list(stack)[-2] + list(stack)[-1])
            elif op == 'D':
                stack.append(list(stack)[-1] * 2)
            elif op == 'C':
                stack.pop()
            else:
                stack.append(int(op))
        return sum(stack)