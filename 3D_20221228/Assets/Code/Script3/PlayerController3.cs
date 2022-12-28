using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController3 : MonoBehaviour
{
    public Rigidbody playerRB;
    public float jumpForce = 10;
    public float gravityMod = 1;

    public bool isOnGround = true; //是否貼合地板
    public int twiceJump = 0;//二段跳計數

    public bool gameOver = false;

    public Animator playerAnim; //宣告控制玩家的動畫控制器
    public ParticleSystem playerExplodation;
    public ParticleSystem PlayerDirt;
    public AudioClip soundJump;
    public AudioClip soundCrash;
    public AudioSource playerSound;


    public TextMeshProUGUI gameNameText;
    public TextMeshProUGUI jumpText;
    void Start()
    {
        //獲得鋼體的控制權
        playerRB = GetComponent<Rigidbody>();
        //playerRB.AddForce(Vector3.up * 1000); 
        Physics.gravity = Physics.gravity * gravityMod;

        playerAnim = GetComponent<Animator>();
        playerSound = GetComponent<AudioSource>();


        gameNameText.gameObject.SetActive(true);
    }

    void Update()
    {
        //改為可二段跳
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround == true && twiceJump < 2 && !gameOver)
        {
            playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            //isOnGround = false; //切換: false
            twiceJump++;//twiceJump=twicejump+1

            playerAnim.SetTrigger("Jump_trig");
            playerAnim.speed = 1;
            PlayerDirt.Stop();
            playerSound.PlayOneShot(soundJump, 3);
            jumpText.gameObject.SetActive(true);
        }
        if (gameObject.transform.position.y > 3)
        {
            jumpText.gameObject.SetActive(false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true; //切換2=true
            twiceJump = 0;
            playerAnim.SetFloat("Speed_f", 1);
            playerAnim.speed = 2;
            PlayerDirt.Play();
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {

            gameOver = true;
            print("Game Over!!!");
            isOnGround = false;
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            playerExplodation.Play();
            PlayerDirt.Stop();
            playerSound.PlayOneShot(soundCrash, 1);

        }
    }
}
