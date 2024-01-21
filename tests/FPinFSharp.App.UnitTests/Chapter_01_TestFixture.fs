namespace FPinFSharp.App.UnitTests

type TestDataBase(generator : obj [] seq) = 
    interface seq<obj []> with
        member this.GetEnumerator() = generator.GetEnumerator()
        member this.GetEnumerator() = generator.GetEnumerator() :> System.Collections.IEnumerator

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
