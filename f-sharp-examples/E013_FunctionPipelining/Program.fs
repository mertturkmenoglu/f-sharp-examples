let addThree n =
    n + 3
    
    
let addFive n =   
   n + 5  


[<EntryPoint>]
let main argv =
    let result = 2 |> addThree |> addFive
    printfn "%d"result
    
    0