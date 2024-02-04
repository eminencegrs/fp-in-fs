namespace FPinFSharp.Exercises.UnitTests.Chapter_02

open FPinFSharp.Exercises.Chapter_02.Exercises
open Shouldly
open Xunit

module Exercises_Tests =

    // 2.1
    [<Theory>]
    [<InlineData(6, true)>]
    [<InlineData(24, true)>]
    [<InlineData(27, true)>]
    [<InlineData(29, false)>]
    [<InlineData(30, false)>]
    let ``GIVEN x WHEN f THEN result as expected`` (x: int) (expectedResult: bool) =
        let actualResult = f x
        actualResult.ShouldBe(expectedResult)

    // 2.2
    [<Theory>]
    [<InlineData("A", 3, "AAA")>]
    [<InlineData("1 ", 5, "1 1 1 1 1 ")>]
    [<InlineData(" x", 7, " x x x x x x x")>]
    let ``GIVEN s and n WHEN concatenateStringV1 THEN result as expected`` (s: string) (n: int) (expectedResult: string) =
        let actualResult = concatenateStringV1(s, n)
        actualResult.ShouldBe(expectedResult)

    [<Theory>]
    [<InlineData("A", 3, "AAA")>]
    [<InlineData("1 ", 5, "1 1 1 1 1 ")>]
    [<InlineData(" x", 7, " x x x x x x x")>]
    let ``GIVEN s and n WHEN concatenateStringV2 THEN result as expected`` (s: string) (n: int) (expectedResult: string) =
        let actualResult = concatenateStringV2(s, n)
        actualResult.ShouldBe(expectedResult)

    [<Theory>]
    [<InlineData("This is my string", 13, 'r', true)>]
    [<InlineData("This is my string", 1, 'T', false)>]
    [<InlineData("This is my string", 4, ' ', true)>]
    [<InlineData("This is my string", 7, ' ', false)>]
    [<InlineData("This is my string", 3, 's', true)>]
    [<InlineData("This is my string", 6, 's', false)>]
    let ``GIVEN str, i and ch  WHEN isIthCharV1 THEN result as expected``
        (str: string) (i: int) (ch: char) (expectedResult: bool) =
        let actualResult = isIthCharV1(str, i, ch)
        actualResult.ShouldBe(expectedResult)

    [<Theory>]
    [<InlineData("This is my string", 13, 'r', true)>]
    [<InlineData("This is my string", 1, 'T', false)>]
    [<InlineData("This is my string", 4, ' ', true)>]
    [<InlineData("This is my string", 7, ' ', true)>]
    [<InlineData("This is my string", 3, 's', true)>]
    [<InlineData("This is my string", 6, 's', true)>]
    let ``GIVEN str, i and ch  WHEN isIthCharV2 THEN result as expected``
        (str: string) (i: int) (ch: char) (expectedResult: bool) =
        let actualResult = isIthCharV2(str, i, ch)
        actualResult.ShouldBe(expectedResult)

    [<Theory>]
    [<InlineData("This is my string", 0, 'i', 3)>]
    let ``GIVEN str, i and ch  WHEN occFromIth THEN result as expected``
        (str: string) (from: int) (ch: char) (expectedResult: int) =
        let actualResult = occFromIth(str, from, ch)
        actualResult.ShouldBe(expectedResult)

    [<Theory>]
    [<InlineData("This is my first string", 't', 2)>]
    [<InlineData("This is my second string", 's', 4)>]
    [<InlineData("This is my third string", 'r', 2)>]
    [<InlineData("This is my fourth string", 'x', 0)>]
    let ``GIVEN string and char WHEN occInString THEN result as expected``
        (str: string) (ch: char) (expectedResult: int) =
        let actualResult = occInString(str, ch)
        actualResult.ShouldBe(expectedResult)
