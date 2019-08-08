type BaseClass() =
    class
        abstract PrintClassName: unit -> unit
        default this.PrintClassName() =
            printfn "Base Class"
    end
    

type DerivedClass() =
    class
        inherit BaseClass()
        override this.PrintClassName() =
            printfn "Derived Class"
    end
    
    
let b = new BaseClass()
let d = new DerivedClass()

b.PrintClassName()
d.PrintClassName()