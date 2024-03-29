namespace FPinFSharp.Chapter_02.UnitTests

open System;
open FPinFSharp.Chapter_02.Section_01
open Xunit

module Section_01_Tests =

    [<Theory>]
    [<InlineData("0", 0)>]
    [<InlineData("0123", 123)>]
    [<InlineData("-388890", -388890)>]
    let ``Should parse string into int`` (value: string, expectedResult: int) =
        let actualResult = tryParseInt value
        Assert.Equal(actualResult.IsNone, false)
        Assert.Equal(expectedResult, actualResult.Value)

    [<Fact>]
    let ``Should get none while parsing string into int`` () =
        let actualResult = tryParseInt "123.456"
        Assert.Equal(actualResult.IsNone, true)

    [<Theory>]
    [<InlineData("0.0", 0.0)>]
    [<InlineData("-7.235", -7.235)>]
    [<InlineData("1.23e-17", 1.23e-17)>]
    let ``Should parse string into float`` (value: string, expectedResult: float) =
        let actualResult = tryParseFloat value
        Assert.Equal(actualResult.IsNone, false)
        Assert.Equal(Math.Round(expectedResult, 3), Math.Round(actualResult.Value, 3))

    [<Fact>]
    let ``Should get none while parsing string into float`` () =
        let actualResult = tryParseFloat "this is not a float type"
        Assert.Equal(actualResult.IsNone, true)

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

    [<Theory>]
    [<InlineData(true, true, false)>]
    [<InlineData(true, false, true)>]
    [<InlineData(false, true, true)>]
    [<InlineData(false, false, false)>]
    let ``Should apply xor (long version) for operands`` a b expectedResult =
        let actualResult = xorLongVersion a b
        Assert.Equal(expectedResult, actualResult)

    [<Theory>]
    [<InlineData(true, true, false)>]
    [<InlineData(true, false, true)>]
    [<InlineData(false, true, true)>]
    [<InlineData(false, false, false)>]
    let ``Should apply xor (short version) for operands`` a b expectedResult =
        let actualResult = xorShortVersion a b
        Assert.Equal(expectedResult, actualResult)

    [<Fact>]
    let ``Should call the function to perform side-effect (v1)`` () =
        let result = performSideEffectV1()
        Assert.Equal((), result)

    [<Fact>]
    let ``Should call the function to perform side-effect (v2)`` () =
        let result = performSideEffectV2()
        Assert.Equal((), result)

    [<Fact>]
    let ``Should call the function to perform side-effect (v3)`` () =
        let result = performSideEffectV3()
        Assert.Equal((), result)

    [<Fact>]
    let ``Should call the function to perform side-effect (v4)`` () =
        let result = performSideEffectV4()
        Assert.Equal((), result)

    [<Fact>]
    let ``Should get a function that performs side-effect (v1)`` () =
        let func = getFunctionThatPerformsSideEffectV1()
        Assert.Equal((), func())

    [<Fact>]
    let ``Should get a function that performs side-effect (v2)`` () =
        let func = getFunctionThatPerformsSideEffectV2()
        Assert.Equal((), func())
