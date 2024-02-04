namespace FPinFSharp.Chapter_02

// 2.12 Summary of the basic types
module Section_12 =

    // Helpers.
    let formatNumeric (values: 'T * 'T) : string * string =
        System.String.Format("{0}", fst values), System.String.Format("{0}", snd values)

    let formatHexadecimal (values: 'T * 'T) : string * string =
        if fst values < Unchecked.defaultof<'T>
        then System.String.Format("-0x{0:X2}", fst values), System.String.Format("0x{0:X2}", snd values)
        else System.String.Format("0x{0:X2}", fst values), System.String.Format("0x{0:X2}", snd values)

    // Char
    let convertIntToChar (x: int) : char =
        System.Convert.ToChar x

    // Byte
    let getMinMaxByte (isHex: bool) : byte * byte =
        match isHex with
        | true  -> (0x0uy, 0xFFuy)
        | false -> (0uy, 255uy)

    let getMinMaxByteInString (isHex: bool) : string * string =
        match isHex with
        | true  -> getMinMaxByte true   |> formatHexadecimal
        | false -> getMinMaxByte false  |> formatNumeric

    // SByte
    let getMinMaxSByte (isHex: bool) : sbyte * sbyte =
        match isHex with
        | true  -> (0x80y, 0x7Fy)
        | false -> (-128y, 127y)

    let getMinMaxSByteInString (isHex: bool) : string * string =
        match isHex with
        | true  -> getMinMaxSByte true  |> formatHexadecimal
        | false -> getMinMaxSByte false |> formatNumeric

    // Int16
    let getMinMaxInt16 (isHex: bool) : int16 * int16 =
        match isHex with
        | true  -> (-0x8000s, 0x7FFFs)
        | false -> (-32768s, 32767s)

    let getMinMaxInt16InString (isHex: bool) : string * string =
        match isHex with
        | true  -> getMinMaxInt16 true  |> formatHexadecimal
        | false -> getMinMaxInt16 false |> formatNumeric

    // UInt16
    let getMinMaxUInt16 (isHex: bool) : uint16 * uint16 =
        match isHex with
        | true  -> (0x0us, 0xFFFFus)
        | false -> (0us, 65535us)

    let getMinMaxUInt16InString (isHex: bool) : string * string =
        match isHex with
        | true  -> getMinMaxUInt16 true  |> formatHexadecimal
        | false -> getMinMaxUInt16 false |> formatNumeric

    // Int32
    let getInt32 (isHex: bool) : int32 * int32 =
        match isHex with
        | true  -> (-0x80000000, 0x7FFFFFFF)
        | false -> (-2147483648, 2147483647)

    let getInt32InString (isHex: bool) : string * string =
        match isHex with
        | true  -> getInt32 true  |> formatHexadecimal
        | false -> getInt32 false |> formatNumeric

    // UInt32
    let getUInt32 (isHex: bool) : uint32 * uint32 =
        match isHex with
        | true  -> (0u, 0xFFFFFFFFu)
        | false -> (0u, 4294967295u)

    let getUInt32InString (isHex: bool) : string * string =
        match isHex with
        | true  -> getUInt32 true  |> formatHexadecimal
        | false -> getUInt32 false |> formatNumeric

    // Int64
    let getInt64 (isHex: bool) : int64 * int64 =
        match isHex with
        | true  -> (-0x8000000000000000L, 0x7FFFFFFFFFFFFFFFL)
        | false -> (-9223372036854775808L, 9223372036854775807L)

    let getInt64InString (isHex: bool) : string * string =
        match isHex with
        | true  -> getInt64 true  |> formatHexadecimal
        | false -> getInt64 false |> formatNumeric

    // UInt64
    let getUInt64 (isHex: bool) : uint64 * uint64 =
        match isHex with
        | true  -> (0UL, 0xFFFFFFFFFFFFFFFFUL)
        | false -> (0UL, 18446744073709551615UL)

    let getUInt64InString (isHex: bool) : string * string =
        match isHex with
        | true  -> getUInt64 true  |> formatHexadecimal
        | false -> getUInt64 false |> formatNumeric

    // nativeint
    let getNativeInt (isHex: bool) : nativeint * nativeint =
        match isHex with
        | true  -> (-0x80000000n, 0x7FFFFFFFn)
        | false -> (-2147483648n, 2147483647n)

    let getNativeIntInString (isHex: bool) : string * string =
        match isHex with
        | true  -> getNativeInt true  |> formatHexadecimal
        | false -> getNativeInt false |> formatNumeric

    // unativeint
    let getUNativeInt (isHex: bool) : unativeint * unativeint =
        match isHex with
        | true  -> (0un, 0xFFFFFFFFun)
        | false -> (0un, 4294967295un)

    let getUNativeIntInString (isHex: bool) : string * string =
        match isHex with
        | true  -> getUNativeInt true  |> formatHexadecimal
        | false -> getUNativeInt false |> formatNumeric

    // Single
    let getMinMaxSingle () : single * single =
        (-3.40282346639e+38f, 3.40282346639e+38f)

    // Double
    let getMinMaxDouble () : double * double =
        (-1.7976931348623157e+308, 1.7976931348623157e+308)

    // Decimal
    let getMinMaxDecimal () : decimal * decimal =
        (System.Decimal.MinValue, System.Decimal.MaxValue)

    // BigInt
    let getBigInt () : bigint =
        18446744073709551615I
