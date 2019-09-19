let rec ackermann(m: int, n: int): int =
    match (m, n) with
        | (m, n) when m = 0 -> n + 1
        | (m, n) when n = 0 -> ackermann(m - 1, 1)
        | _ -> ackermann(m - 1, ackermann(m, n - 1))

printfn "Ackermann(3, 5): %d" (ackermann(3, 5))
