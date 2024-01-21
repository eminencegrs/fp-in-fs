namespace FPinFSharp.App.Chapter_01

// 1.5 Pairs.
module Chapter_01_05 =

    // Let's define a custom complex type that represent a point.
    type Point = { X: int; Y: int }

    // Let's define a function that accept Point and return a pair of coordinates X and Y.
    let getCoordinates (point: Point) =
        (point.X, point.Y)

    // Using these concepts we represent x^n as a function power with a pair (x, n) as the argument.
    // The following declaration is based on the above recursion formula, using composite patterns (x, 0) and (x, n).
    // Please, note: the order of the clauses in the declaration of power is significant. 
    let rec power (x: float, n: uint) =
        match x, n with
        | x, 0u -> 1.0
        | x, n -> x * power(x, n - 1u)   // for n > 0
