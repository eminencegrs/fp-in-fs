namespace FPinFSharp.Exercises.Chapter_02

open System

// 2.10 Equality and ordering
module Section_02_10 =

    // It is not defined on functions (closures):
    //      cos = sin;;
    //      stdin(5,1): error FS0001: The type ’( ˆa ->  ˆa)...
    //      does not support the ’equality’ constraint because it is a function type.
    // No type containing a function type can support equality
    // as F# has no means to decide whether two functions are equal:
    // It is a fundamental fact of theoretical computer science that
    // there exists no (always terminating) algorithm to determine
    // whether two arbitrary programs 'f' and 'g' (i.e., two closures) denote the same function.

    let containsLettersOnly (value: string) (ignoreSpace: bool) =
        value |> Seq.forall (fun x ->
            (ignoreSpace && Char.IsWhiteSpace(x)) || Char.IsLetter(x)
        )
