namespace FPinFSharp.Chapter_02.UnitTests

open FPinFSharp.Chapter_02.Section_08
open Shouldly
open Xunit

module Section_08_Tests =

    [<Theory>]
    [<InlineData(5, 78.53981633974483)>]
    let ``Should get a circle area`` (r, expectedResult) =
        let actualResult = circleArea r
        actualResult.ShouldBe(expectedResult)
