using Requset.Core.Contracts.NewFolder;
using Requset.Domain.Core.Requset;
using Requset.Infrastructures.AccessData.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requset.Infrastructures.AccessData.RequsetPersonconfig
{
    public class RequsetPersonRepository : BaseRepository<RequsetPerson>, IRequestPersonRepository
    {
        public RequsetPersonRepository(RequsetContext requsetContext) : base(requsetContext)
        {
        }
    }
}
