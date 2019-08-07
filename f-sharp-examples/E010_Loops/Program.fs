[<EntryPoint>]
let main argv =
    for i = 0 to 5 do
        printfn "%d"i
        
    for i = 5 downto 0 do
        printfn "%d"i
        
    let names = ["emily"; "diana"; "barbara"]
    
    for name in names do
        printfn "%s"name
        
    let mutable index = 0
    while index < 5 do
        printfn "%d"index
        index <- index + 1
        
    0 
