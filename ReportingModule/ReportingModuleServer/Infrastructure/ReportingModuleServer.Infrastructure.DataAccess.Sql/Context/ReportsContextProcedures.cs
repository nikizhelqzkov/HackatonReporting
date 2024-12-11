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
    public partial class ReportsContext
    {
        private IReportsContextProcedures _procedures;

        public virtual IReportsContextProcedures Procedures
        {
            get
            {
                if (_procedures is null) _procedures = new ReportsContextProcedures(this);
                return _procedures;
            }
            set
            {
                _procedures = value;
            }
        }

        public IReportsContextProcedures GetProcedures()
        {
            return Procedures;
        }
    }

    public partial class ReportsContextProcedures : IReportsContextProcedures
    {
        private readonly ReportsContext _context;

        public ReportsContextProcedures(ReportsContext context)
        {
            _context = context;
        }

        public virtual async Task<List<uspGetContractRentAndFeesReportSourceResult>> uspGetContractRentAndFeesReportSourceAsync(string Projects, DateOnly? StartPeriod, DateOnly? EndPeriod, string Buildings, string Contracts, string Classes, int? ToCurrency, string fromBGN, string fromEUR, string fromUSD, bool? IsExchangeRatesCorrect, string UserName, int? LocaleId, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "Projects",
                    Size = -1,
                    Value = Projects ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                new SqlParameter
                {
                    ParameterName = "StartPeriod",
                    Value = StartPeriod ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Date,
                },
                new SqlParameter
                {
                    ParameterName = "EndPeriod",
                    Value = EndPeriod ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Date,
                },
                new SqlParameter
                {
                    ParameterName = "Buildings",
                    Size = -1,
                    Value = Buildings ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                new SqlParameter
                {
                    ParameterName = "Contracts",
                    Size = -1,
                    Value = Contracts ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                new SqlParameter
                {
                    ParameterName = "Classes",
                    Size = -1,
                    Value = Classes ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                new SqlParameter
                {
                    ParameterName = "ToCurrency",
                    Value = ToCurrency ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Int,
                },
                new SqlParameter
                {
                    ParameterName = "fromBGN",
                    Size = 20,
                    Value = fromBGN ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                new SqlParameter
                {
                    ParameterName = "fromEUR",
                    Size = 20,
                    Value = fromEUR ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                new SqlParameter
                {
                    ParameterName = "fromUSD",
                    Size = 20,
                    Value = fromUSD ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                new SqlParameter
                {
                    ParameterName = "IsExchangeRatesCorrect",
                    Value = IsExchangeRatesCorrect ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Bit,
                },
                new SqlParameter
                {
                    ParameterName = "UserName",
                    Size = 100,
                    Value = UserName ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                new SqlParameter
                {
                    ParameterName = "LocaleId",
                    Value = LocaleId ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Int,
                },
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<uspGetContractRentAndFeesReportSourceResult>("EXEC @returnValue = [Reports].[uspGetContractRentAndFeesReportSource] @Projects = @Projects, @StartPeriod = @StartPeriod, @EndPeriod = @EndPeriod, @Buildings = @Buildings, @Contracts = @Contracts, @Classes = @Classes, @ToCurrency = @ToCurrency, @fromBGN = @fromBGN, @fromEUR = @fromEUR, @fromUSD = @fromUSD, @IsExchangeRatesCorrect = @IsExchangeRatesCorrect, @UserName = @UserName, @LocaleId = @LocaleId", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }
    }
}
