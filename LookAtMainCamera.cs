using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMainCamera : MonoBehaviour
{
    GameObject this_Object;
    GameObject player_Camera;



    // Start is called before the first frame update
    void Start()
    {
        this_Object = this.gameObject;
        player_Camera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        set_LookAtMainCamera();
    }

    void set_LookAtMainCamera()
    {
        this_Object.transform.LookAt(player_Camera.transform);
        /*
        float distance= Vector3.Distance(this_Object.transform.position, player_Camera.transform.position);
        
        if (distance<=30)
        {
            this_Object.SetActive(true);
            this_Object.transform.LookAt(player_Camera.transform);
        }
        else
        {
            this_Object.SetActive(false);
        }
        */
    }




}
