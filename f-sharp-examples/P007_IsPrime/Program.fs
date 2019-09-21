type System.Int32 with
    member this.IsPrime() = match this with
                            | this when this < 2 -> false
                            | this when this = 2 -> true
                            | this when this % 2 = 0 -> false
                            | this when seq { 3 .. int(sqrt(float this)) } |> Seq.exists(fun x -> this % x = 0) -> false
                            | _ -> true

[<EntryPoint>]
let main argv =
    let numbers = [0; 1; 2; 3; 4; 5; 7; 8; 13; 27; 49; 89; 97]
    for n in numbers do
        printf "Number: %d" n
        printfn "\tIsPrime: %b" (n.IsPrime())

    0
