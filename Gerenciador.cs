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
