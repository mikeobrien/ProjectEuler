#light
(*
-----------------------------------------------------------------------------
Project Euler Problem #37
http://projecteuler.net/index.php?section=problems&id=37
-----------------------------------------------------------------------------
  
The number 3797 has an interesting property. Being prime itself, it is possible 
to continuously remove digits from left to right, and remain prime at each 
stage: 3797, 797, 97, and 7. Similarly we can work from right to left: 3797, 
379, 37, and 3.

Find the sum of the only eleven primes that are both truncatable from left to 
right and right to left.

NOTE: 2, 3, 5, and 7 are not considered to be truncatable primes.

Answer:
-----------------------------------------------------------------------------
*)

module Problem37

open System

let RunA _ =
    Display.Print "Solution #1 Result"

let RunB _ =
    Display.Print "Solution #2 Result"

let public Solutions = [RunA;RunB]

  