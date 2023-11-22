﻿using MediatR;
using StudentHouseMembershipCart.Application.Common.Response;

namespace StudentHouseMembershipCart.Application.Features.Services.Commands.CreateService
{
    public class CreateServiceCommand : IRequest<SHMResponse>
    {
        public string? ServiceName { get; set; }
        public string? ServiceDescription { get; set; }
        /// <summary>
        /// Giá Gốc
        /// </summary>
        public double OriginalPrice { get; set; }
        /// <summary>
        /// Đại diện đơn vị KG hoặc Lượt
        /// </summary>
        public string? Unit { get; set; }
        /// <summary>
        /// 1. Khách hàng giao và nhận kết quả
        /// 2. Giao sản phẩm hoặc thực hiện dịch vụ tại nhà khách hàng
        /// </summary>
        public string? ServiceType { get; set; }
        /// <summary>
        /// Phần trăm giảm giá
        /// </summary>
        public double DiscountPercent { get; set; }
        public string? ImageURL { get; set; }
        public string? CategoryId { get; set; }
    }
}