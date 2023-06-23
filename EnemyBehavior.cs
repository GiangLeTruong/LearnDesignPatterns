using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : CharacterBehavior
{
    GameObject Player;
    //Enemy logic:
    [SerializeField] float senseRange;
    bool canMove;
    public void ackPlayer()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        float distance = Vector3.Distance(thisCharacter.transform.position, Player.transform.position);
        if (distance > senseRange)
        {
            canMove = false;
            canAttack = false;

        }
        else
        {
            if (distance > attackRange)
            {
                    canMove = true;
                    canAttack = false;
            }
            else
            {
                thisCharacter.transform.LookAt(Player.transform);
                canMove = false;
                canAttack = true;
            }

        }


    }
    public override void setRegen()
    {

    }
    public override void setDamage()
    {
        thisCharacterWeapon.GetComponent<WeaponDealDamage>().WeaponDamage = AttackDamage;
    }
    public override void setAttack()
    {

    }
    public override void setMove()
    {
        ackPlayer();
        if (canMove)
        {
            this_NavMesh.destination = Player.transform.position;
        }
        else
        {
            this_NavMesh.destination = thisCharacter.transform.position;
        }
    }
}
