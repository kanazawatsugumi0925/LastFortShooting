using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyLifeManager : MonoBehaviour
{
    //敵のHP
    [SerializeField]
    public int enemyHP;

    //敵の最大HP
    [SerializeField]
    private int maxHP = 100;

    EnemyGenerator eg;

    GameObject enemygenerator;

    //HP表示UI
    [SerializeField]
    private GameObject E_HPCanvas;

    //HP表示Slider
    public Slider hpSlider;

    private void Awake()
    {
        enemygenerator = GameObject.Find("EnemyGenerator");
        eg = enemygenerator.GetComponent<EnemyGenerator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        enemyHP = maxHP;
        hpSlider = E_HPCanvas.transform.Find("E_HPbar").GetComponent<Slider>();
        hpSlider.value = (float)enemyHP;
    }

    /*private void LateUpdate()
    {
        transform.rotation = Camera.main.transform.rotation;
    }*/

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnColider Enter");

        // 衝突したオブジェクトがBulletだったとき
        if (collision.gameObject.CompareTag("Bullet"))
        {
            enemyHP -= 50;
            hpSlider.value = (float)enemyHP / (float)maxHP * 100;
            Debug.Log("HP" + hpSlider.value + "__" + maxHP);
            if (enemyHP <= 0)
            {
                eg.count--;

                Destroy(gameObject);
            }
        }

    }

    //衝突したときに呼ばれる
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTrriger Enter");

        //Bulletが衝突した時
        if (other.gameObject.CompareTag("Ballet"))
        {
            
        }
    }
}
