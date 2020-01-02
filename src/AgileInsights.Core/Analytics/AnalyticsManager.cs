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

        public async Task BatchCreateOrUpdateAsync(List<Analytics> input)
        {
            try
            {
                using (var uow = _unitOfWorkManager.Begin(System.Transactions.TransactionScopeOption.RequiresNew))
                {

                    if (input!=null && input.Count>0)
                    {
                        foreach (var record in input)
                        {
                            var existingData = _analyticsRepository.GetAll().Where(x => x.RemoteClientId == record.RemoteClientId
                                         && x.Date.Year == record.Date.Year
                                         && x.Date.Month == record.Date.Month
                                         && x.Date.Day == record.Date.Month
                                         && x.OrganizationId == record.OrganizationId
                                         && x.DepartmentId == record.DepartmentId
                                         && x.Periodicity == record.Periodicity).FirstOrDefault();
                            if (existingData == null)
                            {
                                await _analyticsRepository.InsertAsync(record);
                            }
                            else
                            {
                                existingData.Average = record.Average;
                                existingData.Sum = record.Sum;
                                existingData.Count = record.Count;
                                await _analyticsRepository.UpdateAsync(existingData);
                            }
                        } 
                    }
                    _unitOfWorkManager.Current.SaveChanges();
                    uow.Complete();
                    
                }
            }
            catch (Exception ex)
            {

                throw;
            }
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
