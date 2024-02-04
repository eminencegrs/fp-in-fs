namespace FPinFSharp.Chapter_02.UnitTests

open System
open FPinFSharp.Chapter_02.Section_07
open Shouldly
open Xunit

module Section_07_Tests =

    [<Theory>]
    [<InlineData(2, 3, 5)>]
    [<InlineData(-10, 20, 10)>]
    [<InlineData(-1, -2, -3)>]
    let ``Should add two numbers`` (m, n, expectedResult) =
        let actualResult = addTwoNumbers m n
        actualResult.ShouldBe(expectedResult)

    [<Theory>]
    [<InlineData(1, 2, 3, -4)>]
    [<InlineData(-10, 20, 30, -60)>]
    [<InlineData(-10, -20, -30, 40)>]
    let ``Should subtract three numbers`` (x, y, z, expectedResult) =
        let actualResult = subtractTreeNumbers x y z
        actualResult.ShouldBe(expectedResult)

    [<Theory>]
    [<InlineData(-3, -1)>]
    [<InlineData(-1, 1)>]
    [<InlineData(0, 2)>]
    let ``Should increment a number twice`` (x, expectedResult) =
        let actualResult = doubleIncrement x
        actualResult.ShouldBe(expectedResult)

    [<Theory>]
    [<InlineData(-5, 16)>]
    [<InlineData(0, 1)>]
    [<InlineData(4, 25)>]
    let ``Should increment and square a number (left infix)`` (x, expectedResult) =
        let actualResult = incrementAndSquareLeftInfix x
        actualResult.ShouldBe(expectedResult)

    [<Theory>]
    [<InlineData(-3, 10)>]
    [<InlineData(0, 1)>]
    [<InlineData(4, 17)>]
    let ``Should square and increment a number (left infix)`` (x, expectedResult) =
        let actualResult = squareAndIncrementLeftInfix x
        actualResult.ShouldBe(expectedResult)

    [<Theory>]
    [<InlineData(-5, 16)>]
    [<InlineData(0, 1)>]
    [<InlineData(4, 25)>]
    let ``Should increment and square a number (right infix)`` (x, expectedResult) =
        let actualResult = incrementAndSquareRightInfix x
        actualResult.ShouldBe(expectedResult)

    [<Theory>]
    [<InlineData(-3, 10)>]
    [<InlineData(0, 1)>]
    [<InlineData(4, 17)>]
    let ``Should square and increment a number (right infix)`` (x, expectedResult) =
        let actualResult = squareAndIncrementRightInfix x
        actualResult.ShouldBe(expectedResult)

    [<Theory>]
    [<InlineData(99, 100)>]
    let ``Should apply the 'increment' operation`` (x, expectedResult) =
        let actualResult = apply increment x
        actualResult.ShouldBe(expectedResult)

    [<Theory>]
    [<InlineData(10, 100)>]
    let ``Should apply the 'square' operation`` (x, expectedResult) =
        let actualResult = apply square x
        actualResult.ShouldBe(expectedResult)

    [<Theory>]
    [<InlineData("increment", 99, 100)>]
    [<InlineData("square", 10, 100)>]
    let ``Should apply an operation`` (operationName, x, expectedResult) =
        let actualResult = applyOperation operationName x
        actualResult.ShouldBe(expectedResult)

    [<Theory>]
    [<InlineData("sqrt")>]
    let ``Should fail when an operation is unknown`` (operationName) =
        let action = fun _ -> applyOperation operationName Unchecked.defaultof<int> |> ignore
        Should.Throw<Exception>(action)
