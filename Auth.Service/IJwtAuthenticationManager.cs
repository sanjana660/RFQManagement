﻿namespace Auth.Service
{
    public interface IJwtAuthenticationManager
    {
        string Authenticate(string username, string password);
    }
}
