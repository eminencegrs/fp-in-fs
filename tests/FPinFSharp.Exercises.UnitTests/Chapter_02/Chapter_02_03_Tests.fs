namespace FPinFSharp.Exercises.UnitTests.Chapter_02

open FPinFSharp.Exercises.UnitTests.Extensions
open FPinFSharp.Exercises.Chapter_02.Chapter_02_03
open Shouldly
open Xunit

module Chapter_02_03_Tests =

    [<Fact>]
    let ``Should get a random letter`` () =
        let result = getRandomLetter()
        result.ShouldBeOfType(typeof<char>)
        result.ShouldBeLetter()
        result.ShouldBeInRange(fun c -> (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))

    [<Theory>]
    [<InlineData(10)>]
    [<InlineData(11)>]
    [<InlineData(12)>]
    [<InlineData(13)>]
    let ``Should get a random string of a specified length`` length =
        let result = getRandomString length
        result.ShouldBeOfType(typeof<string>)
        result.ShouldNotBeNullOrWhiteSpace()
        result.Length.ShouldBe(length)
