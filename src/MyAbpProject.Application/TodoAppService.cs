using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace MyAbpProject;

public class TodoAppService : ApplicationService
{
    private readonly IRepository<TodoItem, Guid> _todoRepository;

    public TodoAppService(IRepository<TodoItem, Guid> todoRepository)
    {
        _todoRepository = todoRepository;
    }

    public async Task<List<TodoItemDto>> GetListAsync()
    {
        var items = await _todoRepository.GetListAsync();

        return items
            .Select(x => new TodoItemDto
            {
                Id = x.Id,
                Text = x.Text,
                IsDone = x.IsDone
            })
            .ToList();
    }

    public async Task CreateAsync(CreateTodoDto input)
    {
        var todo = new TodoItem
        {
	    Text = input.Text,
            IsDone = false
        };

        await _todoRepository.InsertAsync(todo);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _todoRepository.DeleteAsync(id);
    }
}
