using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {
    public TMP_Text scoreText;
    public TMP_Text maxScoreText;
    public TMP_Text loseQuote;
    public GameObject loseMenu;

    void Start() {
        Input.backButtonLeavesApp = true;
    }


    void Update() {
        // update Score
        if (Input.GetKeyDown(KeyCode.L)) {
            Time.timeScale = 0;
            SetLoseQuote();
            loseMenu.SetActive(true);
        }
    }

    public void Play() {
        Debug.Log("Playing");
        Input.backButtonLeavesApp = false;
        SceneManager.LoadScene("AudioTest"); // TODO: change it to scene name
    }

    public void Pause() {
        Debug.Log("Pausing");
        // gameManager.TogglePause();
    }

    public void Exit() {
        Input.backButtonLeavesApp = true;
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame() {
        Application.Quit();
        EditorApplication.ExitPlaymode();
    }

    public void ShowMenu(GameObject menu) {
        menu.SetActive(true);
    }

    public void HideMenu(GameObject menu) {
        menu.SetActive(false);
    }

    public void SetLoseQuote() {
        loseQuote.text = Quoutes.GetRandomQuote();
    }
}

[System.Serializable]
class QuotesJson {
    public List<string> qoutes;
}

