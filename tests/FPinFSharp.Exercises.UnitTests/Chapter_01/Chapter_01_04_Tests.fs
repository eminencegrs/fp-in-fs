namespace FPinFSharp.Exercises.UnitTests.Chapter_01

open FPinFSharp.Exercises.Chapter_01.Chapter_01_04
open Xunit

module Chapter_01_04_Tests =

    [<Fact>]
    let ``Should calculate factorial 5`` () =
        let x = 5
        let expectedResult = 120
        let actualResult = factorial x
        Assert.Equal(expectedResult, actualResult)
