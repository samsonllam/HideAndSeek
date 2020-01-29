using UnityEngine;
using UnityEngine.AI;

public class GreenObjectController : MonoBehaviour
{
    public Camera camera;
    public NavMeshAgent agent;
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit)){
                // Move agent
                agent.SetDestination(hit.point);
            }       
        }
    }
}
