using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour {
    public static GameManager gameManager;

    public bool gameOver;
    public bool gamePaused;

    public float score;
    [Header("UI Elements")]
    [SerializeField] UIManager gameMenu;
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject inGameMenu;

    [Header("Gameplay")]
    [SerializeField] List<GameObject> platforms;
    [SerializeField] Transform platformsParent;
    public float platformLength;
    public float speed;

    [HideInInspector]
    public float minSpeed = 0.05f;
    [HideInInspector]
    public float maxSpeed = 0.15f;
    private float startTime;
    private InstantObs obs;



    private void Awake() {
        gameManager = this;
    }

    void Start() {
        obs = FindObjectOfType<InstantObs>();
        speed = minSpeed;
        startTime = Time.time;
    }

    void Update() {
        speed = minSpeed + (maxSpeed - minSpeed) * ((Time.time - startTime) / 120);
        speed = Mathf.Clamp(speed, minSpeed, maxSpeed);
        obs.obsCooldown = 7 - ((speed / (maxSpeed - minSpeed)) * 6);

        if (!gameOver && !gamePaused) {
            score += Time.deltaTime * 4;
        }
        if (gameOver)
            gameMenu.Lose();

    }
    public void TogglePause() {
        gamePaused = !gamePaused;
        if (gamePaused) {
            pauseMenu.SetActive(true);
            inGameMenu.SetActive(false);
            Time.timeScale = 0;
        } else {
            pauseMenu.SetActive(false);
            inGameMenu.SetActive(true);
            Time.timeScale = 1;
        }
    }

    void RandomInstantiate() {
        Vector3 position = platformsParent.position + new Vector3(0, 0, platformLength);

        Instantiate(platforms[0], position, Quaternion.identity);


    }
}
