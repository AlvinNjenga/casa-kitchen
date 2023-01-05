using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaKitchen.Application.Common.Interfaces.Services
{
    public interface IDateTimeProvider
    {
        DateTime UtcNow { get; }
    }
}