#include <string>
using namespace std;

class Pokemon {
	int attackIV;
	int defenseIV;
	int hpIV;
	string name;

public:

	//Default constructor
	Pokemon() {}

	//Set up all 4 values
	Pokemon(int atk, int def, int hp, string nom)
	{
		attackIV = atk;
		defenseIV = def;
		hpIV = hp;
		name = nom;
	}
	//Getters
	int getAttackIV() { return attackIV; }
	int getDefenseIV() { return defenseIV; }
	int getHpIV() { return hpIV; }
	string getName() { return name; }

	//Setters
	void setAttackIV(int attack) { attackIV = attack; }
	void setDefenseIV(int defense) { defenseIV = defense; }
	void setHpIV(int hp) { hpIV = hp; }
	void setName(string nomen) { name = nomen; }

	//Get the percentage of IVs (100% is max, 0% is min)
	double getIVPercentage() {
		return (getAttackIV() + getDefenseIV() + getHpIV()) / 45.0;
	}

	//Return as a string which IV value is highest
	string getHighestIV();

	//Given the desired attack as an integer, return whether the pokemon meets that attack goal
	bool passAttackCheck(int desiredAttack) {
		return desiredAttack <= getAttackIV();
	}

	//Check how far a pokemon is from the attack goal
	int iVsFromAttackGoal(int goal)
	{
		return goal - getAttackIV();
	}

	//Compare pokemon based on their total IV values
	bool operator >(Pokemon& otherMon) {
		return getIVPercentage() > otherMon.getIVPercentage();
	}

	//Compare pokemon based on their total IV values
	bool operator ==(Pokemon& otherMon) {
		return getIVPercentage() == otherMon.getIVPercentage();
	}
};

string Pokemon::getHighestIV()
{
	if (getAttackIV() >= getDefenseIV() and getAttackIV() >= getHpIV())
		return "Attack";
	else if (getDefenseIV() >= getAttackIV() and getDefenseIV() >= getHpIV())
		return "Defense";
	else
		return "Hp";
}
