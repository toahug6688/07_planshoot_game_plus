using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Bullet : MonoBehaviour
{
    public float moveSpeed = 1; // ���ʳt��
                                // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5); //�]�w2���l�u����Q�R��
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += new Vector3(0, moveSpeed, 0) * Time.deltaTime; //�l�u�|

    }
}