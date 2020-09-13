using Livnhigh.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Livnhigh.Repository.IRepository
{
    public interface IJoinClubRepository : IRepository
    {
        Task Create(JoinClubEntity entity);
    }
}
