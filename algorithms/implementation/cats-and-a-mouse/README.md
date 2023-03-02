> [Prepare](https://www.hackerrank.com/dashboard) > [Algorithms](https://www.hackerrank.com/domains/algorithms) > 
[Implementation](https://www.hackerrank.com/domains/algorithms/implementation) > [Cats and a Mouse](https://www.hackerrank.com/challenges/cats-and-a-mouse/problem)
# Cats and a Mouse

### Problem
Two cats and a mouse are at various positions on a line. You will be given their starting positions. 
Your task is to determine which cat will reach the mouse first, assuming the mouse does not move and the cats travel at equal speed. 
If the cats arrive at the same time, the mouse will be allowed to move and it will escape while they fight.

You are given _**q**_ queries in the form of _**x**_, _**y**_, and _**z**_ representing the respective positions 
for cats _**A**_ and _**B**_, and for mouse _**C**_.<br/>
Complete the function `catAndMouse` to return the appropriate answer to each query, which will be printed on a new line.
- If cat _**A**_ catches the mouse first, print `Cat A`.
- If cat _**B**_ catches the mouse first, print `Cat B`.
- If both cats reach the mouse at the same time, print `Mouse C` as the two cats fight and mouse escapes.

#### Example
**_x_ = 2**<br/>
**_y_ = 5**<br/>
**_z_ = 4**<br/>
The cats are at positions **2** (Cat A) and **5** (Cat B), and the mouse is at position **4**. Cat B, at position **5** will 
arrive first since it is only **1** unit away while the other is **2** units away. Return `Cat B`.

#### Function Description
Complete the `catAndMouse` function in the editor below.

`catAndMouse` has the following parameter(s):
- `int` **x**: Cat **A**'s position
- `int` **y**: Cat **B**'s position
- `int` **z**: Mouse **C**'s position

#### Returns
- `string`: Either `Cat A`, `Cat B`, or `Mouse C`

#### Input Format
The first line contains a single integer, _**q**_, denoting the number of queries.<br/>
Each of the _**q**_ subsequent lines contains three space-separated integers describing the respective values of _**x**_ (cat _**A**_'s location),
_**y**_ (cat _**B**_'s location), and _**z**_ (mouse _**C**_'s location).

#### Constraints
- $1 \leq q \leq 100$
- $1 \leq x, y, z \leq 100$

#### Sample Input
```
2
1 2 3
1 3 2
```

#### Sample Output
```
Cat B
Mouse C
```

#### Explanation
**Query 0**: The positions of the cats and mouse are shown below:<br/>
![cat.png](https://s3.amazonaws.com/hr-challenge-images/0/1480434477-7418fccf34-cat.png) <br/>
Cat **B** will catch the mouse first, so we print `Cat B` on a new line.

**Query 1**: In this query, cats **A** and **B** reach mouse **C** at the exact same time:<br/>
![cat1.png](https://s3.amazonaws.com/hr-challenge-images/0/1480434557-601bef86ba-cat1.png) <br/>
Because the mouse escapes, we print `Mouse C` on a new line.
