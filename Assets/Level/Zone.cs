using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone : MonoBehaviour
{
    public Vector4 zone;
    public Vector2 dimentions;
    // Start is called before the first frame update
    void Start()
    {
        zone = new Vector4(transform.position.x - dimentions.x, transform.position.x + dimentions.x, transform.position.y - dimentions.y, transform.position.y + dimentions.y);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
