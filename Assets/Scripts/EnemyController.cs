using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] float speed = 0;
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

        if(distanceToPlayer <= 40)
        {
            transform.LookAt(player);

            if(distanceToPlayer > 1.5)
            {
                _animator.SetBool("isMoving", true);

                transform.position += transform.forward * speed * Time.deltaTime;
            }
        }
    }
}
