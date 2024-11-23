using System;
using AutoMapper;
using Sonaar.Domain.DataContexts;

namespace Sonaar.Domain.Common;

public class BaseRepository
{
    protected readonly DataContext _dataContext;
    protected readonly IMapper _mapper;

    public BaseRepository(DataContext dataContext,IMapper mapper)
    {
        _dataContext = dataContext;
        _mapper = mapper;
    }

}
