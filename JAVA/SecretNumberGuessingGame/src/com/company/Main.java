//Written by: Dustin Shaw
//Purpose: Create a game where the user guesses at a secret number

package com.company;

//imports
import java.util.Scanner;
import  java.util.concurrent.ThreadLocalRandom;

public class Main{

    public static void main(String [] args){
        //input from user of how many rounds they're playing
        System.out.println(" ");
        System.out.println("Can you guess the secret number?");
        System.out.println("How many games would you like to play?");

        Scanner scan1 = new Scanner(System.in);
        int numOfGames = 0;

        //should they not inter an integer (ha puns), then the catch will exit the program.
        try{
            numOfGames = scan1.nextInt();
        }

        catch (Exception e){
            System.out.println("Mission Failed. We'll get em next time.");
            System.exit(-1);
        }
        //Here will start the loop for the number of games that they've selected
        for(int i = 0; i < numOfGames; i++){
            System.out.println("New game has begun...");

            //This strange line of code creates a random number and stores it as secretNum
            int secretNum = ThreadLocalRandom.current().nextInt(1, 100 + 1);

            //We need to get another integer input from the user to store as the guess, again if it is not an integer then the program will exit.
            int userGuess = 0;
            System.out.println("What is your guess?");
            Scanner scan2 = new Scanner(System.in);

            try{
                userGuess = scan2.nextInt();
            }
            catch (Exception e){
                System.out.println("Mission Failed. We'll get em next time.");
                System.exit(-1);
            }

            //if the user has made it this far, we will be checking to see if userGuess does not match the secretNum.
            while (userGuess != secretNum){
                //Using if-else if conditionals we will give clues as to which direction the user needs to move their guess.
                if(userGuess < 1 || userGuess > 100){
                    System.out.println("You're out of range. Try again.");
                }
                else if(userGuess < secretNum){
                    System.out.println("Your guess is too low. Try again.");
                }
                else if(userGuess > secretNum){
                    System.out.println("Your guess is too High. Try again.");
                }

                //To prevent an infinite loop, we will need to reask for a guess to change the value of userGuess (Still ensuring that they choose an integer.)
                System.out.println("What is your guess?");

                try{
                    userGuess = scan2.nextInt();
                }
                catch (Exception e){
                    System.out.println("Mission Failed. We'll get em next time.");
                    System.exit(-1);
                }
            }
            //Here's something about three bears and winning
            System.out.println("You've won, Goldilocks");
            System.out.println(" ");
            //I think this is from Adult Swim show I used to watch, but I don't remember which one.
            System.out.println("Bye. Have a wonderful time.");
            System.out.println(" ");
        }

    }
}
