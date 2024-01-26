namespace FPinFSharp.Exercises.Chapter_02

// 2.4 If-then-else expressions
module Section_02_04 =

    // Please see Chapter_01_08.fs for the additional information.
    let rec gcd (m, n) =
        if m = 0
        then n
        else gcd(n % m, m)
