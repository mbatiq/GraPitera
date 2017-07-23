using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class Monster : Interactable, IMonster
{
    public override void Interact()
    {
        Debug.Log("Interact() with base class MONSTER.");
    }
}
