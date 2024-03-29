> [Prepare](https://www.hackerrank.com/dashboard) > [Algorithms](https://www.hackerrank.com/domains/algorithms) > 
[Warmup](https://www.hackerrank.com/domains/algorithms/warmup) > [Diagonal Difference](https://www.hackerrank.com/challenges/diagonal-difference/problem)
# Diagonal Difference

### Problem
Given a square matrix, calculate the absolute difference between the sums of its diagonals.

For example, the square matrix **arr** is shown below:
```
1 2 3
4 5 6
9 8 9
```
The left-to-right diagonal = **1 + 5 + 9 = 15**. The right to left diagonal = **3 + 5 + 9 = 17**.
Their absolute difference is **|15 - 17| = 2**.

#### Function Description
Complete the `diagonalDifference` function in the editor below. <br/>
`diagonalDifference` takes the following parameter:
- `int` **arr[n][m]**: an array of integers

#### Return
- `int`: the absolute diagonal difference

#### Input Format
The first line contains a single integer, _**n**_, the number of rows and columns in the square matrix _**arr**_. <br/>
Each of the next _**n**_ lines describes a row, _**arr[i]**_, and consists of _**n**_ space-separated integers _**arr[i][j]**_.

#### Constraints
- $-100 \leq arr[i][j] \leq 100$

#### Output Format
Return the absolute difference between the sums of the matrix's two diagonals as a single integer.

#### Sample Input
```text
3
11 2 4
4 5 6
10 8 -12
```

#### Sample Output
```text
15
```

#### Explanation
The primary diagonal is:
```
11 .  . 
.  5  .
.  . -12
```
Sum across the primary diagonal: 11 + 5 - 12 = 4

The secondary diagonal is:
```
.  .  4 
.  5  . 
10 .  . 
```
Sum across the secondary diagonal: 4 + 5 + 10 = 19

Difference: |4 - 19| = 15

#### Note:
|x| is the [absolute value](https://www.mathsisfun.com/numbers/absolute-value.html) of x
