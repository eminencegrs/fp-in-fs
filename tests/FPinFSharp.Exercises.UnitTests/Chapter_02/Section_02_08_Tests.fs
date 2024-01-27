namespace FPinFSharp.Exercises.UnitTests.Chapter_02

open FPinFSharp.Exercises.Chapter_02.Section_02_08
open Shouldly
open Xunit

module Section_02_08_Tests =

    [<Theory>]
    [<InlineData(5, 78.53981633974483)>]
    let ``Should add two numbers`` (r, expectedResult) =
        let actualResult = circleArea r
        actualResult.ShouldBe(expectedResult)
