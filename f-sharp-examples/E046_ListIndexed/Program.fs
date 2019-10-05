[<EntryPoint>]
let main argv =
    let names = [ "Emily"; "Diana"; "Barbara"; "Selina" ]
    
    for e in List.indexed names do
        printf "%d: " (fst e)
        printfn "%s" (snd e)

    0
