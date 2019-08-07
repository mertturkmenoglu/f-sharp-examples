(**
  * Define a function
  *)
let addFunction x y = x + y

[<EntryPoint>]
let main arg =
  printfn "Add 3 and 5"
  printfn "%d"(addFunction 3 5)

  let result = addFunction 3 5
  printfn "%d"result

  // Ignore return value
  addFunction 3 5 |> ignore
  0