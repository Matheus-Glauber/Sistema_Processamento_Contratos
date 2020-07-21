using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo14.services
{
    /**
     * <summary>
     *      Essa Interface têm o objetivo de aplicar as regras de negócio para calcular valores referentes a
     *      pagamento online.
     * </summary> 
    **/
    interface IOnlinePaymentService
    {
        /**
         * <summary>
         *      Esse método calcula a taxa de pagamento.
         * </summary>
         * <returns>
         *      PaymentFee (Taxa de Pagamento) - Double
         * </returns>
        **/
        public double PaymentFee(double amount, int months);
    }
}
