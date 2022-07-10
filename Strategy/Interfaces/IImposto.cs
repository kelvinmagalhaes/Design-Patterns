using Strategy.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Interfaces
{
    //public interface IImposto
    //{
    //    double Calcula(Orçamento orcamento);
    //}

    #region Decorator
    public abstract class IImposto
    {
        private readonly IImposto outroImposto;

        public IImposto(IImposto outroImposto)
        {
            this.outroImposto = outroImposto;
        }

        // construtor default
        public IImposto()
        {
            this.outroImposto = null;
        }

        protected double CalculoDoOutroImposto(Orçamento orcamento)
        {
            // tratando o caso do proximo imposto nao existir!
            return (outroImposto == null ? 0 : outroImposto.Calcula(orcamento));
        }

        public abstract double Calcula(Orçamento orcamento);
    }
    #endregion
}
