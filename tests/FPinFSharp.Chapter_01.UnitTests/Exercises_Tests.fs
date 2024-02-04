namespace FPinFSharp.Chapter_01.UnitTests

open FPinFSharp.Chapter_01.Exercises
open Xunit

module Exercises_Tests =

    // 1.1
    [<Theory>]
    [<InlineData(3.0, 7.0)>]
    let ``Should execute the gFunc function`` (n, expectedResult) =
        let actualResult = gFunc n
        Assert.Equal(actualResult, expectedResult)

    // 1.2
    [<Theory>]
    [<InlineData(3.0, 4.0, 5.0)>]
    let ``Should execute the hFunc function`` (x, y, expectedResult) =
        let actualResult = hFunc(x, y)
        Assert.Equal(actualResult, expectedResult)

    // 1.3
    [<Theory>]
    [<InlineData(3.0, 7.0)>]
    let ``Should execute the gExpr function`` (n, expectedResult) =
        let actualResult = gExpr n
        Assert.Equal(actualResult, expectedResult)

    [<Theory>]
    [<InlineData(3.0, 4.0, 5.0)>]
    let ``Should execute the hExpr function`` (x, y, expectedResult) =
        let actualResult = hExpr(x, y)
        Assert.Equal(actualResult, expectedResult)

    // 1.4
    [<Theory>]
    [<InlineData(4, 10)>]
    [<InlineData(5, 15)>]
    [<InlineData(10, 55)>]
    [<InlineData(100, 5050)>]
    let ``Should calculate the sum of the first n natural numbers, n >= 0`` (n, expectedResult) =
        let actualResult = f(n)
        Assert.Equal(expectedResult, actualResult)

    // 1.5
    [<Theory>]
    [<InlineData(0, 0)>]
    [<InlineData(1, 1)>]
    [<InlineData(2, 1)>]
    [<InlineData(3, 2)>]
    [<InlineData(4, 3)>]
    [<InlineData(5, 5)>]
    [<InlineData(6, 8)>]
    let ``Should get an F(n)-th item of Fibonacci numbers`` (n, expectedResult) =
        let actualResult = fibonacci n
        Assert.Equal(expectedResult, actualResult)

    // 1.6
    [<Theory>]
    [<InlineData(2, 3, 14)>]
    [<InlineData(3, 3, 18)>]
    [<InlineData(4, 2, 15)>]
    let ``Should get a sum of numbers`` (m, n, expectedResult) =
        let actualResult = sum(m, n)
        Assert.Equal(expectedResult, actualResult)

    // 1.8
    [<Fact>]
    let ``Should evaluate expressions`` () =
        let actualResult = func()
        Assert.Equal((4, 9), actualResult)
