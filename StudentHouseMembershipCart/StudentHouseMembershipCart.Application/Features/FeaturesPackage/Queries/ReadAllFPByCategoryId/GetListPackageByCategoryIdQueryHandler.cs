﻿using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;

namespace StudentHouseMembershipCart.Application.Features.FeaturesPackage.Queries.ReadAllFPByCategoryId
{
    public class GetListPackageByCategoryIdQueryHandler : IRequestHandler<GetListPackageByCategoryIdQuery, List<PackageData>>
    {
        private IApplicationDbContext _dbContext;
        private IMapper _mapper;

        public GetListPackageByCategoryIdQueryHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<PackageData>> Handle(GetListPackageByCategoryIdQuery request, CancellationToken cancellationToken)
        {
            var packageByCategoryId = await (from package in _dbContext.Package
                                             join packageService in _dbContext.PackageService
                                             on package.Id
                                             equals packageService.PackageId

                                             join service in _dbContext.Service
                                             on packageService.ServiceId
                                             equals service.Id

                                             join category in _dbContext.Category
                                             on service.CategoryId
                                             equals category.Id
                                             where category.Id == request.CategoryId

                                             select package
                                       ).ToListAsync();
            if (!packageByCategoryId.Any())
            {
                throw new NotFoundException("Does not have Package have Category like that!!");
            }
            var listResult = new List<PackageData>();
            foreach(var item in packageByCategoryId)
            {
                var result =  _mapper.Map<PackageData>(item);   
                listResult.Add(result);
            }
            return listResult;
        }
    }
}
