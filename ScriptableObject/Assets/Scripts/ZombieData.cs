﻿using UnityEngine;

//에디터 상에서 사용할 수 있도록 메뉴를 만든다.
[CreateAssetMenu(fileName ="Zombie Data", menuName = "Scriptable Object/Zombie Data", order = int.MaxValue)]

public class ZombieData : ScriptableObject
{
    [SerializeField]
    private string zombieName;
    public string ZombieName { get { return zombieName; } }

    [SerializeField]
    private int hp;
    public int Hp { get { return hp; } }

    [SerializeField]
    private int damage;
    public int Damage { get { return damage; } }

    [SerializeField]
    private float sightRange;
    public float SightRange { get { return sightRange; } }

    [SerializeField]
    private float moveSpeed;
    public float MoveSpeed {  get { return moveSpeed; } }
}
