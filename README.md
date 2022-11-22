
# Lists

With solving this problems, I practice working with Lists.

## Problem: Array Manipulator

Write a program that reads an array of integers from the console and set of commands and executes them over the array. The commands are as follows:

•	add <index> <element> – adds element at the specified index (elements right from this position inclusively are shifted to the right).

•	addMany <index> <element 1> <element 2> … <element n> – adds a set of elements at the specified index.

•	contains <element> – prints the index of the first occurrence of the specified element (if exists) in the array or -1 if the element is not found.

•	remove <index> – removes the element at the specified index.

•	shift <positions> – shifts every element of the array the number of positions to the left (with rotation).


•	sumPairs – sums the elements in the array by pairs (first + second, third + fourth, …).


•	print – stop receiving more commands and print the last state of the array.


### Example:
#### input:
1 2 4 5 6 7

add 1 8

contains 1

contains -3

print

#### output:
0

-1

[1, 8, 2, 4, 5, 6, 7]

## Problem: Bomb Numbers

Write a program that reads sequence of numbers and special bomb number with a certain power. Your task is to detonate every occurrence of the special bomb number and according to its power his neighbors from left and right. Detonations are performed from left to right and all detonated numbers disappear. Finally print the sum of the remaining elements in the sequence.

### Example:
#### input:
1 2 2 4 2 2 2 9

4 2

#### output:
12

## Problem: Longest Increasing Subsequence 

Read a list of integers and find the longest increasing subsequence. If several such exist, print the leftmost.

### Example:
#### input:
0 10 20 30 30 40 1 50 2 3 4 5 6
#### output:
0 1 2 3 4 5 6

## Problem: Max Sequence of Equal Elements

Read a list of integers and find the longest sequence of equal elements. If several exist, print the leftmost.

### Example:
#### input:
3 4 4 5 5 5 2 2
#### output:
5 5 5

## Problem: Sum Reversed Numbers

Write a program that reads sequence of numbers, reverses their digits, and prints their sum.

### Example:
#### input:
12 12 34 84 66 12
#### output:
220

## Problem: Sum Reversed Numbers Functional coding

Write a program that reads sequence of numbers, reverses their digits, and prints their sum.
Using only LINQ.




