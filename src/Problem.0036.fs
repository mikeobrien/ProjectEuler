#light
(*
-----------------------------------------------------------------------------
Project Euler Problem #36
http://projecteuler.net/index.php?section=problems&id=36
-----------------------------------------------------------------------------
  
The decimal number, 585 = 1001001001_(2) (binary), is palindromic in both bases.

Find the sum of all numbers, less than one million, which are palindromic in 
base 10 and base 2.

(Please note that the palindromic number, in either base, may not include 
leading zeros.)

Answer:
-----------------------------------------------------------------------------
*)

module Problem36

open System

let RunA _ =
    Display.Print "Solution #1 Result"

let RunB _ =
    Display.Print "Solution #2 Result"

let public Solutions = [RunA;RunB]

  