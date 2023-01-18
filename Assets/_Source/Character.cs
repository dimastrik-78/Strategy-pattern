using System;
using System.Collections;
using System.Collections.Generic;
using Strategy;
using UnityEngine;

public class Character
{
    private Animator _animator;
    private Attack1 _attack1;
    private Attack2 _attack2;
    private Attack3 _attack3;
    private int _variantAttack;

    public Character(Animator animator)
    {
        _animator = animator;
        CreateAnimation();
    }

    private void CreateAnimation()
    {
        _attack1 = new Attack1();
        _attack2 = new Attack2();
        _attack3 = new Attack3();
    }
    
    public void SetStrategy(int variant) => _variantAttack = variant;

    public void PerformAttack()
    {
        if (_variantAttack == 1)
        { 
            _attack1.StartAnimation(_animator);
            _variantAttack = 0;
        }
        else if (_variantAttack == 2)
        {
            _attack2.StartAnimation(_animator);
            _variantAttack = 0;
        }
        else if (_variantAttack == 3)
        {
            _attack3.StartAnimation(_animator);
            _variantAttack = 0;
        }
    }
}
