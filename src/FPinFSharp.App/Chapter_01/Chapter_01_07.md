### 1.7 Bindings and environments

Identifiers can be bound to denote an integer, a floating-point value, a pair or a function.
The notions of binding and environment are used to explain that entities are bound by identifiers.
The execution of a declaration, say `let x = e`, causes the identifier `x` to be bound to the value of the expression `e`.
For example, the execution of the declaration:
```fsharp
let a = 3;;
val a : int = 3
```
causes the identifier `a` to be bound to `3`. This binding is denoted by `a -> 3`.
Execution of further declarations gives extra bindings. For example, execution of
```fsharp
let b = 7.0;;
val b : float = 7.0
```
gives a further binding `b -> 7.0`.

A collection of bindings is called an environment, and the environment `env1` obtained 
from execution of the above two declarations is denoted by:
```fsharp
env1 =
[
    { a -> 3 }
    { b -> 7.0 }
]
```
Note that this notation is not part of any program.
Bindings and environments are mathematical objects used to explain the meaning of programs.
The execution of an additional declaration causes an extension of `env1`. For example:
```fsharp
let c = (2, 8);;
val c : int * int = (2, 8)

let circleArea r = System.Math.PI * r * r;;
val circleArea : float -> float
```
adds bindings of the identifiers `c` and `circleArea` to the environment `env1` giving the environment `env2`:
```fsharp
env2 =
[
    { a             -> 3                            }
    { b             -> 7.0                          }
    { c             -> (2, 8)                       }
    { circleArea    -> "the circle area function"   }
]
```

The value of an expression is always evaluated in the actual environment, 
that contains the bindings of identifiers that are valid at evaluation time. 
When the F# system is activated, the actual environment is the Basis Environment 
that gives meanings to /, +, -, sqrt, for example. 
When using environments we will usually not show bindings from the Basis Environment. 
We will usually also omit bindings of identifiers like System.Math.PI from the Library.


"Functional Programming Using F#" &copy; Michael R. Hansen and Hans Rischel, 2013