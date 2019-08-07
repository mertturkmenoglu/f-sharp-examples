let refToFifty = ref 50
let var = 40
let reference = ref var

printfn "%d" 50
printfn "%d" refToFifty.Value
printfn "%d" var
printfn "%d" reference.Value

reference := reference.Value + 1
printfn "%d" reference.Value

reference := !refToFifty
printfn "%d" reference.Value

reference.Value <- 42
printfn "%d" reference.Value