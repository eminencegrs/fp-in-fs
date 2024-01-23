namespace FPinFSharp.Exercises.Chapter_02

open System
open System.Globalization

// 2.1 Numbers. Truth values. The unit type
module Chapter_02_01 =

    let tryParseInt (value: string) =
        match Int32.TryParse(value) with
        | (true, result) -> Some result
        | _ -> None

    let tryParseFloat (value: string) =
        match Double.TryParse(value, NumberStyles.Float, CultureInfo.InvariantCulture) with
        | (true, result) -> Some result
        | _ -> None
