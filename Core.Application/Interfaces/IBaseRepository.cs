using System;
using Core.Application.DTOs;

namespace Core.Application.Interfaces;

public interface IBaseRepository<X, Y>
{
  Task<PaginationDto<X>> GetPaginationByLocationIdAsync(int location, int Page, int PageSize);
  Task<X> CreateAsync(Y domain);
  Task<X> UpdateAsync(Y domain);
  Task<X> DeleteByIdAsync(int id);
}
