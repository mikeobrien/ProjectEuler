#light
(*
-----------------------------------------------------------------------------
Project Euler Problem #78
http://projecteuler.net/index.php?section=problems&id=78
-----------------------------------------------------------------------------
  
Let p(n) represent the number of different ways in which n coins can be 
separated into piles. For example, five coins can separated into piles in 
exactly seven different ways, so p(5)=7.

     OOOOO
   OOOO   O
   OOO   OO
  OOO   O  O
  OO   OO   O
 OO   O   O   O
O   O   O   O   O

Find the least value of n for which p(n) is divisible by one million.

Answer:
-----------------------------------------------------------------------------
*)

module Problem78

open System

let RunA _ =
    Display.Print "Solution #1 Result"

let RunB _ =
    Display.Print "Solution #2 Result"

let public Solutions = [RunA;RunB]

  