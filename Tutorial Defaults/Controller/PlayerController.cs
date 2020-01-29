using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public Camera camera;
    public NavMeshAgent agent;
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Debug.Log("Mouse Clicked");
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            Debug.Log(Physics.Raycast(ray, out hit));
            if(Physics.Raycast(ray, out hit)){
                // Move agent
                Debug.Log("Move");
                agent.SetDestination(hit.point);
            }
        }
    }
}
