using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PJ3.Data;

namespace PJ3.Service
{
    public interface IPaymentModeService
    {
        IEnumerable<PaymentMode> GetPaymentModes();
        PaymentMode GetPaymentMode(int id);
        void InsertPaymentMode(PaymentMode paymentMode);
        void DeletePaymentMode(int id);
    }
}
