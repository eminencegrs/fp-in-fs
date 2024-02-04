namespace FPinFSharp.Chapter_02.UnitTests

open System
open System.Numerics
open FPinFSharp.Chapter_02.Section_12
open Shouldly
open Xunit

module Section_12_Tests =

    [<Theory>]
    [<InlineData(Char.MinValue, Char.MinValue)>]
    [<InlineData(Char.MaxValue, Char.MaxValue)>]
    [<InlineData(65, 'A')>]
    let ``GIVEN int WHEN convertIntToChar THEN result as expected`` (x:int) (expectedResult:char) =
        let actualResult = convertIntToChar x
        actualResult.ShouldBe(expectedResult)

    [<Theory>]
    [<InlineData(Int32.MinValue)>]
    [<InlineData(-1)>]
    let ``GIVEN invalid int WHEN convertIntToChar THEN OverflowException thrown`` (x:int) =
        let action = fun () -> convertIntToChar x |> ignore
        action |> ShouldThrowExtensions.ShouldThrow<OverflowException>

    [<Theory>]
    [<InlineData(true, Byte.MinValue, Byte.MaxValue)>]
    [<InlineData(false, Byte.MinValue, Byte.MaxValue)>]
    let ``GIVEN isHex WHEN getMinMaxByte THEN result as expected`` (isHex:bool) (expectedResult: byte * byte) =
        let actualResult = getMinMaxByte isHex
        actualResult.ShouldBe(expectedResult)

    [<Theory>]
    [<InlineData(true, "0x00", "0xFF")>]
    [<InlineData(false, "0", "255")>]
    let ``GIVEN isHex WHEN getMinMaxByteInString THEN result as expected`` (isHex:bool) (expectedResult: string * string) =
        let actualResult = getMinMaxByteInString isHex
        actualResult.ShouldBe(expectedResult);

    [<Theory>]
    [<InlineData(true, SByte.MinValue, SByte.MaxValue)>]
    [<InlineData(false, SByte.MinValue, SByte.MaxValue)>]
    let ``GIVEN isHex WHEN getMinMaxSByte THEN result as expected`` (isHex:bool) (expectedResult: sbyte * sbyte) =
        let actualResult = getMinMaxSByte isHex
        actualResult.ShouldBe(expectedResult)

    [<Theory>]
    [<InlineData(true, "-0x80", "0x7F")>]
    [<InlineData(false, "-128", "127")>]
    let ``GIVEN isHex WHEN getMinMaxSByteInString THEN result as expected`` (isHex:bool) (expectedResult: string * string) =
        let actualResult = getMinMaxSByteInString isHex
        actualResult.ShouldBe(expectedResult)

    [<Theory>]
    [<InlineData(true, Int16.MinValue, Int16.MaxValue)>]
    [<InlineData(false, Int16.MinValue, Int16.MaxValue)>]
    let ``GIVEN isHex WHEN getMinMaxInt16 THEN result as expected`` (isHex:bool) (expectedResult: int16 * int16) =
        let actualResult = getMinMaxInt16 isHex
        actualResult.ShouldBe(expectedResult)

    [<Theory>]
    [<InlineData(true, "-0x8000", "0x7FFF")>]
    [<InlineData(false, "-32768", "32767")>]
    let ``GIVEN isHex WHEN getMinMaxInt16InString THEN result as expected`` (isHex:bool) (expectedResult: string * string) =
        let actualResult = getMinMaxInt16InString isHex
        actualResult.ShouldBe(expectedResult)

    [<Theory>]
    [<InlineData(true, UInt16.MinValue, UInt16.MaxValue)>]
    [<InlineData(false, UInt16.MinValue, UInt16.MaxValue)>]
    let ``GIVEN isHex WHEN getMinMaxUInt16 THEN result as expected`` (isHex:bool) (expectedResult: uint16 * uint16) =
        let actualResult = getMinMaxUInt16 isHex
        expectedResult.ShouldBe(expectedResult)

    [<Theory>]
    [<InlineData(true, "0x00", "0xFFFF")>]
    [<InlineData(false, "0", "65535")>]
    let ``GIVEN isHex WHEN getMinMaxUInt16InString THEN result as expected`` (isHex:bool) (expectedResult: string * string) =
        let actualResult = getMinMaxUInt16InString isHex
        actualResult.ShouldBe(expectedResult)

    [<Theory>]
    [<InlineData(true, Int32.MinValue, Int32.MaxValue)>]
    [<InlineData(false, Int32.MinValue, Int32.MaxValue)>]
    let ``GIVEN isHex WHEN getInt32 THEN result as expected`` (isHex:bool) (expectedResult: int32 * int32) =
        let actualResult = getInt32 isHex
        actualResult.ShouldBe(expectedResult)

    [<Theory>]
    [<InlineData(true, "-0x80000000", "0x7FFFFFFF")>]
    [<InlineData(false, "-2147483648", "2147483647")>]
    let ``GIVEN isHex WHEN getInt32InString THEN result as expected`` (isHex:bool) (expectedResult: string * string) =
        let actualResult = getInt32InString isHex
        actualResult.ShouldBe(expectedResult)

    [<Theory>]
    [<InlineData(true, UInt32.MinValue, UInt32.MaxValue)>]
    [<InlineData(false, UInt32.MinValue, UInt32.MaxValue)>]
    let ``GIVEN isHex WHEN getUInt32 THEN result as expected`` (isHex:bool) (expectedResult: uint32 * uint32) =
        let actualResult = getUInt32 isHex
        actualResult.ShouldBe(expectedResult)

    [<Theory>]
    [<InlineData(true, "0x00", "0xFFFFFFFF")>]
    [<InlineData(false, "0", "4294967295")>]
    let ``GIVEN isHex WHEN getUInt32InString THEN result as expected`` (isHex:bool) (expectedResult: string * string) =
        let actualResult = getUInt32InString isHex
        actualResult.ShouldBe(expectedResult)

    [<Theory>]
    [<InlineData(true, -0x8000000000000000L, 0x7FFFFFFFFFFFFFFFL)>]
    [<InlineData(false, -9223372036854775808L, 9223372036854775807L)>]
    let ``GIVEN isHex WHEN getInt64 THEN result as expected`` (isHex:bool) (expectedResult: int64 * int64) =
        let actualResult = getInt64 isHex
        actualResult.ShouldBe(expectedResult)

    [<Theory>]
    [<InlineData(true, "-0x8000000000000000", "0x7FFFFFFFFFFFFFFF")>]
    [<InlineData(false, "-9223372036854775808", "9223372036854775807")>]
    let ``GIVEN isHex WHEN getInt64InString THEN result as expected`` (isHex:bool) (expectedResult: string * string) =
        let actualResult = getInt64InString isHex
        actualResult.ShouldBe(expectedResult)

    [<Theory>]
    [<InlineData(true, 0UL, 0xFFFFFFFFFFFFFFFFUL)>]
    [<InlineData(false, 0UL, 18446744073709551615UL)>]
    let ``GIVEN isHex WHEN getUInt64 THEN result as expected`` (isHex:bool) (expectedResult: uint64 * uint64) =
        let actualResult = getUInt64 isHex
        actualResult.ShouldBe(expectedResult)

    [<Theory>]
    [<InlineData(true, "0x00", "0xFFFFFFFFFFFFFFFF")>]
    [<InlineData(false, "0", "18446744073709551615")>]
    let ``GIVEN isHex WHEN getUInt64InString THEN result as expected`` (isHex:bool) (expectedResult: string * string) =
        let actualResult = getUInt64InString isHex
        actualResult.ShouldBe(expectedResult)

    [<Fact>]
    let ``WHEN getMinMaxSingle THEN result as expected`` () =
        let actualResult = getMinMaxSingle()
        actualResult.ShouldBe((Single.MinValue, Single.MaxValue))

    [<Fact>]
    let ``WHEN getMinMaxDouble THEN result as expected`` () =
        let actualResult = getMinMaxDouble()
        actualResult.ShouldBe((Double.MinValue, Double.MaxValue))

    [<Fact>]
    let ``WHEN getMinMaxDecimal THEN result as expected`` () =
        let actualResult = getMinMaxDecimal()
        actualResult.ShouldBe((Decimal.MinValue, Decimal.MaxValue))

    [<Fact>]
    let ``WHEN getBigInt THEN result as expected`` () =
        let actualResult = getBigInt()
        actualResult.ShouldBe(18446744073709551615I)
