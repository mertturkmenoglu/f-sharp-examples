let rec fact n =
    match n with
        | n when n <= 1 -> 1
        | _ -> n * fact(n-1)

printfn "0! --> %d" (fact 0)
printfn "1! --> %d" (fact 1)
printfn "5! --> %d" (fact 5)