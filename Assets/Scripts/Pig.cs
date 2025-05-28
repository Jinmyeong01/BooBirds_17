<<<<<<< HEAD
﻿using UnityEngine;
using System.Collections;

public class Pig : MonoBehaviour
{
    public float Health = 150f;
    public Sprite SpriteShownWhenHurt;
    private float ChangeSpriteHealth;

    void Start()
    {
        ChangeSpriteHealth = Health - 30f;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.GetComponent<Rigidbody2D>() == null) return;

        // 새와 충돌 시 즉시 제거
        if (col.gameObject.tag == "Bird")
        {
            Destroy(gameObject);
        }
        else
        {
            // 충격 데미지 계산
            float damage = col.gameObject.GetComponent<Rigidbody2D>().velocity.magnitude * 10;
            Health -= damage;

            // 체력 변화에 따라 스프라이트 변경
            if (Health < ChangeSpriteHealth)
            {
                GetComponent<SpriteRenderer>().sprite = SpriteShownWhenHurt;
            }

            // 체력이 0 이하이면 제거
            if (Health <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
=======

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


>>>>>>> upstream/master
