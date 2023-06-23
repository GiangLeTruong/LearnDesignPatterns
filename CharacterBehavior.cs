using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public abstract class CharacterBehavior : MonoBehaviour
{
    //General:
    public GameObject thisCharacter { get; private set; }
    
    [SerializeField] protected GameObject thisCharacterWeapon;

    public NavMeshAgent this_NavMesh { get; private set; }

    public int Health { get; private set; }

    //Move:
    [SerializeField] int MoveSpeed;

    //Attack:
    public int AttackSpeed { get; private set; }
    [SerializeField] protected float attackRange;
    [SerializeField] protected int AttackDamage;
    public bool canAttack { get; protected set; }

    //Other:
    [SerializeField] Animator animator;
    [SerializeField] protected bool isDeath;



    private void Awake()
    {
        thisCharacterWeapon.GetComponent<WeaponDealDamage>().WeaponDamage = AttackDamage;
        thisCharacter = this.gameObject;
        this_NavMesh=GetComponent<NavMeshAgent>();
        this_NavMesh.speed = MoveSpeed;
    }
    private void Update()
    {
        isDeath = this.GetComponent<HealthController>().isDie;
        if (isDeath==false)
        {
            setMove();
            setAnimation();
        }
        
    }
    public abstract void setRegen();
    public abstract void setDamage();
    public abstract void setAttack();
    public abstract void setMove();
    public void setAnimation()
    {
        animator.SetBool("canAttack", canAttack);
        animator.SetFloat("MoveSpeed", this.MoveSpeed);
        animator.SetFloat("currentVelocity", this_NavMesh.velocity.magnitude);
    }
}
