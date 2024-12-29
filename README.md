# F# Mutability Misconception

This example demonstrates a common misconception about mutability in F#.  The `add` function calculates the sum of `x` and `y` *at the time of the call*.  Later modifications to `x` and `y` do not retroactively change the value of `z`.

**Key Concept:** Understanding the difference between passing values and passing references in F# functions and how immutability affects subsequent changes to mutable variables.