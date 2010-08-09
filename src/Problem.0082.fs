#light
(*
-----------------------------------------------------------------------------
Project Euler Problem #82
http://projecteuler.net/index.php?section=problems&id=82
-----------------------------------------------------------------------------
  
NOTE: This problem is a more challenging version of Problem 81.

The minimal path sum in the 5 by 5 matrix below, by starting in any cell in 
the left column and finishing in any cell in the right column, and only moving 
up, down, and right, is indicated in red and bold; the sum is equal to 994.
(See Problem.0082.html)

Find the minimal path sum, in Problem.0082.txt, a 31K text file containing a 
80 by 80 matrix, from the left column to the right column.

Answer:
-----------------------------------------------------------------------------
*)

module Problem82

open System

let RunA _ =
    Display.Print "Solution #1 Result"

let RunB _ =
    Display.Print "Solution #2 Result"

let public Solutions = [RunA;RunB]

  