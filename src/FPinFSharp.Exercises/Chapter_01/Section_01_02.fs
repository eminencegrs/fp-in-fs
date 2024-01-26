namespace FPinFSharp.Exercises.Chapter_01

open FPinFSharp.Exercises.Chapter_01.Section_01_01

// 1.2 Simple function declarations.
module Section_01_02 =
    let calculateCircleArea (radius: int) =
        System.Math.PI * float (radius * radius)

    let calculateCircleAreaUsingDoubleFunction (radius: int) =
        System.Math.PI * float (double radius)
