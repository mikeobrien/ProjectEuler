#light

open System
open System.Diagnostics 

let solutions = Problem2.Solutions

let runSolution s (i:int) = 
    let stopWatch = new Stopwatch()
    Display.PrintSectionDivider ()
    Display.PrintTitle (String.Format("Solution {0}", i))
    Display.PrintSubSectionDivider ()
    stopWatch.Start()
    s () |> ignore
    stopWatch.Stop()
    s () |> Display.Print 
    Display.PrintSubSectionDivider ()
    Display.Print (String.Format("Solution Total Time: {0} ticks", stopWatch.ElapsedTicks.ToString("#,###")))
    i + 1

// Get the jitting out of the way so it doesent play into the execution time...
Display.SetColors ConsoleColor.DarkBlue ConsoleColor.DarkBlue
List.fold (fun i s -> runSolution s i) 1 solutions |> ignore

// Run visible now that everything has been jitted
Display.Clear ()
Display.SetColors ConsoleColor.DarkBlue ConsoleColor.White
Display.PrintHeader ()
Display.Print "Project Euler"

List.fold (fun i s -> runSolution s i) 1 solutions |> ignore

Display.PrintFooter ()
Display.Pause ()