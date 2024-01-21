namespace FPinFSharp.App.UnitTests.Chapter_01

open FPinFSharp.App.Chapter_01.Chapter_01_01
open Xunit

module Chapter_01_01_Tests =

    [<Fact>]
    let ``Should double a number`` () =
        let input = 9
        let expectedResult = 81
        let actualResult = double input
        Assert.Equal(expectedResult, actualResult)

    [<Fact>]
    let ``Should triple a number`` () =
        let input = 3
        let expectedResult = 27
        let actualResult = triple input
        Assert.Equal(expectedResult, actualResult)
