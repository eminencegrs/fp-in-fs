namespace FPinFSharp.App.Chapter_01

open FPinFSharp.App.Chapter_01.Chapter_01_01

// 1.2 Simple function declarations.
module Chapter_01_02 =
    let calculateCircleArea (radius: int) =
        System.Math.PI * float (radius * radius)

    let calculateCircleAreaUsingDoubleFunction (radius: int) =
        System.Math.PI * float (double radius)
