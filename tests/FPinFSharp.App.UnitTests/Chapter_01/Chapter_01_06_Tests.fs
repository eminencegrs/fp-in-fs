namespace FPinFSharp.App.UnitTests.Chapter_01

open FPinFSharp.App.Chapter_01.Chapter_01_06
open Xunit

module Chapter_01_06_Tests =

    [<Fact>]
    let ``Should triple 10 to get 1000`` () =
        let x = 10
        let expectedResult = 1000
        let actualResult = validFunction x
        Assert.Equal(expectedResult, actualResult)
