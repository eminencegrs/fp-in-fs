namespace FPinFSharp.Exercises.UnitTests.Chapter_02

open FPinFSharp.Exercises.Chapter_02.Section_02_06
open Shouldly
open Xunit

module Section_02_06_Tests =

    [<Theory>]
    [<InlineData(0.3, 1, 0.3)>]
    [<InlineData(1.5, 2, 2.25)>]
    [<InlineData(10.0, 3, 1000.0)>]
    let ``Should raise the number 'x' to the power of 'n'`` (x: float, n: int, expectedResult: float) =
        let actualResult = power(x, n)
        actualResult.ShouldBe(expectedResult)
