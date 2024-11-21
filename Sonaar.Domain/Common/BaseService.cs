using System;

namespace Sonaar.Domain.Common;

public class BaseService<T>
{
    protected readonly T _repository;

    public BaseService(T repository)
    {
        _repository = repository;
    }

}
