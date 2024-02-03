namespace FPinFSharp.Exercises.Chapter_02

open System

// 2.11 Function application operators |> and <|
module Section_02_11 =
    
    // `arg |> myFunction` means `myFunction arg`
    // `myFunction <| arg` means `myFunction arg`
    let raiseExceptionIfTrue x =
        if x = true
        then raise <| InvalidOperationException()

    let raiseExceptionIfFalse x =
        if x = false
        then InvalidOperationException() |> raise
