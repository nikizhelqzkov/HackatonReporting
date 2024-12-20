﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ReportingModuleServer.Infrastructure.DataAccess.Sql.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace ReportingModuleServer.Infrastructure.DataAccess.Sql.Context
{
    public partial interface IReportsContextProcedures
    {
        Task<List<uspGetContractRentAndFeesReportSourceResult>> uspGetContractRentAndFeesReportSourceAsync(string Projects, DateOnly? StartPeriod, DateOnly? EndPeriod, string Buildings, string Contracts, string Classes, int? ToCurrency, string fromBGN, string fromEUR, string fromUSD, bool? IsExchangeRatesCorrect, string UserName, int? LocaleId, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
    }
}
