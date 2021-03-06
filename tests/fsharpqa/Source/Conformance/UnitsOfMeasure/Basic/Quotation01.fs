// #Regression #Conformance #UnitsOfMeasure #RequiresPowerPack 
// Regression test for FSHARP1.0:3248
// Verify we can use Units of Measure in a quotation
#light

// Bring .Eval(), .Compile(), etc... in scope!
open Microsoft.FSharp.Linq.QuotationEvaluation

[<Measure>]
type Kg

let x = 4.0<Kg>
let q = <@ if (x = 4.0<Kg>) then 0 else 1 @>

q.Eval() |> exit
