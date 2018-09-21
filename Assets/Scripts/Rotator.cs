using System.Collections;
using UnityEngine;


public class Rotator : MonoBehaviour
{

	void Update () 
	{
		transform.Rotate (new Vector3 (0, 30, 0) * Time.deltaTime);
	}


    void Start()
    {
        transform.Rotate(new Vector3(0, Random.Range(0, 180), 0));
    }
}
