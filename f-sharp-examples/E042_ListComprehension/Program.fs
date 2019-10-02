[<EntryPoint>]
let main argv =
    let numbers = [ for i in 0 .. 10 -> (i, i+1) ]

    for n in numbers do
        printfn "%A" n

    let evens = [ for i in 1 .. 10 -> if (i % 2 = 0) then i else 0 ]
                |> List.filter (fun x -> x <> 0)

    printfn "%A" evens

    0