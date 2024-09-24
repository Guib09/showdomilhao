namespace showdomilho
{
    public class Gerenciador
    {
        private List<Questao> ListaQuestoes = new List<Questao>();
        private List<int> ListaQuestoesRespondidas = new List<int>();
        private Questao QuestaoCorrente;

        public Gerenciador(Label labelPerg, Button btnResp01, Button btnResp02, Button btnResp03, Button btnResp04, Button btnResp05)
        {
            CriaPerguntas(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        }

        using showDoMilhao;

namespace Controle
{
    public class Gerenciador
    {
        private List<Questao> ListaQuestoes = new List<Questao>();
        private HashSet<int> QuestoesRespondidas = new HashSet<int>();
        private Questao QuestaoCorrente;

        public Gerenciador(Label lp, Button BT01, Button BT02, Button BT03, Button BT04, Button BT05)
        {
            CriaPerguntas(lp, BT01, BT02, BT03, BT04, BT05);
        }

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
            var P1 = new Questao();
            P1.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            q1.Question = "Qual é a capital da Argentina?";
            q1.FirstQuestion = "Brasil";
            q1.SecondQuestion = "Caracas";
            q1.ThirdQuestion = "Buenos Aires";
            q1.FourthQuestion = "Mendoza";
            q1.FiveQuestion = "Xique-Xique";
            q1.respostaCorreta = 3;
            ListaQuestoes.Add(q1);

            var q2 = new Questao();
            q2.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            q2.Question = "Qual é o maior planeta do sistema solar?";
            q2.FirstQuestion = "Terra";
            q2.SecondQuestion = "Marte";
            q2.ThirdQuestion = "Júpiter";
            q2.FourthQuestion = "Saturno";
            q2.FiveQuestion = "Netuno";
            q2.respostaCorreta = 3;
            ListaQuestoes.Add(q2);

            var P3 = new Questao();
            P3.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P3.Question = "Qual é a fórmula da água?";
            P3.FirstQuestion = "H2O";
            P3.SecondQuestion = "CO2";
            P3.ThirdQuestion = "O2";
            P3.FourthQuestion = "NaCl";
            P3.FiveQuestion = "HCl";
            P3.respostaCorreta = 1;
            ListaQuestoes.Add(P3);

            var P4 = new Questao();
            P4.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P4.Question = "Qual é o símbolo químico do ouro?";
            P4.FirstQuestion = "Au";
            P4.SecondQuestion = "Ag";
            P4.ThirdQuestion = "Fe";
            P4.FourthQuestion = "Pb";
            P4.FiveQuestion = "Hg";
            P4.respostaCorreta = 1;
            ListaQuestoes.Add(P4);

            var P5 = new Questao();
            P5.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P5.Question = "Qual é a capital da França?";
            P5.FirstQuestion = "Paris";
            P5.SecondQuestion = "Londres";
            P5.ThirdQuestion = "Berlim";
            P5.FourthQuestion = "Madri";
            P5.FiveQuestion = "Roma";
            P5.respostaCorreta = 1;
            ListaQuestoes.Add(P5);

            var P6 = new Questao();
            P6.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P6.Question = "Qual é o continente conhecido como berço da humanidade?";
            P6.FirstQuestion = "África";
            P6.SecondQuestion = "Ásia";
            P6.ThirdQuestion = "Europa";
            P6.FourthQuestion = "América";
            P6.FiveQuestion = "Oceania";
            P6.respostaCorreta = 1;
            ListaQuestoes.Add(P6);

            var P7 = new Questao();
            P7.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P7.Question = "Quem escreveu 'Dom Casmurro'?";
            P7.FirstQuestion = "Machado de Assis";
            P7.SecondQuestion = "José de Alencar";
            P7.ThirdQuestion = "Graciliano Ramos";
            P7.FourthQuestion = "Jorge Amado";
            P7.FiveQuestion = "Clarice Lispector";
            P7.respostaCorreta = 1;
            ListaQuestoes.Add(P7);

            var P8 = new Questao();
            P8.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P8.Question = "Qual é o maior oceano do mundo?";
            P8.FirstQuestion = "Atlântico";
            P8.SecondQuestion = "Índico";
            P8.ThirdQuestion = "Pacífico";
            P8.FourthQuestion = "Ártico";
            P8.FiveQuestion = "Antártico";
            P8.respostaCorreta = 3;
            ListaQuestoes.Add(P8);

            var P9 = new Questao();
            P9.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P9.Question = "Qual é o país com mais habitantes?";
            P9.FirstQuestion = "Índia";
            P9.SecondQuestion = "Estados Unidos";
            P9.ThirdQuestion = "China";
            P9.FourthQuestion = "Brasil";
            P9.FiveQuestion = "Indonésia";
            P9.respostaCorreta = 3;
            ListaQuestoes.Add(P9);

            var P10 = new Questao();
            P10.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P10.Question = "Qual é o elemento químico com o símbolo 'He'?";
            P10.FirstQuestion = "Hélio";
            P10.SecondQuestion = "Hidrogênio";
            P10.ThirdQuestion = "Lítio";
            P10.FourthQuestion = "Carbono";
            P10.FiveQuestion = "Oxigênio";
            P10.respostaCorreta = 1;
            ListaQuestoes.Add(P10);

            // Continue com as próximas perguntas até P100...

            var P11 = new Questao();
            P11.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P11.Question = "Qual é a capital do Japão?";
            P11.FirstQuestion = "Tóquio";
            P11.SecondQuestion = "Pequim";
            P11.ThirdQuestion = "Seul";
            P11.FourthQuestion = "Bangkok";
            P11.FiveQuestion = "Hanoi";
            P11.respostaCorreta = 1;
            ListaQuestoes.Add(P11);

            var P12 = new Questao();
            P12.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P12.Question = "Qual é a montanha mais alta do mundo?";
            P12.FirstQuestion = "K2";
            P12.SecondQuestion = "Kangchenjunga";
            P12.ThirdQuestion = "Everest";
            P12.FourthQuestion = "Makalu";
            P12.FiveQuestion = "Lhotse";
            P12.respostaCorreta = 3;
            ListaQuestoes.Add(P12);

            var P13 = new Questao();
            P13.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P13.Question = "Qual é o maior mamífero do planeta?";
            P13.FirstQuestion = "Elefante";
            P13.SecondQuestion = "Baleia Azul";
            P13.ThirdQuestion = "Girafa";
            P13.FourthQuestion = "Tubarão";
            P13.FiveQuestion = "Urso";
            P13.respostaCorreta = 2;
            ListaQuestoes.Add(P13);

            var P14 = new Questao();
            P14.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P14.Question = "Quem pintou a Mona Lisa?";
            P14.FirstQuestion = "Vincent van Gogh";
            P14.SecondQuestion = "Pablo Picasso";
            P14.ThirdQuestion = "Leonardo da Vinci";
            P14.FourthQuestion = "Claude Monet";
            P14.FiveQuestion = "Rembrandt";
            P14.respostaCorreta = 3;
            ListaQuestoes.Add(P14);

            var P15 = new Questao();
            P15.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P15.Question = "Qual é o idioma mais falado no mundo?";
            P15.FirstQuestion = "Inglês";
            P15.SecondQuestion = "Mandarim";
            P15.ThirdQuestion = "Espanhol";
            P15.FourthQuestion = "Francês";
            P15.FiveQuestion = "Árabe";
            P15.respostaCorreta = 2;
            ListaQuestoes.Add(P15);

            // Continue assim até P100...

            // Exemplos adicionais até P100
            var P16 = new Questao();
            P16.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P16.Question = "Qual é a capital da Itália?";
            P16.FirstQuestion = "Veneza";
            P16.SecondQuestion = "Roma";
            P16.ThirdQuestion = "Milão";
            P16.FourthQuestion = "Florença";
            P16.FiveQuestion = "Nápoles";
            P16.respostaCorreta = 2;
            ListaQuestoes.Add(P16);

            var P17 = new Questao();
            P17.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P17.Question = "Qual é o animal conhecido como 'rei da selva'?";
            P17.FirstQuestion = "Elefante";
            P17.SecondQuestion = "Leão";
            P17.ThirdQuestion = "Tigre";
            P17.FourthQuestion = "Urso";
            P17.FiveQuestion = "Cervo";
            P17.respostaCorreta = 2;
            ListaQuestoes.Add(P17);

            var P18 = new Questao();
            P18.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P18.Question = "Qual é a capital do Brasil?";
            P18.FirstQuestion = "Brasília";
            P18.SecondQuestion = "Rio de Janeiro";
            P18.ThirdQuestion = "São Paulo";
            P18.FourthQuestion = "Salvador";
            P18.FiveQuestion = "Belo Horizonte";
            P18.respostaCorreta = 1;
            ListaQuestoes.Add(P18);

            var P19 = new Questao();
            P19.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P19.Question = "Qual é a principal fonte de energia da Terra?";
            P19.FirstQuestion = "Energia solar";
            P19.SecondQuestion = "Energia eólica";
            P19.ThirdQuestion = "Energia nuclear";
            P19.FourthQuestion = "Energia geotérmica";
            P19.FiveQuestion = "Carvão";
            P19.respostaCorreta = 1;
            ListaQuestoes.Add(P19);

            var P20 = new Questao();
            P20.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P20.Question = "Qual é o maior animal terrestre?";
            P20.FirstQuestion = "Elefante Africano";
            P20.SecondQuestion = "Girafa";
            P20.ThirdQuestion = "Rinoceronte";
            P20.FourthQuestion = "Hipopótamo";
            P20.FiveQuestion = "Urso Pardo";
            P20.respostaCorreta = 1;
            ListaQuestoes.Add(P20);

            var P21 = new Questao();
            P21.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P21.Question = "Qual é a moeda do Japão?";
            P21.FirstQuestion = "Yen";
            P21.SecondQuestion = "Won";
            P21.ThirdQuestion = "Dólar";
            P21.FourthQuestion = "Euro";
            P21.FiveQuestion = "Libra";
            P21.respostaCorreta = 1;
            ListaQuestoes.Add(P21);

            var P22 = new Questao();
            P22.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P22.Question = "Qual é o planeta mais próximo do Sol?";
            P22.FirstQuestion = "Mercúrio";
            P22.SecondQuestion = "Vênus";
            P22.ThirdQuestion = "Terra";
            P22.FourthQuestion = "Marte";
            P22.FiveQuestion = "Júpiter";
            P22.respostaCorreta = 1;
            ListaQuestoes.Add(P22);

            var P23 = new Questao();
            P23.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P23.Question = "Quem foi o primeiro presidente dos Estados Unidos?";
            P23.FirstQuestion = "George Washington";
            P23.SecondQuestion = "Abraham Lincoln";
            P23.ThirdQuestion = "Thomas Jefferson";
            P23.FourthQuestion = "John Adams";
            P23.FiveQuestion = "Franklin D. Roosevelt";
            P23.respostaCorreta = 1;
            ListaQuestoes.Add(P23);

            var P24 = new Questao();
            P24.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P24.Question = "Qual é o continente mais frio?";
            P24.FirstQuestion = "África";
            P24.SecondQuestion = "Ásia";
            P24.ThirdQuestion = "Antártida";
            P24.FourthQuestion = "América do Sul";
            P24.FiveQuestion = "Europa";
            P24.respostaCorreta = 3;
            ListaQuestoes.Add(P24);

            var P25 = new Questao();
            P25.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P25.Question = "Qual é o menor país do mundo?";
            P25.FirstQuestion = "Mônaco";
            P25.SecondQuestion = "Vaticano";
            P25.ThirdQuestion = "San Marino";
            P25.FourthQuestion = "Nauru";
            P25.FiveQuestion = "Tuvalu";
            P25.respostaCorreta = 2;
            ListaQuestoes.Add(P25);

            var P26 = new Questao();
            P26.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P26.Question = "Qual é a principal língua falada na Argentina?";
            P26.FirstQuestion = "Espanhol";
            P26.SecondQuestion = "Português";
            P26.ThirdQuestion = "Inglês";
            P26.FourthQuestion = "Francês";
            P26.FiveQuestion = "Italiano";
            P26.respostaCorreta = 1;
            ListaQuestoes.Add(P26);

            var P27 = new Questao();
            P27.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P27.Question = "Qual é o rio mais longo do mundo?";
            P27.FirstQuestion = "Nilo";
            P27.SecondQuestion = "Amazonas";
            P27.ThirdQuestion = "Yangtze";
            P27.FourthQuestion = "Mississipi";
            P27.FiveQuestion = "Ganges";
            P27.respostaCorreta = 1;
            ListaQuestoes.Add(P27);

            var P28 = new Questao();
            P28.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P28.Question = "Qual é o metal mais leve?";
            P28.FirstQuestion = "Alumínio";
            P28.SecondQuestion = "Lítio";
            P28.ThirdQuestion = "Ferro";
            P28.FourthQuestion = "Mercúrio";
            P28.FiveQuestion = "Ouro";
            P28.respostaCorreta = 2;
            ListaQuestoes.Add(P28);

            var P29 = new Questao();
            P29.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P29.Question = "Quem escreveu 'O Pequeno Príncipe'?";
            P29.FirstQuestion = "Antoine de Saint-Exupéry";
            P29.SecondQuestion = "Jules Verne";
            P29.ThirdQuestion = "Victor Hugo";
            P29.FourthQuestion = "Charles Dickens";
            P29.FiveQuestion = "Mark Twain";
            P29.respostaCorreta = 1;
            ListaQuestoes.Add(P29);

            var P30 = new Questao();
            P30.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P30.Question = "Qual é o maior deserto do mundo?";
            P30.FirstQuestion = "Sahara";
            P30.SecondQuestion = "Saara";
            P30.ThirdQuestion = "Gobi";
            P30.FourthQuestion = "Kalahari";
            P30.FiveQuestion = "Antártico";
            P30.respostaCorreta = 5;
            ListaQuestoes.Add(P30);

            // Continue até a P100...

            var P31 = new Questao();
            P31.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P31.Question = "Qual é o nome da maior floresta tropical do mundo?";
            P31.FirstQuestion = "Floresta Amazônica";
            P31.SecondQuestion = "Floresta do Congo";
            P31.ThirdQuestion = "Taiga";
            P31.FourthQuestion = "Floresta de Borneo";
            P31.FiveQuestion = "Floresta de Valdivia";
            P31.respostaCorreta = 1;
            ListaQuestoes.Add(P31);

            var P32 = new Questao();
            P32.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P32.Question = "Qual é o órgão responsável pela respiração em seres humanos?";
            P32.FirstQuestion = "Coração";
            P32.SecondQuestion = "Pulmões";
            P32.ThirdQuestion = "Fígado";
            P32.FourthQuestion = "Rins";
            P32.FiveQuestion = "Estômago";
            P32.respostaCorreta = 2;
            ListaQuestoes.Add(P32);

            var P33 = new Questao();
            P33.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P33.Question = "Qual é o fenômeno natural que ocorre quando a luz do sol passa através de gotas de água?";
            P33.FirstQuestion = "Arco-íris";
            P33.SecondQuestion = "Nuvens";
            P33.ThirdQuestion = "Neve";
            P33.FourthQuestion = "Chuva";
            P33.FiveQuestion = "Vento";
            P33.respostaCorreta = 1;
            ListaQuestoes.Add(P33);

            var P34 = new Questao();
            P34.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P34.Question = "Qual é a distância entre a Terra e a Lua?";
            P34.FirstQuestion = "384.400 km";
            P34.SecondQuestion = "300.000 km";
            P34.ThirdQuestion = "500.000 km";
            P34.FourthQuestion = "1.000.000 km";
            P34.FiveQuestion = "150.000 km";
            P34.respostaCorreta = 1;
            ListaQuestoes.Add(P34);

            var P35 = new Questao();
            P35.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P35.Question = "Quem descobriu a penicilina?";
            P35.FirstQuestion = "Alexander Fleming";
            P35.SecondQuestion = "Louis Pasteur";
            P35.ThirdQuestion = "Marie Curie";
            P35.FourthQuestion = "Albert Einstein";
            P35.FiveQuestion = "Isaac Newton";
            P35.respostaCorreta = 1;
            ListaQuestoes.Add(P35);

            var P36 = new Questao();
            P36.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P36.Question = "Qual é o sistema que controla a temperatura do corpo humano?";
            P36.FirstQuestion = "Sistema nervoso";
            P36.SecondQuestion = "Sistema endócrino";
            P36.ThirdQuestion = "Sistema circulatório";
            P36.FourthQuestion = "Sistema imunológico";
            P36.FiveQuestion = "Sistema digestivo";
            P36.respostaCorreta = 1;
            ListaQuestoes.Add(P36);

            var P37 = new Questao();
            P37.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P37.Question = "Qual é o gás mais abundante na atmosfera terrestre?";
            P37.FirstQuestion = "Oxigênio";
            P37.SecondQuestion = "Nitrogênio";
            P37.ThirdQuestion = "Dióxido de carbono";
            P37.FourthQuestion = "Hélio";
            P37.FiveQuestion = "Argônio";
            P37.respostaCorreta = 2;
            ListaQuestoes.Add(P37);

            var P38 = new Questao();
            P38.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P38.Question = "Qual é a capital da Rússia?";
            P38.FirstQuestion = "Moscovo";
            P38.SecondQuestion = "São Petersburgo";
            P38.ThirdQuestion = "Kiev";
            P38.FourthQuestion = "Minsk";
            P38.FiveQuestion = "Tóquio";
            P38.respostaCorreta = 1;
            ListaQuestoes.Add(P38);

            var P39 = new Questao();
            P39.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P39.Question = "Qual é a maior cadeia de montanhas do mundo?";
            P39.FirstQuestion = "Himalaia";
            P39.SecondQuestion = "Andes";
            P39.ThirdQuestion = "Alpes";
            P39.FourthQuestion = "Rochosas";
            P39.FiveQuestion = "Apalaches";
            P39.respostaCorreta = 1;
            ListaQuestoes.Add(P39);

            var P40 = new Questao();
            P40.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P40.Question = "Qual é a unidade de medida da força?";
            P40.FirstQuestion = "Newton";
            P40.SecondQuestion = "Joule";
            P40.ThirdQuestion = "Pascal";
            P40.FourthQuestion = "Watt";
            P40.FiveQuestion = "Ampère";
            P40.respostaCorreta = 1;
            ListaQuestoes.Add(P40);

            // Continue até a P100...

            var P41 = new Questao();
            P41.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P41.Question = "Qual é a capital da Alemanha?";
            P41.FirstQuestion = "Berlim";
            P41.SecondQuestion = "Munique";
            P41.ThirdQuestion = "Frankfurt";
            P41.FourthQuestion = "Hamburgo";
            P41.FiveQuestion = "Colônia";
            P41.respostaCorreta = 1;
            ListaQuestoes.Add(P41);

            var P42 = new Questao();
            P42.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P42.Question = "Quem foi o autor da teoria da relatividade?";
            P42.FirstQuestion = "Isaac Newton";
            P42.SecondQuestion = "Albert Einstein";
            P42.ThirdQuestion = "Galileu Galilei";
            P42.FourthQuestion = "Nikola Tesla";
            P42.FiveQuestion = "Stephen Hawking";
            P42.respostaCorreta = 2;
            ListaQuestoes.Add(P42);

            var P43 = new Questao();
            P43.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P43.Question = "Qual é a capital da Espanha?";
            P43.FirstQuestion = "Barcelona";
            P43.SecondQuestion = "Sevilha";
            P43.ThirdQuestion = "Madri";
            P43.FourthQuestion = "Valência";
            P43.FiveQuestion = "Bilbau";
            P43.respostaCorreta = 3;
            ListaQuestoes.Add(P43);

            var P44 = new Questao();
            P44.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P44.Question = "Qual é o elemento químico com o símbolo 'Na'?";
            P44.FirstQuestion = "Sódio";
            P44.SecondQuestion = "Nitrogênio";
            P44.ThirdQuestion = "Potássio";
            P44.FourthQuestion = "Magnésio";
            P44.FiveQuestion = "Cálcio";
            P44.respostaCorreta = 1;
            ListaQuestoes.Add(P44);

            var P45 = new Questao();
            P45.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P45.Question = "Qual é a capital do Canadá?";
            P45.FirstQuestion = "Toronto";
            P45.SecondQuestion = "Ottawa";
            P45.ThirdQuestion = "Vancouver";
            P45.FourthQuestion = "Montreal";
            P45.FiveQuestion = "Calgary";
            P45.respostaCorreta = 2;
            ListaQuestoes.Add(P45);

            var P46 = new Questao();
            P46.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P46.Question = "Qual é o país conhecido como 'Terra dos Faraós'?";
            P46.FirstQuestion = "Grécia";
            P46.SecondQuestion = "Egito";
            P46.ThirdQuestion = "Itália";
            P46.FourthQuestion = "Irã";
            P46.FiveQuestion = "Turquia";
            P46.respostaCorreta = 2;
            ListaQuestoes.Add(P46);

            var P47 = new Questao();
            P47.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P47.Question = "Qual é a montanha mais alta da América do Sul?";
            P47.FirstQuestion = "Aconcágua";
            P47.SecondQuestion = "Pico Ojos del Salado";
            P47.ThirdQuestion = "Monte Fitz Roy";
            P47.FourthQuestion = "Pico Bolívar";
            P47.FiveQuestion = "Pico de Orizaba";
            P47.respostaCorreta = 1;
            ListaQuestoes.Add(P47);

            var P48 = new Questao();
            P48.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P48.Question = "Qual é a maior ilha do mundo?";
            P48.FirstQuestion = "Groenlândia";
            P48.SecondQuestion = "Nova Guiné";
            P48.ThirdQuestion = "Borneo";
            P48.FourthQuestion = "Madagascar";
            P48.FiveQuestion = "Ilha de Baffin";
            P48.respostaCorreta = 1;
            ListaQuestoes.Add(P48);

            var P49 = new Questao();
            P49.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P49.Question = "Qual é o nome do processo de transformação de uma lagarta em borboleta?";
            P49.FirstQuestion = "Metamorfose";
            P49.SecondQuestion = "Crescimento";
            P49.ThirdQuestion = "Reprodução";
            P49.FourthQuestion = "Desdobramento";
            P49.FiveQuestion = "Desenvolvimento";
            P49.respostaCorreta = 1;
            ListaQuestoes.Add(P49);

            var P50 = new Questao();
            P50.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P50.Question = "Qual é a capital da Índia?";
            P50.FirstQuestion = "Nova Délhi";
            P50.SecondQuestion = "Mumbai";
            P50.ThirdQuestion = "Calcutá";
            P50.FourthQuestion = "Bangalore";
            P50.FiveQuestion = "Chennai";
            P50.respostaCorreta = 1;
            ListaQuestoes.Add(P50);

            // Continue até P100...

            var P51 = new Questao();
            P51.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P51.Question = "Qual é o nome do famoso edifício inclinado na Itália?";
            P51.FirstQuestion = "Torre de Pisa";
            P51.SecondQuestion = "Torre Eiffel";
            P51.ThirdQuestion = "Torre de Londres";
            P51.FourthQuestion = "Torre de Belém";
            P51.FiveQuestion = "Torre do Relógio";
            P51.respostaCorreta = 1;
            ListaQuestoes.Add(P51);

            var P52 = new Questao();
            P52.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P52.Question = "Qual é a primeira letra do alfabeto grego?";
            P52.FirstQuestion = "Alpha";
            P52.SecondQuestion = "Beta";
            P52.ThirdQuestion = "Gamma";
            P52.FourthQuestion = "Delta";
            P52.FiveQuestion = "Épsilon";
            P52.respostaCorreta = 1;
            ListaQuestoes.Add(P52);

            var P53 = new Questao();
            P53.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P53.Question = "Qual é a capital da Austrália?";
            P53.FirstQuestion = "Canberra";
            P53.SecondQuestion = "Sydney";
            P53.ThirdQuestion = "Melbourne";
            P53.FourthQuestion = "Brisbane";
            P53.FiveQuestion = "Perth";
            P53.respostaCorreta = 1;
            ListaQuestoes.Add(P53);

            var P54 = new Questao();
            P54.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P54.Question = "Qual é o nome do famoso cientista que formulou as leis do movimento?";
            P54.FirstQuestion = "Isaac Newton";
            P54.SecondQuestion = "Albert Einstein";
            P54.ThirdQuestion = "Galileu Galilei";
            P54.FourthQuestion = "Nikola Tesla";
            P54.FiveQuestion = "Stephen Hawking";
            P54.respostaCorreta = 1;
            ListaQuestoes.Add(P54);

            var P55 = new Questao();
            P55.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P55.Question = "Qual é a capital da Itália?";
            P55.FirstQuestion = "Roma";
            P55.SecondQuestion = "Veneza";
            P55.ThirdQuestion = "Florença";
            P55.FourthQuestion = "Milão";
            P55.FiveQuestion = "Nápoles";
            P55.respostaCorreta = 1;
            ListaQuestoes.Add(P55);

            var P56 = new Questao();
            P56.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P56.Question = "Qual é a principal religião do mundo?";
            P56.FirstQuestion = "Cristianismo";
            P56.SecondQuestion = "Islamismo";
            P56.ThirdQuestion = "Hinduísmo";
            P56.FourthQuestion = "Budismo";
            P56.FiveQuestion = "Ateísmo";
            P56.respostaCorreta = 1;
            ListaQuestoes.Add(P56);

            var P57 = new Questao();
            P57.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P57.Question = "Qual é o planeta mais distante do Sol?";
            P57.FirstQuestion = "Netuno";
            P57.SecondQuestion = "Urano";
            P57.ThirdQuestion = "Saturno";
            P57.FourthQuestion = "Júpiter";
            P57.FiveQuestion = "Marte";
            P57.respostaCorreta = 1;
            ListaQuestoes.Add(P57);

            var P58 = new Questao();
            P58.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P58.Question = "Quem foi o primeiro homem a pisar na Lua?";
            P58.FirstQuestion = "Neil Armstrong";
            P58.SecondQuestion = "Buzz Aldrin";
            P58.ThirdQuestion = "Yuri Gagarin";
            P58.FourthQuestion = "John Glenn";
            P58.FiveQuestion = "Michael Collins";
            P58.respostaCorreta = 1;
            ListaQuestoes.Add(P58);

            var P59 = new Questao();
            P59.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P59.Question = "Qual é o continente mais populoso do mundo?";
            P59.FirstQuestion = "Ásia";
            P59.SecondQuestion = "África";
            P59.ThirdQuestion = "Europa";
            P59.FourthQuestion = "América do Norte";
            P59.FiveQuestion = "Oceania";
            P59.respostaCorreta = 1;
            ListaQuestoes.Add(P59);

            var P60 = new Questao();
            P60.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P60.Question = "Qual é a capital da França?";
            P60.FirstQuestion = "Paris";
            P60.SecondQuestion = "Londres";
            P60.ThirdQuestion = "Roma";
            P60.FourthQuestion = "Berlim";
            P60.FiveQuestion = "Madrid";
            P60.respostaCorreta = 1;
            ListaQuestoes.Add(P60);

            // Continue até P100...

            var P61 = new Questao();
            P61.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P61.Question = "Qual é a forma de energia mais utilizada no mundo?";
            P61.FirstQuestion = "Petróleo";
            P61.SecondQuestion = "Carvão";
            P61.ThirdQuestion = "Gás Natural";
            P61.FourthQuestion = "Energia Solar";
            P61.FiveQuestion = "Energia Hidrelétrica";
            P61.respostaCorreta = 1;
            ListaQuestoes.Add(P61);

            var P62 = new Questao();
            P62.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P62.Question = "Qual é o maior mamífero do mundo?";
            P62.FirstQuestion = "Baleia Azul";
            P62.SecondQuestion = "Elefante";
            P62.ThirdQuestion = "Girafa";
            P62.FourthQuestion = "Tubarão";
            P62.FiveQuestion = "Rinoceronte";
            P62.respostaCorreta = 1;
            ListaQuestoes.Add(P62);

            var P63 = new Questao();
            P63.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P63.Question = "Qual é a montanha mais alta do mundo?";
            P63.FirstQuestion = "Everest";
            P63.SecondQuestion = "K2";
            P63.ThirdQuestion = "Kangchenjunga";
            P63.FourthQuestion = "Lhotse";
            P63.FiveQuestion = "Makalu";
            P63.respostaCorreta = 1;
            ListaQuestoes.Add(P63);

            var P64 = new Questao();
            P64.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P64.Question = "Qual é a capital da Grécia?";
            P64.FirstQuestion = "Atenas";
            P64.SecondQuestion = "Salônica";
            P64.ThirdQuestion = "Creta";
            P64.FourthQuestion = "Rhodes";
            P64.FiveQuestion = "Corfu";
            P64.respostaCorreta = 1;
            ListaQuestoes.Add(P64);

            var P65 = new Questao();
            P65.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P65.Question = "Qual é a unidade de medida da temperatura?";
            P65.FirstQuestion = "Celsius";
            P65.SecondQuestion = "Pascal";
            P65.ThirdQuestion = "Joule";
            P65.FourthQuestion = "Newton";
            P65.FiveQuestion = "Watt";
            P65.respostaCorreta = 1;
            ListaQuestoes.Add(P65);

            var P66 = new Questao();
            P66.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P66.Question = "Qual é o processo pelo qual as plantas produzem seu próprio alimento?";
            P66.FirstQuestion = "Respiração";
            P66.SecondQuestion = "Fotossíntese";
            P66.ThirdQuestion = "Transpiração";
            P66.FourthQuestion = "Absorção";
            P66.FiveQuestion = "Evaporação";
            P66.respostaCorreta = 2;
            ListaQuestoes.Add(P66);

            var P67 = new Questao();
            P67.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P67.Question = "Quem foi o famoso pintor que criou a Mona Lisa?";
            P67.FirstQuestion = "Vincent van Gogh";
            P67.SecondQuestion = "Pablo Picasso";
            P67.ThirdQuestion = "Leonardo da Vinci";
            P67.FourthQuestion = "Claude Monet";
            P67.FiveQuestion = "Michelangelo";
            P67.respostaCorreta = 3;
            ListaQuestoes.Add(P67);

            var P68 = new Questao();
            P68.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P68.Question = "Qual é a capital da Suíça?";
            P68.FirstQuestion = "Genebra";
            P68.SecondQuestion = "Zurique";
            P68.ThirdQuestion = "Berna";
            P68.FourthQuestion = "Basileia";
            P68.FiveQuestion = "Lugano";
            P68.respostaCorreta = 3;
            ListaQuestoes.Add(P68);

            var P69 = new Questao();
            P69.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P69.Question = "Qual é a maior cidade do Brasil?";
            P69.FirstQuestion = "São Paulo";
            P69.SecondQuestion = "Rio de Janeiro";
            P69.ThirdQuestion = "Belo Horizonte";
            P69.FourthQuestion = "Brasília";
            P69.FiveQuestion = "Curitiba";
            P69.respostaCorreta = 1;
            ListaQuestoes.Add(P69);

            var P70 = new Questao();
            P70.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P70.Question = "Qual é o maior deserto do mundo?";
            P70.FirstQuestion = "Saara";
            P70.SecondQuestion = "Gobi";
            P70.ThirdQuestion = "Antártida";
            P70.FourthQuestion = "Kalahari";
            P70.FiveQuestion = "Atacama";
            P70.respostaCorreta = 3;
            ListaQuestoes.Add(P70);

            var P71 = new Questao();
            P71.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P71.Question = "Qual é a capital da África do Sul?";
            P71.FirstQuestion = "Joanesburgo";
            P71.SecondQuestion = "Cidade do Cabo";
            P71.ThirdQuestion = "Pretória";
            P71.FourthQuestion = "Durban";
            P71.FiveQuestion = "Bloemfontein";
            P71.respostaCorreta = 3;
            ListaQuestoes.Add(P71);

            var P72 = new Questao();
            P72.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P72.Question = "Quem foi o líder dos direitos civis nos Estados Unidos?";
            P72.FirstQuestion = "Malcolm X";
            P72.SecondQuestion = "Nelson Mandela";
            P72.ThirdQuestion = "Martin Luther King Jr.";
            P72.FourthQuestion = "Rosa Parks";
            P72.FiveQuestion = "Frederick Douglass";
            P72.respostaCorreta = 3;
            ListaQuestoes.Add(P72);

            var P73 = new Questao();
            P73.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P73.Question = "Qual é a principal língua falada na Brasil?";
            P73.FirstQuestion = "Espanhol";
            P73.SecondQuestion = "Português";
            P73.ThirdQuestion = "Inglês";
            P73.FourthQuestion = "Francês";
            P73.FiveQuestion = "Alemão";
            P73.respostaCorreta = 2;
            ListaQuestoes.Add(P73);

            var P74 = new Questao();
            P74.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P74.Question = "Qual é a capital da Argentina?";
            P74.FirstQuestion = "Buenos Aires";
            P74.SecondQuestion = "Córdoba";
            P74.ThirdQuestion = "Rosário";
            P74.FourthQuestion = "La Plata";
            P74.FiveQuestion = "Mendoza";
            P74.respostaCorreta = 1;
            ListaQuestoes.Add(P74);

            var P75 = new Questao();
            P75.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P75.Question = "Qual é o símbolo químico do oxigênio?";
            P75.FirstQuestion = "O";
            P75.SecondQuestion = "Ox";
            P75.ThirdQuestion = "O2";
            P75.FourthQuestion = "O3";
            P75.FiveQuestion = "H2O";
            P75.respostaCorreta = 1;
            ListaQuestoes.Add(P75);

            var P76 = new Questao();
            P76.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P76.Question = "Qual é a capital do Japão?";
            P76.FirstQuestion = "Tóquio";
            P76.SecondQuestion = "Osaka";
            P76.ThirdQuestion = "Kyoto";
            P76.FourthQuestion = "Hiroshima";
            P76.FiveQuestion = "Nagoya";
            P76.respostaCorreta = 1;
            ListaQuestoes.Add(P76);

            var P77 = new Questao();
            P77.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P77.Question = "Qual é a menor unidade da vida?";
            P77.FirstQuestion = "Célula";
            P77.SecondQuestion = "Átomo";
            P77.ThirdQuestion = "Molécula";
            P77.FourthQuestion = "Organismo";
            P77.FiveQuestion = "Tecido";
            P77.respostaCorreta = 1;
            ListaQuestoes.Add(P77);

            var P78 = new Questao();
            P78.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P78.Question = "Qual é a primeira mulher a ganhar o Prêmio Nobel?";
            P78.FirstQuestion = "Marie Curie";
            P78.SecondQuestion = "Ada Lovelace";
            P78.ThirdQuestion = "Rosalind Franklin";
            P78.FourthQuestion = "Jane Goodall";
            P78.FiveQuestion = "Simone de Beauvoir";
            P78.respostaCorreta = 1;
            ListaQuestoes.Add(P78);

            var P79 = new Questao();
            P79.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P79.Question = "Qual é a montanha mais alta do Brasil?";
            P79.FirstQuestion = "Pico da Neblina";
            P79.SecondQuestion = "Pico das Agulhas Negras";
            P79.ThirdQuestion = "Pico do Itatiaia";
            P79.FourthQuestion = "Pico da Bandeira";
            P79.FiveQuestion = "Pico do Cristal";
            P79.respostaCorreta = 1;
            ListaQuestoes.Add(P79);

            var P80 = new Questao();
            P80.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P80.Question = "Qual é a capital da Noruega?";
            P80.FirstQuestion = "Oslo";
            P80.SecondQuestion = "Estocolmo";
            P80.ThirdQuestion = "Copenhague";
            P80.FourthQuestion = "Helsinque";
            P80.FiveQuestion = "Reykjavik";
            P80.respostaCorreta = 1;
            ListaQuestoes.Add(P80);

            // Continue até P100...

            var P81 = new Questao();
            P81.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P81.Question = "Qual é o nome da maior floresta tropical do mundo?";
            P81.FirstQuestion = "Floresta Amazônica";
            P81.SecondQuestion = "Floresta do Congo";
            P81.ThirdQuestion = "Floresta Boreal";
            P81.FourthQuestion = "Floresta de Taiga";
            P81.FiveQuestion = "Floresta de Chuva";
            P81.respostaCorreta = 1;
            ListaQuestoes.Add(P81);

            var P82 = new Questao();
            P82.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P82.Question = "Qual é a capital da Turquia?";
            P82.FirstQuestion = "Ankara";
            P82.SecondQuestion = "Istambul";
            P82.ThirdQuestion = "Izmir";
            P82.FourthQuestion = "Antália";
            P82.FiveQuestion = "Bursa";
            P82.respostaCorreta = 1;
            ListaQuestoes.Add(P82);

            var P83 = new Questao();
            P83.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P83.Question = "Quem é o autor do livro 'Dom Casmurro'?";
            P83.FirstQuestion = "Machado de Assis";
            P83.SecondQuestion = "José de Alencar";
            P83.ThirdQuestion = "Clarice Lispector";
            P83.FourthQuestion = "Joaquim Manuel de Macedo";
            P83.FiveQuestion = "Jorge Amado";
            P83.respostaCorreta = 1;
            ListaQuestoes.Add(P83);

            var P84 = new Questao();
            P84.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P84.Question = "Qual é a moeda oficial do Japão?";
            P84.FirstQuestion = "Yen";
            P84.SecondQuestion = "Won";
            P84.ThirdQuestion = "Dólar";
            P84.FourthQuestion = "Euro";
            P84.FiveQuestion = "Libra";
            P84.respostaCorreta = 1;
            ListaQuestoes.Add(P84);

            var P85 = new Questao();
            P85.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P85.Question = "Qual é a capital da Dinamarca?";
            P85.FirstQuestion = "Copenhague";
            P85.SecondQuestion = "Estocolmo";
            P85.ThirdQuestion = "Oslo";
            P85.FourthQuestion = "Helsinque";
            P85.FiveQuestion = "Reykjavik";
            P85.respostaCorreta = 1;
            ListaQuestoes.Add(P85);

            var P86 = new Questao();
            P86.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P86.Question = "Qual é a cor do sangue oxigenado?";
            P86.FirstQuestion = "Vermelho";
            P86.SecondQuestion = "Azul";
            P86.ThirdQuestion = "Verde";
            P86.FourthQuestion = "Amarelo";
            P86.FiveQuestion = "Preto";
            P86.respostaCorreta = 1;
            ListaQuestoes.Add(P86);

            var P87 = new Questao();
            P87.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P87.Question = "Qual é o nome da maior cadeia de montanhas do mundo?";
            P87.FirstQuestion = "Himalaia";
            P87.SecondQuestion = "Andes";
            P87.ThirdQuestion = "Rocosas";
            P87.FourthQuestion = "Alpes";
            P87.FiveQuestion = "Apalaches";
            P87.respostaCorreta = 1;
            ListaQuestoes.Add(P87);

            var P88 = new Questao();
            P88.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P88.Question = "Qual é o rio mais longo do mundo?";
            P88.FirstQuestion = "Nilo";
            P88.SecondQuestion = "Amazônia";
            P88.ThirdQuestion = "Yangtze";
            P88.FourthQuestion = "Mississippi";
            P88.FiveQuestion = "Danúbio";
            P88.respostaCorreta = 1;
            ListaQuestoes.Add(P88);

            var P89 = new Questao();
            P89.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P89.Question = "Qual é o maior oceano do mundo?";
            P89.FirstQuestion = "Pacífico";
            P89.SecondQuestion = "Atlântico";
            P89.ThirdQuestion = "Índico";
            P89.FourthQuestion = "Ártico";
            P89.FiveQuestion = "Antártico";
            P89.respostaCorreta = 1;
            ListaQuestoes.Add(P89);

            var P90 = new Questao();
            P90.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P90.Question = "Qual é o continente onde fica o Egito?";
            P90.FirstQuestion = "África";
            P90.SecondQuestion = "Ásia";
            P90.ThirdQuestion = "Europa";
            P90.FourthQuestion = "América do Sul";
            P90.FiveQuestion = "Oceania";
            P90.respostaCorreta = 1;
            ListaQuestoes.Add(P90);

            // Continue até P100...

            var P91 = new Questao();
            P91.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P91.Question = "Qual é a língua mais falada do mundo?";
            P91.FirstQuestion = "Mandarim";
            P91.SecondQuestion = "Inglês";
            P91.ThirdQuestion = "Espanhol";
            P91.FourthQuestion = "Árabe";
            P91.FiveQuestion = "Francês";
            P91.respostaCorreta = 2;
            ListaQuestoes.Add(P91);

            var P92 = new Questao();
            P92.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P92.Question = "Qual é a capital da Finlândia?";
            P92.FirstQuestion = "Helsinque";
            P92.SecondQuestion = "Oslo";
            P92.ThirdQuestion = "Estocolmo";
            P92.FourthQuestion = "Copenhague";
            P92.FiveQuestion = "Reykjavik";
            P92.respostaCorreta = 1;
            ListaQuestoes.Add(P92);

            var P93 = new Questao();
            P93.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P93.Question = "Qual é o maior país do mundo?";
            P93.FirstQuestion = "Rússia";
            P93.SecondQuestion = "Canadá";
            P93.ThirdQuestion = "China";
            P93.FourthQuestion = "Estados Unidos";
            P93.FiveQuestion = "Brasil";
            P93.respostaCorreta = 1;
            ListaQuestoes.Add(P93);

            var P94 = new Questao();
            P94.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P94.Question = "Qual é o símbolo químico do hidrogênio?";
            P94.FirstQuestion = "H";
            P94.SecondQuestion = "O";
            P94.ThirdQuestion = "He";
            P94.FourthQuestion = "N";
            P94.FiveQuestion = "C";
            P94.respostaCorreta = 1;
            ListaQuestoes.Add(P94);

            var P95 = new Questao();
            P95.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P95.Question = "Qual é a capital do Egito?";
            P95.FirstQuestion = "Cairo";
            P95.SecondQuestion = "Alexandria";
            P95.ThirdQuestion = "Luxor";
            P95.FourthQuestion = "Aswan";
            P95.FiveQuestion = "Giza";
            P95.respostaCorreta = 1;
            ListaQuestoes.Add(P95);

            var P96 = new Questao();
            P96.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P96.Question = "Quem é o autor da teoria da evolução?";
            P96.FirstQuestion = "Charles Darwin";
            P96.SecondQuestion = "Albert Einstein";
            P96.ThirdQuestion = "Isaac Newton";
            P96.FourthQuestion = "Galileu Galilei";
            P96.FiveQuestion = "Stephen Hawking";
            P96.respostaCorreta = 1;
            ListaQuestoes.Add(P96);

            var P97 = new Questao();
            P97.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P97.Question = "Qual é o planeta vermelho?";
            P97.FirstQuestion = "Marte";
            P97.SecondQuestion = "Vênus";
            P97.ThirdQuestion = "Mercúrio";
            P97.FourthQuestion = "Saturno";
            P97.FiveQuestion = "Urano";
            P97.respostaCorreta = 1;
            ListaQuestoes.Add(P97);

            var P98 = new Questao();
            P98.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P98.Question = "Qual é o maior continente do mundo?";
            P98.FirstQuestion = "Ásia";
            P98.SecondQuestion = "África";
            P98.ThirdQuestion = "América do Norte";
            P98.FourthQuestion = "Europa";
            P98.FiveQuestion = "Antártida";
            P98.respostaCorreta = 1;
            ListaQuestoes.Add(P98);

            var P99 = new Questao();
            P99.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P99.Question = "Qual é o animal mais rápido do mundo?";
            P99.FirstQuestion = "Guepardo";
            P99.SecondQuestion = "Leão";
            P99.ThirdQuestion = "Falcão";
            P99.FourthQuestion = "Cavalo";
            P99.FiveQuestion = "Tigre";
            P99.respostaCorreta = 1;
            ListaQuestoes.Add(P99);

            var P100 = new Questao();
            P100.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P100.Question = "Qual é a cor do céu em um dia ensolarado?";
            P100.FirstQuestion = "Azul";
            P100.SecondQuestion = "Verde";
            P100.ThirdQuestion = "Vermelho";
            P100.FourthQuestion = "Amarelo";
            P100.FiveQuestion = "Cinza";
            P100.respostaCorreta = 1;
            ListaQuestoes.Add(P100);

            ProximaQuestao();
        }

        public async void VerificarSeEstaCorreta(int RR)
        {
            if (QuestaoCorrente.VerificarSeEstaCorreta(RR))
            {
                await Task.Delay(1000); 
                AdicionaPontuacao(NivelAtual);
                NivelAtual++;
                ProximaQuestao();
            }
            else
            {
                await Task.Delay(2500);
                await App.Current.MainPage.DisplayAlert("errou", "deu game over", "OK");
                inicializar();
            }
        }

        public void ProximaQuestao()
        {

            var RandomNumber = Random.Shared.Next(0, ListaQuestoes.Count);

        
            while (QuestoesRespondidas.Contains(RandomNumber))
            {
                RandomNumber = Random.Shared.Next(0, ListaQuestoes.Count);
            }

           
            QuestoesRespondidas.Add(RandomNumber);

          
            QuestaoCorrente = ListaQuestoes[RandomNumber];
            QuestaoCorrente.Desenhar();
        }

    }
}

        private void CriaPerguntas(Label labelPerg, Button btnResp01, Button btnResp02, Button btnResp03, Button btnResp04, Button btnResp05)
        {

            var Q1 = new Questao();
            Q1.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
            Q1.Pergunta = "Em que ano o homem pisou na Lua pela primeira vez?";
            Q1.Resposta0 = "1959";
            Q1.Resposta1 = "1965";
            Q1.Resposta2 = "1969";
            Q1.Resposta3 = "1975";
            Q1.Resposta4 = "1980";
            Q1.RespostaCerta = 2;
            ListaQuestoes.Add(Q1);


            var Q1 = new Questao();
            Q1.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
            Q1.Pergunta = "Em que ano o marcelo pisou na Lua pela primeira vez?";
            Q1.Resposta0 = "1959";
            Q1.Resposta1 = "1965";
            Q1.Resposta2 = "1969";
            Q1.Resposta3 = "1975";
            Q1.Resposta4 = "ta tudo errado";
            Q1.RespostaCerta = 5;
            ListaQuestoes.Add(Q1);

            var Q2 = new Questao();
            Q2.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
            Q2.Pergunta = "Qual é a capital da França?";
            Q2.Resposta0 = "Berlim";
            Q2.Resposta1 = "Madri";
            Q2.Resposta2 = "Roma";
            Q2.Resposta3 = "Paris";
            Q2.Resposta4 = "Lisboa";
            Q2.RespostaCerta = 3;
            ListaQuestoes.Add(Q2);

            var Q3 = new Questao();
            Q3.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
            Q3.Pergunta = "Qual é o elemento químico de número atômico 6?";
            Q3.Resposta0 = "Hidrogênio";
            Q3.Resposta1 = "Oxigênio";
            Q3.Resposta2 = "Carbono";
            Q3.Resposta3 = "Ferro";
            Q3.Resposta4 = "Nitrogênio";
            Q3.RespostaCerta = 2;
            ListaQuestoes.Add(Q3);

            var Q4 = new Questao();
            Q4.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
            Q4.Pergunta = "Quem escreveu Dom Quixote?";
            Q4.Resposta0 = "William Shakespeare";
            Q4.Resposta1 = "Miguel de Cervantes";
            Q4.Resposta2 = "Fernando Pessoa";
            Q4.Resposta3 = "João Cabral de Melo Neto";
            Q4.Resposta4 = "Luís de Camões";
            Q4.RespostaCerta = 1;
            ListaQuestoes.Add(Q4);

            var Q5 = new Questao();
            Q5.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
            Q5.Pergunta = "Qual é o maior planeta do sistema solar?";
            Q5.Resposta0 = "Terra";
            Q5.Resposta1 = "Marte";
            Q5.Resposta2 = "Saturno";
            Q5.Resposta3 = "Júpiter";
            Q5.Resposta4 = "Vênus";
            Q5.RespostaCerta = 3;
            ListaQuestoes.Add(Q5);

            var Q6 = new Questao();
            Q6.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
            Q6.Pergunta = "Qual é o símbolo químico da prata?";
            Q6.Resposta0 = "Ag";
            Q6.Resposta1 = "Au";
            Q6.Resposta2 = "Pb";
            Q6.Resposta3 = "Fe";
            Q6.Resposta4 = "Cu";
            Q6.RespostaCerta = 0;
            ListaQuestoes.Add(Q6);

            var Q7 = new Questao();
            Q7.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
            Q7.Pergunta = "Quem pintou a obra Mona Lisa?";
            Q7.Resposta0 = "Michelangelo";
            Q7.Resposta1 = "Leonardo da Vinci";
            Q7.Resposta2 = "Pablo Picasso";
            Q7.Resposta3 = "Salvador Dalí";
            Q7.Resposta4 = "Vincent van Gogh";
            Q7.RespostaCerta = 1;
            ListaQuestoes.Add(Q7);

            var Q8 = new Questao();
            Q8.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
            Q8.Pergunta = "Qual é o país mais populoso do mundo?";
            Q8.Resposta0 = "Estados Unidos";
            Q8.Resposta1 = "Índia";
            Q8.Resposta2 = "China";
            Q8.Resposta3 = "Rússia";
            Q8.Resposta4 = "Brasil";
            Q8.RespostaCerta = 2;
            ListaQuestoes.Add(Q8);

            var Q9 = new Questao();
            Q9.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
            Q9.Pergunta = "Qual é a velocidade da luz no vácuo?";
            Q9.Resposta0 = "150.000 km/s";
            Q9.Resposta1 = "300.000 km/s";
            Q9.Resposta2 = "450.000 km/s";
            Q9.Resposta3 = "600.000 km/s";
            Q9.Resposta4 = "750.000 km/s";
            Q9.RespostaCerta = 1;
            ListaQuestoes.Add(Q9);

            var Q10 = new Questao();
            Q10.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
            Q10.Pergunta = "Quem foi o primeiro presidente do Brasil?";
            Q10.Resposta0 = "Getúlio Vargas";
            Q10.Resposta1 = "Juscelino Kubitschek";
            Q10.Resposta2 = "Deodoro da Fonseca";
            Q10.Resposta3 = "Floriano Peixoto";
            Q10.Resposta4 = "João Goulart";
            Q10.RespostaCerta = 2;
            ListaQuestoes.Add(Q10);

            var Q11 = new Questao();
            Q11.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
            Q11.Pergunta = "Em qual continente está localizado o Egito?";
            Q11.Resposta0 = "Ásia";
            Q11.Resposta1 = "África";
            Q11.Resposta2 = "Europa";
            Q11.Resposta3 = "América do Sul";
            Q11.Resposta4 = "Oceania";
            Q11.RespostaCerta = 1;
            ListaQuestoes.Add(Q11);

            var Q12 = new Questao();
            Q12.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
            Q12.Pergunta = "Qual desses animais é um mamífero?";
            Q12.Resposta0 = "Pinguim";
            Q12.Resposta1 = "Tubarão";
            Q12.Resposta2 = "Golfinho";
            Q12.Resposta3 = "Jacaré";
            Q12.Resposta4 = "Salamandra";
            Q12.RespostaCerta = 2;
            ListaQuestoes.Add(Q12);

            var Q13 = new Questao();
            Q13.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
            Q13.Pergunta = "Quantos estados existem no Brasil?";
            Q13.Resposta0 = "26";
            Q13.Resposta1 = "25";
            Q13.Resposta2 = "27";
            Q13.Resposta3 = "28";
            Q13.Resposta4 = "29";
            Q13.RespostaCerta = 2;
            ListaQuestoes.Add(Q13);

            var Q14 = new Questao();
            Q14.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
            Q14.Pergunta = "Qual é o maior oceano do mundo?";
            Q14.Resposta0 = "Atlântico";
            Q14.Resposta1 = "Índico";
            Q14.Resposta2 = "Ártico";
            Q14.Resposta3 = "Pacífico";
            Q14.Resposta4 = "Antártico";
            Q14.RespostaCerta = 3;
            ListaQuestoes.Add(Q14);

            var Q15 = new Questao();
            Q15.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
            Q15.Pergunta = "Qual é o órgão responsável pela circulação do sangue no corpo humano?";
            Q15.Resposta0 = "Pulmão";
            Q15.Resposta1 = "Estômago";
            Q15.Resposta2 = "Rim";
            Q15.Resposta3 = "Fígado";
            Q15.Resposta4 = "Coração";
            Q15.RespostaCerta = 4;
            ListaQuestoes.Add(Q15);

            var Q16 = new Questao();
            Q16.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
            Q16.Pergunta = "Em que país se encontra a Torre Eiffel?";
            Q16.Resposta0 = "Itália";
            Q16.Resposta1 = "Espanha";
            Q16.Resposta2 = "França";
            Q16.Resposta3 = "Alemanha";
            Q16.Resposta4 = "Suíça";
            Q16.RespostaCerta = 2;
            ListaQuestoes.Add(Q16);

            var Q17 = new Questao();
            Q17.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
            Q17.Pergunta = "Qual é a fórmula química da água?";
            Q17.Resposta0 = "H2O";
            Q17.Resposta1 = "CO2";
            Q17.Resposta2 = "O2";
            Q17.Resposta3 = "NaCl";
            Q17.Resposta4 = "CH4";
            Q17.RespostaCerta = 0;
            ListaQuestoes.Add(Q17);

            var Q18 = new Questao();
            Q18.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
            Q18.Pergunta = "Quem foi o autor de O Pequeno Príncipe?";
            Q18.Resposta0 = "J.K. Rowling";
            Q18.Resposta1 = "Antoine de Saint-Exupéry";
            Q18.Resposta2 = "George Orwell";
            Q18.Resposta3 = "Mark Twain";
            Q18.Resposta4 = "Franz Kafka";
            Q18.RespostaCerta = 1;
            ListaQuestoes.Add(Q18);

            var Q19 = new Questao();
            Q19.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
            Q19.Pergunta = "Em qual país nasceu o futebol moderno?";
            Q19.Resposta0 = "Espanha";
            Q19.Resposta1 = "Brasil";
            Q19.Resposta2 = "Alemanha";
            Q19.Resposta3 = "Inglaterra";
            Q19.Resposta4 = "Itália";
            Q19.RespostaCerta = 3;
            ListaQuestoes.Add(Q19);

            var Q20 = new Questao();
            Q20.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
            Q20.Pergunta = "Qual é o menor país do mundo?";
            Q20.Resposta0 = "Vaticano";
            Q20.Resposta1 = "Mônaco";
            Q20.Resposta2 = "San Marino";
            Q20.Resposta3 = "Liechtenstein";
            Q20.Resposta4 = "Malta";
            Q20.RespostaCerta = 0;
            ListaQuestoes.Add(Q20);
        }
        ProximaQuestao();
    }

}