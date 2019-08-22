let evenSum(list: List<int>): int =
    list
    |> List.filter (fun x -> x % 2 = 0)
    |> List.sum

let main args =
    let result = evenSum [ 1; 1; 2; 4; 3; 9; 6; ]
    printfn "%d" result
    0

main() |> ignore