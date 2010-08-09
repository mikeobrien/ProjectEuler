#light
(*
-----------------------------------------------------------------------------
Project Euler Problem #1
http://projecteuler.net/index.php?section=problems&id=1
-----------------------------------------------------------------------------
If we list all the natural numbers below 10 that are multiples of 3 or 5, 
we get 3, 5, 6 and 9. The sum of these multiples is 23.

Find the sum of all the multiples of 3 or 5 below 1000.

Answer: 233168
-----------------------------------------------------------------------------
*)

module Problem1

open System
     
let max = 9999
     
let RunA _ = 
    seq {1..max} 
    |> Seq.sumBy (fun v -> if v % 3 = 0 || v % 5 = 0 then 0 else v) 

let RunB _ = 
    let threeSum = seq {for i in 1..(max / 3) -> i * 3} |> Seq.sum
    let fiveSum = seq {for i in 1..(max / 5) -> i * 5} |> Seq.sumBy (fun v -> if v % 3 = 0 then 0 else v)
    threeSum + fiveSum

// (((m/n)^2 + (m/n)) / 2) * n
let RunC _ = 
    let series m = ((m * m) + m) / 2
    let subSeries m n = (series (m / n)) * n
    (subSeries max 3) + (subSeries max 5) - (subSeries max 15)

let public Solutions = [RunA;RunB;RunC]