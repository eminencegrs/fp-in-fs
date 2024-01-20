namespace FPinFSharp.App

// This chapter introduces some of the main concepts of functional programming languages:
// the concepts of value, expression, declaration, recursive function and type.
// Also it introduces the notions: binding, environment and evaluation of expressions.
module Chapter_01 =

    // 1.1 Values, types, identifiers and declarations
    let double x =
        x * x

    // 1.2 Simple function declarations
    let calculateCircleAreaV1 (radius: int) =
        System.Math.PI * float (radius * radius)

    let calculateCircleAreaV2 (radius: int) =
        System.Math.PI * float (double radius)

    // 1.3 Anonymous functions. Function expressions
    let calculateCircleAreaV3 (radius: int) =
        let anonymousFunction = fun r -> System.Math.PI * r * r
        anonymousFunction radius

    let daysNumberByMonth (month: int) =
        match month with
        | 2                 -> 28
        | 4 | 6 | 9 | 11    -> 30
        | _                 -> 31

    // 1.4 Recursion
    // The evaluation of the expression fact 4 proceeds until a value is reached:
    // --> fact 4
    // --> 4 * fact(4 - 1)                      [1]
    // --> 4 * fact 3                           [2]
    // --> 4 * (3 * fact(3 - 1))                [3]
    // --> 4 * (3 * fact 2)                     [4]
    // --> 4 * (3 * (2 * fact(2 - 1)))          [5]
    // --> 4 * (3 * (2 * fact 1))               [6]
    // --> 4 * (3 * (2 * (1 * fact(1 - 1))))    [7]
    // --> 4 * (3 * (2 * (1 * fact 0)))         [8]
    // --> 4 * (3 * (2 * (1 * 1)))              [9]
    // --> 4 * (3 * (2 * 1))                    [10]
    // --> 4 * (3 * 2)                          [11]
    // --> 4 * 6                                [12]
    // --> 24                                   [13]
    let rec factorial x =
        match x with
        | 0 -> 1
        | n -> n * factorial(n - 1)
