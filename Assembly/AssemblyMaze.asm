include "emu8086.inc"
org 100h
 
jmp code



;The Maze values to be drawn

maze DB 1,1,1,1,1,1,1,1,1,1  
     DB 1,3,1,0,0,1,0,0,0,1
     DB 1,0,1,0,1,1,2,1,0,1
     DB 1,0,1,0,1,1,1,1,0,1
     DB 1,0,1,0,0,0,0,0,0,1
     DB 1,0,1,0,1,0,1,0,0,1
     DB 1,0,1,0,1,0,1,0,0,1
     DB 1,0,1,0,1,0,1,0,0,1 
     DB 1,0,0,4,1,0,0,0,0,1
     DB 1,1,1,1,1,1,1,1,1,1
      
      
 
 
 
 ;VARIABLES;
 ;__________________________________________________________________-;

 COLS = 10               ; number of bytes in a single row  
 ROWS = ($ - maze)/ COLS ; # of rows
 holdCount DW ?      ;Holds the value of CX because we have a nested loop and want to retain CX's value for the outter loop
 holdAddress DW 0  
 
 charPos DB 12
 charUser DB 173
 dor DB 206; doors. 




           ;PROCEDURES:
;_______________________________________________________________________; 


 
;My first assembly procedured, it should be updateCursor 
;but I chose curse because assembly is cursed... 
upDateCurse PROC
     mov bh, 0
     mov ah, 2
     int 10h 
     jmp LoopForMovement
     ret
upDateCurse ENDP 

;______________________________________________________________________________;

;check for wall hitting, although I don't think beeps will stop kyle from drinking too
;much monsters and punching holes in the drywall (Its a meme, look it up)

;;just a proc to beep
beepWall PROC       
     putc 007     
     jmp LoopForMovement
     ret
beepWall ENDP   

                                                          
 

;power up for the player;

powerUp DB 084,072,069,032,076,073,077,073,084,065,073,079,078,083,032,065,082,069,032,065,078,032,073,076,076,085,083,073,079,078

powerUpRec PROC
    mov CX, 30 ; num of values in message
    mov BX, 0 ; index pos of the last value
    
    loopStart:
    
        mov al, powerUp + BX
        putc al
        inc BX
        loop loopStart
        
powerUpRec ENDP   


;Win Condition stuff;
;--------------------------------------------------------------------------;

winConditionCheck PROC
     ;check to see if the user won
      cmp DX, 518
      jz Exit 
      jmp LoopForMovement
      ret  
winConditionCheck ENDP 



winConditionPrint DB 089,079,085,032,087,073,078,033 

;win message proc
winMessage PROC
    mov CX, 8 ; num of values in message
    mov BX, 0 ; index pos of the last value
    
    startLoop:
    
        mov al, winConditionPrint + BX
        putc al
        inc BX
        loop startLoop
        
     ret
winMessage ENDP     



;CODE begins here....End of DATA and PROCEDURES
 
 
 code:
 
  ;Setting up for the cursor movement waiting for input from the arrow keys
    
    
    mov dl, 1 ;x pos
    mov dh, 1 ;y pos
       
 
 
 
  
; Draw The Maze

;----------------------------------------------

 mov CX, rows   ; This controls how many times the loop runs and a row is printed
   
 PrintRow:    ;OutterLoop
     mov holdCount, CX 
     mov CX, COLS  
     
      
     PrintAnother: ;InnerLoop 
     
       ;Check if it was the User's Character that was found
       
      ;  cmp maze + BX, 173
      ;  jz userPrint
         
       
       cmp maze +BX, 0 ;is it an opening
       jz Opening
       
       
       
       cmp maze + BX, 1  ;we're checking to see if we have a 1. and if it is making a wall
       jz wall   ;if it was a 1, we'll go find the wall value 
       
       cmp maze + BX, 2 ; is it goal  
       jz goalPrint
                    
       cmp maze + BX, 3 ; it is the character            
       jz userPrint   
       
       ;check to see if the power up is there
       cmp maze + BX, 4
       jz powerUpPrint
       
       Opening:  ;if the value from maze was a 0 we'll make it an opening
       
           mov AL, 032 ; open space character for the path
           jmp characterPrint ; if it was a 0, jump to print it 
           
       goalPrint:
           mov AL, dor ; it was the door/goal
           jmp characterPrint
           
       userPrint:
           mov AL, charUser
           jmp characterPrint
               
           
           
       Wall:
           mov AL, 178 ;grainy, textured wall value
           jmp characterPrint; if it was a 1, we stored 178 and jumped to print it
             
           
       powerUpPrint:
           mov AL, 112 ; we found the power up so now we'll print it
           
           
       characterPrint:
       
           putc AL  ;outputting the character here
           
                   
        
       inc BX ;inc BX index through the 2-D array
       loop PrintANother
     
     printn
     
    
     
     mov CX, holdCount 
     loop PrintRow  
     
      
     
     
     
 
     
   
               
              
;Update the characters location 
;------------------------------------------------------------------------;

