#light
(*
-----------------------------------------------------------------------------
Project Euler Problem #53
http://projecteuler.net/index.php?section=problems&id=53
-----------------------------------------------------------------------------
  
There are exactly ten ways of selecting three from five, 12345:

123, 124, 125, 134, 135, 145, 234, 235, 245, and 345

In combinatorics, we use the notation, ^(5)C_(3) = 10.

In general,

^(n)C_(r) = n!/(r!(n−r)!), where  r≤ n, n! = n×(n−1)×...×3×2×1, and 0! = 1.

It is not until n = 23, that a value exceeds one-million: ^(23)C_(10) = 1144066.

How many, not necessarily distinct, values of  ^(n)C_(r), for 1 ≤ n ≤ 100, are 
greater than one-million?

Answer:
-----------------------------------------------------------------------------
*)

module Problem53

open System

let RunA _ =
    Display.Print "Solution #1 Result"

let RunB _ =
    Display.Print "Solution #2 Result"

let public Solutions = [RunA;RunB]

  