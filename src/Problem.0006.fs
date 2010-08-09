#light
(*
-----------------------------------------------------------------------------
Project Euler Problem #6
http://projecteuler.net/index.php?section=problems&id=6
-----------------------------------------------------------------------------
  
The sum of the squares of the first ten natural numbers is:

1^(2) + 2^(2) + ... + 10^(2) = 385

The square of the sum of the first ten natural numbers is:

(1 + 2 + ... + 10)^(2) = 55^(2) = 3025

Hence the difference between the sum of the squares of the first ten natural 
numbers and the square of the sum is 3025 − 385 = 2640.

Find the difference between the sum of the squares of the first one hundred 
natural numbers and the square of the sum.

Answer:
-----------------------------------------------------------------------------
*)

module Problem6

open System

let RunA _ =
    Display.Print "Solution #1 Result"

let RunB _ =
    Display.Print "Solution #2 Result"

let public Solutions = [RunA;RunB]

  