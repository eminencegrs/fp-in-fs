namespace FPinFSharp.App.UnitTests

open FPinFSharp.App.Chapter_01
open Xunit

module Chapter_01_Tests =

    [<Fact>]
    let ``Should double a number`` () =
        let input = 9
        let expectedResult = 81
        let actualResult = double input
        Assert.Equal(expectedResult, actualResult)

    [<Fact>]
    let ``Should triple a number`` () =
        let input = 3
        let expectedResult = 27
        let actualResult = triple input
        Assert.Equal(expectedResult, actualResult)

    [<Fact>]
    let ``Should calculate a circle area (v1)`` () =
        let radius = 10
        let expectedResult = 314.15926535897933
        let actualResult = calculateCircleAreaV1 radius
        Assert.Equal(expectedResult, actualResult)

    [<Fact>]
    let ``Should calculate a circle area (v2)`` () =
        let radius = 10
        let expectedResult = 314.15926535897933
        let actualResult = calculateCircleAreaV2 radius
        Assert.Equal(expectedResult, actualResult)

    [<Fact>]
    let ``Should calculate a circle area (v3)`` () =
        let radius = 10
        let expectedResult = 314.15926535897933
        let actualResult = calculateCircleAreaV3 radius
        Assert.Equal(expectedResult, actualResult)

    [<Theory>]
    [<ClassData(typeof<MonthsAndDaysTestData>)>]
    let ``Should get a number of days by a month number`` (month: int, expectedResult: int) =
        let actualResult = daysNumberByMonth month
        Assert.Equal(expectedResult, actualResult)

    [<Fact>]
    let ``Should calculate factorial 5`` () =
        let x = 5
        let expectedResult = 120
        let actualResult = factorial x
        Assert.Equal(expectedResult, actualResult)
