# Stacks and Queues
*Author: Andrew Curtis*

## Challenge

This challenge involved creating a console app that implements hand-built stack and queue data structures. 


## Approach & Efficiency

In implementing my solution to this challenge, I made both my stack and queue of *generic* type (`<T>`). This allows a range of data types to be passed inin as values for the nodes. 

### Algorithm Efficiency

The time complexity of all of the stack and queue methods below is O(1). 

#### Stack
* `Push()`
* `Pop()`
* `Peek()`

#### Queue
* `Enqueue()`
* `Dequeue()`
* `Peek()`

## API

#### Stack
* `Push()`: Creates new node containing user-specified value and adds it to top of stack.
* `Pop()`: Removes top node from stack and returns it from the method.
* `Peek()`: Returns top node on stack without removing or modifying it in any way. 

#### Queue
* `Enqueue()`: Creates new node containing user-specified value and adds it to end of queue.
* `Dequeue()`: Removes front node from queue and returns is from the method.
* `Peek()`: Returns top node on stack without removing or modifying it in any way.


## Change Log

#### `v1.1`

`2019-03-31`-`2019-04-01`: Built out classes, added documentation
