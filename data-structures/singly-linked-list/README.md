# Singly Linked List
*Author: Andrew Curtis*

## Challenge

Create a console app that implements a singly linked list based on two classes. Make a `Node` class that has properties for the value stored in the node as well as a pointer to the next node. Make a `LinkedList` class that includes a head property and three methods. Upon instantiation, an empty linked list should be created. The three methods should include:

1. A method called Insert() which takes any value as an argument and adds a new node with that value to the head of the list with an O(1) Time performance.

2. A method called Includes() which takes any value as an argument and returns a boolean result depending on whether that value exists as a node’s value anywhere within the list.

3. A method called Print() which takes in no arguments and returns a collection all of the current node values in the linked list.


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


## API

#### `public class LList` 

The `LList` class includes public properties `Head` and `Current` for the nodes in the linked list. It also includes the following public methods: 

1. `Insert()`: Takes `int`-type argument "value", returns `void`. Inserts new node at _beginning_ of linked list.
2. `Includes()`: Takes `int`-type argument "value", return `bool`. Tests whether linked list includes any instances of the specified value.
3. `Print()`: Takes no arguments, returns integer array (`int[]`) containing values of all nodes in the linked list.

#### `public class Node` 

The `Node` class includes public Node properties for `Value` (type `int`) and `Value` (type `Node`). It also includes a constructor for the `Node` object.
