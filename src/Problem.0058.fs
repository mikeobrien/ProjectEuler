#light
(*
-----------------------------------------------------------------------------
Project Euler Problem #58
http://projecteuler.net/index.php?section=problems&id=58
-----------------------------------------------------------------------------
  
Starting with 1 and spiralling anticlockwise in the following way, a square 
spiral with side length 7 is formed (See Problem.0058.html).

It is interesting to note that the odd squares lie along the bottom right 
diagonal, but what is more interesting is that 8 out of the 13 numbers lying 
along both diagonals are prime; that is, a ratio of 8/13 ≈ 62%.

If one complete new layer is wrapped around the spiral above, a square spiral 
with side length 9 will be formed. If this process is continued, what is the 
side length of the square spiral for which the ratio of primes along both 
diagonals first falls below 10%?

Answer:
-----------------------------------------------------------------------------
*)

module Problem58

open System

let RunA _ =
    Display.Print "Solution #1 Result"

let RunB _ =
    Display.Print "Solution #2 Result"

let public Solutions = [RunA;RunB]

  