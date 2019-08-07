let AddOneAndTwo n =
    (n + 1, n + 2)

let values = (3.14, 42, "Emily", (fun a -> a * a))  
let (pi, answer, name, square) = values

printfn "%A"values
printfn "%f"pi
printfn "%d"answer
printfn "%s"name
printfn "%d"(square 3)

let vals = AddOneAndTwo 42
printfn "%A"vals
printfn "%d"(fst(vals))
printfn "%d"(snd(vals))