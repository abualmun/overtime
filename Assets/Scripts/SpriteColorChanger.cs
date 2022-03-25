using UnityEngine;

public class SpriteColorChanger : MonoBehaviour {

    private SpriteRenderer sp;
    private AudioManager audioManager;

    void Start() {
        sp = GetComponent<SpriteRenderer>();
        audioManager = GetComponent<AudioManager>();
    }


    void Update() {
        sp.color = Color.blue * audioManager.GetValue();
    }
}
