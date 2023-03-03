> [Prepare](https://www.hackerrank.com/dashboard) > [Algorithms](https://www.hackerrank.com/domains/algorithms) > 
[Implementation](https://www.hackerrank.com/domains/algorithms/implementation) > [Repeated String](https://www.hackerrank.com/challenges/repeated-string/problem)
# Repeated String

### Problem
There is a string, **s**, of lowercase English letters that is repeated infinitely many times. 
Given an integer, **n**, find and print the number of letter `a`'s in the first **n** letters of the infinite string.

#### Example
**_s_ = 'abcac'**<br/>
**_n_ = 10**<br/>
The substring we consider is **abcacabcac**, the first **10** characters of the infinite string. 
There are **4** occurrences of `a` in the substring.

#### Function Description
Complete the `repeatedString` function in the editor below.

`repeatedString` has the following parameter(s):
- `string` **s**: a string to repeat
- `int` **n**: the number of characters to consider

#### Returns
- `int`: the frequency of `a` in the substring

#### Input Format
The first line contains a single string, **s**.<br/>
The second line contains an integer, **n**.

#### Constraints
- $1 \leq |s| \leq 100$
- $1 \leq n \leq 10^{12}$
- For $25%$ of the test cases, $n \leq 10^6$.

#### Sample Input 0
```
aba
10
```

#### Sample Output 0
```
7
```

#### Explanation 0
The first **n = 10** letters of the infinite string are `abaabaabaa`. Because there are **7** `a`'s, we return **7**.

#### Sample Input 1
```
a
1000000000000
```

#### Sample Output 1
```
1000000000000
```

#### Explanation 1
Because all of the first **n = 1000000000000** letters of the infinite string are `a`, we return **1000000000000**.
