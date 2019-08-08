type Squirrel() =
    class
        member this.Eat() =
            printfn "Eating"
    end


type Squirrel with
    member this.Sound() =
        printfn "Making sound"


let s = new Squirrel()
s.Eat()
s.Sound()