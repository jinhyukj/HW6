namespace CS220

open System

/// Available options.
type GameOption =
  | RandomAIPlayerFirst
  | RandomAIComputerFirst
  | MinimaxAIPlayerFirst
  | MinimaxAIComputerFirst
  | Exit

module GameOption =
  let rec take () =
    printfn "1. Play with random AI (player first)."
    printfn "2. Play with random AI (computer first)."
    printfn "3. Play with minimax AI (player first)."
    printfn "4. Play with minimax AI (computer first)."
    printfn "5. Exit"
    Console.Write "> " (* Show the prompt here. *)
    match Console.ReadLine () with
    | "1" -> RandomAIPlayerFirst
    | "2" -> RandomAIComputerFirst
    | "3" -> MinimaxAIPlayerFirst
    | "4" -> MinimaxAIComputerFirst
    | "5" -> Exit
    | _ -> printfn "\n[*] Invalid option.\n"; take ()
