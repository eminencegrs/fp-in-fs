namespace FPinFSharp.Exercises.UnitTests.Chapter_02

open FPinFSharp.Exercises.Chapter_02.Section_02_05
open Shouldly
open Xunit

module Section_02_05_Tests =

    [<Theory>]
    [<InlineData(11, 121)>]
    [<InlineData(12, 144)>]
    [<InlineData(13, 169)>]
    let ``Should get a square of integer (v1)`` (x: int, expectedResult: int) =
        let actualResult = Math_v1().square x
        actualResult.ShouldBe(expectedResult)

    [<Theory>]
    [<InlineData(0.3, 0.09)>]
    [<InlineData(1.5, 2.25)>]
    [<InlineData(10.0, 100.0)>]
    let ``Should get a square of float (v1)`` (x: float, expectedResult: float) =
        let actualResult = Math_v1().square x
        actualResult.ShouldBe(expectedResult)

    [<Theory>]
    [<InlineData(11, 121)>]
    [<InlineData(12, 144)>]
    [<InlineData(13, 169)>]
    let ``Should get a square of integer (v2)`` (x: int, expectedResult: int) =
        let actualResult = Math_v2().square x
        actualResult.ShouldBe(expectedResult)

    [<Theory>]
    [<InlineData(0.3, 0.09)>]
    [<InlineData(1.5, 2.25)>]
    [<InlineData(10.0, 100.0)>]
    let ``Should get a square of float (v2)`` (x: float, expectedResult: float) =
        let actualResult = Math_v2().square x
        actualResult.ShouldBe(expectedResult)

    [<Theory>]
    [<InlineData(11, 121)>]
    [<InlineData(12, 144)>]
    [<InlineData(13, 169)>]
    let ``Should get a square of integer (v3)`` (x: int, expectedResult: int) =
        let actualResult = Math_v3().square x
        actualResult.ShouldBe(expectedResult)

    [<Theory>]
    [<InlineData(0.3, 0.09)>]
    [<InlineData(1.5, 2.25)>]
    [<InlineData(10.0, 100.0)>]
    let ``Should get a square of float (v3)`` (x: float, expectedResult: float) =
        let actualResult = Math_v3().square x
        actualResult.ShouldBe(expectedResult)
