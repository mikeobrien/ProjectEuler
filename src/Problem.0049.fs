#light
(*
-----------------------------------------------------------------------------
Project Euler Problem #49
http://projecteuler.net/index.php?section=problems&id=49
-----------------------------------------------------------------------------
  
The arithmetic sequence, 1487, 4817, 8147, in which each of the terms increases 
by 3330, is unusual in two ways: (i) each of the three terms are prime, and, 
(ii) each of the 4-digit numbers are permutations of one another.

There are no arithmetic sequences made up of three 1-, 2-, or 3-digit primes, 
exhibiting this property, but there is one other 4-digit increasing sequence.

What 12-digit number do you form by concatenating the three terms in this 
sequence?

Answer:
-----------------------------------------------------------------------------
*)

module Problem49

open System

let RunA _ =
    Display.Print "Solution #1 Result"

let RunB _ =
    Display.Print "Solution #2 Result"

let public Solutions = [RunA;RunB]

  