﻿using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Application.Common.Repositories;
using Common;
using MediatR;

namespace Application.Search.Queries.SearchHotelRooms
{
    public class SearchHotelRoomsHandler : IRequestHandler<SearchHotelRoomsQuery, SearchHotelRoomsResponse>
    {
        private readonly IHotelRoomRepository _hotelRoom;
        private readonly ICountryService _country;
        private readonly ICurrentUserService _currentUser;
        private readonly ICurrencyConversionService _currencyConversion;

        public SearchHotelRoomsHandler(IHotelRoomRepository hotelRoom, ICountryService country, ICurrentUserService currentUser, ICurrencyConversionService currencyConversion)
        {
            _hotelRoom = hotelRoom ?? throw new ArgumentNullException(nameof(hotelRoom));
            _country = country ?? throw new ArgumentNullException(nameof(country));
            _currentUser = currentUser ?? throw new ArgumentNullException(nameof(currentUser));
            _currencyConversion = currencyConversion ?? throw new ArgumentNullException(nameof(currencyConversion));
        }

        public async Task<SearchHotelRoomsResponse> Handle(SearchHotelRoomsQuery request, CancellationToken cancellationToken)
        {
            var countryCode = await _country.GetCountryCode(_currentUser.Ip);
            var currencyCode = new RegionInfo(countryCode).ISOCurrencySymbol;
            var currency = _currencyConversion.ConvertFromCountryCode(currencyCode);

            var count = await _hotelRoom.SearchedHotelRoomsCount(
                request.Term,
                request.AvailableFrom,
                request.AvailableTo,
                request.Capacity,
                request.RoomType,
                cancellationToken
            );

            return new SearchHotelRoomsResponse
            {
                HotelRooms = await _hotelRoom.SearchHotelRooms(
                        request.Term,
                        currency,
                        request.AvailableFrom,
                        request.AvailableTo,
                        request.Capacity,
                        request.Page,
                        20,
                        request.RoomType,
                        request.SortBy,
                        cancellationToken
                    ),
                Count = count,
                HighestPrice = count > 0 ? (int)await _hotelRoom.HighestPricesRoomSearch(
                        request.Term,
                        request.AvailableFrom,
                        request.AvailableTo,
                        request.Capacity,
                        request.RoomType,
                        cancellationToken
                    ) : 0,
                CurrencyCode = currencyCode
            };
        }
    }
}