using Microsoft.Azure.Cosmos.Table;
using System;
using System.Collections.Generic;
using System.Text;

namespace Livnhigh.Data
{
    public class JoinClubEntity : TableEntity
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime DOB { get; set; }
    }
}
