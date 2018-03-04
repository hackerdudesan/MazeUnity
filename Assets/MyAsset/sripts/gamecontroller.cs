using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamecontroller : MonoBehaviour {
    float player_x ;
    float player_z ;

    // Use this for initialization
    void Start () {
        UnityEngine.VR.InputTracking.Recenter();

        GameObject cmr = GameObject.Find("CameraContainer");
        Transform trn = cmr.GetComponent<Transform>();

        player_x = trn.position.x;
        player_z = trn.position.z;

    }

    // Update is called once per frame
    void Update () {
        Debug.Log("Called");
//        return;

//        GameObject player = GameObject.FindGameObjectWithTag ("Player");
//        Transform ply_trn = player.GetComponent<Transform>();

        GameObject cmr = GameObject.Find("CameraContainer");
        Transform trn = cmr.GetComponent<Transform>();

        GameObject main_camera = GameObject.Find("Main Camera");
        Transform main_camera_trn = main_camera.GetComponent<Transform>();

//        Debug.Log("Camera pos =" + main_camera_trn.localPosition.x + "," + main_camera_trn.localPosition.z);
        trn.localPosition = new Vector3( - main_camera_trn.localPosition.x, 
            trn.localPosition.y, -1.5f - main_camera_trn.localPosition.z);
 //       trn.position = new Vector3(ply_trn.position.x, 1.6f, ply_trn.position.z );
    }
}
