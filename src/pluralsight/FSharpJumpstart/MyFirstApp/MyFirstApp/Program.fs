// Learn more about F# at http://fsharp.org

open System

let SayHello() = 
    printfn "Hello"

[<EntryPoint>]
let main argv =
    SayHello()
    System.Console.ReadKey() |> ignore
    0 // return an integer exit code
