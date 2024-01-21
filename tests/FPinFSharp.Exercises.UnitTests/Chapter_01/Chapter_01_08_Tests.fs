namespace FPinFSharp.Exercises.UnitTests.Chapter_01

open FPinFSharp.Exercises.Chapter_01.Chapter_01_08
open Xunit

module Chapter_01_08_Tests =

    [<Theory>]
    [<InlineData(6, 8, 2)>]
    [<InlineData(12, 27, 3)>]
    [<InlineData(36, 116, 4)>]
    [<InlineData(100, 20, 20)>]
    [<InlineData(20, 100, 20)>]
    let ``Should get the greatest common divisor of two natural numbers`` (m, n, expectedResult) =
        let actualResult = gcd(m, n)
        Assert.Equal(expectedResult, actualResult)
