open System

[<EntryPoint>]
let main argv =
    Console.Write("Enter a number: ")
    
    let inp = Console.ReadLine()
    let num = inp |> Int32.Parse
    
    if num > 0 then
        printfn "Positive"
    elif num = 0 then
        printfn "Zero"
    else printfn "Negative"
    
    0