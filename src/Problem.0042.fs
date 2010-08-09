#light
(*
-----------------------------------------------------------------------------
Project Euler Problem #42
http://projecteuler.net/index.php?section=problems&id=42
-----------------------------------------------------------------------------
  
The nth term of the sequence of triangle numbers is given by, 
t_(n) = ½n(n+1); so the first ten triangle numbers are:

1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ...

By converting each letter in a word to a number corresponding to its 
alphabetical position and adding these values we form a word value. For 
example, the word value for SKY is 19 + 11 + 25 = 55 = t_(10). If the word 
value is a triangle number then we shall call the word a triangle word.

Using Problem.0042.txt, a 16K text file containing nearly two-thousand common 
English words, how many are triangle words?

Answer:
-----------------------------------------------------------------------------
*)

module Problem42

open System

let RunA _ =
    Display.Print "Solution #1 Result"

let RunB _ =
    Display.Print "Solution #2 Result"

let public Solutions = [RunA;RunB]

  