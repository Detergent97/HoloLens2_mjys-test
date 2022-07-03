using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Microsoft;
using Microsoft.MixedReality.Toolkit.Utilities;
using Microsoft.MixedReality.Toolkit.Input;

public class HandTracking : MonoBehaviour
{

    public GameObject sphereMarker;
    public GameObject sphereMarkerEnable;

    public bool interactionStated;

   // GameObject thumbObject;
    GameObject indexObject;

    MixedRealityPose pose;

    // Start is called before the first frame update
    void Start()
    {
       // thumbObject = Instantiate(sphereMarker, this.transform);
        indexObject = Instantiate(sphereMarker, this.transform);
        interactionStated = false; 
    }

    // Update is called once per frame
    void Update()
    {
        //thumbObject.GetComponent<Renderer>().enabled = false;
        indexObject.GetComponent<Renderer>().enabled = false;

        if(HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexTip, Handedness.Right, out pose))
        {
            // thumbObject.GetComponent<Renderer>().enabled = true;
            // thumbObject.transform.position = pose.Position;

            indexObject.GetComponent<Renderer>().enabled = true;
            indexObject.transform.position = pose.Position;
        }
               

        else if (interactionStated == true)
        {
            //thumbObject = Instantiate(sphereMarkerEnable, this.transform);
            indexObject  = Instantiate(sphereMarkerEnable, this.transform);
            Debug.Log("inter");
        }
    }
}
