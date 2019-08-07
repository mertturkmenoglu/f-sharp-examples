open System

printfn "Hello World with printfn"
Console.WriteLine("Hello World with System.Console.WriteLine")

let program =
    printfn "Hello World with function declaration"
    
program

type Program() =
    class
        do printfn "Hello World with class"
    end
    
new Program() |> ignore