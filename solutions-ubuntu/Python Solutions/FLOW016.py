import math

testCases = int(input())

for testCase in range(testCases):
    A, B = map(int, input().split())
    gcd = math.gcd(A, B)
    lcm = (A * B) // gcd
    print(gcd, lcm)