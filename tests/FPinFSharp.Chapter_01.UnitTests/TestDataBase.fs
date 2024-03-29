namespace FPinFSharp.Chapter_01.UnitTests

type TestDataBase(generator : obj [] seq) =

    interface seq<obj []> with
        member this.GetEnumerator() = generator.GetEnumerator()
        member this.GetEnumerator() = generator.GetEnumerator() :> System.Collections.IEnumerator
