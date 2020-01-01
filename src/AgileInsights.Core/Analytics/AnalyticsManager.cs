using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.Domain.Uow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileInsights.Analytics
{

    public class AnalyticsManager : DomainService, IAnalyticsManager
    {
        private readonly IUnitOfWorkManager _unitOfWorkManager;
        private readonly IRepository<Analytics, long> _analyticsRepository;
         public AnalyticsManager(IUnitOfWorkManager unitOfWorkManager,
             IRepository<Analytics, long> analyticsRepository)
        {
            _unitOfWorkManager = unitOfWorkManager;
            _analyticsRepository = analyticsRepository;
        }
        public async Task<Analytics> CreateOrUpdateAsync(Analytics input)
        {
            try
            {
                using (var uow= _unitOfWorkManager.Begin(System.Transactions.TransactionScopeOption.RequiresNew))
                {
                    var result = new Analytics();
                    var existingData = _analyticsRepository.GetAll().Where(x => x.RemoteClientId == input.RemoteClientId
                     && x.Date.Year == input.Date.Year
                     && x.Date.Month == input.Date.Month
                     && x.Date.Day == input.Date.Month
                     && x.OrganizationId == input.OrganizationId
                     && x.DepartmentId == input.DepartmentId
                     && x.Periodicity == input.Periodicity).FirstOrDefault();
                    if (existingData==null)
                    {
                        result= await _analyticsRepository.InsertAsync(input);
                    }
                    else
                    {
                        existingData.Average = input.Average;
                        existingData.Sum = input.Sum;
                        existingData.Count = input.Count;
                        result= await _analyticsRepository.UpdateAsync(existingData);
                    }
                    _unitOfWorkManager.Current.SaveChanges();
                    uow.Complete();
                    return result;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        
    }
}
