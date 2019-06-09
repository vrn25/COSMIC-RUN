using UnityEngine;

public class playercollision : MonoBehaviour
{
    public playermovement move;           //reference to the movement of our player

    //public Gamemanager gamemanage;->instead of doing this, we search for the gamemanager when we want it

    void OnCollisionEnter(Collision collisioninfo)   //called when we hit an object. collisioninfo carries information abt collision
    {
        if(collisioninfo.collider.tag == "obstacle"){
            Debug.Log("we hit");
            //move.enabled=false;
            GetComponent<playermovement>().enabled = false;
            FindObjectOfType<Gamemanager>().Endgame();
        }
    }

}
