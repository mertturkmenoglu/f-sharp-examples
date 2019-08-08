type Person(name, age) =
    class
        let name = name
        let age = age
        
        member this.DisplayInfo() =
            printfn "Person: %s - %d" name age
    end
    
    
type MathUtil() =
    class
        static member addOne(a) = a + 1
    end
    
    
let e = new Person("emily", 35)
e.DisplayInfo()

printfn "%d" (MathUtil.addOne 3)