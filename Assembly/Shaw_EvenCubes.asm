;Name: Dustin Shaw
;Assignment 3: Even Cubes
;03/27/2022 
;Goal: Output the values of each even cube from 1 to maxNum 

include 'emu8086.inc' ;included to import print functions so emu doesn't yell at me anymore

org 100h
     

mov BX, 1 ;Used to compate to maxNum so we know when to stop

LoopStart:
    ;Condtional - While type
    cmp maxNum, AX ;compare AX to maxNum        
    je END ; if AX is equal exit the loop
    
    
    mov AX, BX ;made AX the same as BX so we can multiply the same number

    mul BX ;using two muls here which feels wrong
    mul BX 
    
    mov DX, AX ; so we can store AX value without altering
    ;Conditional to check for even number
    sar DX, 1
    jc continueLoop ;Jump if carry flag is set; so not even.
        
        
        call PRINT_NUM
        printn
    
    continueLoop:
        inc BX
        jmp LoopStart 
    
    
    
   
   
END:
ret           

;Storing the max number we want to run
maxNum DW 512
;Import the print functions here
DEFINE_PRINT_NUM
DEFINE_PRINT_NUM_UNS



