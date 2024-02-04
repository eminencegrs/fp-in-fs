namespace FPinFSharp.Chapter_02.UnitTests

open FPinFSharp.Chapter_02.Section_10
open Shouldly
open Xunit

module Section_10_Tests =

    [<Theory>]
    [<InlineData("Lettersonly", true, true)>]
    [<InlineData("Lettersonly", false, true)>]
    [<InlineData("This text contains letters only", true, true)>]
    [<InlineData("This text also contains numbers: 1 2 3", true, false)>]
    [<InlineData("This text contains spaces", false, false)>]
    let ``Should check if a string contains letters only`` (text, ignoreSpace, expectedResult) =
        let actualResult = containsLettersOnly text ignoreSpace
        actualResult.ShouldBe(expectedResult)
