namespace CS220

/// Minimax strategy.
type MinimaxStrategy () =
  inherit AI ()
  override __.NextMove player board =
    //failwith "Implement" // REMOVE this line when you implement your own code
        let evaluate (board: Board) = 
            match board.CheckWinner () with
            | Some O -> -1
            | Some X -> 1
            | None -> 0


        let rec minimax board depth isMax = 
            let score = evaluate board

            if score = 1 then score
            elif score = -1 then score
            else
                if board.IsDraw () then 0
                else 
                    if isMax then 
                        let mutable best = -1000
                        for i in 1 .. 9 do
                            if not (board.IsOccupied i) then 
                                board.Mark i X
                                printf $"The depth is %d{depth} and %d{i} is being marked as X\n"
                                best <- max best (minimax board (depth + 1) (not isMax))
                                board.Clear i
                            else ()
                        best
                    else 
                        let mutable worst = 1000
                        for i in 1 .. 9 do 
                            if not (board.IsOccupied i)then
                                board.Mark i O
                                printf $"The depth is %d{depth} and %d{i} is being marked as O\n"
                                worst <- min worst (minimax board (depth + 1) (not isMax))
                                board.Clear i
                            else ()
                        worst

        let mutable bestVal = -1000
        let mutable bestMove = 0

        for i in 1..9 do
            if not (board.IsOccupied i) then 
                board.Mark i player
                let moveVal = 
                    if player = X then minimax board 0 false
                    else minimax board 0 true
                board.Clear i

                if moveVal > bestVal then
                    printf $"moveVal is %d{moveVal}\n"
                    printf $"i is %d{i}\n"
                    bestMove <- i
                    bestVal <- moveVal
                else ()
            else ()
        
        bestMove

                                


                    
