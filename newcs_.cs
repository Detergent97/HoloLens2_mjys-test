using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newcs_ : MonoBehaviour
{

    public GameObject cube1;
    public GameObject cube2;

    public Vector3 cube1pos;
    public Vector3 cube2pos;

    public float Dist;
    public float min_dist = 0.02f;

    // Start is called before the first frame update
    void Start()
    {
        cube1 = GameObject.FindWithTag("cube1");
        cube2 = GameObject.FindWithTag("cube2");
    }

    // Update is called once per frame
    void Update()
    {
        cube1pos = cube1.transform.position;
        cube2pos = cube2.transform.position;

        Dist = Vector3.Distance(cube1pos, cube2pos);

       // Debug.Log(Dist);

        if (Dist <= min_dist)
        {
            cube2.transform.position = cube1pos;
        }
    }
}
