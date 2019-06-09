
using UnityEngine;

public class followplayer : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform player;  //Transform refers to the player, here the spaceship
    public Vector3 offset;  //vector3 is a vector of 3 floats for x,y,z positions.
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(player.position);
        transform.position = player.position+offset;  //transform on which we are sitting and seeing the player(camera here). Here camera follows cube.        
        
    }
}
