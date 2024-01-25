namespace FPinFSharp.Exercises.UnitTests.Chapter_02

open FPinFSharp.Exercises.Chapter_02.Chapter_02_03
open Xunit

module Chapter_02_03_Tests =

    [<Theory>]
    [<InlineData(10)>]
    [<InlineData(11)>]
    [<InlineData(12)>]
    [<InlineData(13)>]
    let ``Should get random string with a specified length`` length =
        let result = getRandomString length
        Assert.NotNull(result)
        Assert.IsType(typeof<string>, result)
        Assert.Equal(result.Length, length)
