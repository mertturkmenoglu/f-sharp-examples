let getSqrt x =
    if x < 0.0 then invalidArg "x"("Can not operate with negative numbers")
    else sqrt x


let getSqrt2 x =
    if x < 0.0 then failwith "Can not operate with negative numbers"
    else sqrt x
    
    
let main args =
    let valid = 25.0
    let invalid = -25.0
    
    printfn "%f" (getSqrt valid)
    printfn "%f" (getSqrt2 valid)
    
    try
        printfn "%f" (getSqrt invalid)
    with
        | _ as e -> printfn "%s" e.Message
        
    try
        printfn "%f" (getSqrt2 invalid)
    with
        | _ as e -> printfn "%s" e.Message
    
    0
    
main() |> ignore