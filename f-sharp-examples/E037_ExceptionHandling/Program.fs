let division first second =
    let mutable result = 0
    try
        try
            result <- first / second
        with
            | :? System.DivideByZeroException as e -> printfn "%s" e.Message
    finally
        printfn "Division"
    result

printfn "6 / 2 = %d" (division 6 2)
printfn "6 / 0 = %d" (division 6 0)