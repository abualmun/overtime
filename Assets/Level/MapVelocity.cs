using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapVelocity : MonoBehaviour {
    private float speed = 0.1f;

    // Start is called before the first frame update
    void Start() {
    }

    // Update is called once per frame
    void Update() {
        speed = GameManager.gameManager.speed;
        transform.Translate((Vector3.down * speed) * Time.timeScale);


    }
}
