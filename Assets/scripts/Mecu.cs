using UnityEngine;
using UnityEngine.SceneManagement;
public class Mecu : MonoBehaviour
{
    public void GotoContols()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
