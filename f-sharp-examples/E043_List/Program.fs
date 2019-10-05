open System

[<EntryPoint>]
let main argv =
    let strList = [ "Emily"; "Diana"; "barbara"; "selina" ]
    let intList = [ 1; 2; 3; 4; 5 ]
    let fibList = [ 1; 1; 2; 3; 5 ]
    let emptyList = List.empty
    let appended = List.append emptyList [ 1.1; 2.0; 3.14; 4.2; 5.1 ]
    let avg = List.average appended
    let choose = List.choose (fun (e: string) -> match e with
                                                 | e when Char.IsUpper e.[0] -> Some(e)
                                                 | _ -> None) strList
    
    printfn "%A" strList
    printfn "%A" intList
    printfn "%A" fibList
    printfn "%A" emptyList
    printfn "%A" appended
    printfn "%A" avg
    printfn "%A" choose
    0
