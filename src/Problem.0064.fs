#light
(*
-----------------------------------------------------------------------------
Project Euler Problem #64
http://projecteuler.net/index.php?section=problems&id=64
-----------------------------------------------------------------------------
  
All square roots are periodic when written as continued fractions and can be 
written in the form:

√N = a_(0) +          1
            ------------------------
            a_(1) +       1
                   -----------------
                   a_(2) +    1
                          ----------
                          a_(3) + ...

For example, let us consider √23:

√23 = 4 + √23 — 4 = 4 +   1   = 4 +    1
                       -------     ------------
                          1            √23 – 3
                       -------     1 + --------
                        √23—4             7

If we continue we would get the following expansion:

√23 = 4 +     1
         ------------------
         1 +     1
            ---------------
            3 +    1
               ------------
               1 +   1
                  ---------
                  8 + ...

The process can be summarised as follows:

               1      √23+4         √23—3
a_(0) = 4, ------- = -------- = 1 + -------
             √23—4      7              7
             
               7     7(√23+3)        √23—3
a_(1) = 1, ------- = -------- = 3 + -------
             √23—3      14             2  
             
               2     2(√23+3)        √23—4
a_(2) = 3, ------- = -------- = 1 + -------
             √23—3      14             7   
             
               7     7(√23+4)        
a_(3) = 1, ------- = -------- = 8 + √23—4
             √23—4      7         
             
               1      √23+4         √23—3
a_(4) = 8, ------- = -------- = 1 + -------
             √23—4      7              7  
             
               7     7(√23+3)        √23—3
a_(5) = 1, ------- = -------- = 3 + -------
             √23—3      14             2   
             
               2     2(√23+3)        √23—4
a_(6) = 3, ------- = -------- = 1 + -------
             √23—3      14             7   
             
               7     7(√23+4)        
a_(7) = 1, ------- = -------- = 8 + √23—4
             √23—4      7         

It can be seen that the sequence is repeating. For conciseness, we use the 
notation √23 = [4;(1,3,1,8)], to indicate that the block (1,3,1,8) repeats 
indefinitely.

The first ten continued fraction representations of (irrational) square 
roots are:

√2  = [1;(2)], period=1
√3  = [1;(1,2)], period=2
√5  = [2;(4)], period=1
√6  = [2;(2,4)], period=2
√7  = [2;(1,1,1,4)], period=4
√8  = [2;(1,4)], period=2
√10 = [3;(6)], period=1
√11 = [3;(3,6)], period=2
√12 = [3;(2,6)], period=2
√13 = [3;(1,1,1,1,6)], period=5

Exactly four continued fractions, for N ≤ 13, have an odd period.

How many continued fractions for N ≤ 10000 have an odd period?

Answer:
-----------------------------------------------------------------------------
*)

module Problem64

open System

let RunA _ =
    Display.Print "Solution #1 Result"

let RunB _ =
    Display.Print "Solution #2 Result"

let public Solutions = [RunA;RunB]

  