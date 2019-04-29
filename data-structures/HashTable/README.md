# Hash Table

## Challenge

In this project I implemented a custom-built hash table written in C#. 


## Approach & Efficiency

### Time efficiency 
* Searching: O(1) on average, O(n) in worst case
* Adding new key:value pair: O(1) on average, O(n) in worse case

### Space efficiency

* O(n) on average, O(n) in worse case


## API

My Hashtable class has the following methods:

* `Hash()`: takes a key of type string as input and returns an integer-type hash of the key
* `Add()`: void method that takes a key and a value of type string as input and adds them to the hash table
* `Contains()`: takes a key of type string as input and returns boolean true or false depending on whether key is present in table
* `Get()`: takes a key of type string as input and returns a Node object containing the key:value pair corresponding to the key argument if the pair is present in the table, otherwise returns null
* `Print()`: void method that writes all key:value pairs in the table to the console
