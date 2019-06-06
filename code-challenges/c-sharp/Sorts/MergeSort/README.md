# Merge Sort

## Challenge

In this challenge I implemented a merge sort algorithm written in C#. The algorithm consists of two methods, `MergeSort()` and `Merge()`. `MergeSort()` takes an integer array as input, divides in half, copies the halves into two subarrays, and recursively performs the same division and copying actions on increasingly small subarrays until the subarrays consist of only one element each. Then `MergeSort()` calls the `Merge()` method on the subarrays, which performs comparison logic on the individual subarrays and sorts their values and then merges the sorted values into larger subarrays until it produces a sorted array of the original input array's size and then returns the sorted array.


## Approach & Efficiency

The approach I took in my merge sort algorithm has the following time and space efficiencies:

Time: O(n log n)

Space: O(n)
