// Pattern match
let pmatch arg =
    match arg with
        | 1 -> "One"
        | 2 -> "Two"
        | _ -> "Other"


// Object pattern match
let opmatch(arg: obj) =
    match arg with
        | :? int -> "Integer"
        | :? float -> "Real"
        | _ -> "Other type"

        
// Conditional pattern match
let cpmatch arg1 arg2 =
    match (arg1, arg2) with
        | (arg1, arg2) when arg1 > arg2 -> ">"
        | (arg1, arg2) when arg1 < arg2 -> "<"
        | _ -> "="


// List pattern match
let lpmatch list =
    match list with
        | [value] -> value
        | [value1; value2] -> value1 + value2
        | _ -> -1


// Tuple pattern match
let tpmatch tuple =
    match tuple with
        | ("a", "a") -> "AA"
        | ("a", _) -> "A_"
        | (_, "a") -> "_A"
        | _ -> ""
        
        
[<EntryPoint>]
let main argv =
    printfn "%s"(pmatch 2)
    printfn "%s"(pmatch 42)
    
    printfn "%s"(opmatch(3.14))
    printfn "%s"(opmatch("emily"))
    
    let result = cpmatch 3 5
    printfn "%s"result
    
    printfn "%d"(lpmatch [1; 2])
    
    printfn "%s"(tpmatch ("a", "b"))
    
    0