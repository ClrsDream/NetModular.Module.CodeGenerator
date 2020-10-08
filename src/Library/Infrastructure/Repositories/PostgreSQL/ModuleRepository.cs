﻿using NetModular.Lib.Data.Abstractions;

namespace NetModular.Module.CodeGenerator.Infrastructure.Repositories.PostgreSQL
{
    public class ModuleRepository : SqlServer.ModuleRepository
    {
        public ModuleRepository(IDbContext context) : base(context)
        {
        }
    }
}
