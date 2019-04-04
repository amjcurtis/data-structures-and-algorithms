# First In, First Out Animal Shelter

## Challenge

For this challenge I created a .NET Core console app that implements a queue data structure and uses it to model an animal shelter that operates with a *first in, first out* approach. It has an `Enqueue(animal)` method that takes an `animal` as an argument and adds (enqueues) it to the shelter queue. `animal` can be either a `"dog"` or a `"cat"` object. The app also has a `Dequeue(pref)` method that takes `pref` (preferred animal) as an argument and returns either a dog or a cat object, or, if `pref` is neither a dog nor a cat, it returns `null`.

## Approach & Efficiency

The approach I took has an efficiency of O(1) time for the `Enqueue()` method and O(n) time for the `Dequeue()` method.

## Solution

![Whiteboard Planning](https://github.com/amjcurtis/data-structures-and-algorithms/blob/fifo_animal_shelter/assets/fifo-animal-shelter.JPG)