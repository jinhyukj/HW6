module CS220.BoardHelper

let checkWinner (states: SlotState array) =
  //failwith "Implement" // REMOVE this line when you implement your own code
  if (states.[0] = Marked O) && (states.[1] = Marked O) && (states.[2] = Marked O) then Some O
  elif (states.[3] = Marked O) && (states.[4] = Marked O) && (states.[5] = Marked O) then Some O
  elif (states.[6] = Marked O) && (states.[7] = Marked O) && (states.[8] = Marked O) then Some O
  elif (states.[0] = Marked O) && (states.[3] = Marked O) && (states.[6] = Marked O) then Some O
  elif (states.[1] = Marked O) && (states.[4] = Marked O) && (states.[7] = Marked O) then Some O
  elif (states.[2] = Marked O) && (states.[5] = Marked O) && (states.[8] = Marked O) then Some O
  elif (states.[0] = Marked O) && (states.[4] = Marked O) && (states.[8] = Marked O) then Some O
  elif (states.[2] = Marked O) && (states.[4] = Marked O) && (states.[6] = Marked O) then Some O
  elif (states.[0] = Marked X) && (states.[1] = Marked X) && (states.[2] = Marked X) then Some X
  elif (states.[3] = Marked X) && (states.[4] = Marked X) && (states.[5] = Marked X) then Some X
  elif (states.[6] = Marked X) && (states.[7] = Marked X) && (states.[8] = Marked X) then Some X
  elif (states.[0] = Marked X) && (states.[3] = Marked X) && (states.[6] = Marked X) then Some X
  elif (states.[1] = Marked X) && (states.[4] = Marked X) && (states.[7] = Marked X) then Some X
  elif (states.[2] = Marked X) && (states.[5] = Marked X) && (states.[8] = Marked X) then Some X
  elif (states.[0] = Marked X) && (states.[4] = Marked X) && (states.[8] = Marked X) then Some X
  elif (states.[2] = Marked X) && (states.[4] = Marked X) && (states.[6] = Marked X) then Some X
  else None


let isDraw (states: SlotState array) =
  //failwith "Implement" // REMOVE this line when you implement your own code
  if (states.[0] = EmptySlot) || (states.[1] = EmptySlot) || (states.[2] = EmptySlot) || (states.[3] = EmptySlot) || (states.[4] = EmptySlot) || (states.[5] = EmptySlot) || (states.[6] = EmptySlot) || (states.[7] = EmptySlot) || (states.[8] = EmptySlot) then false
  else true