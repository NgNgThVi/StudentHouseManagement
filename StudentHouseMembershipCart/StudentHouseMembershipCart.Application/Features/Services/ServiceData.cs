﻿namespace StudentHouseMembershipCart.Application.Features.Services
{
    public class ServiceData
    {
        public Guid Id { get; set; }
        public string? ServiceName { get; set; } 
        public string? ServiceDescription { get; set;}
        public string? Quantity { get; set; }
        public string? CategoryId { get; set; }
        public DateTime? Created { get; set; }
        public string? CreateBy { get; set; }
        public DateTime? LastModified { get; set; }
        public string? LastModifiedBy { get;set; }
        public bool? IsDelete { get; set; }
    }
}