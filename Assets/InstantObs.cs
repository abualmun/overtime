using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantObs : MonoBehaviour
{
    public List<GameObject> obs = new List<GameObject>();
    List<Zone> currentObs = new List<Zone>();

    public float obsCooldown = 0.5f;
    private float _obsTimer;
    private bool isWaiting;

    // Start is called before the first frame update
    void Start()
    {
        currentObs.Add(Instantiate(obs[Random.Range(0, obs.Count - 1)], new Vector3(Random.Range(-3, 5), Random.Range(18, 30), 0), Quaternion.identity, transform).GetComponent<Zone>());
    }

    // Update is called once per frame
    void Update()
    {
        if (!isWaiting)
        {
            _obsTimer = Time.time;
            isWaiting = true;

        }
        if (_obsTimer + obsCooldown < Time.time)
        {
            currentObs.Add(Instantiate(obs[Random.Range(0, obs.Count)], setObs(), Quaternion.identity, transform).GetComponent<Zone>());
            isWaiting = false;
            if (currentObs.Count >= 10)
            {
                Destroy(currentObs[0].gameObject);
                currentObs.RemoveAt(0);
            }
        }
    }

    Vector3 setObs()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-3, 5), Random.Range(18, 30), 0);
        foreach (var position in currentObs)
        {

            if (randomPosition.x < position.zone.x || randomPosition.x > position.zone.y)
            {
                if (randomPosition.y < position.zone.z || randomPosition.y > position.zone.w)
                {
                    return randomPosition;
                }
                else
                {
                    return setObs();
                }
            }
            else
            {
                return setObs();
            }
        }
        return randomPosition;
    }

}