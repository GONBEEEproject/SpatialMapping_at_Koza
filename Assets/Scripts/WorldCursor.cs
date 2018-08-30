using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldCursor : MonoBehaviour {

    private MeshRenderer meshRenderer;





	// Use this for initialization
	void Start () {
        meshRenderer = GetComponentInChildren<MeshRenderer>();
	}
	
	// Update is called once per frame
	void Update () {

        var headPos = Camera.main.transform.position;
        var gazeDir = Camera.main.transform.forward;

        RaycastHit hitInfo;

        if(Physics.Raycast(headPos,gazeDir,out hitInfo))
        {
            meshRenderer.enabled = true;

            transform.position = hitInfo.point;

            transform.rotation = Quaternion.FromToRotation(Vector3.up, hitInfo.normal);
        }
        else
        {
            meshRenderer.enabled = false;
        }






	}
}
