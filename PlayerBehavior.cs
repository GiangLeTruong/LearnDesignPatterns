using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : CharacterBehavior
{
    public override void setRegen()
    {

    }
    public override void setDamage()
    {

    }
    public override void setAttack()
    {
        thisCharacterWeapon.GetComponent<WeaponDealDamage>().WeaponDamage = AttackDamage;
    }
    public override void setMove()
    {
        if (Input.GetMouseButtonDown(1))
        {
            (bool isGround, bool isEnemy, Vector3 position) result = MouseManager.instance.GetMousePosition();
            Vector3 mousePosition = result.position;
            thisCharacter.transform.LookAt(mousePosition);
            if (result.isGround)
            {
                this_NavMesh.destination = mousePosition;
                canAttack = false;
                float distance = Vector3.Distance(thisCharacter.transform.position, mousePosition);
                if (distance > attackRange)
                {
                    this_NavMesh.destination = mousePosition;
                    canAttack = false;
                }
                else
                {
                    canAttack = true;
                }
            }
            
                
            
        }
    }
}
