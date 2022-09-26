using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe;
    public float timeDiff;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeDiff) {
            GameObject newPipe = Instantiate(pipe);
            
            float y = Random.Range(-1.7f, 5.5f);
            newPipe.transform.position = new Vector3(6, y, 0);
            timer = 0;
            Destroy(newPipe, 10.0f);
        }
        
    }
}
