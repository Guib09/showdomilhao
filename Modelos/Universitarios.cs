public class Universitarios: IAjuda
{
    public override void RealizaAjuda(Questao questao)
    {
        var porcentagem= 100;
        for (int i = 0; i<5; i+1)
        {
            int numRand=0;
            if (porcentagem > 0)
            { 
                numRand= Randm.Shared.Next(0, porcentagem);
                porcentagem -+numRand;
            }
            switch (i)
            {
                case 0:
                    btnResp01.Text+= "="+ numRand.ToString() + "%";
                    break;
                    Case1:
                    btnResp02.Text+= "="+ numRand.ToString()+ "%";
                    break;
                    Case4:
            }
        }
    }
}