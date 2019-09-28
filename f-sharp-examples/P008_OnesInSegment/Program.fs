let ones(n: int) = System.Convert.ToString(n, 2).ToCharArray()
                   |> Array.countBy (fun x -> x = '1')
                   |> Array.length

let countOnes(start: int, last: int): int =
    if (start < 1) then
        -1
    else
        [start .. last]
        |> List.map (fun x -> ones(x))
        |> List.reduce (fun acc x -> acc + x)

[<EntryPoint>]
let main argv =
    let result = countOnes(4, 7)
    printfn "%d" result
    0