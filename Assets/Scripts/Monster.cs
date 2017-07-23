using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class Monster : Interactable {
    private void FixedUpdate()
    {
        
        //poprawka
        //kolejna poprawka
        //funkcja odpawiadająca za to ze kazdy Monster tej klasy porusza sie do przeciwnika gdy ten zblizy
        //sie na jakas odleglosc itd. 

    }

    public override void Interact()
    {
        Debug.Log("Interact() with base class MONSTER.");
    }
}
