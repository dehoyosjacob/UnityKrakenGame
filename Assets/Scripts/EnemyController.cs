using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 0;
    [SerializeField] Transform player;

    float distanceToPlayer = 0;
    Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        distanceToPlayer = Vector3.Distance(transform.position, player.position);

        _animator.SetBool("isMoving", false);

        if(distanceToPlayer <= 20 && speed > 0)
        {
            transform.LookAt(player);

            if(distanceToPlayer > 3 && speed > 0)
            {
                _animator.SetBool("isMoving", true);

                transform.position += transform.forward * speed * Time.deltaTime;
            }
        }
    }
}
