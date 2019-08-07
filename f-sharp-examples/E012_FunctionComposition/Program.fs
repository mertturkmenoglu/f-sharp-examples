let addThree n =
    n + 3
    
    
let addFive n =   
   n + 5  
  
  
[<EntryPoint>]
let main argv =
    let addEight = addThree >> addFive
    let result = addEight 2
    printfn "%d"result
    0