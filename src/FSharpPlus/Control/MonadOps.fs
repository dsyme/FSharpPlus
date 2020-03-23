namespace FSharpPlus.Internals

module internal MonadOps =
    open FSharpPlus.Control

    let inline (>>=) x f = Bind.Invoke x f
    let inline result  x = Return.Invoke x
    let inline (<*>) f x = Apply.Invoke f x
    let inline (>=>) (f: 'a->'``Monad<'b>``) (g: 'b->'``Monad<'c>``) (x: 'a) : '``Monad<'c>`` = f x >>= g