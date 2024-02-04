namespace FPinFSharp.Chapter_01

// 1.4 Recursion.
module Section_04 =
    let rec factorial x =
        match x with
        | 0 -> 1
        | n -> n * factorial(n - 1)

    // Explanation.
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
