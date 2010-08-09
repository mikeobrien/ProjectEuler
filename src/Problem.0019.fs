#light
(*
-----------------------------------------------------------------------------
Project Euler Problem #19
http://projecteuler.net/index.php?section=problems&id=19
-----------------------------------------------------------------------------

You are given the following information, but you may prefer to do some 
research for yourself.

- 1 Jan 1900 was a Monday. 
- September, April, June and November have thirty days. 
- All the rest have thirty-one, Saving February alone, which has twenty-eight, 
  rain or shine. And on leap years, twenty-nine.
- A leap year occurs on any year evenly divisible by 4, but not on a century 
  unless it is divisible by 400.

How many Sundays fell on the first of the month during the twentieth century 
(1 Jan 1901 to 31 Dec 2000)?

Answer:
-----------------------------------------------------------------------------
*)

module Problem19

open System

let RunA _ =
    Display.Print "Solution #1 Result"

let RunB _ =
    Display.Print "Solution #2 Result"

let public Solutions = [RunA;RunB]

  