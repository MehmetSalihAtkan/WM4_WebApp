using ItServiceApp.Models.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItServiceApp.Services
{
    public interface IPaymentService
    {
        public List<InstallmentModel> CheckInstalment(string binNumber, decimal price);
        public PaymentResponseModel Pay(PaymentModel model);
    }
}
