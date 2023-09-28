﻿using AutoMapper;
using shopecommerce.Application.Services.RoleService;
using shopecommerce.Application.Services.UserService;
using shopecommerce.Domain.Commons.Commands;
using shopecommerce.Domain.Entities;
using shopecommerce.Domain.Exceptions;
using shopecommerce.Domain.Interfaces;
using shopecommerce.Domain.Models;
using shopecommerce.Domain.Resources;

namespace shopecommerce.Application.Commands.UserCommand.RegisterUser;

public class RegisterUserCommandHandler : ICommandHandler<RegisterUserCommand, BaseResponseDto>
{
    private readonly IUserRepository _userRepository;
    private readonly IRoleService _roleService;
    private readonly IRoleRepository _roleRepository;
    private readonly IUserService _userService;
    private readonly IMapper _mapper;

    public RegisterUserCommandHandler(IUserService userService, IUserRepository userRepository, IMapper mapper, IRoleService roleService, IRoleRepository roleRepository)
    {
        _userService = userService;
        _userRepository = userRepository;
        _mapper = mapper;
        _roleService = roleService;
        _roleRepository = roleRepository;
    }

    public async Task<BaseResponseDto> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
    {
        if(await _userService.ExistsEmailAsync(request.email))
        {
            throw new BusinessRuleException("user_email_existed", UserMessages.user_email_existed);
        }

        if(await _userService.ExistsPhoneNumberAsync(request.phone_number))
        {
            throw new BusinessRuleException("user_phone_number_is_existed", UserMessages.user_phone_number_is_existed);
        }

        var dataRole = await _roleRepository.GetRoleByNameAsync(request.name_role);

        if(dataRole == null)
        {
            throw new BusinessRuleException("role_name_is_invalid", RoleMessages.role_name_is_invalid);
        }

        var userMapping = _mapper.Map<Users>(request);
        userMapping.SetRoleUser(dataRole.id);
        userMapping.SetPassWordHash(userMapping.password);
        userMapping.SetCreatedatUser();

        await _userRepository.AddAsync(userMapping);
        await _userRepository.UnitOfWork.SaveEntitiesChangeAsync(cancellationToken);

        return new BaseResponseDto(true, "Đăng ký người dùng thành công");
    }
}