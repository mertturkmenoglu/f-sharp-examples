type Season = Winter | Spring | Summer | Fall

let SeasonInfo (s: Season) =
    match s with
    | Winter -> printfn "Winter is coming"
    | Spring -> printfn "Spring is ok"
    | Summer -> printfn "My sweet summer child"
    | Fall -> printfn "Fall of the knights"

[<EntryPoint>]
let main argv =
    SeasonInfo(Season.Winter)
    SeasonInfo(Summer)
    0