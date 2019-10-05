[<EntryPoint>]
let main argv =
    let strList = [ "Emily"; "Diana"; "barbara"; "selina" ]
    let intList = [ 1; 2; 3; 4; 5 ]
    
    let find = List.find (fun e -> e = "Emily") strList
    let fold = List.fold (fun acc e -> acc + e) 0 intList
    let fold2 = List.fold2 (fun acc x1 x2 -> acc + max x1 x2) 0 [1; 2; 3] [0; 3; 5]
    let for_all = List.forall (fun e -> e > 3) intList 
    let for_all2 = List.forall2 (fun x1 x2 -> x1 > x2) [1; 2; 3] [0; 1; 2]
    let head = List.head strList
    let indexed = List.indexed strList
    let init = List.init 5 (fun x -> x)
    let item = List.item 2 strList
    
    printfn "%A" find
    printfn "%A" fold
    printfn "%A" fold2
    printfn "%A" for_all
    printfn "%A" for_all2
    printfn "%A" head
    printfn "%A" indexed
    printfn "%A" init
    printfn "%A" item
    
    0