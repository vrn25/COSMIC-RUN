using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour
{
    public Transform player;
    public Text scoretext;
    // Update is called once per frame
    void Update()
    {
        scoretext.text = (player.position.z+4987).ToString("0");
    }
}
