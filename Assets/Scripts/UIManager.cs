using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {
    public TMP_Text scoreText;
    public TMP_Text maxScoreText;

    void Start() {
    }


    void Update() {
        // update Score
    }

    public void Play() {
        Debug.Log("Playing");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Pause() {

    }

    public void Exit() {
        SceneManager.LoadScene("MainMenu");
    }
}
