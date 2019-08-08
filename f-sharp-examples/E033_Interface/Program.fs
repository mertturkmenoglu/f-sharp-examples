type IAnimal =
    abstract member PrintInfo: unit -> unit
    
type Squirrel(name) =
    interface IAnimal with
        member this.PrintInfo() =
            printfn "Squirrel: %s" name


let alf = new Squirrel("alf")
(alf :> IAnimal).PrintInfo()