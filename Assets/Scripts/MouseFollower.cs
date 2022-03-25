using UnityEngine;

public class MouseFollower : MonoBehaviour {

    public Camera cam;
    void Start() {
    }


    void Update() {
        var newPos = cam.ScreenToWorldPoint(Input.mousePosition);
        newPos.z = 1;
        transform.position = newPos;
    }
}
