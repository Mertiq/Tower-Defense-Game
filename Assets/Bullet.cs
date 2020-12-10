using UnityEngine;

public class Bullet : MonoBehaviour
{
    Transform target;
    public GameObject bulletImpactEffect;

    public float speed = 70f;

    public void Seek(Transform _target)
    {
        target = _target;
    }

   
    void Update()
    {
        if(target == null)
        {
            Destroy(gameObject);
            return;
        }
        
        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if(dir.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }
        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
        
    }

    void HitTarget()
    {
        GameObject effectIns = (GameObject)Instantiate(bulletImpactEffect, transform.position, transform.rotation);
        Destroy(effectIns, 2f);
        Destroy(target.gameObject);
        Destroy(gameObject);
    }

}
