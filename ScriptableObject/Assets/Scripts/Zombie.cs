using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    [SerializeField]
    private ZombieData zombieData;
    public ZombieData ZombieData { set { zombieData = value; } }

    public void WatchZombieInfo()
    {
        Debug.Log("좀비 이름 :: " + zombieData.ZombieName);
        Debug.Log("좀비 체력 :: " + zombieData.Hp);
        Debug.Log("좀비 공격력 :: " + zombieData.Damage);
        Debug.Log("좀비 시야 :: " + zombieData.SightRange);
        Debug.Log("좀비 이동속도 :: " + zombieData.MoveSpeed);
    }
}
