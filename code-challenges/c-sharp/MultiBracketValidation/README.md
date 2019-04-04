# Multi-Bracket Validation Using Stacks

## Challenge

For this challenge I created a .NET Core console app that uses the stack data structure to test whether the bracket characters in a given string are "balanced," i.e. whether every opening bracket has a corresponding closing bracket and vice versa.

I wrote a function that takes a string as its only argument and returns a boolean representing whether or not the brackets in the string are balanced. There are 3 types of brackets:

1. Round Brackets (parentheses): `()`
2. Square Brackets: `[]`
3. Curly Brackets: `{}`

## Approach & Efficiency

The approach I followed for implementing my stack data structure has a time and space efficiencies of O(1).

## Solution

![Whiteboard Planning](https://github.com/amjcurtis/data-structures-and-algorithms/blob/fifo_animal_shelter/assets/multi_bracket_validation.JPG)

## Attribution

I got the idea of using a single stack to push to and pop from from a conversation with Andrew Roska ([Roketsu86](https://github.com/Roketsu86)). The code of my implementation is all my own, however. 
