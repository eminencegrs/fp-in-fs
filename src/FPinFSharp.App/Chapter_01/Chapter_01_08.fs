namespace FPinFSharp.App.Chapter_01

// 1.8 Euclid’s algorithm (for computing the greatest common divisor of two natural numbers).
module Chapter_01_08 =

    let rec gcd (m, n) =
        match (m, n) with
        | (0, n) -> n
        | (m, n) -> gcd(n % m, m)
