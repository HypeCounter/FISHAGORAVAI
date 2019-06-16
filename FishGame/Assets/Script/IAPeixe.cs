using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class IAPeixe : MonoBehaviour
{
    [SerializeField] WayPointConteiner patrolPath; // caminho nos transforms
    [SerializeField] float wayPointDwell = .5f; // tempo de aguardo para nova posicao
    [SerializeField] float waypointTolerence = 2f;
    int nextWayPointIndex;

    enum State
    {
        idle, patrolling
    }
    State state = State.idle;
    Character character;

    private void Start()
    {
        character = GetComponent<Character>();
    }

    private void Update()
    {
        if (!BaitController.pescou)
        {
            StartCoroutine(Patrol());
        }
    }

    IEnumerator Patrol()
    {
        state = State.patrolling;


      //  while (true)
      //  {
            Vector3 nextWayPointPos = patrolPath.transform.GetChild(nextWayPointIndex).position;
            character.MoveTo(nextWayPointPos);
          //  Debug.Log(nextWayPointIndex);
            CycleWaypointWhenClose(nextWayPointPos);
            yield return new WaitForSeconds(wayPointDwell);
      //  }
        
    }
    private void CycleWaypointWhenClose(Vector3 nextWayPointPos)
    {
      //  Debug.Log("chamou cycle");
       // Debug.Log(Vector3.Distance(transform.position, nextWayPointPos));

        if (Vector3.Distance(transform.position, nextWayPointPos) <= waypointTolerence)
        {

            nextWayPointIndex = (nextWayPointIndex + 1) % patrolPath.transform.childCount;
            Debug.Log(nextWayPointIndex);
            new WaitForSeconds(1f);
        }
    }

}
