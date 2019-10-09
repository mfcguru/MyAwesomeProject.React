using AutoMapper;
using MyAwesomeProject.Data.Entities;
using MyAwesomeProject.Dto;
using System.Linq;

namespace MyAwesomeProject.AutoMapper
{
	public class AutoMapperProfile : Profile
	{
		public AutoMapperProfile()
		{
			CreateMap<Role, RoleDto>();
			CreateMap<User, UserDto>()
				.ForMember(dest => dest.Id, src => src.MapFrom(o => o.UserId))
				.ForMember(dest => dest.Roles, src => src.MapFrom(o => o.UserInRoles.Select(s => s.Role)));

			CreateMap<RoleDto, Role>();
			CreateMap<UserDto, User>()
				.ForMember(dest => dest.UserId, src => src.MapFrom(o => o.Id));
			CreateMap<RegisterDto, User>();

			CreateMap<CategoryDto, Category>();
			CreateMap<CustomerDto, Customer>();
			CreateMap<CustomerDemographicDto, CustomerDemographic>();
			CreateMap<DemographicDto, Demographic>();
			CreateMap<EmployeeDto, Employee>();
			CreateMap<EmployeeTerritoryDto, EmployeeTerritory>();
			CreateMap<OrderDto, Order>();
			CreateMap<OrderDetailDto, OrderDetail>();
			CreateMap<ProductDto, Product>();
			CreateMap<RegionDto, Region>();
			CreateMap<ShipperDto, Shipper>();
			CreateMap<SupplierDto, Supplier>();
			CreateMap<TerritoryDto, Territory>();
			CreateMap<Category, CategoryDto>();
			CreateMap<Customer, CustomerDto>();
			CreateMap<Demographic, DemographicDto>();
			CreateMap<Employee, EmployeeDto>();
			CreateMap<Order, OrderDto>();
			CreateMap<Product, ProductDto>();
			CreateMap<Region, RegionDto>();
			CreateMap<Shipper, ShipperDto>();
			CreateMap<Supplier, SupplierDto>();
			CreateMap<Territory, TerritoryDto>();
			CreateMap<Category, CategoryQueryDto>();
			CreateMap<Customer, CustomerQueryDto>();
			CreateMap<Demographic, DemographicQueryDto>();
			CreateMap<Employee, EmployeeQueryDto>();
			CreateMap<Order, OrderQueryDto>();
			CreateMap<Product, ProductQueryDto>();
			CreateMap<Region, RegionQueryDto>();
			CreateMap<Shipper, ShipperQueryDto>();
			CreateMap<Supplier, SupplierQueryDto>();
			CreateMap<Territory, TerritoryQueryDto>();

			CreateMap<CustomerDemographic, CustomerDemographicDto>()
				.ForMember(dest => dest.DemographicName, opt => opt.MapFrom(src => src.Demographic.DemographicName));
			CreateMap<EmployeeTerritory, EmployeeTerritoryDto>()
				.ForMember(dest => dest.TerritoryName, opt => opt.MapFrom(src => src.Territory.TerritoryName));
			CreateMap<OrderDetail, OrderDetailDto>()
				.ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Product.ProductName));
		}
	}
}
