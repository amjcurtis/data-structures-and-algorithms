# Singly Linked List
*Author: Andrew Curtis*

## Challenge

Create a console app that implements a singly linked list based on two classes. Make a `Node` class that has properties for the value stored in the node as well as a pointer to the next node. Make a `LinkedList` class that includes a head property and several methods. Upon instantiation, an empty linked list should be created. The methods should include:

1. A method called Insert() that takes an integer as an argument and adds a new node with that value to the head of the list with an O(1) Time performance.

2. A method called Includes() that takes an integer as an argument and returns a boolean result depending on whether that value exists as a node’s value anywhere within the list.

3. A method called Print() that takes in no arguments and returns a collection all of the current node values in the linked list.

4. A method called Append() that takes an integer as an argument and adds new node with that value to the end of the linked list.

5. A method called InsertBefore() that takes two integers as arguments and adds a new node whose value is the second integer argument to the list *before* the node whose value is the first integer argument. Returns boolean result depending on success of insertion. 

6. A method called InsertAfter() that takes two integers as arguments and adds a new node whose value is the second integer argument to the list *after* the node whose value is the first integer argument. Returns boolean result depending on success of insertion.

7. A method called GetKthNodeFromEnd() that takes an integer argument *k* and returns the *k*th node from the end of the list. 

## Approach & Efficiency

I implemented this project as a minimal approach to creating a singly linked list with a few useful methods available to it. 

#### Time and Space Complexity Analysis

* `Insert()` method
    * Big O Time: O(1)
    * Big O Space: O(1)
* `Includes()` method 
    * Big O Time: O(n)
    * Big O Space: O(1)
* `Print()` method 
    * Big O Time: O(n)
    * Big O Space: O(1)
* `Append()` method 
    * Big O Time: O(n)
    * Big O Space: O(1)
* `InsertBefore()` method 
    * Big O Time: O(n)
    * Big O Space: O(1)
* `InsertAfter()` method 
    * Big O Time: O(n)
    * Big O Space: O(1)
* `GetKthValueFromEnd()` method
    * Big O Time: O(n)
    * Big O Space: O(1)

## API

#### `public class LList` 

The `LList` class includes public properties `Head` and `Current` for the nodes in the linked list. It also includes the following public methods: 

1. `Insert()`: Takes `int`-type argument "value," returns `void`. Inserts new node at _beginning_ of linked list.
2. `Includes()`: Takes `int`-type argument "value," returns `bool`. Tests whether linked list includes any instances of the specified value.
3. `Print()`: Takes no arguments, returns integer array (`int[]`) containing values of all nodes in the linked list.
4. `Append()`: Takes `int`-type argument "value," returns `void`. Adds new node to end of list.
5. `InsertBefore()`: Takes two `int`-type arguments "existingNodeValue" and "newNodeValue," returns `bool`. Inserts new node before specified node.
6. `InsertAfter()`: Takes two `int`-type arguments "existingNodeValue" and "newNodeValue," returns `bool`. Inserts new node after specified node.
7. `GetKthNodeFromEnd()`: Takes `int`-type argument "k" and returns node at *k*th position from end of list.

#### `public class Node` 

The `Node` class includes public Node properties for `Value` (type `int`) and `Value` (type `Node`). It also includes a constructor for the `Node` object.


## Change Log

#### `v1.1`
* `2019-03-25`: Added Node and LList classes and methods Insert(), Includes(), and Print() and corresponding unit tests.

#### `v1.2`
* `2019-03-26`: Added Append(), InsertBefore(), InsertAfter() methods and corresponding unit tests.

#### `v1.3`
* `2019-03-27`: Added GetKthNodeFromEnd() method and corresponding unit tests.


## Initial Whiteboard Planning for Linked List Methods

* [Insert Methods](https://github.com/amjcurtis/data-structures-and-algorithms/blob/ll_insertions/assets/ll_insertions.JPG)

* [Get *k*th Node from End](../../assets/linked-list_kth-from-end.jpeg)
