> [Prepare](https://www.hackerrank.com/dashboard) > [Algorithms](https://www.hackerrank.com/domains/algorithms) > 
[Warmup](https://www.hackerrank.com/domains/algorithms/warmup) > [Plus Minus](https://www.hackerrank.com/challenges/plus-minus/problem)
# Plus Minus

### Problem
Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero. 
Print the decimal value of each fraction on a new line with **6** places after the decimal.

**Note**: This challenge introduces precision problems. The test cases are scaled to six decimal places, 
though answers with absolute error of up to **10<sup>-4</sup>** are acceptable.

#### Example
$arr = [1, 1, 0, -1, -1]$ <br/>
There are **n = 5** elements, two positive, two negative and one zero. 
Their ratios are $\frac{2}{5} = 0.400000$, $\frac{2}{5} = 0.400000$ and $\frac{1}{5} = 0.200000$.
Results are printed as:
```
0.400000
0.400000
0.200000
```

#### Function Description
Complete the `plusMinus` function in the editor below. <br/>
`plusMinus` has the following parameter(s):
- `int` **arr[n]**: an array of integers

#### Print
Print the ratios of positive, negative and zero values in the array. Each value should be printed 
on a separate line with **6** digits after the decimal. The function should not return a value.

#### Input Format
The first line contains an integer, _**n**_, the size of the array. <br/>
The second line contains _**n**_ space-separated integers that describe _**arr[n]**_.

#### Constraints
```math
\begin{flalign}
& 0 \lt n \leq 100 \\
& -100 \leq arr[i] \leq 100 &
\end{flalign}
```

#### Output Format
**Print** the following **3** lines, each to **6** decimals:
1. proportion of positive values
2. proportion of negative values
3. proportion of zeros

#### Sample Input
```text
STDIN           Function
-----           --------
6               arr[] size n = 6
-4 3 -9 0 4 1   arr = [-4, 3, -9, 0, 4, 1]
```

#### Sample Output
```text
0.500000
0.333333
0.166667
```

#### Explanation
There are **3** positive numbers, **2** negative numbers, and **1** zero in the array.<br/>
The proportions of occurrence are positive: $\frac{3}{6} = 0.500000$, 
negative: $\frac{2}{6} = 0.333333$ and zeros: $\frac{1}{6} = 0.166667$.
