using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTilemap : MonoBehaviour
{
    public List<GameObject> maps = new List<GameObject>();
    private List<GameObject> currentMaps = new List<GameObject>();
    Transform lastMap;
    public Transform mapParent;
    // Start is called before the first frame update
    void Awake()
    {

        Vector3 position = transform.position + new Vector3(0, 0, 0);
        lastMap = GameObject.Instantiate(maps[Random.Range(0, maps.Count)], position, Quaternion.identity, mapParent).transform;

    }

    // Update is called once per frame
    void Update()
    {
        if (lastMap.position.y <= 0)
        {
            setMap();
            if (currentMaps.Count > 3)
            {
                Destroy(currentMaps[0].gameObject);
                currentMaps.RemoveAt(0);
            }
        }

    }

    void setMap()
    {
        Vector3 position = lastMap.position + new Vector3(0, 79, 0);
        lastMap = GameObject.Instantiate(maps[Random.Range(0, maps.Count)], position, Quaternion.identity, mapParent).transform;
        currentMaps.Add(lastMap.gameObject);
    }
}
