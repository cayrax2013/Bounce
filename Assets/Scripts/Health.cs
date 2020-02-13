using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField]
    private GameObject spawnPoint_1;
    [SerializeField]
    private int numOfHearts;
    public int _Health;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    private BallMover player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<BallMover>();
    }

    private void Update()
    {
        if (_Health > numOfHearts)
            _Health = numOfHearts;

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < _Health)
                hearts[i].sprite = fullHeart;
            else
                hearts[i].sprite = emptyHeart;

            if (i < numOfHearts)
                hearts[i].enabled = true;
            else
                hearts[i].enabled = false;
        }

        if (_Health < 1)
            SceneManager.LoadScene("SampleScene");
    }
}
