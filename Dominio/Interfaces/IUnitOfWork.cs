namespace Dominio.Interfaces;
public interface IUnitOfWork
{
    IAddressRepository Addresses {get;}     
    IArlRepository Arls {get;}     
    IBillRepository Bills {get;}     
    IBrandRepository Brands {get;}     
    ICabineRepository Cabines {get;}     
    ICityRepository Cities {get;}     
    IContactRepository Contacts {get;}     
    ICountryRepository Countries {get;}     
    IDiagnosticMechanicRepository DiagnosticMechanics {get;}     
    IDoorRepository Doors {get;}     
    IEmployeeRepository Employes {get;}     
    IEpsRepository Eps {get;}     
    IInspeccionRepository Inspeccions {get;}     
    IProviderRepository Providers {get;}     
    IRadioRepository Radios {get;}     
    IRegionRepository Regions {get;}     
    IRelPartsOrderRepository RelPartsOrders {get;}     
    IRelServiceOrderRepository RelServiceOrders {get;}     
    IRepairOrderRepository RepairOrders {get;}     
    IRolEmployeRepository RolEmployes {get;}     
    IRolRepository Rols {get;}     
    IServiceFeeRepository ServiceFees {get;}     
    IServiceRepository Services {get;}     
    ISpecialityRepository Specialities {get;}     
    ISquarePartRepository SquareParts {get;}     
    IStateRepository States {get;}     
    ISummaryFailRepository SummaryFails {get;}     
    ITelephoneRepository Telephones {get;}     
    ITypeContactRepository TypeContacts {get;}     
    ITypePersonRepository TypePersons {get;}     
    IUpholsteryRepository Upholsteries {get;}     
    IVehicleRepository Vehicles {get;}     
  
    Task<int> SaveAsync();
}