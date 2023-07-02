using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_mvc_consumer.Models;

namespace dotnet_mvc_consumer.Interfaces
{
    public interface IHolidaysApiService
    {
        Task<List<HolidayModel>> GetHolidays(string countryCode, int year);
    }
}