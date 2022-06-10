using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PJ3.Data;
using PJ3.Repo;

namespace PJ3.Service
{
    public class PaymentModeService : IPaymentModeService
    {
        private readonly IRepository<PaymentMode> _paymentModeRepository;
        private readonly IRepository<Booking> _bookingsRepository;
        public PaymentModeService(IRepository<PaymentMode> paymentModeRepository, IRepository<Booking> bookingRepository)
        {
            _paymentModeRepository = paymentModeRepository;
            _bookingsRepository = bookingRepository;
        }
        public void DeletePaymentMode(int id)
        {
            IEnumerable<Booking> bookingList = _bookingsRepository.GetAll().Where(x => x.PaymentModeId == id);
            foreach (Booking booking in bookingList)
            {
                _bookingsRepository.Remove(booking);
            }
            PaymentMode paymentMode = GetPaymentMode(id);
            _paymentModeRepository.Remove(paymentMode);
            _paymentModeRepository.SaveChange();
        }

        public PaymentMode GetPaymentMode(int id)
        {
            return _paymentModeRepository.Get(id);
        }

        public IEnumerable<PaymentMode> GetPaymentModes()
        {
            return _paymentModeRepository.GetAll();
        }

        public void InsertPaymentMode(PaymentMode paymentMode)
        {
            _paymentModeRepository.Insert(paymentMode);
        }
    }
}
