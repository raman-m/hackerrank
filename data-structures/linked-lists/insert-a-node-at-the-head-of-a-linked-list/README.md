> [Prepare](https://www.hackerrank.com/dashboard) > [Data Structures](https://www.hackerrank.com/domains/data-structures) > 
[Linked Lists](https://www.hackerrank.com/domains/data-structures/linked-lists) > [Insert a node at the head of a linked list](https://www.hackerrank.com/challenges/insert-a-node-at-the-head-of-a-linked-list/problem)
# Insert a node at the head of a linked list

### Problem
<sub><sup>This challenge is part of a tutorial track by [MyCodeSchool](https://www.youtube.com/mycodeschool) 
and is accompanied by a [video lesson](https://www.youtube.com/playlist?list=PL2_aWCzGMAwI3W_JlcBbtYTwiQSsOTa6P).</sup></sub>

Given a pointer to the head of a linked list, insert a new node before the head. 
The **next** value in the new node should point to **head** and the **data** value should be replaced with a given value. 
Return a reference to the new head of the list. The head pointer given may be null meaning that the initial list is empty.

#### Function Description
Complete the function `insertNodeAtHead` in the editor below.

`insertNodeAtHead` has the following parameter(s):
- `SinglyLinkedListNode` **llist**: a reference to the head of a list
- **data**: the value to insert in the **data** field of the new node

#### Input Format
The first line contains an integer **n**, the number of elements to be inserted at the head of the list.<br/>
The next **n** lines contain an integer each, the elements to be inserted, one per function call.

#### Constraints
- **1 &le; n &le; 1000**
- **1 &le; list[i] &le; 1000**

#### Sample Input
```
5
383
484
392
975
321
```

#### Sample Output
```
321
975
392
484
383
```

#### Explanation
Initially the list is **NULL**. After inserting **383**, the list is **383 &rarr; NULL**.<br/>
After inserting **484**, the list is **484 &rarr; 383 &rarr; NULL**.<br/>
After inserting **392**, the list is **392 &rarr; 484 &rarr; 383 &rarr; NULL**.<br/>
After inserting **975**, the list is **975 &rarr; 392 &rarr; 484 &rarr; 383 &rarr; NULL**.<br/>
After inserting **321**, the list is **321 &rarr; 975 &rarr; 392 &rarr; 484 &rarr; 383 &rarr; NULL**.
