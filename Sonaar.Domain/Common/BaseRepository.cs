using System;
using Sonaar.Domain.DataContexts;

namespace Sonaar.Domain.Common;

public class BaseRepository
{
    protected readonly DataContext _dataContext;

    public BaseRepository(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

}
