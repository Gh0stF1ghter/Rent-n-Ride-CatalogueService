using DAL.Extensions;
using Microsoft.Extensions.Caching.Distributed;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Mocks;

internal class DistributedCacheMock : Mock<IDistributedCache>
{
    public void GetDataFromCache(byte[] dataToReturn) =>
        Setup(dc => dc.GetAsync(It.IsAny<string>(), It.IsAny<CancellationToken>()))
        .ReturnsAsync(dataToReturn);
}
