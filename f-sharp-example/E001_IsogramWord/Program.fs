let isIsogram(str: string) =
    let filtered =
        str.ToLower().ToCharArray()
        |> Array.filter (fun c -> c <> ' ' || c <> '-')
        
    let l =filtered |> Array.distinct
    
    l.Length = filtered.Length
    
[<EntryPoint>]
let main args =
    printfn "%b" (isIsogram("aBcD eFg-rM"))
    printfn "%b" (isIsogram("mM"))
    
    0