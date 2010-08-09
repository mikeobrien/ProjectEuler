#light
(*
-----------------------------------------------------------------------------
Project Euler Problem #80
http://projecteuler.net/index.php?section=problems&id=80
-----------------------------------------------------------------------------
  
It is well known that if the square root of a natural number is not an 
integer, then it is irrational. The decimal expansion of such square roots is 
infinite without any repeating pattern at all.

The square root of two is 1.41421356237309504880..., and the digital sum of 
the first one hundred decimal digits is 475.

For the first one hundred natural numbers, find the total of the digital sums 
of the first one hundred decimal digits for all the irrational square roots.

Answer:
-----------------------------------------------------------------------------
*)

module Problem80

open System

let RunA _ =
    Display.Print "Solution #1 Result"

let RunB _ =
    Display.Print "Solution #2 Result"

let public Solutions = [RunA;RunB]

  