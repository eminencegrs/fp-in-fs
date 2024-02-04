namespace FPinFSharp.Chapter_01.UnitTests

open FPinFSharp.Chapter_01.Section_04
open Xunit

module Section_04_Tests =

    [<Fact>]
    let ``Should calculate factorial 5`` () =
        let x = 5
        let expectedResult = 120
        let actualResult = factorial x
        Assert.Equal(expectedResult, actualResult)
