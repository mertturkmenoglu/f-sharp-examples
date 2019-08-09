exception InvalidNameException of string
let validateName name =
    match name with
        | "Emily" -> "Valid"
        | _ -> raise(InvalidNameException "Not a valid name")

let mutable result = ""
try
    result <- validateName "Emily"
with
    | :? InvalidNameException as e -> printfn "%s" e.Message
    
printfn "%s" result