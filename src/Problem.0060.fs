#light
(*
-----------------------------------------------------------------------------
Project Euler Problem #60
http://projecteuler.net/index.php?section=problems&id=60
-----------------------------------------------------------------------------
  
The primes 3, 7, 109, and 673, are quite remarkable. By taking any two primes 
and concatenating them in any order the result will always be prime. For 
example, taking 7 and 109, both 7109 and 1097 are prime. The sum of these 
four primes, 792, represents the lowest sum for a set of four primes with 
this property.

Find the lowest sum for a set of five primes for which any two primes 
concatenate to produce another prime.

Answer:
-----------------------------------------------------------------------------
*)

module Problem60

open System

let RunA _ =
    Display.Print "Solution #1 Result"

let RunB _ =
    Display.Print "Solution #2 Result"

let public Solutions = [RunA;RunB]

  