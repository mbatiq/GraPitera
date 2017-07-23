using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class Monster : MonoBehaviour {
    [HideInInspector]

    public NavMeshAgent playerAgent;
    public bool hasInteracted;

    public virtual void MoveToInteraction(NavMeshAgent playerAgent) //zminiamy wlasciwosci playera 
    {
        hasInteracted = false;
        this.playerAgent = playerAgent;
        playerAgent.stoppingDistance = 3f;
        playerAgent.destination = transform.position;
    }
    private void Update()
    {
        //funkcja odpawiadająca za to ze kazdy Monster tej klasy porusza sie do przeciwnika gdy ten zblizy
        //sie na jakas odleglosc itd. 
        if (!hasInteracted && playerAgent != null && !playerAgent.pathPending)
        {
            playerAgent.GetComponent<WorldInteraction>().grounded = false;
            if (playerAgent.remainingDistance <= playerAgent.stoppingDistance)
            {
                Interact();
                hasInteracted = true;
                playerAgent.GetComponent<WorldInteraction>().grounded = true;
            }
        }
    }

    public virtual void Interact()
    {
        Debug.Log("Interact() with base class MONSTER.");
    }
}
