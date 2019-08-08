[<AbstractClass>]
type Person() =
    class
        abstract member PrintName: unit -> unit
    end
    
    
type Emily() =
    class
        inherit Person()
        override this.PrintName() =
            printfn "Emily"
    end
    
    
let e = new Emily()
e.PrintName()