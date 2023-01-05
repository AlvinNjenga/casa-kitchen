using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CasaKitchen.Application.Common.Interfaces.Services;

namespace CasaKitchen.Infrastructure.Services
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}