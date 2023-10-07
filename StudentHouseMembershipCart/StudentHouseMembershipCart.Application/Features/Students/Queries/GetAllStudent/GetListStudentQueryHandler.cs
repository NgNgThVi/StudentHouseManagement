﻿using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Contracts.Persistance;
using StudentHouseMembershipCart.Application.Features.Staffs.Queries.GetStaff;
using StudentHouseMembershipCart.Domain.Entities;
using StudentHouseMembershipCart.Domain.IdentityModels;

namespace StudentHouseMembershipCart.Application.Features.Students.Queries.GetAllStudent
{
    public class GetListStudentQueryHandler : IRequestHandler<GetListStudentQuery, List<StudentResponse>>
    {
        private IApplicationDbContext _context { get; set; }
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IMapper _mapper;
        private readonly IStudentRepository _studentRepository;
        public GetListStudentQueryHandler(IApplicationDbContext context, IMapper mapper, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<ApplicationUser> signInManager, IStudentRepository studentRepository)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _studentRepository = studentRepository;
        }

        public async Task<List<StudentResponse>> Handle(GetListStudentQuery request, CancellationToken cancellationToken)
        {
            var student = await _context.Student.Where(e => e.IsDelete == false).ToListAsync();
            if (!student.Any()) {
                throw new NotFoundException("Have no Student!");
            }

            var listResult = new List<StudentResponse>();
            foreach (var item in student) {
                var studentInfor = await _userManager.FindByIdAsync(item.ApplicationUserId);
                var result = new StudentResponse
                {
                    StudentTableData = item,
                    ApplicationUserTableData = studentInfor,
                };
                listResult.Add(result);
            }

            return listResult;
        }
    }
}
