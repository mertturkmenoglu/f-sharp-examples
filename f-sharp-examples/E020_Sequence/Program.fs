// Large data but not all of it is used
let seq1 = seq { 0 .. 50 }
Seq.iter(fun e -> printf " %d " e) seq1
printfn ""

let evenseq = seq { 0 .. 2 .. 10 }
for e in evenseq do
    printf " %d " e
    
printfn ""

let fromArr = [| 1 .. 100 |] |> Seq.ofArray
printfn "%A" fromArr

let fromList = [ 1 .. 20 ] |> Seq.ofList
printfn "%A" fromList

// Search (exists)
printfn "%b" (Seq.exists (fun e -> e = 42) { 1 .. 100 } )

// Sort
let sorted = Seq.sort ([ 3; 5; 2; 1; 7 ] |> Seq.ofList)
printfn "%A" sorted