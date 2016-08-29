using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelManager : MonoBehaviour {

    private int currentIndex;

    void Start() {
        currentIndex = SceneManager.GetActiveScene().buildIndex;
    }

    public void LoadNextScene() {        
        SceneManager.LoadScene(currentIndex + 1);
    }

    public void LoadPreviousScene() {
        SceneManager.LoadScene(currentIndex - 1);
    }

    public void LoadLevel(int index) {
        SceneManager.LoadScene(index);
    }

    public void LoadLevelByName(string levelName) {
        SceneManager.LoadScene(levelName);
    }

    public void QuitRequest() {
        Application.Quit();
    }
}
