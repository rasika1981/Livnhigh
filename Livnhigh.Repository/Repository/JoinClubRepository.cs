using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Livnhigh.Repository.Entities;
using Livnhigh.Repository.IRepository;
using Microsoft.Azure.Cosmos.Table;

namespace Livnhigh.Repository.Repository
{
    public class JoinClubRepository : IJoinClubRepository
    {
        private readonly CloudTable cloudTable;

        public JoinClubRepository(CloudTable cloudTable)
        {
            this.cloudTable = cloudTable;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task Create(JoinClubEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
