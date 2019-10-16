let stringHash (str: string) =
    let r = float 31
    let m = 97
    let entries = List.ofArray (str.ToCharArray())
                |> List.map (fun x -> int x - int 'a' + 1)
                |> List.indexed

    let mutable result = 0
    for entry in entries do
        result <- result + (snd entry) * int(r ** float(fst entry)) 
    result % m

[<EntryPoint>]
let main argv =
    let l = [ "elma"; "male"; "lame" ]
    printfn "%A" (List.map stringHash l)
    0
