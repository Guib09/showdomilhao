﻿
namespace showdomilhao;

public partial class gerenciador
{
    public abstract gerenciador();
	 public void MainPage()
	{
		InitializeComponent();
    gerenciador = new Gerenciador(labelPergunta, btnResposta01, btnResposta02, btnResposta03, btnResposta04, btnResposta05);
    gerenciador.ProximaQuestao();
	}

  private void OnBtnResposta01Clicked(object sender, EventArgs e)
  {
    gerenciador!.VerificaCorreto(1);
  }

  private void OnBtnResposta02Clicked(object sender, EventArgs e)
  {
    gerenciador!.VerificaCorreto(2);
  }

  private void OnBtnResposta03Clicked(object sender, EventArgs e)
  {
    gerenciador!.VerificaCorreto(3);
  }

  private void OnBtnResposta04Clicked(object sender, EventArgs e)
  {
    gerenciador!.VerificaCorreto(4);
  }

  private void OnBtnResposta05Clicked(object sender, EventArgs e)
  {
    gerenciador!.VerificaCorreto(5);
  }
   void OnPularClicked (object sender)
   { 
    gerenciador.ProximaQuestao(OnPularClicked, 1)
    (s as Button).IsVisible =false;
     int pula=0;
     void OnPulaClicked(Object s, EventArgs a)
     {
       if(pula ==2)
             (s as Button).IsVisible=false;
             else
             { 
               gerenciador.ProximaQuestao();
               pula++;
             }
    }
   }
}
  
