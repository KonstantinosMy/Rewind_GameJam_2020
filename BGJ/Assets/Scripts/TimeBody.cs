using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Experimental.Rendering.Universal;
public class TimeBody : MonoBehaviour
{

    bool isRewinding = false;

    public float recordTime = 5f;
    public float rewindAllowance = 6f;
    public bool canRewind;

    public Slider rewindSlider;
    public TMP_Text rewindPercentage;
    List<PointInTime> pointsInTime;

    Rigidbody2D rb;
    public Light2D timemachingLight;
    public AudioSource rewindSound;
    // Use this for initialization
    void Start()
    {
        pointsInTime = new List<PointInTime>();
        rb = GetComponent<Rigidbody2D>();
        canRewind = true;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (rewindAllowance > 0f && canRewind)
        {
            if (Input.GetKeyDown(KeyCode.Mouse1))
                StartRewind();
          

            if (Input.GetKeyUp(KeyCode.Mouse1))
                StopRewind();
        }

        if (rewindAllowance <= 0)
        {
            StopRewind();
        }

        DropAllowance();

        if (rewindAllowance <= 0)
        {
            canRewind = false;
        }
    }

    void FixedUpdate()
    {
        if (isRewinding)
            Rewind();
        else
            Record();
    }

    void DropAllowance()
    {
        if (rewindAllowance > 0 && isRewinding)
        {
            rewindAllowance -= Time.deltaTime;
            Debug.Log("rewind allowance left: " + rewindAllowance);
            rewindSlider.value = rewindAllowance;
            //LeftCount / TotalCount * 100
            rewindPercentage.text = (rewindAllowance / 6f * 100f).ToString("0") + "%";
        }
    }
    void Rewind()
    {
        if (pointsInTime.Count > 0)
        {
            PointInTime pointInTime = pointsInTime[0];
            transform.position = pointInTime.position;
            transform.rotation = pointInTime.rotation;
            pointsInTime.RemoveAt(0);
        }
        else
        {
            StopRewind();
        }

    }

    void Record()
    {
        if (pointsInTime.Count > Mathf.Round(recordTime / Time.fixedDeltaTime))
        {
            pointsInTime.RemoveAt(pointsInTime.Count - 1);
        }

        pointsInTime.Insert(0, new PointInTime(transform.position, transform.rotation));
    }

    public void StartRewind()
    {
        rewindSound.Play();
        isRewinding = true;
        rb.isKinematic = true;
        timemachingLight.intensity = Mathf.Lerp(1.2f, 3f, 5f);
        timemachingLight.pointLightOuterRadius = Mathf.Lerp(0.8f, 1.60f, 6f);


    }

    public void StopRewind()
    {
        rewindSound.Stop();
        isRewinding = false;
        rb.isKinematic = false;
        timemachingLight.intensity = Mathf.Lerp(3f, 1.2f, 5f);
        timemachingLight.pointLightOuterRadius = Mathf.Lerp(1.60f, 0.8f, 6f);
    }
}
