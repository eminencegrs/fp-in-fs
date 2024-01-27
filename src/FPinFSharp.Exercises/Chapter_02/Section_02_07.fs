namespace FPinFSharp.Exercises.Chapter_02

// 2.7 Functions are first-class citizens (higher-order functions)
module Section_02_07 =

    // # The value of a function can be a function.
    // Function application associates to the left.
    let addTwoNumbers m n =
        (+) m n

    let subtractTreeNumbers x y z =
        (-) ((-) x y) z

    // # The argument of a function can be a function.
    let increment =
        fun y -> y + 1

    let square =
        fun x -> x * x

    // Function composition operator
    let doubleIncrement =
        (fun y -> y + 1) >> (fun y -> y + 1)

    let squareAndIncrementLeftInfix =
        increment << square

    let incrementAndSquareLeftInfix =
        square << increment

    let squareAndIncrementRightInfix =
        square >> increment

    let incrementAndSquareRightInfix =
        increment >> square

    // # Declaration of higher-order functions.
    // If functions have first-class status, it is possible to pass them as arguments in the same way.
    // This is the first characteristic of higher-order functions.
    // The ability to send a function as an argument to another function underlies common abstractions
    // in functional programming languages, such as map or filter operations.

    // Define the function using lambda expression syntax.
    let apply =
        fun op arg -> op arg

    let applyOperation operationName arg =
        match operationName with
        | "increment" -> apply increment arg
        | "square" -> apply square arg
        | _ -> failwith "Unknown operation"
