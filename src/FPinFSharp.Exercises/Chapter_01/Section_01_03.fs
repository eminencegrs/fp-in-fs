namespace FPinFSharp.Exercises.Chapter_01

// 1.3 Anonymous functions. Function expressions.
module Section_01_03 =
    let calculateCircleAreaUsingAnonymousFunction (radius: int) =
        let anonymousFunction = fun r -> System.Math.PI * r * r
        anonymousFunction radius

    let daysNumberByMonth (month: int) =
        match month with
        | 2                 -> 28
        | 4 | 6 | 9 | 11    -> 30
        | _                 -> 31
