[<EntryPoint>]
let main argv =
    let x: int = 65
    let y: byte = byte x
    
    printfn "y as int = %d"y
    
    let z: int = int y
    
    printfn "z as int = %d"z
    
    0