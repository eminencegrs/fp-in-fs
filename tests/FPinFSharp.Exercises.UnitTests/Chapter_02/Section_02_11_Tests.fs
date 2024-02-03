namespace FPinFSharp.Exercises.UnitTests.Chapter_02

open System
open FPinFSharp.Exercises.Chapter_02.Section_02_11
open Shouldly
open Xunit

module Section_02_11_Tests =

    [<Fact>]
    let ``Given true when call raiseExceptionIfTrue then InvalidOperationException is thrown`` () =
        let action = fun () -> raiseExceptionIfTrue true
        action |> ShouldThrowExtensions.ShouldThrow<InvalidOperationException>

    [<Fact>]
    let ``Given false when call raiseExceptionIfTrue then no exception is thrown`` () =
        let action = fun () -> raiseExceptionIfTrue false
        action |> ShouldThrowExtensions.ShouldNotThrow

    [<Fact>]
    let ``Given false when call raiseExceptionIfFalse then InvalidOperationException is thrown`` () =
        let action = fun () -> raiseExceptionIfFalse false
        action |> ShouldThrowExtensions.ShouldThrow<InvalidOperationException>

    [<Fact>]
    let ``Given true when call raiseExceptionIfFalse then no exception is thrown`` () =
        let action = fun () -> raiseExceptionIfFalse true
        action |> ShouldThrowExtensions.ShouldNotThrow
