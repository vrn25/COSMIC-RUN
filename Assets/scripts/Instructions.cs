using UnityEngine;
using UnityEngine.SceneManagement;
public class Instructions : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