LoopForMovement:  

    gotoxy dl, dh
    putc charUser
  
             
    mov ah, 00h  ; To check key for key press use this value 
    
    int 16h
    CURSOROFF ; suppose to turn the cursor on
   
     ;up  -w
     cmp ah, 11h
     je w
  
    
     ;down -s
     cmp ah, 1Fh
     je s
   
          
     ;right -d
     cmp ah, 20h
     je d
    
    
     ;left   -a
     cmp ah, 1Eh
     je a
   
w:   
     mov ah, 3 
     gotoxy dl, dh
     putc 032
     sub dh, 1  ;started at top-left xy so we need to subtract y to go up 
      ;check maze at new position compared to playerPOS   
     sub charPos, cols
      
     ;check to see if wall was hit 
     cmp DX, 1     ;cmp character to the wall
     je wallHitUp         ; the wall is hit if equal so we'll beep  
     cmp DX, 1794
     je wallHitUp
      
     ;check for the power up
     cmp DX, 2051
     jz puUp
     jmp upWin
     
     puUp:
        call powerUpRec
    
      
      
     upWin: 
       ;check for win condition
       call winConditionCheck
      
     
     jmp upDateCursor     ; the wall was not it so we'll just draw the new playerPOS
      
     
     
     
     
     upDateCursor:
     
        call upDateCurse  
         
     wallHitup:
        add dh, 1   
        add charPos, 10
        call beepWall    ;beep noises 
         
     
        
  
    
     
    
    
s: 
    
     mov ah, 3 
     gotoxy dl, dh
     putc 032
     add dh, 1   ;need to add to y to go down  
     add charPos, cols
     
     ;check to see if the wall was hit
     cmp DX, 2305     ;cmp character to the wall
     je wallHitDown         ; the wall is hit if equal so we'll beep
     cmp DX, 2306
     je wallHitDown
      
     ;check for the power up
    
     cmp DX, 2051
     jz puDown
     
     jmp downWin   
     
     puDown:
        call powerUpRec
    
      
      
     downWin: 
       ;check for win condition
       call winConditionCheck 
     
     
      
     ;check for win condition
     call winConditionCheck
      
     jmp upDateCursor     ; the wall was not it so we'll just draw the new playerPOS
       
     
      
     call upDateCurse
     
     wallHitDown:   
         sub dh, 1
         sub charPos, cols
         call beepWall
   
   

  
d: 
       
     mov ah, 3 
     gotoxy dl, dh
     putc 032 
     add dl, 1  ;adding to dl will take you to the right    
     add charPos, 1
     
     ;check to see if wall was hit
     cmp DX, 258             ;cmp character to the wall
     je wallHitRight         ; the wall is hit if equal so we'll beep 
     cmp DX, 514
     je wallHitRight
     cmp DX, 770
     je wallHitRight
     cmp DX, 1026
     je wallHitRight
     cmp DX, 1282
     je wallHitRight
     cmp DX, 1538
     je wallHitRight
     cmp DX, 1794
     je wallHitRight
      
     ;check for the power up
     cmp DX, 2051  
     
     jz puRight
     
     jmp rightWin
     
     puRight:
        call powerUpRec
    
      
      
     rightWin: 
       ;check for win condition
       call winConditionCheck 
      
     ;check for win condition
     call winConditionCheck
      
     jmp upDateCursor     ; the wall was not it so we'll just draw the new playerPOS
       
      
     call upDateCurse  
     
     wallHitRight: 
         sub dl, 1
         sub charPos, 1
         call beepWall
     
     
     
    
a:   
     
     mov ah, 3
     gotoxy dl, dh
     putc 032
     sub dl, 1  ;subtracting from dl should take you left 
     sub charPos,1 
     
     ;check to see if wall was hit
     cmp DX, 256
     je wallHitLeft
     cmp DX, 512
     je wallHitLeft
     cmp DX, 768
     je wallHitLeft
     cmp DX, 1024
     je wallHitLeft
     cmp DX, 1280
     je wallHitLeft
     cmp DX, 1536
     je wallHitLeft
     cmp DX, 1792
     je wallHitLeft
     cmp DX, 2048
     je wallHitLeft
    
     
     ;check for the power up
     cmp DX, 2051
     
     jz puLeft
     
     jmp leftWin
     
     puLeft:
        call powerUpRec
    
      
      
     leftWin: 
       ;check for win condition
       call winConditionCheck 
     
     ;check for win condition
     call winConditionCheck
     
     jmp upDateCursor
    
    
     call upDateCurse
     
     wallHitLeft:
         add dl, 1
         add charPos, 1
         call beepWall 
     
     
     
     
     
     

     
      
;The goal is a door
;so we want the user to find the door to exit the loop
;so we need to compare the location of the user to that of the user     
     
     
     
    

;When we reach the 'goal' exit the input    
exit: 
  call winMessage
  
  je END
  
  loop exit
  
  
END:
 












        
ret            

DEFINE_PRINT_NUM
DEFINE_PRINT_NUM_UNS


