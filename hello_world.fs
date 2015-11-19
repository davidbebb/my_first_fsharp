open System //This allows us to use Console. later on
//This is a comment in f#
[<EntryPoint>] //This tells the compiler/repl where to start
let main (argv :String[]) = // NB could have left this as 'let main argv =', as f# can guess type...'
  printfn "Hello World" //Simples
  Console.ReadLine() |> ignore // F# rule: function MUST have a return. |> ignore as a way of discarding the
  // returm from .readline
  0 // The return from this function  (did I mention that f# likes functions to return stuff)
