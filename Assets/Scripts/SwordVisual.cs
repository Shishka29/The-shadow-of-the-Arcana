using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class SwordVisual : MonoBehaviour
{
    [SerializeField] private Sword sword;


    private Animator animator;
    private const string ATTACK = "Attack";


    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        sword.OnSwordSwing += Sword_onSwing;
    }

    private void Sword_onSwing(object sender, System.EventArgs e)
    {
        animator.SetTrigger(ATTACK);
    }
}
