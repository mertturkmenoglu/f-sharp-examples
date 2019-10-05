// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let strList = [ "Emily"; "Diana"; "barbara"; "selina" ]
    let intList = [ 1; 2; 3; 4; 5 ]
    let fibList = [ 1; 1; 2; 3; 5 ]
    
    let collected = List.collect (fun (e: string) -> [e.Length]) strList
    let concat = List.concat [ strList; [ "London"; "Toronto"; "Paris" ] ]
    let contains = List.contains 3 intList
    let distinct = List.distinct fibList
    let except = List.except [1; 2] intList
    let exists = List.exists (fun e -> e > 3) intList
    let exists2 = List.exists2 (fun e x -> e = 3 && x = 5) intList
    let filter = List.filter (fun (e: string) -> Char.IsUpper e.[0]) strList
    
    printfn "%A" collected
    printfn "%A" concat
    printfn "%A" contains
    printfn "%A" distinct
    printfn "%A" except
    printfn "%A" exists
    printfn "%A" exists2
    printfn "%A" filter
    
    0