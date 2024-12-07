# Uninitialized Property Access in C#

This example demonstrates a potential issue in C# where accessing a class property before it has been explicitly assigned a value can lead to unexpected results.  Uninitialized properties will have their default value (0 for integers, null for reference types, etc.). This might not be the intended behavior, potentially causing runtime errors or logical flaws.

## Steps to Reproduce
1. Compile and run the provided code in a C# environment.
2. Observe that the output might not be what you initially expect, as `MyProperty` has its default value before the `MyMethod` assigns a value to it.  

## Solution
Ensure that properties are initialized before they are accessed.  Consider initializing in the constructor or using null-conditional operators to handle potential null values if needed.