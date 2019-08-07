module MathUtil =
    let addOp(first: int, second: int): int =
        first + second
    let subOp(first: int, second: int): int =
        first - second
    let mulOp(first: int, second: int): int =
        first * second
    let divOp(first: int, second: int): int =
        if second <> 0 then
           first / second
        else 0
    let modOp(first: int, second: int): int =
        first % second


open MathUtil
        
[<EntryPoint>]
let main argv =
    printfn "%d"(addOp(3, 5))
    printfn "%d"(subOp(3, 5))
    printfn "%d"(mulOp(3, 5))
    printfn "%d"(divOp(7, 2))
    printfn "%d"(modOp(8, 5))
    
    0
