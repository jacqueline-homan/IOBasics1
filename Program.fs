let x = 42
let hi = "Hello"
let sayHiTo me =
    printfn "Hi, %s" me
sayHiTo "J"

let square x = x * x
printfn "Enter an integer: "
let response = System.Console.ReadLine() |> int

printfn "%A" (square x, response)



[<EntryPoint>]
let main argv = 
    //printfn "%A" argv
    0 // return an integer exit code

