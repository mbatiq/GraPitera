using UnityEngine.AI;

public interface IMonster
{
    void Interact();
    void MoveToInteraction(NavMeshAgent playerAgent);
}