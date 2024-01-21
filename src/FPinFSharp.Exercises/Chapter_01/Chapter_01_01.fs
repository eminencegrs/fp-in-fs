namespace FPinFSharp.Exercises.Chapter_01

// 1.1 Values, types, identifiers and declarations.
module Chapter_01_01 =

    // The function name is `double`, the argument is `x`, which has type `int`, and the return value is of type `int`.
    let double x =
        x * x

    // The function name is `triple`, the argument is `x`, which has type `int`, and the return value is of type `int`.
    let triple (x: int) : int =
        x * x * x
