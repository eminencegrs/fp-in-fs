namespace FPinFSharp.Exercises.Chapter_01

open System;

module Exercises =

    // 1.1 Declare a function g: int -> int, where g(n) = n + 4.
    let gFunc (n: int) =
        n + 4

    // 1.2 Declare a function h: float * float -> float, where h(x, y) = sqrt(x^2 + y^1).
    let hFunc (x: float, y: float) =
        Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2))

    // 1.3 Write function expressions corresponding to the functions g and h in the exercises 1.1 and 1.2.
    let gExpr (n: int) =
        let expression = fun n -> n + 4
        expression n

    let hExpr (x, y) =
        let expression = fun (x, y) -> Math.Sqrt(Math.Pow(x, 2.0) + Math.Pow(y, 2.0))
        expression(x, y)

    // 1.4 Declare a recursive function f: int -> int, where f(n) = 1 + 2 + ... + (n − 1) + n, for n >= 0
    let rec f (n: int) =
        match n with
        | 0 -> 0
        | n -> f(n - 1) + n

    // 1.5 The sequence F0, F1, F2 ... of Fibonacci numbers is defined by:
    // --> F0 = 0
    // --> F1 = 1
    // --> Fn = Fn−1 + Fn−2
    // Declare a function to compute Fn.
    let rec fibonacci (n: int) =
        match n with
        | 0 -> 0
        | 1 -> 1
        | n -> fibonacci(n - 2) + fibonacci(n - 1)

    // 1.6 Declare a recursive function sum: int * int -> int, where
    // sum(m, n) = m + (m + 1) + (m + 2) + · · · + (m + (n − 1)) + (m + n) for m ≥ 0 and n ≥ 0.
    // (Hint: use two clauses with (m,0) and (m,n) as patterns.)
    // Give the recursion formula corresponding to the declaration.
    let rec sum (m: int, n: int) =
        match (m, n) with
        | m, 0 -> m
        | m, n -> (m + n) + sum(m, n - 1)

    // 1.7 Determine a type for each of the expressions:
    // --> (System.Math.PI, fact -1)
    // --> fact(fact 4)
    // --> power(System.Math.PI, fact 2)
    // --> (power, fact) *)

    // 1.8 Consider the following declarations,
    // find the environment obtained from these declarations and
    // write the evaluations of the expressions f 3 and g 3.
    let func () =
        let a = 5
        let f a = a + 1
        let g b = (f b) + a
        (f 3, g 3)

    // Explanation:
    // --> a is set to 5.
    // --> (f 3) evaluates to 3 + 1, which is 4.
    // --> (g 3) evaluates to (f 3) + a, which is 4 + 5, resulting in 9.
