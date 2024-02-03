namespace FPinFSharp.Exercises.Chapter_02

// 2.12 Summary of the basic types
module Section_02_12 =

    let getChar () : char = 'c'

    let getByte isHex : byte =
        match isHex with
        | true  -> 0xFFuy
        | false -> 255uy

    let getSByte isHex : sbyte =
        match isHex with
        | true  -> -0x80y
        | false -> 127y

    let getInt16 isHex : int16 =
        match isHex with
        | true  -> -0x8000s
        | false -> 32767s

    let getUInt16 isHex : uint16 =
        match isHex with
        | true  -> 0xFFFFus
        | false -> 65535us

    let getInt32 isHex : int32 =
        match isHex with
        | true  -> -0x80000000
        | false -> 2147483647

    let getUInt32 isHex : uint32 =
        match isHex with
        | true  -> 0xFFFFFFFFu
        | false -> 4294967295u
