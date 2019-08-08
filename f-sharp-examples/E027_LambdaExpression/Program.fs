let forEach(arr: int[], f:  (int -> unit)) =
    for e in arr do
        f(e)
        
let main args =
    let arr = Array.init 5 (fun i -> i)
    forEach(arr, (fun e -> printf "%d "e))
    printfn ""
    forEach(arr, (fun e -> printf "%.2f "(float(e) ** 2.0)))
    0
    
main() |> ignore