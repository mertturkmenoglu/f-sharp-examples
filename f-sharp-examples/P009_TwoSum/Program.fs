let rec FindPairHelper(numbers: int list) (k: int) (passed: Set<int>): bool =
    if numbers.IsEmpty then
        false
    elif (Set.contains (k - numbers.Head) passed) then
        true
    else
        FindPairHelper numbers.Tail k (Set.add numbers.Head passed)
    
let FindPair (numbers: int list) (k: int) : bool =
    FindPairHelper numbers k Set.empty<int>


[<EntryPoint>]
let main argv =
    let list = [ 10; 15; 3; 7 ]
    let k = 17
    
    printfn "%b" (FindPair list k)
    
    0