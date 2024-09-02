using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Efeitodigitador : MonoBehaviour
    {
        private TextMeshProUGUI componenteTexto;
        private AudioSource _audioSource;
        private string mensagemOriginal;
        public bool imprimindo;
    
    private void Awake()
{

}

private void onEnable()
{

   }
   
   private void onDisable()
   {

   }

   public void ImprimirMensagem(string msg)
   {

   }
  IEnumerator LetraPorLetra(String msg)
   {
     yield return null;
   }
    }