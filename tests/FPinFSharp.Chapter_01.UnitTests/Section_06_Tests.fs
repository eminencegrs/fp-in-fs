namespace FPinFSharp.Chapter_01.UnitTests

open FPinFSharp.Chapter_01.Section_06
open Xunit

module Section_06_Tests =

    [<Fact>]
    let ``Should triple 10 to get 1000`` () =
        let x = 10
        let expectedResult = 1000
        let actualResult = validFunction x
        Assert.Equal(expectedResult, actualResult)
