> [Prepare](https://www.hackerrank.com/dashboard) > [Algorithms](https://www.hackerrank.com/domains/algorithms) > 
[Warmup](https://www.hackerrank.com/domains/algorithms/warmup) > [A Very Big Sum](https://www.hackerrank.com/challenges/a-very-big-sum/problem)
# A Very Big Sum

### Problem
In this challenge, you are required to calculate and print the sum of the elements in an array, 
keeping in mind that some of those integers may be quite large.

#### Function Description
Complete the `aVeryBigSum` function in the editor below. It must return the sum of all array elements. <br/>
`aVeryBigSum` has the following parameter(s):
- `int` **ar[n]**: an array of integers.

#### Return
- `long`: the sum of all array elements

#### Input Format
The first line of the input consists of an integer _**n**_. <br/>
The next line contains _**n**_ space-separated integers contained in the array.

#### Output Format
Return the integer sum of the elements in the array.

#### Constraints
```math
\begin{flalign}
& 1 \leq n \leq 10 \\
& 0 \leq ar[i] \leq 10^{10} &
\end{flalign}
```

#### Sample Input
```text
5
1000000001 1000000002 1000000003 1000000004 1000000005
```

#### Sample Output
```text
5000000015
```

#### Note:
The range of the 32-bit integer is **(-2<sup>31</sup>)** to **(2<sup>31</sup> - 1)** or **[-2147483648, 2147483647]**. <br/>
When we add several integer values, the resulting sum might exceed the above range. 
You might need to use long int C/C++/Java to store such sums.
