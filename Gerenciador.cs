namespace showdomilho
{
    public class Gerenciador
    {
        List<Questao> ListaQuestoes = new List<Questao>();
        List<int> ListaQuestoesRespondidas = new List<int>();
        Questao QuestaoCorrente;
        Label labelnivel;
        Label Labelpontuacao;

        public Gerenciador(Label labelPerg, Button btnResp01, Button btnResp02, Button btnResp03, Button btnResp04, Button btnResp05, Label labelnivel, Labelpontuacao,)
        {
            Label = labelnivel;
            Label = Labelpontuacao;
            CriaPerguntas(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        }

        private HashSet<int> QuestoesRespondidas = new HashSet<int>();
        public int Pontuacao { get; private set; }
        int NivelAtual = 1;

        void inicializar()
        {
            Pontuacao = 0;
            NivelAtual = 1;
            ProximaQuestao();
        }

        void AdicionaPontuacao(int n)
        {
            if (n == 1)
                Pontuacao = 1000;
            else if (n == 2)
                Pontuacao = 2000;
            else if (n == 3)
                Pontuacao = 5000;
            else if (n == 4)
                Pontuacao = 10000;
            else if (n == 5)
                Pontuacao = 20000;
            else if (n == 6)
                Pontuacao = 50000;
            else if (n == 7)
                Pontuacao = 100000;
            else if (n == 8)
                Pontuacao = 200000;
            else if (n == 9)
                Pontuacao = 500000;
            else if (n == 10)
                Pontuacao = 1000000;
        }

        private void CriaPerguntas(Label lp, Button BT01, Button BT02, Button BT03, Button BT04, Button BT05)
        {
            var q0 = new Questao();
            q0.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            q0.Pergunta = "Qual é a capital da Argentina?";
            q0.Resposta0 = "Brasil";
            q0.Resposta1 = "Caracas";
            q0.Resposta2 = "Buenos Aires";
            q0.Resposta3 = "Mendoza";
            q0.Resposta4 = "Xique-Xique";
            q0.RespostaCerta = 3;

            ListaQuestoes.Add(q0);

            var q2 = new Questao();
            q2.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            q2.Pergunta = "Qual é o maior planeta do sistema solar?";
            q2.Resposta0 = "Terra";
            q2.Resposta1 = "Marte";
            q2.Resposta2 = "Júpiter";
            q2.Resposta3 = "Saturno";
            q2.Resposta4 = "Netuno";
            q2.RespostaCerta = 3;
            ListaQuestoes.Add(q2);

            var q3 = new Questao();
            q3.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            q3.Pergunta = "Qual é a fórmula da água?";
            q3.Resposta0 = "H2O";
            q3.Resposta1 = "CO2";
            q3.Resposta2 = "O2";
            q3.Resposta3 = "NaCl";
            q3.Resposta4 = "HCl";
            q3.RespostaCerta = 1;
            ListaQuestoes.Add(q3);

            var q4 = new Questao();
            q4.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            q4.Pergunta = "Qual é o símbolo químico do ouro?";
            q4.Resposta0 = "Au";
            q4.Resposta1 = "Ag";
            q4.Resposta2 = "Fe";
            q4.Resposta3 = "Pb";
            q4.Resposta4 = "Hg";
            q4.RespostaCerta = 1;
            ListaQuestoes.Add(q4);





            var q5 = new Questao();
            q5.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            q5.Pergunta = "Qual é a capital da França?";
            q4.Resposta0 = "Paris";
            q4.Resposta1 = "Londres";
            q4.Resposta2 = "Berlim";
            q4.Resposta3 = "Madri";
            q4.Resposta4 = "Roma";
            q5.RespostaCerta = 1;
            ListaQuestoes.Add(q5);

            var q6 = new Questao();
            q6.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            q6.Pergunta = "Qual é o continente conhecido como berço da humanidade?";
            q6.Resposta0 = "África";
            q6.Resposta1 = "Ásia";
            q6.Resposta2 = "Europa";
            q6.Resposta3 = "América";
            q6.Resposta4 = "Oceania";
            q6.RespostaCerta = 1;
            ListaQuestoes.Add(q6);

            var q7 = new Questao();
            q7.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            q7.Pergunta = "Quem escreveu 'Dom Casmurro'?";
            q7.Resposta0 = "Machado de Assis";
            q7.Resposta1 = "José de Alencar";
            q7.Resposta2 = "Graciliano Ramos";
            q7.Resposta3 = "Jorge Amado";
            q7.Resposta4 = "Clarice Lispector";
            q7.RespostaCerta = 1;
            ListaQuestoes.Add(q7);


            ProximaQuestao();
        }

        public async void VerificarSeEstaCorreta(int RespostaCerta)
        {
            if (QuestaoCorrente.VerificarSeEstaCorreta(RespostaCerta))
            {
                await Task.Delay(1000);
                AdicionaPontuacao(NivelAtual);
                NivelAtual++;
                ProximaQuestao();
            }
            else
            {
                await Task.Delay(25000);
                await App.Current.MainPage.DisplayAlert("errou", "deu game over", "OK");
                inicializar();
            }
        }

        public void ProximaQuestao()
        {

            var numRandomNumber = Random.Shared.Next(0, ListaQuestoes.Count -1);
                  while (QuestoesRespondidas.Contains(numRandomNumber))
            {
                numRandomNumber = Random.Shared.Next(0, ListaQuestoes.Count);
            }


            QuestoesRespondidas.Add(numRandomNumber);


            QuestaoCorrente = ListaQuestoes[numRandomNumber];
            QuestaoCorrente.Desenhar();
        }

    }
}