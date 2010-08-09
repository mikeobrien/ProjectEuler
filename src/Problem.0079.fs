#light
(*
-----------------------------------------------------------------------------
Project Euler Problem #79
http://projecteuler.net/index.php?section=problems&id=79
-----------------------------------------------------------------------------
  
A common security method used for online banking is to ask the user for three 
random characters from a passcode. For example, if the passcode was 531278, 
they may asked for the 2nd, 3rd, and 5th characters; the expected reply would 
be: 317.

The text file, Problem.0079.txt, contains fifty successful login attempts.

Given that the three characters are always asked for in order, analyse the 
file so as to determine the shortest possible secret passcode of unknown 
length.

Answer:
-----------------------------------------------------------------------------
*)

module Problem79

open System

let RunA _ =
    Display.Print "Solution #1 Result"

let RunB _ =
    Display.Print "Solution #2 Result"

let public Solutions = [RunA;RunB]

  