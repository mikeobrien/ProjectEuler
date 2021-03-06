﻿#light
(*
-----------------------------------------------------------------------------
Project Euler Problem #2
http://projecteuler.net/index.php?section=problems&id=2
-----------------------------------------------------------------------------
Each new term in the Fibonacci sequence is generated by adding the previous 
two terms. By starting with 1 and 2, the first 10 terms will be:

                   1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...

Find the sum of all the even-valued terms in the sequence which do not 
exceed four million.

Answer: 4,613,732
-----------------------------------------------------------------------------
*)

module Problem2

open System

let max = 4000000
    
let fib = Seq.unfold (fun (last, current) -> Some (last, (current, current + last))) (1, 1)
     
let RunA _ = 
    fib 
    |> Seq.takeWhile (fun i -> i <= max)
    |> Seq.filter (fun i -> i % 2 = 0)
    |> Seq.fold(fun state item -> state + item) 0

let sqrt5 = sqrt 5.0
let Phi = (1.0 + sqrt5) / 2.0
let fibn n = Phi ** float n / sqrt5 |> round |> int
let fib2 = Seq.unfold (fun index -> Some (fibn index,index + 1)) 1

let RunB _ = 
    fib2 
    |> Seq.takeWhile (fun i -> i <= max)
    |> Seq.filter (fun i -> i % 2 = 0)
    |> Seq.fold(fun state item -> state + item) 0
    
let public Solutions = [RunA;RunB]