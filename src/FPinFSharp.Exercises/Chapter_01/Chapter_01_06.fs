namespace FPinFSharp.Exercises.Chapter_01

open FPinFSharp.Exercises.Chapter_01.Chapter_01_01

// 1.6 Types and type checking.
module Chapter_01_06 =

    // F# will try to infer a type for each value, expression and declaration entered.
    // If the system can infer a type for the input, then the input is accepted by the system.
    // Otherwise the system will reject the input with an error message.

    // For example, the expression `triple 3` is accepted, because
    // - `triple 3` has the type `int -> int` and
    // - `3` has the type int.
    let validFunction (n: int) =
        let runTriple = fun () -> triple n
        runTriple()

    // However, the following function will not compile.
    // The system will reject the expression `triple n` with an error message since `n` has the type `float`
    // while the argument for `triple` must be of type `int`.
    (*
    let invalidFunction (n: float) =
        let runTriple = fun () -> triple n
        runTriple
    *)
