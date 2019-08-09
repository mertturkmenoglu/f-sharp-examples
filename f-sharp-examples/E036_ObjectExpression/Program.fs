[<AbstractClass>]
type Squirrel() =
    class
        abstract member PrintInfo: unit -> unit
    end

let alf =
    {
        new Squirrel() with member this.PrintInfo() = printfn "Alf"
    }
    
alf.PrintInfo()