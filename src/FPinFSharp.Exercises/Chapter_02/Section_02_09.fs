namespace FPinFSharp.Exercises.Chapter_02

// 2.9 Declaring prefix and infix operators
module Section_02_09 =

    // Prefix operators are expected to be placed in front of an operand or operands, much like a function.
    // Infix operators are expected to be placed between the two operands.
    // Only certain operators can be used as prefix operators.
    // Some operators are always prefix operators, others can be infix or prefix, and the rest are always infix operators.
    // Operators that begin with !, except !=, and the operator ~, or repeated sequences of~, are always prefix operators.
    // The operators +, -, +., -., &, &&, %, and %% can be prefix operators or infix operators.
    // It is possible to distinguish the prefix version of these operators from the infix version
    // by adding a ~ at the beginning of a prefix operator when it is defined.
    // The ~ is not used when you use the operator, only when it is defined.

    let (.||.) p q =
        (p || q) && not(p && q)

    let (~%%) x =
        1.0 / x
