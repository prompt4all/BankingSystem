using AutoMapper;
using BankingSystem.Application.Common.Requests;
using BankingSystem.Application.Common.Responses;
using BankingSystem.Contracts.Payment;
using BankingSystem.Contracts.PaymentAccount;
using BankingSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Contracts.Mapper
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<CreatePaymentAccountJsonRequest, CreatePaymentAccountRequest>();
            CreateMap<DeletePaymentAccountJsonRequest, DeletePaymentAccountRequest>();
            CreateMap<CreatedPaymentAccountResponse, CreatePaymentAccountResponse>();
            CreateMap<PaymentAccountJson, BankingSystem.Domain.Entities.PaymentAccount>();
            CreateMap<CreatePaymentJsonRequest, CreatePaymentRequest>()
                .ForMember(x=>x.PaymentType, s=>s.MapFrom(pt=>(PaymentTypeEnum)pt.PaymentType));
        }
    }
}
