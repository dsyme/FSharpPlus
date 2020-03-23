module FSharpPlus.Tests.Helpers

open System
open NUnit.Framework
open FSharpPlus

let res18 = Operators.sequence [Some 3; Some 2; Some 1]                    // Some [3; 2; 1]
