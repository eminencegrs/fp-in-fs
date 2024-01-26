namespace FPinFSharp.Exercises.UnitTests.Chapter_01

open FPinFSharp.Exercises.Chapter_01.Section_01_04
open Xunit

module Section_01_04_Tests =

    [<Fact>]
    let ``Should calculate factorial 5`` () =
        let x = 5
        let expectedResult = 120
        let actualResult = factorial x
        Assert.Equal(expectedResult, actualResult)
