﻿using UnityEngine;
using System.Collections.Generic;

// This script is to be set to an empty game object that has multiple children each with a Coin_Dropper script.
public class Dropper_Master : MonoBehaviour {

    public GameObject Stage;        //A reference to the Stage GameObject in the Scene.
    public GameObject Dropper;      //A reference to a prefab GameObject with the Coin_Dropper script.
    List<GameObject> Droppers;      //A list for holding and referencing GameObjects with the Coin_Dropper script.
    int i = 0;                      //An integer variable that will act as an iterator for the foreach loop inside the Update function.

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        foreach(GameObject dropper in Droppers)                                         //Iterates through all the GameObjects in the Droppers List.
        {
            if(dropper.GetComponent<Coin_Dropper>().Dropping)                           //Checks to see if the current dropper has the boolean variable Dropping
                                                                                        //  set to true.
            {
                if(dropper.GetComponent<Coin_Dropper>().Dropped)                        //Checks to see if the current dropper has the boolean variable Dropped
                                                                                        //  set to true.
                {
                    Droppers[i].GetComponent<Coin_Dropper>().Dropping = false;          
                                                                                        //If the if statement is entered, the current GameObject's Dropping &
                                                                                        //  Dropped booleans are set to false.
                    Droppers[i].GetComponent<Coin_Dropper>().Dropped = false;
                    if(i == Droppers.Count - 1)                                         //Checks to see if the iterator variable, i, holds the same value as
                                                                                        //  the amount of items inside of the Droppers List minus one.
                    {
                        Droppers[0].GetComponent<Coin_Dropper>().Dropping = true;       //If the if statement is entered, it sets the boolean variable Dropping
                                                                                        //  of the first item in the Droppers List to true.
                    }
                    else
                    {
                        Droppers[i + 1].GetComponent<Coin_Dropper>().Dropping = true;   //If the if statement is not entered, it sets the boolean variable
                                                                                        //  Dropping to true of the item in the Droppers List with the item
                                                                                        //  placement value of the iterator variable, i, plus one.
                    }
                }
            }
            i++;                                                                        //Increases the iterator variable, i, by one.
        }
        i = 0;                                                                          //Resets the iterator variable, i, to 0.
	}
}