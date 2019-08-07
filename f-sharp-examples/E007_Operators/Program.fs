let compare(a: int, b: int): string =
    if (a < b) then
        "<"
    elif (a > b) then
        ">"
    else "="
        
[<EntryPoint>]
let main argv =
    printfn "Compare result: %s"(compare(3, 5))
   
    0