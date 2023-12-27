
;Name: Dustin Shaw
;Assignment 3
;Part 1: FizzBuzz
 

include 'emu8086.inc'

org 100h

mov CX, 10
mov BX, 15

LoopStart:

   ;check if div by 3
   mov DX, 0
   mov AX, BX
   div num3
   cmp DX, 0
   jnz checkFive
   
   
   mov AX, BX
   print "Fizz"
  
   
   
   ;check if div by 5
   checkFive:
       mov DX, 0
       mov AX, BX
       div num5
       cmp DX, 0
       jnz skipPrint
       
       mov AX, BX
       printn "Buzz"
       dec BX
       loop LoopStart
       
       
   ;if neither we'll skip the printing
   skipPrint:
       mov AX, BX
       Call PRINT_NUM
       printn
       dec BX
       loop LoopStart    



ret
num3 DW 3
num5 DW 5 
DEFINE_PRINT_NUM
DEFINE_PRINT_NUM_UNS



