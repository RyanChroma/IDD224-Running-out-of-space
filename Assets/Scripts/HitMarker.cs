using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitMarker : MonoBehaviour
{
    public CanvasGroup group;

    public void OnEnable()
    {
        Bullet.onHit += ActivateHitMarker;
    }

    public void OnDisable()
    {
        Bullet.onHit -= ActivateHitMarker;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void ActivateHitMarker()
    {
        group.DOFade(1f, 0.1f).OnComplete(() => group.DOFade(0f, 0.1f));
    }
}
