# Binary Search of an Array

## Challenge

Write a static method called BinarySearch that takes in two parameters: a sorted array and a 
search key. Without utilizing any of the built-in methods available to in your language, 
return the index of the array's element that is equal to the search key, or -1 if the 
element is not present in the array.

## Approach & Efficiency

I used an iterative approach to implementing my binary search algorithm. It returns the index of the first matching array element even if duplicate elements are included in the array. 

1. Worst-case performance: Big O Time = O(log *n*)
2. Best-case performance: Big O Time = O(1)
3. Average performance: Big O Time = O(log *n*)
4. Worst-case space complexity: Big O Space Complexity: O(1)

I got my initial understanding of binary search's Big O performance from Wikipedia's article ["Binary Search Algorithm"](https://en.wikipedia.org/wiki/Binary_search_algorithm).

## Solution

![Binary Search Whiteboard Solution](https://github.com/amjcurtis/data-structures-and-algorithms/blob/master/assets/binary-search-whiteboard.JPG)