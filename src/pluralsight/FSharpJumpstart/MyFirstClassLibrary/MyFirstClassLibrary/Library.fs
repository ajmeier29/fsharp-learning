
module JumpStart

let SayHiTo (me : string) = 
    printfn "hi, %s", me

let Area (length : float) (height : float) : float =
    length * height

// filtering an array
let squares = 
    [|
        for i in 0..99 do 
            yield i*i
    |]

let IsEven n = 
    n % 2 = 0

let evenSquares = Array.filter(fun x -> IsEven x) squares

// forward pipe operator
let PrintLongWordsNoPipe (words : string[]) =
    let longWords : string [] = Array.filter(fun w -> w.Length > 8) words
    let sortedLongWords = Array.sort longWords
    Array.iter(fun w -> printfn "%s" w) sortedLongWords
// using a pipe operator this can become:
let PrintLongWordsWithPipe (words : string[]) =
    words
    |> Array.filter(fun w -> w.Length > 8)
    |> Array.sort
    |> Array.iter(fun w -> printfn "%s" w)