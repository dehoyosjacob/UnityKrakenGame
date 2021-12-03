using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactWebController : MonoBehaviour
{
    [SerializeField] ParticleSystem impactParticle;
    [SerializeField] float shootDistance = 50f;
    [SerializeField] AudioSource fireWeb;
    [SerializeField] GameObject player;
    [SerializeField] Transform rayOrigin;

    RaycastHit objectHit;
    int timesHit;

    void PlayAudio(AudioSource audio)
    {
        audio.Play();
    }

    void PlayParticle(ParticleSystem particle)
    {
        particle.Play();
    }

    public void FireImpactWeb()
    {
        PlayAudio(fireWeb);
        PlayParticle(impactParticle);

        Vector3 rayDirection = player.transform.forward;

        if (Physics.Raycast(rayOrigin.position, rayDirection, out objectHit, shootDistance))
        {
            EnemyController _enemy = objectHit.transform.gameObject.GetComponent<EnemyController>();
            if (_enemy != null)
            {
                Debug.Log("Hit");
                timesHit++;
                Debug.Log(timesHit.ToString());

                if (timesHit == 2)
                {
                    _enemy.speed = 0f;
                }
            }
        }
    }
}
