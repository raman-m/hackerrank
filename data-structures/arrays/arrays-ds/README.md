> [Prepare](https://www.hackerrank.com/dashboard) > [Data Structures](https://www.hackerrank.com/domains/data-structures) > 
[Arrays](https://www.hackerrank.com/domains/data-structures/arrays) > [Arrays - DS](https://www.hackerrank.com/challenges/arrays-ds/problem)
# Arrays - DS

### Problem
An array is a type of data structure that stores elements of the same type in a contiguous block of memory. 
In an array, _**A**_, of size _**N**_, each memory location has some unique index, **i** (where _**0 &le; i &lt; N**_), 
that can be referenced as _**A[i]**_ or _**A<sub>i</sub>**_.

Reverse an array of integers.
**Note**: If you've already solved our C++ domain's Arrays Introduction challenge, you may want to skip this.

#### Example
**_A_ = [1, 2, 3]** <br/>
Return **[3, 2, 1]**.

#### Function Description
Complete the function `reverseArray` in the editor below.

`reverseArray` has the following parameter(s):
- `int` **A[n]**: the array to reverse

#### Returns
- `int[n]`: the reversed array

#### Input Format
The first line contains an integer, **N**, the number of integers in **A**.<br/>
The second line contains **N** space-separated integers that make up **A**.

#### Constraints
- $1 \leq N \leq 10^3$
- $1 \leq A[i] \leq 10^4$, where **A[i]** is **i<sup>th</sup>** integer in **A**

#### Sample Input
<svg width="100pt" height="70pt" viewBox="0.00 0.00 100.00 69.80" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink">
<g id="graph0" class="graph" transform="scale(1 1) rotate(0) translate(4 65.8)">
	<title>G</title>
	<text text-anchor="middle" x="46" y="-8.2" font-family="Times,serif" font-size="14.00" fill="#000000">Array: arr</text>
	<g id="node1" class="node">
		<title>node1</title>
		<polygon fill="none" stroke="#000000" points="0,-25.3 0,-61.3 92,-61.3 92,-25.3 0,-25.3"></polygon>
		<text text-anchor="middle" x="11.5" y="-39.1" font-family="Times,serif" font-size="14.00" fill="#000000">1</text>
		<polyline fill="none" stroke="#000000" points="23,-25.3 23,-61.3 "></polyline>
		<text text-anchor="middle" x="34.5" y="-39.1" font-family="Times,serif" font-size="14.00" fill="#000000">4</text>
		<polyline fill="none" stroke="#000000" points="46,-25.3 46,-61.3 "></polyline>
		<text text-anchor="middle" x="57.5" y="-39.1" font-family="Times,serif" font-size="14.00" fill="#000000">3</text>
		<polyline fill="none" stroke="#000000" points="69,-25.3 69,-61.3 "></polyline>
		<text text-anchor="middle" x="80.5" y="-39.1" font-family="Times,serif" font-size="14.00" fill="#000000">2</text>
	</g>
</g>
</svg>

```
4
1 4 3 2
```

#### Sample Output
```
2 3 4 1
```
