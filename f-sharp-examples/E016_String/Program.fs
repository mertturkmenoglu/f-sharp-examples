let chars : byte[] = "emily"B  
for i = 0 to chars.Length-1 do
    printfn "%d - %d" i chars.[i]
    
printfn "%c"("emily".[3])
    
    
let name = "Emily"

// String concat
printfn "%s"(name + " Smith")

// Substring
printfn "%s"(name.[2..4])

// Get Char
printfn "%c"(name.Chars(3))

// Compare
printfn "%b"(name = "Emily")

// Contains
printfn "%b"(name.Contains("mil"))

// Trim
printfn "Name:%s"("  Emily  .".Trim())