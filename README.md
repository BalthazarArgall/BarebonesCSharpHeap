# Barebones C# Heap
This is a List based implementation of a Heap in C#. The features are barebones because I dont need them yet but I may expand it and maybe make it implement some interfaces from System.

This Heap is completely generic, very lightweight and (SHOULD BE) performant. Hopefully it is clear and easy to understand too.

It is abstract, you'll have to make a concrete implementation for it first.

Some concrete implementation examples can be found in the Examples folder and showcase how easily you can make any kind of Heap, min, max, generic or not.

Basically, the only thing you have to do is give a definition of how an item T is better than another, if T is better because its value is lower you got yourself a Minheap.
