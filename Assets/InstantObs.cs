using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class InstantObs : MonoBehaviour {
    public List<GameObject> obs = new List<GameObject>();
    List<Zone> currentObs = new List<Zone>();

    public float obsCooldown = 1f;
    private float _obsTimer;
    private bool isWaiting;
    private bool fullStack;

    // Start is called before the first frame update
    void Start() {
        currentObs.Add(Instantiate(obs[Random.Range(0, obs.Count - 1)], new Vector3(Random.Range(-3, 5), Random.Range(18, 50), 0), Quaternion.identity, transform).GetComponent<Zone>());
    }

    // Update is called once per frame
    void Update() {
        if (!isWaiting) {
            _obsTimer = Time.time;
            isWaiting = true;

        }
        if (_obsTimer + obsCooldown < Time.time && !fullStack) {

            currentObs.Add(Instantiate(obs[Random.Range(0, obs.Count)], setObs(), Quaternion.identity, transform).GetComponent<Zone>());
            isWaiting = false;
        }
        fullStack = currentObs.Count >= 30;
        foreach (var obs in currentObs.ToList()) {
            if (obs.transform.position.y < -1.5) {
                currentObs.Remove(obs);
                Destroy(obs.gameObject);
            }
        }
    }

    Vector3 setObs(int i = 0) {

        Vector3 randomPosition = new Vector3(Random.Range(-3, 5), Random.Range(18, 70), 0);
        bool canFit = true;
        foreach (var position in currentObs) {


            if (!(randomPosition.y < position.zone.z || randomPosition.y > position.zone.w)) {
                canFit = false;
            }
            if (!canFit) break;

        }
        if (canFit) {
            return randomPosition;
        } else {
            return (i >= 20) ? setObs(++i) : new Vector3(50, -1.5f, 0);
        }
    }

}
