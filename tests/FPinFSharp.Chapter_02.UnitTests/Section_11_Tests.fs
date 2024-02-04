namespace FPinFSharp.Chapter_02.UnitTests

open System
open FPinFSharp.Chapter_02.Section_11
open Shouldly
open Xunit

module Section_11_Tests =

    [<Fact>]
    let ``GIVEN true WHEN raiseExceptionIfTrue THEN InvalidOperationException is thrown`` () =
        let action = fun () -> raiseExceptionIfTrue true
        action |> ShouldThrowExtensions.ShouldThrow<InvalidOperationException>

    [<Fact>]
    let ``GIVEN false WHEN raiseExceptionIfTrue THEN no exception is thrown`` () =
        let action = fun () -> raiseExceptionIfTrue false
        action |> ShouldThrowExtensions.ShouldNotThrow

    [<Fact>]
    let ``GIVEN false WHEN raiseExceptionIfFalse THEN InvalidOperationException is thrown`` () =
        let action = fun () -> raiseExceptionIfFalse false
        action |> ShouldThrowExtensions.ShouldThrow<InvalidOperationException>

    [<Fact>]
    let ``GIVEN true WHEN raiseExceptionIfFalse THEN no exception is thrown`` () =
        let action = fun () -> raiseExceptionIfFalse true
        action |> ShouldThrowExtensions.ShouldNotThrow
