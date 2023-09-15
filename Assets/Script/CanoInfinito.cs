using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanoInfinito : MonoBehaviour
{
    public float maxTime;
    private float time;
    public GameObject cano;
    GameObject canoClone;
    public float dist;
    // Start is called before the first frame update
    void Start()
    {
        canoInfinito();
    }

    // Update is called once per frame
    void Update()
    {
        if(time > maxTime){
            canoInfinito();
            time = 0;
        }

        time += Time.deltaTime;
    }

    void canoInfinito() {
        canoClone = Instantiate(cano);
        canoClone.transform.position = transform.position + new Vector3(0, Random.Range(dist, -dist), 0);
    }
}
