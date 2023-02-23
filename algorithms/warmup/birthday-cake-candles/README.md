> [Prepare](https://www.hackerrank.com/dashboard) > [Algorithms](https://www.hackerrank.com/domains/algorithms) > 
[Warmup](https://www.hackerrank.com/domains/algorithms/warmup) > [Birthday Cake Candles](https://www.hackerrank.com/challenges/birthday-cake-candles/problem)
# Birthday Cake Candles

### Problem
You are in charge of the cake for a child's birthday. You have decided the cake will have one candle for each year of their total age. 
They will only be able to blow out the tallest of the candles. Count how many candles are tallest.

#### Example
**candles = [4, 4, 1, 3]**

The maximum height candles are **4** units high. There are **2** of them, so return **2**.

#### Function Description
Complete the function `birthdayCakeCandles` in the editor below. <br/>
`birthdayCakeCandles` has the following parameter(s):
- `int` **candles[n]**: the candle heights

#### Returns
`int`: the number of candles that are tallest

#### Input Format
The first line contains a single integer, _**n**_, the size of _**candles[]**_.
The second line contains _**n**_ space-separated integers, where each integer _**i**_ describes the height of _**candles[i]**_.

#### Constraints
- $1 \leq n \leq 10^5$
- $1 \leq candles[i] \leq 10^7$

#### Sample Input
```text
4
3 2 1 3
```

#### Sample Output
```text
2
```

#### Explanation
Candle heights are **[3, 2, 1, 3]**. The tallest candles are **3** units, and there are **2** of them.
