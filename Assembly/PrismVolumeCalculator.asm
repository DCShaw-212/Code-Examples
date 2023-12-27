;Assigntment 2 Part 2 Volume of a pun-cated cone
;Dustin Shaw
;03/02/2022

org 100h  

;Formula will go here

;V = (1/3) * pi * (R^2 + r^2 + R * r)

;finding big R squared
mov ax, bigRad

mul bigRad

mov bigSquared, ax

;finding the lil r squared
mov ax, lilRad

mul lilRad

mov lilSquared, ax

;figure out what the product of BIG R and lil r is
mov ax, bigRad
mul lilRad
mov rTeam, ax 

;Adding things up from the parans
mov ax, bigSquared
add ax, lilSquared
add ax, rTeam

;multiply the height by the results of the parans
mul height

;completely ignoring (1/3) * pi because it cancels out to 1 (Thanks for that)




;store the result of the formula in CX
mov cx, ax


ret   



;declared variables in memory

height  dw 3

bigRad dw 20 

lilRad dw 15 

bigSquared dw 0 

lilSquared dw 0

rTeam dw 0


