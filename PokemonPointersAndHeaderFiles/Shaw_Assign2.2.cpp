//Dustin Shaw
//Shaw_Assign2-2
//

#include <iostream>
#include <string>
#include "pokemon.h"

using namespace std;

int main()
{
    //class pointer
    //Pokemon* pokepointer1;
    //Pokemon* pokepointer2;

    Pokemon* pokepointer1 = new Pokemon(15, 0, 8, "Attack");
    Pokemon* pokepointer2 = new Pokemon(4, 5, 6, "Hp");

    //Desired Attack
    int desiredAttack = 12;

    //Create the first pokemon
    pokepointer1 -> setName("Pikachu");
    

    //Output Stats for Pokemon 1
    cout << "Pokemon 1s Name: " << pokepointer1 ->getName() << endl;
    cout << "Pokemon 1s Attack: " << pokepointer1->getAttackIV() << endl;
    cout << "Pokemon 1s Defense: " << pokepointer1->getDefenseIV() << endl;
    cout << "Pokemon 1s HP: " << pokepointer1->getHpIV() << endl;
    cout << "Pokemon 1s Highest IV: " << pokepointer1->getHighestIV() << endl;
    cout << "Pokemon 1s IV Percentage: " << pokepointer1->getIVPercentage() << endl;
    cout << "" << endl;



    //Create the second pokemon
    pokepointer2-> setName("Spinarak");
   


    //Output Stats for pokemon 2

    cout << "Pokemon 2s Name: " << pokepointer2->getName() << endl;
    cout << "Pokemon 2s Attack: " << pokepointer2->getAttackIV() << endl;
    cout << "Pokemon 2s Defense: " << pokepointer2->getDefenseIV() << endl;
    cout << "Pokemon 2s HP: " << pokepointer2->getHpIV() << endl;
    cout << "Pokemon 2s Highest IV: " << pokepointer2->getHighestIV() << endl;
    cout << "Pokemon 2s IV Percentage: " << pokepointer2->getIVPercentage() << endl;
    cout << "" << endl;

    //Check which pokemon has the better stats
    if (*pokepointer1 > *pokepointer2)
        cout << pokepointer1->getName() << " is the champion." << endl;
    else if (*pokepointer1 == *pokepointer2)
        cout << pokepointer1->getName() << " and " << pokepointer2->getName() << " are equals." << endl;
    else
        cout << pokepointer2->getName() << " is the stronger." << endl;

    //See if the pokemon have high enough attack stats and if they missed their goal how far are they off

    if (pokepointer1->passAttackCheck(desiredAttack))
    {
        cout << pokepointer1->getName() << " has passed the attack requirements!";
    }
    else
        cout << pokepointer1->getName() << " has missed the attack goal by: " << pokepointer1->iVsFromAttackGoal(desiredAttack) << " points." << endl;

    cout << "" << endl;

    if (pokepointer2->passAttackCheck(desiredAttack))
    {
        cout <<pokepointer2->getName() << " has passed the attack requirements!";
    }
    else
        cout << pokepointer2->getName() << " has missed the attack goal by: " << pokepointer2->iVsFromAttackGoal(desiredAttack) << " points." << endl;







    //test complete message
    cout << "Pokemon class testing complete..." << endl;


    //delete the pointers
    delete  pokepointer1;
    delete  pokepointer2;

}

