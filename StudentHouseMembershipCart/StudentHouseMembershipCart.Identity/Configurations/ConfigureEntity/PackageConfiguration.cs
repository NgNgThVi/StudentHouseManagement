﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Domain.Entities;

namespace StudentHouseMembershipCart.Identity.Configurations.ConfigureEntity
{
    public class PackageConfiguration : IEntityTypeConfiguration<Package>
    {
        public void Configure(EntityTypeBuilder<Package> builder)
        {
            builder.HasData(
                new Package
                {
                    Id = Guid.Parse("EE75EA18-F6A7-4025-84B7-588AB1C6BF2D"),
                    PackageName = "Maintenance & Repairs normal Package",
                    WeekNumberBooking = 6,
                    NumberOfPerWeekDoPackage = 2,
                    DayDoServiceInWeek = "26",
                    Image = "https://res.cloudinary.com/dqqqgyqjl/image/upload/v1698421423/opuaf4ugi3y5iutu6vvp.jpg?fbclid=IwAR3rtgIeRmGXgoilgjIh0hupzfpXJCv_rArlNgBqTMkgRYwPL9wV0HJ9rEU",
                    TotalPrice = 250000,  // price of sercive * numberOfWeekPackage * dicount%
                    PackageDescription = "Sửa chữa ....."

                },
                new Package
                {
                    Id = Guid.Parse("68E3BF2B-2BD7-4428-AC39-148F1A186CBA"),
                    PackageName = "Nấu ăn package",
                    WeekNumberBooking = 1,
                    NumberOfPerWeekDoPackage = 1,
                    DayDoServiceInWeek = "5",
                    Image = "https://res.cloudinary.com/dqqqgyqjl/image/upload/v1698421423/opuaf4ugi3y5iutu6vvp.jpg?fbclid=IwAR3rtgIeRmGXgoilgjIh0hupzfpXJCv_rArlNgBqTMkgRYwPL9wV0HJ9rEU",
                    TotalPrice = 150000,  // price of sercive * numberOfWeekPackage * dicount%

                },
                new Package
                {
                    Id = Guid.Parse("649CE925-0CD1-4CB2-9FB2-4C6AE8FF521E"),
                    PackageName = "Hỗ trợ tài chính vippro package",
                    WeekNumberBooking = 1,
                    NumberOfPerWeekDoPackage = 1,
                    DayDoServiceInWeek = "5",
                    Image = "https://res.cloudinary.com/dqqqgyqjl/image/upload/v1698421423/opuaf4ugi3y5iutu6vvp.jpg?fbclid=IwAR3rtgIeRmGXgoilgjIh0hupzfpXJCv_rArlNgBqTMkgRYwPL9wV0HJ9rEU",
                    TotalPrice = 3000000,  // price of sercive * numberOfWeekPackage * dicount%
                    PackageDescription = "hỗ trợ tài chính ....."

                },
                new Package
                {
                    Id = Guid.Parse("4DA4E6AD-3328-4F03-964E-C31E1A8421F3"),
                    PackageName = "Rửa xe premium package",
                    WeekNumberBooking = 1,
                    NumberOfPerWeekDoPackage = 1,
                    DayDoServiceInWeek = "4",
                    Image = "https://res.cloudinary.com/dqqqgyqjl/image/upload/v1698421423/opuaf4ugi3y5iutu6vvp.jpg?fbclid=IwAR3rtgIeRmGXgoilgjIh0hupzfpXJCv_rArlNgBqTMkgRYwPL9wV0HJ9rEU",
                    TotalPrice = 50000,  // price of sercive * numberOfWeekPackage * dicount%
                    PackageDescription = "Rửa xe....."

                },
                new Package
                {
                    Id = Guid.Parse("C0E52326-C1C2-4C58-A5D9-D6A768E0C7A9"),
                    PackageName = "Giặt đồ package",
                    WeekNumberBooking = 1,
                    NumberOfPerWeekDoPackage = 1,
                    DayDoServiceInWeek = "2",
                    Image = "https://res.cloudinary.com/dqqqgyqjl/image/upload/v1698421423/opuaf4ugi3y5iutu6vvp.jpg?fbclid=IwAR3rtgIeRmGXgoilgjIh0hupzfpXJCv_rArlNgBqTMkgRYwPL9wV0HJ9rEU",
                    TotalPrice = 100000,  // price of sercive * numberOfWeekPackage * dicount%
                    PackageDescription = "Giặt đồ ....."
                },
                new Package
                {
                    Id = Guid.Parse("D0E4FC80-5E14-4F54-B3D3-90FFF85DF063"),
                    PackageName = "Dọn vệ sinh nhà cửa package",
                    WeekNumberBooking = 6,
                    NumberOfPerWeekDoPackage = 2,
                    DayDoServiceInWeek = "25",
                    Image = "https://res.cloudinary.com/dqqqgyqjl/image/upload/v1698421423/opuaf4ugi3y5iutu6vvp.jpg?fbclid=IwAR3rtgIeRmGXgoilgjIh0hupzfpXJCv_rArlNgBqTMkgRYwPL9wV0HJ9rEU",
                    TotalPrice = 120000,  // price of sercive * numberOfWeekPackage * dicount%
                    PackageDescription = "Dọn vệ sinh ....."
                }
                ,
                new Package
                {
                    Id = Guid.Parse("B17C9D4C-B164-4097-8D5F-03D2246DA758"),
                    PackageName = "Vận chuyên giao vận package",
                    WeekNumberBooking = 6,
                    NumberOfPerWeekDoPackage = 2,
                    DayDoServiceInWeek = "37",
                    Image = "https://res.cloudinary.com/dqqqgyqjl/image/upload/v1698421423/opuaf4ugi3y5iutu6vvp.jpg?fbclid=IwAR3rtgIeRmGXgoilgjIh0hupzfpXJCv_rArlNgBqTMkgRYwPL9wV0HJ9rEU",
                    TotalPrice = 140000,  // price of sercive * numberOfWeekPackage * dicount%
                    PackageDescription = "Vận chuyển ....."
                }
            );
        }

    }
}
