namespace FPinFSharp.Exercises.Chapter_02

open System;

module Exercises =

    // 2.1 Declare a function f: int -> bool such that f(n) = true
    // exactly when n is divisible by 2 or divisible by 3 but not divisible by 5.
    // Write down the expected values of f(24), f(27), f(29) and f(30) and compare with the result.
    let f (x: int) : bool =
        (x % 2 = 0 || x % 3 = 0) && x % 5 <> 0

    // 2.2 Declare a function: string * int -> string, where: pow(s,n) = s · s · ... · s
    // We use '·' to denote string concatenation. (The F# representation is '+'.).
    let rec concatenateStringV1 (s: string, n: int) : string =
        if n <= 0
        then ""
        else s + concatenateStringV1(s, n - 1)

    let rec concatenateStringV2 (s: string, n: int) : string =
        match n with
        | _ when n <= 0 -> ""
        | _ -> s + concatenateStringV2(s, n - 1)

    // 2.3 Declare a function isIthChar: string * int * char -> bool
    // where the value of isIthChar(str, i, ch) is true if and only
    // if ch is the i’th character in the string str (numbering starting at zero).
    let isIthCharV1 (str: string, i: int, ch: char) : bool =
        if i < 0 then ArgumentOutOfRangeException() |> raise
        str.IndexOf(ch) = i

    let isIthCharV2 (str: string, i: int, ch: char) : bool =
        if i < 0 then ArgumentOutOfRangeException() |> raise
        let positions = 
            let rec inner (part: string, from: int, x: char) =
                match from with
                | _ when from >= str.Length -> []
                | _ ->
                    if x = part.[from]
                    then from :: inner(part, from + 1, ch)
                    else inner(part, from + 1, ch)
            inner(str, 0, ch)
        List.contains i positions

    // 2.4 Declare a function occFromIth: string * int * char -> int
    // where occFromIth(str, i, ch) = the number of occurrences of character 'ch' in positions 'j'
    // in the string 'str' with j ≥ i.
    // Hint: the value should be 0 for i ≥ size str.
    let rec occFromIth (str: string, from: int, ch: char) : int =
        if from < 0 then ArgumentOutOfRangeException() |> raise
        match from with
        | _ when from >= str.Length -> 0
        | _ ->
            let current = str[from]
            let sum = occFromIth(str, from + 1, ch)
            if current = ch
            then sum + 1
            else sum

    // 2.5 Declare the F# function occInString: string * char -> int
    // where occInString(str, ch) = the number of occurrences of character ch in the string str.
    let rec occInString (str: string, ch: char) : int =
        let mutable sum = 0;
        match str.Length with
        | 0 -> sum
        | _ ->
            if ch = str.[0] then
                sum <- sum + 1
            sum + occInString(str.Substring(1), ch)
