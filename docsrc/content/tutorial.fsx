(*** hide ***)
// This block of code is omitted in the generated HTML documentation. Use 
// it to define helpers that you do not want to show in the documentation.
#I "../../bin"
#r @"..\lib\FSharp.Plotly.dll"
(**
Introducing your project
========================

Say more

*)

(** 
### Evaluation demo 
The following is a simple calculation: *)
let test = 40 + 2

(** We can print it as follows: *)
(*** define-output:test ***)
printf "Result is: %d" test

(** The result of the previous snippet is: *)
(*** include-output:test ***)

(** And the variable `test` has the following value: *)
(*** include-value: test ***)

open FSharp.Plotly

let testData = [1.,2.;3.,4.]


let testPlot = testData |> Chart.Line

(*** include-value:testPlot ***)

#r "FSharpAux.dll"
open FSharpAux

Library.hello 0
(**
Some more info
*)
