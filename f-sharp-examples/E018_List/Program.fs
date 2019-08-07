open System

let primes = [ 2; 3; 5; 7; 11 ]
let numbers = [ 0 .. 9 ]

for p in primes do
    printf "%d" p

printfn ""
    

// Add element
let extendedPrimes = 13::primes 
printfn "%A" extendedPrimes
    
    
// Concat
let all = numbers@extendedPrimes
printfn "%A" all


// Properties
printfn "IsEmpty: %b" all.IsEmpty
printfn "Length:  %d" all.Length
printfn "Head: %d" all.Head
printfn "Tail.Head: %d" all.Tail.Head
printfn "Item(3): %d" (all.Item(3))

// Sort
let sorted = List.sort all
Console.WriteLine sorted

// Search (Find)
let comp n e = e = n
let result = List.find (comp 42) [1..100]
printfn "%d" result

// Zip
let zipped = List.zip [3..5][7..9]
printfn "%A" zipped

for (f, s) in zipped do
    printfn "%d - %d" f s

let unzipped = List.unzip(zipped)
printfn "%A" unzipped