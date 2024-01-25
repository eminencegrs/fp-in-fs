namespace FPinFSharp.Exercises.Chapter_02

open System

// 2.3 Characters and strings
module Chapter_02_03 =

    let getRandomString length =
        let random = Random()
        let initializer = fun _ ->
            let letter =
                match random.Next(2) with
                | 0 -> random.Next(int 'A', int 'Z' + 1)
                | _ -> random.Next(int 'a', int 'z' + 1)
            char letter

        let chars = Array.init length initializer
        String.Join("", chars)
