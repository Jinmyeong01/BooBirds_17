<<<<<<< HEAD
﻿using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour {


    void OnTriggerEnter2D(Collider2D col)
    {
        //destroyers are located in the borders of the screen
        //if something collides with them, the'll destroy it
        string tag = col.gameObject.tag;
        if(tag == "Bird" || tag == "Pig" || tag == "Brick")
=======
// ��迡 �ִ� ������Ʈ�� ȭ�� ������ �����¸� �ش� ������Ʈ ����

using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour
{ // MonoBehaviour ���

    // Collider2D�� isTrigger�� ������ ������Ʈ�� ����� �� ȣ��
    // col: ���� ������Ʈ�� ����
    void OnTriggerEnter2D(Collider2D col)

    {
        string tag = col.gameObject.tag; // tag= �浹�� ������Ʈ�� �±� 
        if (tag == "Bird" || tag == "Pig" || tag == "Brick")
        // ���� tag�� Bird, Pig, Brick �� �ϳ���� 
        // �ش� ������Ʈ ����
>>>>>>> upstream/master
        {
            Destroy(col.gameObject);
        }
    }
}
