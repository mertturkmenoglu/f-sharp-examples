let addNumbers(first: int, second: int) =
    first + second

let addOne n = addNumbers(n, 1)
let addTwo n = addNumbers(n, 2)
let addThree = addTwo >> addOne

let numbers = [1..10]
let result = numbers |> Seq.map addThree
printfn "%A" result
