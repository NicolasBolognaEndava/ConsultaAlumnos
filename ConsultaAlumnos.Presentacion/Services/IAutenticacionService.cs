﻿using ConsultaAlumnos.API.Entities;
using ConsultaAlumnos.API.Models;

namespace ConsultaAlumnos.API.Services
{
    public interface ICustomAuthenticationService
    {
        User? ValidateUser(AuthenticationRequestBody authenticationRequestBody);
    }
}