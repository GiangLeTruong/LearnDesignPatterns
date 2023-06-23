using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MouseManager : MonoBehaviour
{
    [SerializeField] LayerMask groundMask;
    [SerializeField] LayerMask enemyMask;
    Camera mainCam;

    public static MouseManager instance { get; private set; }
    // Start is called before the first frame update
    void Awake()
    {
        mainCam=this.GetComponent<Camera>();
        instance = this;
    }
    private void Update()
    {
        /*
        if(Input.GetMouseButtonDown(1))
        {
            (bool success, Vector3 position) result = GetMousePosition();
            if (result.success)
            {
                Vector3 mousePosition = result.position;
                Debug.Log(mousePosition);
            }
            else
            {
                Debug.Log(false);
            }
        }
        */
    }
    public (bool isGround, bool isEnemy, Vector3 position) GetMousePosition()
    {
        var ray = mainCam.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray,out var hitInfo1,Mathf.Infinity,groundMask ))
        {
            return (isGround: true, isEnemy: false, position:hitInfo1.point);
        }
        else if(Physics.Raycast(ray, out var hitInfo2, Mathf.Infinity, enemyMask))
        {
            return (isGround: true, isEnemy: true, position: hitInfo2.point);
        }
        else
        {
            return (isGround: false, isEnemy: false, position: Vector3.zero);
        }


    }


}
