
// �� (����)�� ü��, �浹 ó��, ������ ó��, ��������Ʈ ����
using UnityEngine;
using System.Collections;

public class Pig : MonoBehaviour // MonoBehaviour ���
{
    // �� (����)�� ü�� �⺻ 150
    public float Health = 150f;
    // ü���� ���� ���Ϸ� �������� �� �ٲ� ��������Ʈ
    public Sprite SpriteShownWhenHurt;
    // ��������Ʈ �ٲ� ü�°� (����)
    private float ChangeSpriteHealth;

    void Start() // ��������Ʈ �ٲٵ��� ���� ����
    {
        ChangeSpriteHealth = Health - 30f; // ü�� 30 �پ��� ��������Ʈ ����
    }

    void OnCollisionEnter2D(Collision2D col)
    {	// �������� �ʴ� ������Ʈ �浹 ����
        if (col.gameObject.GetComponent<Rigidbody2D>() == null) return;

        // �� (źȯ, ��)�� �ε��� ���
        if (col.gameObject.tag == "Bird")
        {	// ������Ʈ ����
            Destroy(gameObject);
        }
        else // ���� �ƴ� �ٸ� ������Ʈ�� �ε��� ���
        {
            // ������= �ӵ� * 10
            float damage = col.gameObject.GetComponent<Rigidbody2D>().velocity.magnitude * 10;
            // ü��- ������
            Health -= damage;

            if (Health < ChangeSpriteHealth) // ü���� ��������Ʈ �ٲ�� ���ذ����� ������
            {	// ��������Ʈ ����
                GetComponent<SpriteRenderer>().sprite = SpriteShownWhenHurt;
            }
            // ü���� 0 ���ϰ� �Ǹ� ������Ʈ ����
            if (Health <= 0) Destroy(this.gameObject);
        }
    }


}


