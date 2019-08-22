let duplicateCount(str: string) =
    str.ToLower()
    |> Seq.toList
    |> List.groupBy(fun x -> x)
    |> List.filter(fun x -> (snd x).Length > 1)
    |> List.map(fun x -> (fst x, snd(x).Length))

[<EntryPoint>]
let main argv =
    printfn "%A" ( duplicateCount "Canakkale")
    0