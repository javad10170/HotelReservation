﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Models;
using Domain.Entities;
using Domain.Enums;
using Domain.Models;

namespace Application.Common.Repositories
{
    public interface IHotelRoomRepository : IRepository<HotelRoom>
    {
        Task<HotelRoomVm> GetVmById(string id, decimal conversionRate, DateTime afterDate, CancellationToken token);

        Task<HotelRoom> GetRoomWithReservationsOverDate(string id, DateTime date, CancellationToken token);

        Task<List<HotelRoomShortVm>> SearchHotelRooms(string term, decimal conversionRate, DateTime? from, DateTime? to, int? capacity, int page, int pageCount, RoomType? type, decimal? start, decimal? end, SortBy sort, CancellationToken token);

        Task<int> SearchedHotelRoomsCount(string term, DateTime? from, DateTime? to, int? capacity, RoomType? type, decimal? start, decimal? end, CancellationToken token);

        Task<decimal> HighestPricesRoomSearch(string term, DateTime? from, DateTime? to, int? capacity, RoomType? type, decimal? start, decimal? end, CancellationToken token);
    }
}