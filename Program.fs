module CS220.Program

let start = function
  | RandomAIPlayerFirst ->
    TicTacToe(O, X, true, RandomStrategy ()).Run()
    true
  | RandomAIComputerFirst ->
    TicTacToe(O, X, false, RandomStrategy ()).Run()
    true
  | MinimaxAIPlayerFirst ->
    TicTacToe(O, X, true, MinimaxStrategy ()).Run()
    true
  | MinimaxAIComputerFirst ->
    TicTacToe(O, X, false, MinimaxStrategy ()).Run()
    true
  | Exit -> false

let rec gameLoop keepGoing =
  if keepGoing then GameOption.take () |> start |> gameLoop
  else 0

[<EntryPoint>]
let main _args =
  printfn "[CS220] Tic Tac Toe"
  gameLoop true
