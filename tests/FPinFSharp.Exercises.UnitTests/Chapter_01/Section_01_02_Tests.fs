namespace FPinFSharp.Exercises.UnitTests.Chapter_01

open FPinFSharp.Exercises.Chapter_01.Section_01_02
open Xunit

module Section_01_02_Tests =

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
