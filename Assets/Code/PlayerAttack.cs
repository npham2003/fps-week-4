using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAttack : MonoBehaviour
{
    private float raycastDist = 50;
    public LayerMask enemyLayer;
    public Transform camTrans;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(camTrans.position, camTrans.forward, out hit, raycastDist, enemyLayer))
            {
                GameObject enemy = hit.collider.gameObject;
                //destroy
                if(enemy.CompareTag("Monster"))
                {
                    Destroy(enemy);
                }
            }
        }
    }
}
