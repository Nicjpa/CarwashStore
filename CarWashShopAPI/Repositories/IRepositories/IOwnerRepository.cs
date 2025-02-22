﻿using CarWashShopAPI.DTO;
using CarWashShopAPI.DTO.BookingDTO;
using CarWashShopAPI.DTO.CarWashShopDTOs;
using CarWashShopAPI.DTO.OwnerDTO;
using CarWashShopAPI.Entities;

namespace CarWashShopAPI.Repositories.IRepositories
{
    public interface IOwnerRepository
    {
        public Task<List<T>> Pagination<T>(HttpContext httpContext, IQueryable<T> genericList, int recPerPage, PaginationDTO paginationDTO);
        public Task<List<ShopRemovalRequest>> GetShopRequestsToCancel(int id, string userName);
        public Task<List<ShopRemovalRequest>> GetShopRequestsToApprove(int id, string userName);
        public Task<DisbandRequest> GetDisbandRequestToApprove(int id, string userName);
        public Task<Booking> GetBookingByID(BookingStatusSelection status, string userName);
        public Task<CarWashShop> GetShopToDisbandOwner(int id, string userName);
        public Task<DisbandRequest> CreateDisbandRequest(DisbandRequestCreation statement, CarWashShop shop, string userName);
        public Task<List<CarWashShopsOwners>> AssignNewOwnersToTheShop(CarWashShop carWashShop, List<string> approvedOwnersIDs, List<string> CurrentOwnerUserIds);
        public Task<CarWashShop> GetCarWashShopToAssignOwners(int id);
        public Task<List<string>> GetApprovedOwnerIDs(CarWashShopOwnerAdd listOfNewOwners, List<string> currentOwnerList);
        public Task<List<ShopIncome>> GetIncome(IncomeFilter filter, string userName);
        public Task<List<IncomeViewDays>> IncomeEntityMap2IncomeViewDays(List<ShopIncome> incomeEntities, IncomeFilter filter);
        public Task<List<IncomeViewOther>> IncomeEntityMap2IncomeViewOther(List<ShopIncome> incomeEntities, IncomeFilter filter);
        public Task<IQueryable<CarWashShop>> GetShopsForRevenue(string userName, RevenueFilters revenueFilters);
        public Task<List<RevenueReportView>> CalculateRevenue(List<CarWashShop> carWashShops);
        public Task<List<ShopRemovalRequest>> GetShopRemovalRequests(string userName);
        public Task<List<DisbandRequest>> GetDisbandRequests(string userName);
        public Task<IQueryable<Booking>> GetBookings(string userName, BookingFilters filters);
        public Task<IQueryable<CarWashShop>> GetOwners(string userName, OwnersPerShopFilters filters);
        public Task Commit();
        public Task UpdateEntity<T>(T entity);
        public Task AddRangeOfOwners(List<CarWashShopsOwners> ownerList);
        public Task MakeDisbandRequest(DisbandRequest request);
        public Task CancelShopRemovalReq(List<ShopRemovalRequest> shopRemovalList, int shopID);
        public Task RemoveMyselfFromShop(string userName, int shopID);
        public Task RemoveDisbandRequest(DisbandRequest request);
    }
}
