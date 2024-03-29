namespace FPinFSharp.Chapter_01.UnitTests

open FPinFSharp.Chapter_01.Section_03
open FPinFSharp.Chapter_01.UnitTests
open Xunit

module Section_03_Tests =

    [<Fact>]
    let ``Should calculate a circle area (v3)`` () =
        let radius = 10
        let expectedResult = 314.15926535897933
        let actualResult = calculateCircleAreaUsingAnonymousFunction radius
        Assert.Equal(expectedResult, actualResult)

    type MonthsAndDaysTestData() = 
        inherit TestDataBase([
            [| 1; 31 |]
            [| 2; 28 |]
            [| 3; 31 |]
            [| 4; 30 |]
            [| 5; 31 |]
            [| 6; 30 |]
            [| 7; 31 |]
            [| 8; 31 |]
            [| 9; 30 |]
            [| 10; 31 |]
            [| 11; 30 |]
            [| 12; 31 |]
        ])

    [<Theory>]
    [<ClassData(typeof<MonthsAndDaysTestData>)>]
    let ``Should get a number of days by a month number`` (month: int, expectedResult: int) =
        let actualResult = daysNumberByMonth month
        Assert.Equal(expectedResult, actualResult)
