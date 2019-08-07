let printArray(arr: int[]) =
    printfn "Array: %A" arr

// Initialize
let arr1 = [| 2; 3; 5; 7; 11; |]

// Sequence of Expression
let arr2 = [| for i in 1..5->i |]

printfn "arr1: %A" arr1
printfn "arr2: %A" arr2

// Use Array module
let arr3 = Array.empty    // Create empty array
let arr4 = Array.create 5 42    // Create 5-element array, init with 42
let arr5 = Array.init 5 (fun i -> i)    // Create 5-element array, init with function
let arr6: int[] = Array.zeroCreate 5    // Create 5-element array, init 0

printfn "arr3: %A" arr3
printfn "arr4: %A" arr4
printfn "arr5: %A" arr5
printfn "arr6: %A" arr6


let arr = [| 1; 2; 3; |]
printfn "Array: %A" arr
Array.set arr 1 42
printArray arr  
     
// Multidimensional Arrays
let mtr = array2D [ [ 1; 2]; [3; 4] ]  
printfn "mtr: \n%A" mtr

printf "First element: %d" mtr.[0,0]