using UnityEngine.SceneManagement;
using UnityEngine;

public class Levelcomplete : MonoBehaviour
{
    
    // Update is called once per frame
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
