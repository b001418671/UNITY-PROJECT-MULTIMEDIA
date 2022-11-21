
using UnityEngine;

public class playercollision : MonoBehaviour
{
    public PlayerMovment movement;
    
    void OnCollisionEnter (Collision collisionInfo)
    {
       if (collisionInfo.collider.tag == "Obstacle")
       {
           movement.enabled = false;
       }
    }
}
