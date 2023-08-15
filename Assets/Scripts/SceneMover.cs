using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneMover : MonoBehaviour
{

    public float radius = 2500f;
    public float degreesPerSec = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        // Move scene (left) by radius positive z
        transform.localPosition = new Vector3(0f, 0f, radius);

        // Average helicopter speed is 295 meters/sec

        // Start moving in positive X direction
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localRotation *= Quaternion.AngleAxis(degreesPerSec * Time.deltaTime, Vector3.down);
    }
}
