using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe;
    public float timer = 0;
    public float TimeDiff = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > TimeDiff)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = new Vector3(4, Random.Range(-1.0f, 4.0f), 0);
            timer = 0;
            Destroy(newpipe, 6.0f);
        }
    }
}
