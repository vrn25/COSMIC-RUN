using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public Gamemanager gameManager;
    void OnTriggerEnter(Collider col)
    {
        if (col.tag=="Player")
        {
            gameManager.completelevel();
        }
    }
}
