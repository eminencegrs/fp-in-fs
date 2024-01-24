namespace FPinFSharp.Exercises.UnitTests.Chapter_02

open System;
open FPinFSharp.Exercises.Chapter_02.Chapter_02_01
open Xunit

module Chapter_02_01_Tests =

    [<Theory>]
    [<InlineData("0", 0)>]
    [<InlineData("0123", 123)>]
    [<InlineData("-388890", -388890)>]
    let ``Should parse string into int`` (value: string, expectedResult: int) =
        let actualResult = tryParseInt value
        Assert.Equal(actualResult.IsNone, false)
        Assert.Equal(expectedResult, actualResult.Value)

    [<Theory>]
    [<InlineData("0.0", 0.0)>]
    [<InlineData("-7.235", -7.235)>]
    [<InlineData("1.23e-17", 1.23e-17)>]
    let ``Should parse string into float`` (value: string, expectedResult: float) =
        let actualResult = tryParseFloat value
        Assert.Equal(actualResult.IsNone, false)
        Assert.Equal(Math.Round(expectedResult, 3), Math.Round(actualResult.Value, 3))

    [<Theory>]
    [<InlineData(5, -5)>]
    [<InlineData(-7, 7)>]
    let ``Should negate a constant`` (x: int, expectedResult: int) =
        let actualResult = negateConstant x
        Assert.Equal(expectedResult, actualResult)

    [<Theory>]
    [<InlineData(5, -10)>]
    [<InlineData(-10, 20)>]
    let ``Should apply monadic minus operator to the result of the expression using lambda`` (x: int, expectedResult: int) =
        let actualResult = applyMonadicMinusOperatorUsingExternalFunction (fun x -> - (x + x)) x
        Assert.Equal(expectedResult, actualResult)

    [<Theory>]
    [<InlineData(5, -10)>]
    [<InlineData(-10, 20)>]
    let ``Should apply monadic minus operator to the result of the expression using the 'negateConstant' function``
        (x: int, expectedResult: int) =
        let actualResult = applyMonadicMinusOperatorUsingExternalFunction negateConstant (x + x)
        Assert.Equal(expectedResult, actualResult)

    [<Theory>]
    [<InlineData(27, 20, 7)>]
    [<InlineData(-10, 5, -15)>]
    [<InlineData(-25, -25, 0)>]
    let ``Should subtract values``(x: int, y: int, expectedResult: int) =
        let actualResult =  subtractValues x y
        Assert.Equal(expectedResult, actualResult)
