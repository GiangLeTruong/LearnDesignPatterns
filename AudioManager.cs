using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource _Jump;
    [SerializeField] AudioSource _Theme;
    [SerializeField] Slider sld_Theme;
    public static AudioManager Play { get; private set; }
    private void Awake()
    {
        if (Play!=null&&Play!=this)
        {
            Destroy(this);
        }
        else
        {
            Play = this;
        }
    }
    private void Update() => set_ThemeVolume();
    
    public void audio_Jump() => _Jump.Play();
   
    public void set_ThemeVolume() => _Theme.volume = sld_Theme.value;

}
