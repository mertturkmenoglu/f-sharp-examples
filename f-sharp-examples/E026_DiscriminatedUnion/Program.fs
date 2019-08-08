type Squirrel = { name: string; color: string }

type Mixed =  
    | I of int  
    | Sq of Squirrel  
    | SpecialTuple of int * int  
  
let whatIsIt arg =  
   match arg with  
     | I _ -> "Integer"  
     | Sq _ -> "Squirrel"       
     | SpecialTuple (_, _) -> "Tuple"
                           
let alf = Sq { name = "alf"; color = "brown" }
let number = I 42
let myTuple = SpecialTuple (42, 42)
  
printfn "Alf is a %s" (whatIsIt alf)
printfn "Number is an %s" (whatIsIt number)
printfn "My tuple is a %s" (whatIsIt myTuple)