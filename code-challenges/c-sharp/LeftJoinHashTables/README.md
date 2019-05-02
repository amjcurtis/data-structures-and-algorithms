# Hash Table LEFT JOIN

## Challenge

In this challenge I wrote a C# console app containing a method called `LeftJoin()`. The method takes two hash tables as inputs and returns a generic list of arrays. Each array in the list contains a key as well as the corresponding values from the left and right tables (or the value from the left table and a NULL string if the right table does not contain that key).

My solution uses my own custom implementations of the hash table data structure. 

## Approach & Efficiency

### Time Efficiency

* Hash table lookup
	* O(1)

* Traversal of all rows in hash table
	* O(n)

### Space Efficiency

* Hash table
	* O(n)

* Creation of list of arrays
    * O(n)

## Solution
I collaborated with [Alexander White](https://github.com/AlexWhitey)
on the first-take whiteboard planning for the `LeftJoin()` method.

![Initial whiteboard planning for LeftJoin](https://github.com/amjcurtis/data-structures-and-algorithms/blob/left-join-hash-tables/assets/left-join-hash-tables.jpg)
