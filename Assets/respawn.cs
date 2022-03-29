using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class respawn : MonoBehaviour
{
    float time = 0f;
    int cnt = 0;
    float gameTime;
    public GameObject prefab;
    Text score;
    Text timeLimit;
    // Use this for initialization
    void Start()
    {
        gameTime = 30.0f;   // ���� ���� �ð��� 30�ʷ� �մϴ�.
        score = GameObject.Find("Canvas").transform.Find("ballCnt").GetComponent<Text>();  // ������Ʈ ����
        timeLimit = GameObject.Find("Canvas").transform.Find("timeLimit").GetComponent<Text>(); // ����
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        // �ǽð� �ð��� ���մϴ�.
        if (time > 1.0)  // ���� 1�ʰ� �����ٸ�,
        {
            time -= 1.0f;       // 1�ʸ� ����
            respawnMissile();   // respawnMissile() �̶�� �Լ��� ȣ���մϴ�.
            cnt++;              // �̻����� �߰��� �� ���� ī��Ʈ�� �ø��ϴ�.
        }

        score.text = cnt.ToString();    // �������� ����ϴ� ī��Ʈ�� ����
        timeLimit.text = gameTime.ToString("N2");   // ���� �ð��� �����մϴ�. N2�� �Ҽ��� ��°¥������ ���
        gameTime -= Time.deltaTime;     // �ǽð����� ���ҽ�ŵ�ϴ�.
        if (gameTime < 0.0f)
        {
            // ���� ���ѽð��� ��� �Ҹ�Ǿ��� �� �Ʒ� ��ɾ �����մϴ�.
            // ���ѽð� ���� ��� ��ƾ ���̹Ƿ� �¸��ϴ� ��ư�� �߰����ݴϴ�.

            // �̰��� �߰��մϴ�.
        }
    }

    void respawnMissile()
    {
        float x = 9.4f;
        float y = 5.47f;

        int rand = Random.Range(0, 4);
        // 4���� �� �� ������ �������� ȣ���մϴ�. 0���� 3���� �����Դϴ�.
        // �� : 0 > ���� 1 > ������ 2 > ���� 3 > �Ʒ���
        switch (rand)
        {
            case 0:
                newUnit(-x, Random.Range(0.0f, y * 2) - y);
                break;
            case 1:
                newUnit(x, Random.Range(0.0f, y * 2) - y);
                break;
            case 2:
                newUnit(Random.Range(0.0f, x * 2) - x, y);
                break;
            case 3:
                newUnit(Random.Range(0.0f, x * 2) - x, -y);
                break;
            default:
                Debug.Log("I don't care. :D ");
                break;
        }
    }
    void newUnit(float x, float y)
    {
        Instantiate(prefab, new Vector3(x, y, 0), Quaternion.identity);
    }
}
