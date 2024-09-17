namespace showdomilhao
{
  public class Questao
  {
    public string questao { get; set; }

    //---------------------------------------------------------------
    public string resposta1 { get; set; }
    public string resposta2 { get; set; }
    public string resposta3 { get; set; }
    public string resposta4 { get; set; }
    public string resposta5 { get; set; }
    public int NivelDaPergunta;
    public int RespostaR;
    public int RespostaC;
    private Label labelPergunta;
    private Button buttonrep1;
    private Button buttonrep2;
    private Button buttonrep3;
    private Button buttonrep4;
    private Button buttonrep5;

    public void desenhar()
    {
      labelPergunta.Text = questao;
      buttonrep1.Text = resposta1;
      buttonrep2.Text = resposta2;
      buttonrep3.Text = resposta3;
      buttonrep4.Text = resposta4;
      buttonrep5.Text = resposta5;
    }



    public  Questao ()
    {}
    public Questao(Label per, Button bot1, Button bot2, Button bot3, Button bot4, Button bot5)
    {
      labelPergunta = per;
      buttonrep1 = bot1;
      buttonrep2 = bot2;
      buttonrep3 = bot3;
      buttonrep4 = bot4;
      buttonrep5 = bot5;
    }


    public bool verificaresposdta(int RespostaC)
    {
      if (RespostaC == RespostaR)
      {
        var bot = QualBot(RespostaC);
        bot.BackgroundColor = Colors.Green;
        return true;
      }
      else
      {
        return false;
      }
    }
     
    private Button QualBot (int RespostaC)
    {
      if (RespostaC == 1)
        return buttonrep1;
      else if (RespostaC == 2)
        return buttonrep2;
      else if (RespostaC == 3)
        return buttonrep3;
      else if (RespostaC == 4)
        return buttonrep4;
      else if (RespostaC == 5)
        return buttonrep5;
        else
        return null;
    }
  }
}



//ublic void configurar(Label per,Button bot1,Button bot2,Button bot3,Button bot4,Button bot5); 
// {
//  labelPergunta=per;
//  buttonrep=bot1;
//  buttonrep=bot2;
//  buttonrep=bot3;
//  buttonrep=bot4;
//  buttonrep=bot5;
// }
