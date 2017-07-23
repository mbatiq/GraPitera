using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NowaKostka : ItemPickUp {
    
	//Trzeba sprawdzic czy pojawi Ci sie kostka w scenie Gry
    //wysyłam scenę z nowym obiektem i Kod w C Sharpie.
    // po zaakaceptowaniu daj mi znać.

	void Update () {
        transform.Rotate(15f * Time.deltaTime, 15f * Time.deltaTime, 15f * Time.deltaTime);
	}
    public override void Interact()
    {
        print("Interakcja wywolana z Klasy Nowa Kostka, ktora jest Itemem");
    }
}
