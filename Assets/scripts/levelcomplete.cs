using UnityEngine;
using UnityEngine.SceneManagement;
public class levelcomplete : MonoBehaviour
{
    public void loadnextlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
