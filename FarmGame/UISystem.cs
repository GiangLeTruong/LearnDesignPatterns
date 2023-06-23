using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class UISystem : MonoBehaviour
{
    [SerializeField] GameObject landField;
    [SerializeField] Transform point;
    [SerializeField] AudioSource canBuy;
    [SerializeField] AudioSource canNotBuy;


    public void button_BuyLand()
    {
        var land = Instantiate(landField, point.transform.position, point.transform.rotation);
        canBuy.Play();
        Destroy(this.gameObject);
    }
}
