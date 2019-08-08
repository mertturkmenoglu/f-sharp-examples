type Animal(name) =
    class
        let name = name
        
        member this.PrintInfo =
            printfn "Animal: %s" name
    end
    

type Squirrel(name) =
    class
        inherit Animal(name)
        
        member this.PrintSquirrelInfo =
            printfn "Squirrel: %s" name
    end
    
    
let alf = new Squirrel("alf")
alf.PrintInfo
alf.PrintSquirrelInfo