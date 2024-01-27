namespace FPinFSharp.Exercises.Chapter_02

// 2.5 Type inference
module Section_02_06 =

    // Consider the function 'power'.
    // Please note: there is already a power operator '**' in F#,
    // so this function 'power' is used for illustrating the declaration of
    // recursive functions and the type inference performed by the system.
    let rec power = function
        | x, 0 -> 1.0
        | x, n -> x * power(x, n - 1)

    // The F# system deduces that 'power' has the type 'float * int -> float'.
    // How F# is able to infer this type of power by arguing as follows:
    // 1. The keyword 'function' indicates that the type of 'power' is
    //    a function type "T -> T'" for some types "T" and "T'".
    // 2. Since 'power' is applied to a pair (x, n) in the declaration,
    //    the type "T" must have the form "T1 * T2" for some types "T1" and "T2".
    // 3. Given "T2 = int", since the pattern of this clause is (x, 0),
    //    and 0 has type 'int'.
    // 4. Given "T' = float", since the expression for the function value in the 1st clause:
    //    1.0 has type 'float'.
    // 5. 'power(x, n - 1)' has the type 'float' since "T' = float".
    //    Thus, the overloaded operator symbol '*' in 'x * power(x, n - 1)'
    //    resolves to 'float' multiplication and 'x' must be of type 'float'.
    //    We hence get 'T1 = float'.
