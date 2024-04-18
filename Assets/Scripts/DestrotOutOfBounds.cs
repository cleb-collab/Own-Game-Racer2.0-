using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestrotOutOfBounds : MonoBehaviour
{
    private float topBound = -850;
	private float lowerBound = -142;
    private float downBound = -4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < topBound)
		{
			Destroy(gameObject);
		}
        if (transform.position.z > lowerBound)
		{
			Destroy(gameObject);
		}
        if (transform.position.y < downBound)
		{
			Destroy(gameObject);
		}
    }
}
