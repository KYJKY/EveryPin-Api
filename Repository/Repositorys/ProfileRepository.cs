﻿using Contracts.Repository.Models;
using Entites.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models;

public class ProfileRepository : RepositoryBase<Profile>, IProfileRepository
{
    public ProfileRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }

    public async Task<IEnumerable<Profile>> GetAllProfile(bool trackChanges) =>
        await FindAll(trackChanges)
        .OrderBy(c => c.UserId)
        .ToListAsync();

    public void CreateProfile(Profile profile) =>
        Create(profile);

    public void UpdateProfile(Profile profile) =>
        Update(profile);

    public async Task<Profile?> GetProfileByUserId(string userId, bool trackChanges) =>
        await FindByCondition(profile => profile.UserId.Equals(userId), trackChanges)
        .Include(c => c.User)
        .SingleOrDefaultAsync();

    public async Task<Profile?> GetProfileByDisplayId(string profileDisplayId, bool trackChanges) =>
        await FindByCondition(profile => profile.ProfileDisplayId.Equals(profileDisplayId), trackChanges)
        .Include(c => c.User)
        .SingleOrDefaultAsync();
}
