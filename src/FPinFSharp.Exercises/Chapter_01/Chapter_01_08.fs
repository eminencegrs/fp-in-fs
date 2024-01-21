namespace FPinFSharp.Exercises.Chapter_01

// 1.8 Euclid’s algorithm (for computing the greatest common divisor of two natural numbers).
module Chapter_01_08 =

    // Euclid's algorithm is implemented by using pattern matching to handle the base case (when `m` is 0)
    // and recursively updating the values of `m` and `n` until the base case is reached.
    let rec gcd (m, n) =
        match (m, n) with
        | 0, n -> n
        | m, n -> gcd(n % m, m)
