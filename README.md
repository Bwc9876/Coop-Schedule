# Co-op Scheduler
An application that can be used to schedule students into units.

## Problem Statement

Each student needs to be scheduled into a unit for a specific number of days.

Once a student is put in a unit for one day, they cannot be placed in that unit again.

A unit can only take a vertain number of students per-day.

## Solution

This problem can be solved using wave function collapse, a procedural generation algorithm that abides by specific constaints.

Let's imagine the schedule as a table, where each element represents the possible units a student can be in.

|               | **Day 1** | **Day 2** |
|---------------|-----------|-----------|
| **Student 1** | UNIT      | UNIT      |
| **Student 2** | UNIT      | UNIT      |

Let's also imagine that we have 2 units, A and B. Each of these can only have one student.

To repesent the possible state of an element we use a boolean array, where each index corresponds to a unit and each value determines whether that unit is a valid state for the element.

So if an element can be any unit, it would be [True, True]  
If it can't be any (contradictory state), it would be [False, False]  
If it can only be A, then it would be [True, False]  
And if it was B it would be [False, True]  

These boolean arrays will be repesented as binary numbers, each boolean corresponds to the bit in the number.

So if an element can be any unit it would be 3 (because 11₂ = 3)  
If it can't be any is would be 0 (because 00₂ = 0)  
If it can only be A, then it would be 2 (because 10₂ = 2)  
And if it was B it would be 1 (becuase 01₂ = 1)  

We represent the elements like this because we can utilize bitwise operations to save on time.  


We first setup the table in a completely unobserved state, that is, every element can be any unit:

|               | **Day 1** | **Day 2** |
|---------------|-----------|-----------|
| **Student 1** | 3         | 3         |
| **Student 2** | 3         | 3         |

Next we need to choose which element we want to observe first, we do this by calculating the [shannon entropy](https://en.wikipedia.org/wiki/Entropy_(information_theory)) of each element and taking the lowest non-zero one. If they're all the same, we just grab whichever we find first.  

Collapsing an element means picking one of the states it can be and forcing it to only be that state.

So lets say we picked the element (0, 0) to observe, we see that it can be either A or B, so we randomly pick which one we want it to be.  

Lets say we choose B, now our table will look something like this:

|               | **Day 1** | **Day 2** |
|---------------|-----------|-----------|
| **Student 1** | 1         | 3         |
| **Student 2** | 3         | 3         |

But wait! now that (0, 0) is B, we know that (1, 0) and (0, 1) both can't be B!

This is where the constain stage comes in, once we observe an element we look in the row and column of that element and restrict the elements in that row accordingly.  

So for (1, 0) we know that a unit can only appear in a row once, so we'll limit the element to 10₂ (2).  

For (0, 1) we know that unit B only allows for one student per-day, therefore we should limit to 10₂ as well.

Now because we have such a small table and only two units, these can only be A, however in larger datasets these won't always be constrained to a single state.

So now we have the following table:

|               | **Day 1** | **Day 2** |
|---------------|-----------|-----------|
| **Student 1** | 1         | 2         |
| **Student 2** | 2         | 3         |

The next element that has the lowest non-zero shannon entropy is (1, 1), this can only be one value, B.


|               | **Day 1** | **Day 2** |
|---------------|-----------|-----------|
| **Student 1** | 1         | 2         |
| **Student 2** | 2         | 1         |

We've successfully observed all elements of the table!  

One last thing, we need to be able to remember what units a student for subsequent generations, this is simply achieved by constraining the elements before collapsing any.

Doing this, however, can result in a student not being able to be in any unit. This is called a contradictory state.

## Screenshots

![Main App](https://user-images.githubusercontent.com/25644444/190924859-c55535fc-5d1b-4f08-9e1b-620b4060b335.png)

![Table Generated From App](https://user-images.githubusercontent.com/25644444/190924870-9a56f4f0-6fb2-49e3-a50e-caa64f550aab.png)

## Works Cited

Gumin, M. (2016). Wave Function Collapse Algorithm (Version 1.0) [Computer software]. https://github.com/mxgmn/WaveFunctionCollapse  
Wave function collapse. (2022, September 8). In Wikipedia. https://en.wikipedia.org/wiki/Wave_function_collapse  
Entropy (information theory). (2022, September 8). In Wikipedia. https://en.wikipedia.org/wiki/Entropy_(information_theory)  
