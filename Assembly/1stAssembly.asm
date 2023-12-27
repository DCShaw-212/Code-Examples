
;The program is printing out "Hello World!" to the console.

org 100h

include "emu8086.inc"

org 100h

jmp Code

message DB "World!",0

Code:
     
     ;I suspect that the mov command tells the emulator to the following value and check the 
     ;following value against ascii(may or may not be ascii, but it looks like it)
     
     ;I also suspect that the putc command for each line of code is sending the ascii value to
     ;the console
     
     
     ;This line finds the char H and since char H is equivilent to ascii H, that is what is output
     mov AL, "H"
     putc AL 
     
     ;101 is equivilent to e in ascii so is output
     mov AL, 101
     putc AL
     
     ;6Ch is hexidecimal, then translated to ascii and output
     mov AL, 6CH ;h is hexidecimal
     putc AL 
     
     ;This one I'm sure of but somehow 0x6C is l in ascii. 
     mov AL, 0x6C
     putc AL 
     
     ;b is for binary (Just like sesame street lol) I suppose in this case it could also mean byte
     ;01101111 is translated into ascii and outputs o.
     
     mov AL, 01101111b ;b is binary
     putc AL
     
     ;40o is the space character that is between Hello and World!
     mov AL, 40o ;the little o represents octal
     putc AL  
     
     
     ;0 represents the null character, not sure how it is used but if I guessed I would say it's to mark the end of a string or a segment of code
     mov BX, 0
     
     
     ;Looping through the message variable and prints the string one character at a time. Cool!
     
     StartLoop:
        
        ;This is grabbing the next character in the variable message
        mov AL, message + BX
        putc AL 
        
        ;These two I'm not really sure.
        
        inc BX 
        
        cmp message + BX, 0 
        
        ;I think this is starting the loop over
        jnz StartLoop

ret




