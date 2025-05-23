// Brick (������) �浹 ó��, ������ �ý��� ����
using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour // MonoBehaviour ���
{

    // 2D ���� �������� �浹�� �߻����� �� ȣ��Ǵ� �Լ�
    // col: �浹�� ��� ������Ʈ�� ���� ������ ��� ����
    void OnCollisionEnter2D(Collision2D col)

    {
        // �浹�� ������Ʈ�� Rigidbody2D ������Ʈ�� ������ return
        if (col.gameObject.GetComponent<Rigidbody2D>() == null) return;

        // ������ ���, ������= �ӵ��� ũ��* 10
        float damage = col.gameObject.GetComponent<Rigidbody2D>().velocity.magnitude * 10;

        // ��������ŭ ü�� ����
        Health -= damage;

        // ü���� 0 ���ϰ� �Ǹ� ������Ʈ ����
        if (Health <= 0) Destroy(this.gameObject);

    }

    // ���� ü��, 0 ���ϸ� ������Ʈ ����
    public float Health = 70f;


}

