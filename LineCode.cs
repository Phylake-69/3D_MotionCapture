using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineCode : MonoBehaviour
{
    LineRenderer lineRenderer;//

    public Transform origin;//starting point of the line 
    public Transform destination;//ending point of the line
    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>(); //calling the function from LineRedere i,e coordiantes of the sphere
        lineRenderer.startWidth=0.1f; //width of the line 
        lineRenderer.endWidth=0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        lineRenderer.SetPosition(0,origin.position);//setting the starting point as origin position from origin
        lineRenderer.SetPosition(1,destination.position);

    }
}
