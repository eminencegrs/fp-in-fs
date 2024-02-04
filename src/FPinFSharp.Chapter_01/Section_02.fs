namespace FPinFSharp.Chapter_01

open FPinFSharp.Chapter_01.Section_01

// 1.2 Simple function declarations.
module Section_02 =
    let calculateCircleArea (radius: int) =
        System.Math.PI * float (radius * radius)

    let calculateCircleAreaUsingDoubleFunction (radius: int) =
        System.Math.PI * float (double radius)
