;Assignment 2   Part 1: A Power-ful Problem
;Dustin Shaw
;Date: 2/24/2022

org 100h

;set initial values to be used
mov ax, 2
mov bx, 2
mov cx, 2

;first mul
mul cx
mov cx, ax

;ax is now 2 ** 2
;cx is now 2 ** 2


;second mul 
mul cx
mov cx, ax

;ax is now 2 ** 4
;cx is now 2 ** 4

;third mul
mul bx
;ax is now 2 ** 5

;fourth mul 
mul ax
;ax is now 2 ** 10

;firth mul
mul cx

;ax is now 2 ** 14


;move ax into cx so that cx can be the value 16384 or 2**14
mov cx, ax







ret




