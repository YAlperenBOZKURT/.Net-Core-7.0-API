﻿using Microsoft.AspNetCore.Identity;

namespace NzWalks.API.Repositories
{
    public interface ITokenRepository
    {
        string CreateJWTToken(IdentityUser user, List<string> roles);
    }
}
