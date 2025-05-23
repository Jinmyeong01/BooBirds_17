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
        {
            Destroy(col.gameObject);
        }
    }
}
