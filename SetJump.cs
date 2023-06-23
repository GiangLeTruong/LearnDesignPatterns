using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetJump : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        set_Jump();
    }
    void set_Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            this.GetComponent<Rigidbody>().AddRelativeForce(Vector3.up*200);
            AddScores.create.add_Score(1);
            AudioManager.Play.audio_Jump();
        }
    }
}
