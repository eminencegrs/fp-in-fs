namespace FPinFSharp.Chapter_01.UnitTests

open FPinFSharp.Chapter_01.Section_05
open Xunit

module Section_05_Tests =

    [<Fact>]
    let ``Should get a pair of coordinates from a point`` () =
        let getPoint = fun () -> { X = 10; Y = 20 }
        let expectedResult = (10, 20)
        let actualResult = getCoordinates(getPoint())
        Assert.Equal(expectedResult, actualResult)

    [<Theory>]
    [<InlineData(-5.0, 3, -125.0)>]
    [<InlineData(-4.0, 2, 16.0)>]
    [<InlineData(0.0, 5, 0.0)>]
    [<InlineData(2.0, 0, 1.0)>]
    [<InlineData(2.0, 3, 8.0)>]
    [<InlineData(3.0, 4, 81.0)>]
    let ``Should power a number`` (x, n, expected) =
        let result = power(x, n)
        Assert.Equal(expected, result)
