using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class Boss : Entity
{   
    private Animator _animator;
    private Vector3 dir;

    private Animator anim;

    public Transform attackPos;
    public float attackRange;
    public LayerMask Player;
    private GameObject _player;

    public GameObject enemyPrefab;
    public Transform[] spawnPoints;
    public string spawnAnimationTag = "Spawn";
    public int enemiesToSpawn = 3;
    public float spawnDelay = 0.2f;
    private int _enemiesSpawned = 0;
    private bool _isSpawning = false;
    private float _spawnTimer = 0f;
   
    private void Awake()
    {
        lives = 200;
    }
    void Start()
    {
        _animator = GetComponent<Animator>();
        _player = GameObject.FindGameObjectWithTag("Player");
        if(_animator == null)
        {
            Debug.LogError("Animator component is missing!");
            enabled = false;
        }

        anim = GetComponent<Animator>();
    }

    void Update()
    {
        Debug.Log(lives);
        if (lives <= 100)
        {
            anim.SetTrigger("Stage2");
        }
        //Debug.Log(lives);
        if (lives <= 0)
        {
            anim.SetTrigger("death");
        }

        if(_animator == null) return;
        AnimatorStateInfo stateInfo = _animator.GetCurrentAnimatorStateInfo(0);
        int currentAnimationHash = stateInfo.shortNameHash;
        if(currentAnimationHash == Animator.StringToHash("attack_boss"))
        {
            //Debug.Log("Current Animation: attack");
            OnAttack();
        }
        if(currentAnimationHash == Animator.StringToHash("skill_boss"))
        {
            //Debug.Log("Current Animation: skill");
            OnAttack();
        }
        if(currentAnimationHash == Animator.StringToHash("summon_boss"))
        {
            _isSpawning = true;
        }
        else
        {
            _isSpawning = false;
            _spawnTimer = 0f;
            _enemiesSpawned = 0;
        }
        if (_isSpawning)
        {
            _spawnTimer += Time.deltaTime;

            if (_spawnTimer >= spawnDelay && _enemiesSpawned < enemiesToSpawn)
            {
                SpawnEnemy();
                _spawnTimer = 0f;
            }
        }
    }

    public override void Die()
    {
        
    }

    private void OnAttack()
    {
        float distanceToPlayer = Vector2.Distance(transform.position, _player.transform.position);
        if (distanceToPlayer <= attackRange)
        {
            // Наносим урон игроку
            Hero.Instance.GetDamage();
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }
    void SpawnEnemy()
    {
        // Выбираем случайную точку спавна
        if (spawnPoints.Length > 0)
        {
            Transform spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];

            // Создаем врага
            Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
            _enemiesSpawned++;
        }
        else
        {
            Debug.LogWarning("Нет точек спавна!");
        }
    }
}
