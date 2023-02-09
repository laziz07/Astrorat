using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHP : MonoBehaviour
{
    [SerializeField]
    private float maxHP = 2;     // �ִ� ü��
    private float currentHP;      // ���� ü��

    public float MaxHP => maxHP;
    public float CurrentHP => currentHP;

    private void Awake()
    {
        currentHP = maxHP;          // ���� ü���� �ִ� ü�°� ���� ����
    }

    public void TakeDamage(float damage)
    {
        // ���� ü���� damage��ŭ ����
        currentHP -= damage;

        // ü���� 0�� �Ǹ� ���ӿ���
        if (currentHP <= 0)
        {
            Debug.Log("�÷��̾� ���");
        }
    }
}