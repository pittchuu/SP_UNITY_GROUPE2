using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    private UnityEngine.AI.NavMeshAgent agent;
    private UnityEngine.Animator anim;
    // public AudioClip RechargeSon;
    void Start()
    {
        agent = GetComponent(typeof(UnityEngine.AI.NavMeshAgent)) as UnityEngine.AI.NavMeshAgent;
        anim = GetComponent<Animator>();
        //anim.Play("Base Layer.DS_onehand_idle");

    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            // Check for a new destination with raycast
            var ray = Camera.main.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
            var hitInfo = new RaycastHit();
            Physics.Raycast(ray, out hitInfo, 500);
            if (hitInfo.collider.gameObject.tag == "walkable")
            {
                anim.Play("Base Layer.DS_onehand_walk");
                agent.SetDestination(hitInfo.point);
            }

        }
        //debug.log(agent.pathStatus);
        //anim.Play("Base Layer.DS_onehand_idle");
    }
}
