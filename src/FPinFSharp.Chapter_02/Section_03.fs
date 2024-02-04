namespace FPinFSharp.Chapter_02

open System

// 2.3 Characters and strings
module Section_03 =

    // A string is a sequence of characters. Strings are values of the type string.
    // A string is written inside enclosing quotes that are not part of the string.
    // Quote, backslash or control characters in a string are written by using the escape sequences.

    let getRandomLetter _ =
        let random = Random()
        let letter =
            match random.Next(2) with
            | 0 -> random.Next(int 'A', int 'Z' + 1)
            | _ -> random.Next(int 'a', int 'z' + 1)
        char letter

    let getRandomString length =
        let chars = Array.init length getRandomLetter
        String.Join("", chars)
