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

    // Operators.
    // A monadic operator is an operator with one operand, while a dyadic operator has two operands.
    // Most monadic operators are used in prefix notation where the operator is written in front of the operand.
    // The symbol “-” (minus) is used for three purposes in F# as in mathematics:
    // --> Case 1: In number constants like “-2” it denotes the sign of the constant.
    // --> Case 2: In expressions like “- 2” and “-(2+1)” it denotes an application of the monadic minus operator.
    // --> Case3: In the expression “1-2” it denotes the dyadic subtraction operator.

    // Case 1. Sign of Number Constants:
    // This is similar to how it works in mathematics, where a hyphen before a number signifies a negative value.
    // For example, -2 represents the integer -2.
    let negateConstant (x: int) : int =
        -x

    // Case 2. Monadic Minus Operator:
    // The monadic minus operator is a unary operator that negates the value that follows it.
    // In the example "- 2", it means the negative of 2.
    // In the example "-(2+1)", it means the negative of the result of the expression (2+1).
    let applyMonadicMinusOperatorUsingExternalFunction func x =
        func x

    // Case 3. Dyadic Subtraction Operator:
    // In the expression "1-2", the hyphen is used to denote the dyadic subtraction operator.
    // This is a binary operator that performs subtraction between the two operands.
    // In this case, it represents the subtraction of 2 from 1, resulting in -1.
    let subtractValues (x: int) (y: int) : int =
        x - y
