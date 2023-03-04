> [Prepare](https://www.hackerrank.com/dashboard) > [Algorithms](https://www.hackerrank.com/domains/algorithms) > 
[Implementation](https://www.hackerrank.com/domains/algorithms/implementation) > [Grading Students](https://www.hackerrank.com/challenges/grading/problem)
# Grading Students

### Problem
HackerLand University has the following grading policy:<br/>
- Every student receives a _**grade**_ in the inclusive range from **0** to **100**.
- Any _**grade**_ less than **40** is a failing grade.

Sam is a professor at the university and likes to round each student's _**grade**_ according to these rules:
- If the difference between the _**grade**_ and the next multiple of **5** is less than **3**, round _**grade**_ up to the next multiple of **5**.
- If the value of _**grade**_ is less than **38**, no rounding occurs as the result will still be a failing grade.

#### Example
**_grade_ = 84** round to **85** (85 - 84 is less than 3)<br/>
**_grade_ = 29** do not round (result is less than 40)<br/>
**_grade_ = 57** do not round (60 - 57 is 3 or higher)<br/>
Given the initial value of _**grade**_ for each of Sam's **n** students, write code to automate the rounding process.

#### Function Description
Complete the function `gradingStudents` in the editor below.

`gradingStudents` has the following parameter(s):
- `int` **grades[n]**: the grades before rounding

#### Returns
- `int[n]`: the grades after rounding as appropriate

#### Input Format
The first line contains a single integer, **n**, the number of students.<br/>
Each line **i** of the **n** subsequent lines contains a single integer, _**grades[i]**_.

#### Constraints
- $1 \leq n \leq 60$
- $0 \leq grades[i] \leq 100$

#### Sample Input
```
4
73
67
38
33
```

#### Sample Output
```
75
67
40
33
```

#### Explanation
![curving2.png](https://s3.amazonaws.com/hr-challenge-images/0/1484768684-54439977a1-curving2.png)<br/>
1. Student **1** received a **73**, and the next multiple of **5** from **73** is **75**. Since **75 - 73 &lt; 3**, the student's grade is rounded to **75**.
2. Student **2** received a **67**, and the next multiple of **5** from **67** is **70**. Since **70 - 67 = 3**, the grade will not be modified and the student's final grade is **67**.
3. Student **3** received a **38**, and the next multiple of **5** from **38** is **40**. Since **40 - 38 &lt; 3**, the student's grade will be rounded to **40**.
4. Student **4** received a grade below **33**, so the grade will not be modified and the student's final grade is **33**.
