type Animal() =
    class
        member this.PrintInfo() =
            printfn "General animal"
end


type Squirrel() =
    class
        inherit Animal()
        member this.PrintInfo() =
            printfn "Little squirrel"
end


[<EntryPoint>]
let main argv =
    let a = new Animal()
    let s: Squirrel = new Squirrel()
    
    a.PrintInfo()
    s.PrintInfo()
    
    let castIntoAnimal = s :> Animal // Upcasting
    castIntoAnimal.PrintInfo()
    
    // TODO: Unhandled exception
//    let castIntoSquirrel = a :?>Squirrel    // Downcasting
//    castIntoSquirrel.PrintInfo()
    
    0