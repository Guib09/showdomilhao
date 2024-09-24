namespace showdomilhao
{
  public class Questao
  {
    //________________________________________________________________________________________________________________
    public string? Pergunta {get;set;}
    public string? Resposta0{get;set;}
    public string? Resposta1{get;set;}
    public string? Resposta2{get;set;}
    public string? Resposta3{get;set;}
    public string? Resposta4{get;set;}
    public int Nivel {get;set;} = 0;
    public int RespostaCerta {get;set;} = 0;
    public int RespostaE {get;set;} = 0;
    //________________________________________________________________________________________________________________
    
    private Label labelPergunta;
    private Button buttonResposta0;
    private Button buttonResposta1;
    private Button buttonResposta2;
    private Button buttonResposta3;
    private Button buttonResposta4;
    //___________________________________________________________________________________________________________________
    public Questao()
    {
    }
    //________________________________________________________________________________________________________________
    public void Desenhar()
    {
      labelPergunta.Text = Pergunta;
      buttonResposta0.Text = Resposta0;
      buttonResposta1.Text = Resposta1;
      buttonResposta2.Text = Resposta2;
      buttonResposta3.Text = Resposta3;
      buttonResposta4.Text = Resposta4;

    }

    //________________________________________________

    public Questao(Label LP, Button bt00, Button bt01, Button bt02, Button bt03, Button bt04)
    {

      labelPergunta = LP;

      buttonResposta0 = bt00;
      buttonResposta1 = bt01;
      buttonResposta2 = bt02;
      buttonResposta3 = bt03;
      buttonResposta4 = bt04;
    }
    //________________________________________________________________________________________________________________
    public void ConfigurarDesenho(Label LP, Button bt00, Button bt01, Button bt02, Button bt03, Button bt04)
    {
      labelPergunta = LP;
      buttonResposta0 = bt00;
      buttonResposta1 = bt01;
      buttonResposta2 = bt02;
      buttonResposta3 = bt03;
      buttonResposta4 = bt04;
    }
    //__________________________________________________________________________________________________________________
    public bool verificaresposdta(int RespostaCerta)
    {
      if (RespostaCerta == RespostaE)
      {
        var bot = QualBot(RespostaCerta);
        bot.BackgroundColor = Colors.Black;
        return true;
      }
      else
      {
        return false;
      }
    }
    //___________________________________________________________________________________________________________________
    private Button QualBot(int RespostaCerta)
    {
      if (RespostaCerta == 0)
        return buttonResposta0;

      else if (RespostaCerta == 1)
        return buttonResposta1;

      else if (RespostaCerta == 2)
        return buttonResposta2;

      else if (RespostaCerta == 3)
        return buttonResposta3;

      else if (RespostaCerta == 4)
        return buttonResposta4;
      else
        return null;
    }
  }
}