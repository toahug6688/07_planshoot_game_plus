using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    public GameObject BulletPrefab;
    public float moveSpeed = 1; // ���ʳt��

    void FixedUpdate()
    {
        //²�檺���k����A�o�ӽd�һP�L�h���߫}���ʳ��O������
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.position += new Vector3(moveSpeed, 0, 0) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.position += new Vector3(-moveSpeed, 0, 0) * Time.deltaTime;
        }
    }

    void Update()
    {
        //�W�[�l�u�o�g���\��
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 pos = gameObject.transform.position + new Vector3(0, 0.6f, 0); //�l�u�ͦ�����m�ھھԾ�����m�A�A���W�[0.6f
            Instantiate(BulletPrefab, pos, gameObject.transform.rotation); //�̾ڤW�z��pos��m�A�ͦ��l�u
        }
    }
}