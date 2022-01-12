using ItServiceApp.Models;
using ItServiceApp.Models.Payment;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItServiceApp.Services
{
    public class IyzicoPaymentService : IPaymentService
    {
        private readonly IConfiguration _configuration;
        private readonly IyzicoPaymentOptions _options;
        public IyzicoPaymentService(IConfiguration configuration)
        {
            _configuration = configuration;
            var section = configuration.GetSection(IyzicoPaymentOptions.Key);
            _options = new IyzicoPaymentOptions() { 
            ApiKey=section["ApiKey"],
            SecretKey=section["SecretKey"],
            BaseUrl=section["BaseUrl"],
            ThreadsCallbackUrl=section["ThreadsCallbackUrl"],
            };
        }


        public PaymentResponseModel Pay(PaymentModel model)
        {
            
            return null;
        }
    }
}
