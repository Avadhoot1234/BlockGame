
using UnityEngine;

public class Playercollision : MonoBehaviour
{
    public Player movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag=="Obstacle")
        {
            movement.enabled=false;
            FindObjectOfType<Gamemanager>().EndGame();
        }
        
    }
}
