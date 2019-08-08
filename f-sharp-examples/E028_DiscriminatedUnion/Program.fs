type Light = | ON | OFF

let lightSwitch = function
    | ON -> OFF
    | OFF -> ON
    
let main() =
    let lamp = ON
    printfn "%A" lamp
    
    let newStatus = lightSwitch(lamp)
    printfn "%A" newStatus

    0
    
main() |> ignore