using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donme : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    float speed = 0.1f;
    float smooth = 1.0f;
    float z =1.1f;
    // Update is called once per frame
    void Update()
    {
        /* Quaternion target = Quaternion.Euler(0, transform.rotation.y, 0);
         transform.rotation = Quaternion.Lerp(transform.rotation,target , Time.deltaTime *smooth);*/
        transform.Rotate(new Vector3(0, 1 * z, 0)); //applying rotation
                                                    //Debug.Log(transform.rotation.y.ToString());
                                                    // transform.Rotate(0, z * Time.deltaTime, 0);
    }
    }
   
