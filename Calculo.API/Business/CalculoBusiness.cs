using salao.API.Model;

namespace salao.API.Business
{
    public class CalculoBusiness
    {
        public CalculaItem Calcula(CalculaItem item)
        {
            if (item.operacao == "soma")
            {
                item.total = item.valorA + item.valorB;
                return item;
            } else if (item.operacao == "subtracao")
            {
                item.total = item.valorA - item.valorB;
                return item;
            }
            else if (item.operacao == "multiplicacao")
            {
                item.total = item.valorA * item.valorB;
                return item;
            }
            else
            {
                return null;
            }
        }
    }
}
