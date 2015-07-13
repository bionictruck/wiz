using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	// Declare variables. Type Name

	//Create an int variable GuessNum that gets it's value from random number generator
	int GuessNum() {
		return(Random.Range(0, 1001));
		}

	int max;
	int min;
	int guess;
	
	void Start () {
		StartGame ();
		
	}
	
	// Create a function - void Name () {}
	void StartGame () {
	
		// Set values of the declared variables	
		max = 1000;
		min = 1;
		guess = GuessNum();
	
		// Simple print statements
		print ("=============================");
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me");
		
		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);
		
		print ("Is the number higher or lower than " + guess);
		print ("Up arrow for higher, down arrow for lower, return if equal");
		
		// Adds 1 to the max so 1000 can be achieved
		max = max + 1;
	
	}
	
	void NextGuess () {
		guess = ( max + min) / 2;
		print ("Higher or lower than " + guess);
		print ("Up arrow for higher, down arrow for lower, return if equal");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	// Else If statements Receives input from a keypress and prints a result
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			min = guess;
			NextGuess ();
			
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			max = guess;
			NextGuess ();
			
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("I won!");
			StartGame ();
		}
	}
}
