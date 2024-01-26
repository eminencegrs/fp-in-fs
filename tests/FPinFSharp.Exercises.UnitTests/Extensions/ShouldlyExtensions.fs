namespace FPinFSharp.Exercises.UnitTests.Extensions

open System
open System.Runtime.CompilerServices
open Shouldly

[<Extension>]
type CharExtensions =

    [<Extension>]
    static member inline ShouldBeLetter(value: char) =
        if Char.IsLetter(value)
        then ()
        else raise <| ShouldAssertException("The provided value is not char")

    [<Extension>]
    static member inline ShouldBeInRange(value: char, predicate: Func<char, bool>) =
        if predicate.Invoke(value)
        then ()
        else raise <| ShouldAssertException("The provided value is not in the specified range")
