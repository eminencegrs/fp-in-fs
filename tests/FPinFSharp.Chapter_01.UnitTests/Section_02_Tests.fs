namespace FPinFSharp.Chapter_01.UnitTests

open FPinFSharp.Chapter_01.Section_02
open Xunit

module Section_02_Tests =

    [<Fact>]
    let ``Should calculate a circle area`` () =
        let radius = 10
        let expectedResult = 314.15926535897933
        let actualResult = calculateCircleArea radius
        Assert.Equal(expectedResult, actualResult)

    [<Fact>]
    let ``Should calculate a circle area using the double function`` () =
        let radius = 10
        let expectedResult = 314.15926535897933
        let actualResult = calculateCircleAreaUsingDoubleFunction radius
        Assert.Equal(expectedResult, actualResult)
