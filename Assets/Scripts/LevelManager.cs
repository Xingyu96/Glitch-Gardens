using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    private float autoLoadNextLevelAfter = 5;

    void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
            Invoke("LoadNextLevel", autoLoadNextLevelAfter);
    }

    public void loadLevel(string name){
        //Application.LoadLevel(name);
        SceneManager.LoadScene(name);

    }

    public void quitRequest()
    {
        Application.Quit();
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
