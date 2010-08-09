#light
(*
-----------------------------------------------------------------------------
Project Euler Problem #40
http://projecteuler.net/index.php?section=problems&id=40
-----------------------------------------------------------------------------
  
An irrational decimal fraction is created by concatenating the positive 
integers:

0.12345678910 1 112131415161718192021...

It can be seen that the 12th digit of the fractional part is 1.

If d_(n) represents the nth digit of the fractional part, find the value 
of the following expression.

d_(1)×d_(10)×d_(100)×d_(1000)×d_(10000)×d_(100000)×d_(1000000)

Answer:
-----------------------------------------------------------------------------
*)

module Problem40

open System

let RunA _ =
    Display.Print "Solution #1 Result"

let RunB _ =
    Display.Print "Solution #2 Result"

let public Solutions = [RunA;RunB]

  