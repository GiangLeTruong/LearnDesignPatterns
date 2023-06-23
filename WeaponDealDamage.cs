using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDealDamage : MonoBehaviour
{
    bool isDealDamage = false;
    float nextAttack = 0;
    float attackDelay=1;
    public int WeaponDamage;
    private int opponent_ID_Mask;
    private void Awake()
    {
        if(this.gameObject.layer==6)
        {
            opponent_ID_Mask = 7;
        }
        if (this.gameObject.layer == 7)
        {
            opponent_ID_Mask = 6;
        }
    }

    private void OnTriggerEnter(Collider opponent)
    {
        if(nextAttack<=Time.deltaTime)
        {
            if(opponent.gameObject.layer == opponent_ID_Mask&& opponent.GetComponent<HealthController>())
            {
                int newDamage = (int)Random.Range(WeaponDamage - 1f, WeaponDamage + 1f);
                opponent.GetComponent<HealthController>().TakeDamge((int)newDamage);
                nextAttack =Time.deltaTime+ attackDelay;
            }
        }
        else
        {
            nextAttack = -1f;
        }
    }
    private void OnTriggerExit(Collider opponent)
    {

    }
}
