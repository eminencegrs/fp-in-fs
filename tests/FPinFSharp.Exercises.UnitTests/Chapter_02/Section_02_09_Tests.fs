namespace FPinFSharp.Exercises.UnitTests.Chapter_02

open FPinFSharp.Exercises.Chapter_02.Section_02_09
open Shouldly
open Xunit

module Section_02_09_Tests =

    [<Theory>]
    [<InlineData(true, true, false)>]
    [<InlineData(true, false, true)>]
    [<InlineData(false, true, true)>]
    [<InlineData(false, false, false)>]
    let ``Should XOR values`` (first, second, expectedResult) =
        let actualResult = first .||. second
        actualResult.ShouldBe(expectedResult)

    [<Theory>]
    [<InlineData(0.5, 2.0)>]
    [<InlineData(0.02, 50.0)>]
    [<InlineData(0.003, 333.3333333333333)>]
    let ``Should calculate reciprocal`` (x: float, expectedResult: float) =
        let actualResult = %% x
        actualResult.ShouldBe(expectedResult)
