using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ActiveWeapon : MonoBehaviour
{
    [SerializeField] private Sword sword;
    [SerializeField]
    private Transform playerTransform;

    public static ActiveWeapon Instance { get; private set;  }

    private void Awake()
    {
        Instance = this; 
    }

    public Sword GetActiveWeapon()
    {
        return sword; 
    }

    
}
