using AutoMapper;
using Pausal.BLL.Model;
using Pausal.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pausal.BLL.Mapper
{
    public class ObjectMapper
    {
        private static readonly Lazy<IMapper> Lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                // This line ensures that internal properties are also mapped over.
                cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                cfg.AddProfile<AspnetRunDtoMapper>();
            });
            var mapper = config.CreateMapper();
            return mapper;
        });
        public static IMapper Mapper => Lazy.Value;

        public class AspnetRunDtoMapper : Profile
        {
            public AspnetRunDtoMapper()
            {

                CreateMap<Account, AccountModel>().ReverseMap();
                CreateMap<Transaction, Transaction>().ReverseMap();
                CreateMap<AccountTransaction, AccountTransactionModel>().ReverseMap();
                CreateMap<User, UserModel>().ReverseMap();
                CreateMap<Client, ClientModel>().ReverseMap();
                CreateMap<Entrepreneur, EntrepreneurModel>().ReverseMap();
                CreateMap<InvoiceItem, InvoiceItemModel>().ReverseMap();
                CreateMap<Invoice, InvoiceModel>().ReverseMap();

            }
        }
    }
}
