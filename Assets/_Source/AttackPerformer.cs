using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackPerformer : MonoBehaviour
{
    [SerializeField] private Button button1;
    [SerializeField] private Button button2;
    [SerializeField] private Button button3;
    [SerializeField] private KeyCode attack;
    [SerializeField] private Animator animator;

    private Character _character;
    
    private void Start()
    {
        _character = new Character(animator);
        
        button1.onClick.AddListener(FirstVariantAttack);
        button2.onClick.AddListener(SecondVariantAttack);
        button3.onClick.AddListener(ThirdVariantAttack);
    }

    void Update()
    {
        if (Input.GetKeyDown(attack))
        {
            _character.PerformAttack();
        }
    }

    public void FirstVariantAttack()
    {
        _character.SetStrategy(1);

        button1.image.color = Color.green;
        button2.image.color = Color.white;
        button3.image.color = Color.white;

        button1.interactable = false;
        button2.interactable = true;
        button3.interactable = true;
    }

    public void SecondVariantAttack()
    {
        _character.SetStrategy(2);
        
        button1.image.color = Color.white;
        button2.image.color = Color.green;
        button3.image.color = Color.white;
        
        button1.interactable = true;
        button2.interactable = false;
        button3.interactable = true;
    }

    public void ThirdVariantAttack()
    {
        _character.SetStrategy(3);
        
        button1.image.color = Color.white;
        button2.image.color = Color.white;
        button3.image.color = Color.green;
        
        button1.interactable = true;
        button2.interactable = true;
        button3.interactable = false;
    }
}
