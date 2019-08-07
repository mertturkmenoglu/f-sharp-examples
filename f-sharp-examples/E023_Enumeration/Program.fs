type Direction =  
   | North = 0  
   | West  = 1  
   | South = 2  
   | East  = 3  
  
let playerDirection = enum<Direction>(2)
printfn "Player looks at %A" playerDirection

let north: Direction = Direction.North
let northValue = int north
printfn "%A - %d" north northValue