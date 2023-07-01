using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Threading;

public class AnimationCode : MonoBehaviour//monobehavious is developed by unity and has functions like start update //the file is in a list,and these lists are consited of strings
{

    public GameObject[] Body;//creating gameobj and storing it in body
    List<string> lines;
    int counter=0; //so that the sphere can move from one line to the other
    // Start is called before the first frame update
    void Start()
    {
        lines = System.IO.File.ReadLines("Assets/AnimationFile.txt").ToList();
    }

    // Update is called once per frame
    void Update()
    {
        string[] points=lines[counter].Split(',');
        //print(lines[0]);
        for(int i=0;i<=32;i++)//each i is a different sphere
        {

        float x=float.Parse(points[0 + (i * 3)])/100;//minimizing the point value to match the point value by 100
        float y=float.Parse(points[1 + (i * 3)])/100;//i*3 to keep distance between 2 point i,e charity
        float z=float.Parse(points[2 + (i * 3)])/300;
        Body[i].transform.localPosition = new Vector3(x,y,z);

        }

        counter+=1;
        if (counter == lines.Count) {counter=0;}//lines.Count checks the no of lines present in the code
                                                //for one point and stop it from moving indefinitly
        Thread.Sleep(30);                                        
    }

}



