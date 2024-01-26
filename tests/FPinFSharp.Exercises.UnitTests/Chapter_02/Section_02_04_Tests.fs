namespace FPinFSharp.Exercises.UnitTests.Chapter_02

open FPinFSharp.Exercises.Chapter_02.Section_02_04
open Shouldly
open Xunit

module Section_02_04_Tests =

    [<Theory>]
    [<InlineData(6, 8, 2)>]
    [<InlineData(12, 27, 3)>]
    [<InlineData(36, 116, 4)>]
    [<InlineData(100, 20, 20)>]
    [<InlineData(20, 100, 20)>]
    let ``Should get the greatest common divisor of two natural numbers`` (m, n, expectedResult) =
        let actualResult = gcd(m, n)
        actualResult.ShouldBe(expectedResult)
