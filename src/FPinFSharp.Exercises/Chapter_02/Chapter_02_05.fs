namespace FPinFSharp.Exercises.Chapter_02

// 2.5 Overloaded functions and operators
module Chapter_02_05 =

    // A name or symbol for a function or operator is overloaded if it has different meanings
    // when applied to arguments or operands of different types.
    // A (mathematical) function on real numbers is considered different from the corresponding function on integers,
    // as they are implemented in F# by different machine instructions. An operator of this kind is hence overloaded:
    // it denotes different functions depending on the context, and it depends on the types of the operands whether,
    // for example, the operator * denotes multiplication on integers (of type int)
    // or multiplication on real numbers (of type float).
    // The F# system tries to resolve these ambiguities in the following way:
    // --> If the type can be inferred from the context, then an overloaded operator symbol is interpreted
    // as denoting the function on the inferred type.
    // --> If the type cannot be inferred from the context, then an overloaded operator symbol with a default type
    // will default to this type. The default type is int if the operator can be applied to integers.

    type Math_v1() =
        member this.square (x: int) : int = x * x

        // Declaring a squaring function on reals can be done either by specifying
        // THE TYPE OF THE ARGUMENT.
        member this.square (x: float) : float = x * x

    type Math_v2() =
        member this.square (x: int) : int = x * x

        // Declaring a squaring function on reals can be done either by specifying
        // THE TYPE OF THE RESULT.
        member this.square x : float = x * x

    type Math_v3() =
        member this.square (x: int) : int = x * x

        // Declaring a squaring function on reals can be done either by specifying
        // THE TYPE OF THE EXPRESSION for the function value.
        member this.square x = x * x : float

    // Please, note:
    // Overloading is extensively used in the .NET library and
    // typing of arguments is frequently needed to resolve ambiguities.
    // The user may declare overloaded operators and functions inside a type declaration
    // as explained in Section 07 03.
