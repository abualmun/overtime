using UnityEditor.Build.Player;
using UnityEngine;

public class LightChanger : MonoBehaviour {

    public float min;
    public float max;

    private new Light light;
    private AudioManager manager;
    void Start() {
        light = GetComponent<Light>();
        manager = FindObjectOfType<AudioManager>();
    }


    void Update() {
        light.intensity = manager.GetValue(min, max);
    }
}
