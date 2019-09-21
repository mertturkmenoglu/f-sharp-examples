let rec MergeHelper(f: int list, s: int list, r: int list): int list =
    match (f, s) with
        | (f, s) when List.isEmpty f && List.isEmpty s -> r
        | (f, s) when List.isEmpty f -> MergeHelper(f, s.Tail, r@[s.Head])
        | (f, s) when List.isEmpty s -> MergeHelper(f.Tail, s, r@[f.Head])
        | _ -> if f.Head <= s.Head then MergeHelper(f.Tail, s, r@[f.Head]) else MergeHelper(f, s.Tail, r@[s.Head])

let Merge(f: int list, s: int list): int list = MergeHelper(f, s, [])

[<EntryPoint>]
let hello name =
    let r = Merge([1; 2; 3], [0; 2; 5])
    printfn "%A" r
    0

