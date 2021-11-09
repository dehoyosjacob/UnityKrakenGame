using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] float speed = 0;
    [SerializeField] Transform player;

    float distanceToPlayer = 0;

    // Update is called once per frame
    void Update()
    {
        distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if(distanceToPlayer <= 40)
        {
            transform.LookAt(player);

            if(distanceToPlayer > 1.5)
            {
                transform.position += transform.forward * speed * Time.deltaTime;
            }
        }
    }
}
