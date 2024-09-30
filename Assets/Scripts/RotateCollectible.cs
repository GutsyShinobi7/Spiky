using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCollectible : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        //multiply by time.deltaTime to make it frame independent
        transform.Rotate(new Vector3(15,30,45) * Time.deltaTime);
    }
}
