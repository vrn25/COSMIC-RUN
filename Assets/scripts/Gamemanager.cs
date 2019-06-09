using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    bool game_has_ended = false;
    public float restartdelay=0.5f;
    public void Endgame()
    {
        if (game_has_ended == false)
        {
            game_has_ended = true;
            Debug.Log("game ends");
            //restart the game
            Invoke("Restart",restartdelay);
        }

    }
    public GameObject completelevelUI; 

    public void completelevel()
    {
        completelevelUI.SetActive(true);  //enabling the level complete screen from disabled
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
