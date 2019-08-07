let rec factorial n =
    if n > 1 then
        (n * factorial(n - 1))
    else
        1
        
        
[<EntryPoint>]
let main argv =
    printfn "%d"(factorial 5)
    0
