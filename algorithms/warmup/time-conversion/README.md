> [Prepare](https://www.hackerrank.com/dashboard) > [Algorithms](https://www.hackerrank.com/domains/algorithms) > 
[Warmup](https://www.hackerrank.com/domains/algorithms/warmup) > [Time Conversion](https://www.hackerrank.com/challenges/time-conversion/problem)
# Time Conversion

### Problem
Given a time in [**12**-hour AM/PM format](https://en.wikipedia.org/wiki/12-hour_clock), convert it to military (24-hour) time.<br/>
**Note**: - 12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.<br/>
- 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.

#### Example
- **s = '12:01:00PM'**
  Return '12:01:00'.
- **s = '12:01:00AM'**
  Return '00:01:00'.

#### Function Description
Complete the `timeConversion` function in the editor below. It should return a new string representing the input time in 24 hour format. <br/>
`timeConversion` has the following parameter(s):
- `string` **s**: a time in **12** hour format

#### Returns
`string`: the time in 24 hour format

#### Input Format
A single string _**s**_ that represents a time in **12**-hour clock format (i.e.: **hh:mm:ssAM** or **hh:mm:ssPM**).

#### Constraints
- All input times are valid

#### Sample Input
```text
07:05:45PM
```

#### Sample Output
```text
19:05:45
```
