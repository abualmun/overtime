using System;
using TMPro;
using UnityEngine;

public class ValueChanger : MonoBehaviour {

    public float min;
    public float max;
    public ChangeType type;
    public Color color;

    private new Light light;
    private TMP_Text text;
    private SpriteRenderer sp;

    private AudioManager manager;
    Action function;

    void Start() {
        light = GetComponent<Light>();
        text = GetComponent<TMP_Text>();
        manager = FindObjectOfType<AudioManager>();
        sp = GetComponent<SpriteRenderer>();

        function = type switch {
            ChangeType.FontSize => () => text.fontSize = manager.GetValue(min, max),
            ChangeType.Light => () => light.intensity = manager.GetValue(min, max),
            ChangeType.Scale => () => transform.localScale = Vector3.one * manager.GetValue(min, max),
            ChangeType.Color => () => sp.color = Color.Lerp(Color.black, color, manager.GetValue(min, max)),
            _ => null
        };
    }

    void Update() {
        function();
    }
}

public enum ChangeType {
    Light,
    FontSize,
    Scale,
    Color
}

