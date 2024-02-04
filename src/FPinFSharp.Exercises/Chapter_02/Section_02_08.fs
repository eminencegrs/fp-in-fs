namespace FPinFSharp.Exercises.Chapter_02

// 2.7 Closures
module Section_02_08 =

    // A closure gives the means of explaining a value that is a function. A closure is a triple: (x, exp, env).
    // Where 'x' is an argument identifier,
    // 'exp' is the expression to evaluate to get a function value,
    // while 'env' is an environment giving bindings to be used in such an evaluation.

    // The following simple example illustrates the role of the environment in the closure:
    let getPI = System.Math.PI

    let circleArea r = getPI * r * r   // float -> float
    // These declarations bind the identifier 'pi' to a float value and 'circleArea' to a closure:
    //      pi --> 3.14159
    //      circleArea --> (r, pi * r * r, [pi --> 3.14159...])
