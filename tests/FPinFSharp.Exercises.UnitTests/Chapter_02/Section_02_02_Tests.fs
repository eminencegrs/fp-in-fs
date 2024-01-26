namespace FPinFSharp.Exercises.UnitTests.Chapter_02

open FPinFSharp.Exercises.Chapter_02.Section_02_02
open Xunit

module Section_02_02_Tests =

    [<Theory>]
    [<InlineData(1, 3, 4)>]
    let ``Should add 2 numbers`` a b expectedResult =
        let actualResult = add a b
        Assert.Equal(expectedResult, actualResult)

    [<Theory>]
    [<InlineData(1, 3, -2)>]
    let ``Should subtract 2 numbers`` a b expectedResult =
        let actualResult = subtract a b
        Assert.Equal(expectedResult, actualResult)

    [<Theory>]
    [<InlineData(3, 4, 12)>]
    let ``Should multiply 2 numbers`` x y expectedResult =
        let actualResult = multiply x y
        Assert.Equal(expectedResult, actualResult)

    [<Theory>]
    [<InlineData(10, 2, 5)>]
    let ``Should divide 2 numbers`` x y expectedResult =
        let actualResult = divide x y
        Assert.Equal(expectedResult, actualResult)

    [<Theory>]
    [<InlineData(10, 3, 1)>]
    let ``Should modulo 2 numbers`` x y expectedResult =
        let actualResult = modulo x y
        Assert.Equal(expectedResult, actualResult)

    [<Theory>]
    [<InlineData(10, 3, 1000)>]
    let ``Should exponentiate 2 numbers`` x y expectedResult =
        let actualResult = exponentiate x y
        Assert.Equal(expectedResult, actualResult)
